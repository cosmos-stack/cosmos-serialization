namespace Cosmos.Serialization.MsgPackCli;

public static partial class MsgPackExtensions
{
    /// <summary>
    /// Unpack
    /// </summary>
    /// <param name="stream"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromMsgPackStream<TValue>(this Stream stream)
    {
        return MsgPackHelper.FromStream<TValue>(stream);
    }

    /// <summary>
    /// Unpack
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="type"></param>
    /// <returns></returns>
    public static object FromMsgPackStream(this Stream stream, Type type)
    {
        return MsgPackHelper.FromStream(type, stream);
    }

    /// <summary>
    /// Unpack async
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<TValue> FromMsgPackStreamAsync<TValue>(this Stream stream, CancellationToken cancellationToken = default)
    {
        return MsgPackHelper.FromStreamAsync<TValue>(stream, cancellationToken);
    }

    /// <summary>
    /// Unpack async
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="type"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<object> FromMsgPackStreamAsync(this Stream stream, Type type, CancellationToken cancellationToken = default)
    {
        return MsgPackHelper.FromStreamAsync(type, stream, cancellationToken);
    }
}