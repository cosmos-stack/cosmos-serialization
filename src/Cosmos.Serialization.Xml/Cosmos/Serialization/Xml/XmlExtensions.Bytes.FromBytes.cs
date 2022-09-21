namespace Cosmos.Serialization.Xml;

public static partial class XmlExtensions
{
    /// <summary>
    /// Initialize a memory stream by the bytes and deserialize it.
    /// </summary>
    /// <param name="bytes"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromXmlBytes<TValue>(this byte[] bytes)
    {
        return XmlHelper.FromBytes<TValue>(bytes);
    }

    /// <summary>
    /// Initialize a memory stream by the bytes and deserialize it.
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="type"></param>
    /// <returns></returns>
    public static object FromXmlBytes(this byte[] bytes, Type type)
    {
        return XmlHelper.FromBytes(type, bytes);
    }

    /// <summary>
    /// Initialize a memory stream by the bytes and deserialize it.
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<TValue> FromXmlBytesAsync<TValue>(this byte[] bytes, CancellationToken cancellationToken = default)
    {
        return XmlHelper.FromBytesAsync<TValue>(bytes, cancellationToken);
    }

    /// <summary>
    /// Initialize a memory stream by the bytes and deserialize it.
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="type"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<object> FromXmlBytesAsync(this byte[] bytes, Type type, CancellationToken cancellationToken = default)
    {
        return XmlHelper.FromBytesAsync(type, bytes, cancellationToken);
    }
}