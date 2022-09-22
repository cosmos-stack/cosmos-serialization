using Cosmos.Conversions;

namespace Cosmos.Serialization.MsgPackCli;

public static partial class MsgPackHelper
{
    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="value"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static byte[] ToBytes<TValue>(TValue value)
    {
        using var stream = ToStream(value);
        return stream.CastToBytes();
    }

    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="type"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    public static byte[] ToBytes(Type type, object value)
    {
        using var stream = ToStream(type, value);
        return stream.CastToBytes();
    }

    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="value"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static async Task<byte[]> ToBytesAsync<TValue>(TValue value, CancellationToken cancellationToken = default)
    {
#if NETCOREAPP
        await using var stream = await ToStreamAsync(value, cancellationToken);
#else
        using var stream = await ToStreamAsync(value, cancellationToken);
#endif
        return await stream.CastToBytesAsync();
    }

    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="type"></param>
    /// <param name="value"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<byte[]> ToBytesAsync(Type type, object value, CancellationToken cancellationToken = default)
    {
#if NETCOREAPP
        await using var stream = await ToStreamAsync(type, value, cancellationToken);
#else
        using var stream = await ToStreamAsync(type, value, cancellationToken);
#endif
        return await stream.CastToBytesAsync();
    }
}