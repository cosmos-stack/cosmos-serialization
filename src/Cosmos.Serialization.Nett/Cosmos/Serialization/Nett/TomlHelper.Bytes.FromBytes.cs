using System.Text;

namespace Cosmos.Serialization.Nett;

public static partial class TomlHelper
{
    public static TValue FromBytes<TValue>(byte[] bytes, TomlSettings settings = default)
    {
        if (bytes is null || bytes.Length is 0) return default;
        using var ms = new MemoryStream(bytes);
        return Tommy.ReadStream<TValue>(ms, settings ?? Man.DefaultSettings);
    }

    public static object FromBytes(Type type, byte[] bytes, TomlSettings settings = default)
    {
        if (bytes is null || bytes.Length is 0) return default;
        using var ms = new MemoryStream(bytes);
        return Tommy.ReadStream(ms, settings).Get(type);
    }
}