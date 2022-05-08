using System.IO.Compression;
using StackExchange.Redis.Extensions.Core;

namespace Habr.RedisCompression.Serializers;

public class CompressorWrap : ISerializer
{
    private readonly ISerializer _serializer;
    public CompressorWrap(ISerializer serializer)
    {
        _serializer = serializer;
    }
    public byte[] Serialize<T>(T? item)
    {
        using var sourceStream = new MemoryStream(_serializer.Serialize(item));

        using var compressStream = new MemoryStream();
        using var deflateStream = new DeflateStream(compressStream, CompressionLevel.SmallestSize);

        sourceStream.CopyTo(deflateStream);
        return compressStream.ToArray();
    }
    public T Deserialize<T>(byte[] serializedObject)
    {
        using var compressStream = new MemoryStream(serializedObject);
        using var deflateStream = new DeflateStream(compressStream, CompressionMode.Decompress);
        using var decompressedStream = new MemoryStream();

        deflateStream.CopyTo(decompressedStream);
        var decompressedObj = decompressedStream.ToArray();
        return _serializer.Deserialize<T>(decompressedObj);
    }

    public override string ToString() => $"Deflated {_serializer}";
}
