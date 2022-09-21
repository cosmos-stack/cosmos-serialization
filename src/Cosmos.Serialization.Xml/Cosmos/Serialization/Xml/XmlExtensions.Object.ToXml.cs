using System.Text;

namespace Cosmos.Serialization.Xml;

public static partial class XmlExtensions
{
    /// <summary>
    /// Serialize the object into a memory stream,get bytes from it and return the decode result.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="encoding"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static string ToXml<TValue>(this TValue value, Encoding encoding = default)
    {
        return XmlHelper.ToXml(value, encoding);
    }

    /// <summary>
    /// Serialize the object into a memory stream,get bytes from it and return the decode result.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="type"></param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    public static string ToXml(this object value, Type type, Encoding encoding = default)
    {
        return XmlHelper.ToXml(type, value, encoding);
    }

    /// <summary>
    /// Serialize the object into a memory stream,get bytes from it and return the decode result.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<string> ToXmlAsync<TValue>(this TValue value, Encoding encoding = default, CancellationToken cancellationToken = default)
    {
        return XmlHelper.ToXmlAsync(value, encoding, cancellationToken);
    }

    /// <summary>
    /// Serialize the object into a memory stream,get bytes from it and return the decode result.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="type"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<string> ToXmlAsync(this object value, Type type, Encoding encoding = default, CancellationToken cancellationToken = default)
    {
        return XmlHelper.ToXmlAsync(type, value, encoding, cancellationToken);
    }
}