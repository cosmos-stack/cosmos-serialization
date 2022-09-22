namespace Cosmos.Serialization.MsgPackCli;

public static partial class MsgPackHelper
{
    /// <summary>
    /// Serializes specified object to the memory stream.
    /// </summary>
    /// <param name="value"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Stream ToStream<TValue>(TValue value)
    {
        var stream = new MemoryStream();
        Pack(value, stream);
        return stream;
    }

    /// <summary>
    /// Serializes specified object to the memory stream.
    /// </summary>
    /// <param name="type"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    public static Stream ToStream(Type type, object value)
    {
        var stream = new MemoryStream();
        Pack(type, value, stream);
        return stream;
    }

    /// <summary>
    /// Serializes specified object to the memory stream.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static async Task<Stream> ToStreamAsync<TValue>(TValue value, CancellationToken cancellationToken = default)
    {
        var stream = new MemoryStream();
        await PackAsync(value, stream, cancellationToken);
        return stream;
    }

    /// <summary>
    /// Serializes specified object to the memory stream.
    /// </summary>
    /// <param name="type"></param>
    /// <param name="value"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<Stream> ToStreamAsync(Type type, object value, CancellationToken cancellationToken = default)
    {
        var stream = new MemoryStream();
        await PackAsync(type, value, stream, cancellationToken: cancellationToken);
        return stream;
    }
}