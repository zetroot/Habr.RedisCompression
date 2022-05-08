using StackExchange.Redis.Extensions.MsgPack;
using StackExchange.Redis.Extensions.Protobuf;
using StackExchange.Redis.Extensions.System.Text.Json;

namespace Habr.RedisCompression.Serializers;

public class MsgPackSerializer : MsgPackObjectSerializer
{
    public override string ToString() => "MsgPack";
}

public class MyProtobufSerializer : ProtobufSerializer
{
    public override string ToString() => "Protobuf";
}

public class JsonSerializer : SystemTextJsonSerializer
{
    public override string ToString() => "SystemTextJson";
}
