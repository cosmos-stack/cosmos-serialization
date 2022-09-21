namespace Cosmos.Serialization.ProtoBuf;

public static partial class ProtobufExtensions
{
    /// <summary>
    /// Unpack
    /// </summary>
    /// <param name="stream"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromProtobufStream<TValue>(this Stream stream)
    {
        return ProtobufHelper.FromStream<TValue>(stream);
    }

    /// <summary>
    /// Unpack
    /// </summary>
    /// <param name="type"></param>
    /// <param name="stream"></param>
    /// <returns></returns>
    public static object FromProtobufStream(this Stream stream, Type type)
    {
        return ProtobufHelper.FromStream(type, stream);
    }

    /// <summary>
    /// Unpack
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<TValue> FromProtobufStreamAsync<TValue>(this Stream stream, CancellationToken cancellationToken = default)
    {
        return ProtobufHelper.FromStreamAsync<TValue>(stream, cancellationToken);
    }

    /// <summary>
    /// Unpack async
    /// </summary>
    /// <param name="type"></param>
    /// <param name="stream"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<object> FromProtobufStreamAsync(this Stream stream, Type type, CancellationToken cancellationToken = default)
    {
        return ProtobufHelper.FromStreamAsync(type, stream, cancellationToken);
    }
}