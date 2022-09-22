namespace Cosmos.Serialization.MsgPackCli;

public static partial class MsgPackHelper
{
    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="bytes"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromBytes<TValue>(byte[] bytes)
    {
        if (bytes is null || bytes.Length is 0)
            return default;
        using var stream = new MemoryStream(bytes);
        return FromStream<TValue>(stream);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="type"></param>
    /// <param name="bytes"></param>
    /// <returns></returns>
    public static object FromBytes(Type type, byte[] bytes)
    {
        if (bytes is null || bytes.Length is 0)
            return default;
        using var stream = new MemoryStream(bytes);
        return FromStream(type, stream);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static async Task<TValue> FromBytesAsync<TValue>(byte[] bytes, CancellationToken cancellationToken = default)
    {
        if (bytes is null || bytes.Length is 0)
            return default;
        using var stream = bytes.ToMemoryStream();
        return await FromStreamAsync<TValue>(stream, cancellationToken);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="type"></param>
    /// <param name="bytes"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<object> FromBytesAsync(Type type, byte[] bytes, CancellationToken cancellationToken = default)
    {
        if (bytes is null || bytes.Length is 0)
            return null;
        using var stream = bytes.ToMemoryStream();
        return await FromStreamAsync(type, stream, cancellationToken);
    }
}