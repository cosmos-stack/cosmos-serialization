namespace Cosmos.Serialization.Xml;

public static partial class XmlHelper
{
    /// <summary>
    /// Initialize a memory stream by the bytes and deserialize it.
    /// </summary>
    /// <param name="bytes"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromBytes<TValue>(byte[] bytes)
    {
        if (bytes is null || bytes.Length is 0) return default;
        return (TValue)FromBytes(typeof(TValue), bytes);
    }

    /// <summary>
    /// Initialize a memory stream by the bytes and deserialize it.
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="type"></param>
    /// <returns></returns>
    public static object FromBytes(Type type, byte[] bytes)
    {
        if (bytes is null || bytes.Length == 0)
            return null;
        using var stream = new MemoryStream(bytes);
        return FromStream(type, stream);
    }

    /// <summary>
    /// Initialize a memory stream by the bytes and deserialize it.
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<TValue> FromBytesAsync<TValue>(byte[] bytes, CancellationToken cancellationToken = default)
    {
        return Async(() => FromBytes<TValue>(bytes), cancellationToken);
    }

    /// <summary>
    /// Initialize a memory stream by the bytes and deserialize it.
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="type"></param>
    /// <returns></returns>
    public static Task<object> FromBytesAsync(Type type, byte[] bytes, CancellationToken cancellationToken = default)
    {
        return Async(() => FromBytes(type, bytes), cancellationToken);
    }
}