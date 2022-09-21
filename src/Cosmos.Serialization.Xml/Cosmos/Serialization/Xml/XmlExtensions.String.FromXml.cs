using System.Text;

namespace Cosmos.Serialization.Xml;

public static partial class XmlExtensions
{
    /// <summary>
    /// Encode the xml to a bytes and initialize a memory stream by it,deserialize to a object.
    /// </summary>
    /// <param name="xml"></param>
    /// <param name="encoding"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromXml<TValue>(this string xml, Encoding encoding = default)
    {
        return XmlHelper.FromXml<TValue>(xml, encoding);
    }

    /// <summary>
    /// Encode the xml to a bytes and initialize a memory stream by it,deserialize to a object.
    /// </summary>
    /// <param name="xml"></param>
    /// <param name="type"></param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    public static object FromXml(this string xml, Type type, Encoding encoding = default)
    {
        return XmlHelper.FromXml(type, xml, encoding);
    }

    /// <summary>
    /// Encode the xml to a bytes and initialize a memory stream by it,deserialize to a object.
    /// </summary>
    /// <param name="xml"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<TValue> FromXmlAsync<TValue>(this string xml, Encoding encoding = default, CancellationToken cancellationToken = default)
    {
        return XmlHelper.FromXmlAsync<TValue>(xml, encoding, cancellationToken);
    }

    /// <summary>
    /// Encode the xml to a bytes and initialize a memory stream by it,deserialize to a object.
    /// </summary>
    /// <param name="xml"></param>
    /// <param name="type"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<object> FromXmlAsync(this string xml, Type type, Encoding encoding = default, CancellationToken cancellationToken = default)
    {
        return XmlHelper.FromXmlAsync(type, xml, encoding, cancellationToken);
    }
}