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

    public static async Task<TValue> FromBytesAsync<TValue>(byte[] bytes, TomlSettings settings = default, CancellationToken cancellationToken = default)
    {
        if (bytes is null || bytes.Length is 0) return default;

        return await Async(() =>
        {
            using var ms = new MemoryStream(bytes);
            return Tommy.ReadStream<TValue>(ms, settings ?? Man.DefaultSettings);
        }, cancellationToken);
    }

    public static async Task<object> FromBytesAsync(Type type, byte[] bytes, TomlSettings settings = default, CancellationToken cancellationToken = default)
    {
        if (bytes is null || bytes.Length is 0) return default;

        return await Async(() =>
        {
            using var ms = new MemoryStream(bytes);
            return Tommy.ReadStream(ms, settings ?? Man.DefaultSettings).Get(type);
        }, cancellationToken);
    }
}