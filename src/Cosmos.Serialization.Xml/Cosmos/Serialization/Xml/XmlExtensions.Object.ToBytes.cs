namespace Cosmos.Serialization.Xml;

public static partial class XmlExtensions
{
    /// <summary>
    /// Serialize the object to a memory stream and return a bytes contain the stream content.
    /// </summary>
    /// <param name="value"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static byte[] ToXmlBytes<TValue>(this TValue value)
    {
        return XmlHelper.ToBytes(value);
    }

    /// <summary>
    /// Serialize the object to a memory stream and return a bytes contain the stream content.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="type"></param>
    /// <returns></returns>
    public static byte[] ToXmlBytes(this object value, Type type)
    {
        return XmlHelper.ToBytes(type, value);
    }

    /// <summary>
    /// Serialize the object to a memory stream and return a bytes contain the stream content.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<byte[]> ToXmlBytesAsync<TValue>(this TValue value, CancellationToken cancellationToken = default)
    {
        return XmlHelper.ToBytesAsync(value, cancellationToken);
    }

    /// <summary>
    /// Serialize the object to a memory stream and return a bytes contain the stream content.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="type"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<byte[]> ToXmlBytesAsync(this object value, Type type, CancellationToken cancellationToken = default)
    {
        return XmlHelper.ToBytesAsync(type, value, cancellationToken);
    }
}