namespace Cosmos.Serialization.MsgPackCli;

public static partial class MsgPackExtensions
{
    /// <summary>
    /// Serializes specified object to the memory stream.
    /// </summary>
    /// <param name="value"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Stream ToMsgPackStream<TValue>(this TValue value)
    {
        return MsgPackHelper.ToStream(value);
    }

    /// <summary>
    /// Serializes specified object to the memory stream.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="type"></param>
    /// <returns></returns>
    public static Stream ToMsgPackStream(this object value, Type type)
    {
        return MsgPackHelper.ToStream(type, value);
    }

    /// <summary>
    /// Serializes specified object to the memory stream.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<Stream> ToMsgPackStreamAsync<TValue>(this TValue value, CancellationToken cancellationToken = default)
    {
        return MsgPackHelper.ToStreamAsync(value, cancellationToken);
    }

    /// <summary>
    /// Serializes specified object to the memory stream.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="type"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<Stream> ToMsgPackStreamAsync(this object value, Type type, CancellationToken cancellationToken = default)
    {
        return MsgPackHelper.ToStreamAsync(type, value, cancellationToken);
    }
}