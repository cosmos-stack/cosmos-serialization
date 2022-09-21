using Cosmos.Conversions;

namespace Cosmos.Serialization.Xml;

public static partial class XmlHelper
{
    /// <summary>
    /// Serialize the object to a memory stream and return a bytes contain the stream content.
    /// </summary>
    /// <param name="value"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static byte[] ToBytes<TValue>(TValue value)
    {
        return ToBytes(typeof(TValue), value);
    }

    /// <summary>
    /// Serialize the object to a memory stream and return a bytes contain the stream content.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="type"></param>
    /// <returns></returns>
    public static byte[] ToBytes(Type type, object value)
    {
        var stream = ToStream(type, value);
        return stream.CastToBytes();
    }

    /// <summary>
    /// Serialize the object to a memory stream and return a bytes contain the stream content.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<byte[]> ToBytesAsync<TValue>(TValue value, CancellationToken cancellationToken = default)
    {
        return ToBytesAsync(typeof(TValue), value, cancellationToken);
    }

    /// <summary>
    /// Serialize the object to a memory stream and return a bytes contain the stream content.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="type"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<byte[]> ToBytesAsync(Type type, object value, CancellationToken cancellationToken = default)
    {
        var stream = await ToStreamAsync(type, value, cancellationToken);
        return await stream.CastToBytesAsync(); //TODO
    }
}