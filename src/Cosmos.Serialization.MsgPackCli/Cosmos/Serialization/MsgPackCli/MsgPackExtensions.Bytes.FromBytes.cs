namespace Cosmos.Serialization.MsgPackCli;

public static partial class MsgPackExtensions
{
    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="bytes"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromMsgPackBytes<TValue>(this byte[] bytes)
    {
        return MsgPackHelper.FromBytes<TValue>(bytes);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="type"></param>
    /// <returns></returns>
    public static object FromMsgPackBytes(this byte[] bytes, Type type)
    {
        return MsgPackHelper.FromBytes(type, bytes);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<TValue> FromMsgPackBytesAsync<TValue>(this byte[] bytes, CancellationToken cancellationToken = default)
    {
        return MsgPackHelper.FromBytesAsync<TValue>(bytes, cancellationToken);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="type"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<object> FromMsgPackBytesAsync(this byte[] bytes, Type type, CancellationToken cancellationToken = default)
    {
        return MsgPackHelper.FromBytesAsync(type, bytes, cancellationToken);
    }
}