using BenchmarkDotNet.Attributes;
using Habr.RedisCompression.Serializers;
using StackExchange.Redis.Extensions.Core;
using StackExchange.Redis.Extensions.Core.Configuration;
using StackExchange.Redis.Extensions.Core.Implementations;
using StackExchange.Redis.Extensions.MsgPack;
using StackExchange.Redis.Extensions.Protobuf;
using StackExchange.Redis.Extensions.System.Text.Json;

namespace Habr.RedisCompression;

[MemoryDiagnoser]
public class CompressingBenchmarks
{
    const string Key = "benchmarkentry";
    private RedisClient client;
    private readonly Model origValue = Model.Generate();

    [ParamsSource(nameof(Serializers))]
    public ISerializer Serializer;

    public IEnumerable<ISerializer> Serializers { get; } = new ISerializer[]
    {
        new MsgPackSerializer(), new MyProtobufSerializer(), new JsonSerializer(),
        new CompressorWrap(new MsgPackSerializer()), new CompressorWrap(new MyProtobufSerializer()), new CompressorWrap(new JsonSerializer())
    };
    
    [GlobalSetup]
    public async Task Setup()
    {
        var config = new RedisConfiguration()
        {
            AllowAdmin = true,
            Hosts = new[] { new RedisHost { Host = "localhost", Port = 6379 } }
        };
        var poolManager = new RedisConnectionPoolManager(config);
        client = new RedisClient(poolManager, new MsgPackObjectSerializer(), config);
        await client.Db0.AddAsync(Key, origValue);
    }

    [GlobalCleanup]
    public async Task Cleanup()
    {
        await client.Db0.FlushDbAsync();
    }
    
    [Benchmark]
    public async Task<bool> DoWork()
    {
        var model = await client.Db0.GetAsync<Model>(Key);
        model.Counter++;
        return await client.Db0.ReplaceAsync(Key, model);
    } 
}
