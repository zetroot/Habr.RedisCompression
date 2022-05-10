using Habr.RedisCompression;
using Habr.RedisCompression.Serializers;
using StackExchange.Redis.Extensions.Core;
using StackExchange.Redis.Extensions.Core.Configuration;
using StackExchange.Redis.Extensions.Core.Implementations;

public class SizeBenchmark
{
    private readonly ISerializer[] _serializers = 
    {
        new MsgPackSerializer(), new MyProtobufSerializer(), new JsonSerializer(),
        new CompressorWrap(new MsgPackSerializer()), new CompressorWrap(new MyProtobufSerializer()), new CompressorWrap(new JsonSerializer())
    };

    private readonly RedisConfiguration _configuration = new()
    {
        AllowAdmin = true,
        Hosts = new[] { new RedisHost { Host = "localhost", Port = 6379 } }
    };

    private readonly RedisConnectionPoolManager _poolManager;

    public SizeBenchmark()
    {
        _poolManager = new(_configuration);
    }
    
    public async Task Execute(int size)
    {
        Console.WriteLine($"Generating data - {size} items");
        var data = new List<Model>(size);
        for (int i = 0; i < size; i++)
            data.Add(Model.Generate());
        
        foreach (var serializer in _serializers)
        {
            Console.WriteLine($"Testing serializer {serializer}");
            var client = new RedisClient(_poolManager, serializer, _configuration);
            foreach (var item in data)
                await client.Db0.AddAsync(Guid.NewGuid().ToString(), item);
            var info = await client.Db0.GetInfoAsync();
            Console.WriteLine($"Used memory human\t{info["used_memory_human"]}");
            Console.WriteLine("---------------------------------------------------");
            await client.Db0.FlushDbAsync();
        }
        
    }
}
