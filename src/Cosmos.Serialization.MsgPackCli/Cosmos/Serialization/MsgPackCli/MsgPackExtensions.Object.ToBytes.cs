namespace Cosmos.Serialization.MsgPackCli;

public static partial class MsgPackExtensions
{
    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="value"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static byte[] ToMsgPackBytes<TValue>(this TValue value)
    {
        return MsgPackHelper.ToBytes(value);
    }

    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="value"></param>
    /// <param name="type"></param>
    /// <returns></returns>
    public static byte[] ToMsgPackBytes(this object value, Type type)
    {
        return MsgPackHelper.ToBytes(type, value);
    }

    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="value"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<byte[]> ToMsgPackBytesAsync<TValue>(this TValue value, CancellationToken cancellationToken = default)
    {
        return MsgPackHelper.ToBytesAsync(value, cancellationToken);
    }

    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="value"></param>
    /// <param name="type"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<byte[]> ToMsgPackBytesAsync(this object value, Type type, CancellationToken cancellationToken = default)
    {
        return MsgPackHelper.ToBytesAsync(type, value, cancellationToken);
    }
}