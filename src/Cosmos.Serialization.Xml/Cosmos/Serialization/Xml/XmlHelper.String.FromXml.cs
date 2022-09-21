using System.Text;

namespace Cosmos.Serialization.Xml;

public static partial class XmlHelper
{
    /// <summary>
    /// Encode the xml to a bytes and initialize a memory stream by it,deserialize to a object.
    /// </summary>
    /// <param name="xml"></param>
    /// <param name="encoding"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromXml<TValue>(string xml, Encoding encoding = default)
    {
        if (string.IsNullOrWhiteSpace(xml))
            return default;
        return (TValue)FromXml(typeof(TValue), xml, encoding);
    }

    /// <summary>
    /// Encode the xml to a bytes and initialize a memory stream by it,deserialize to a object.
    /// </summary>
    /// <param name="xml"></param>
    /// <param name="type"></param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    public static object FromXml(Type type, string xml, Encoding encoding = default)
    {
        if (string.IsNullOrWhiteSpace(xml))
            return default;
        var stream = encoding.ToEncoding().GetBytes(xml).ToMemoryStream();
        return FromStream(type, stream);
    }

    /// <summary>
    /// Encode the xml to a bytes and initialize a memory stream by it,deserialize to a object.
    /// </summary>
    /// <param name="xml"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static async Task<TValue> FromXmlAsync<TValue>(string xml, Encoding encoding = default, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(xml))
            return default;
        var value = await FromXmlAsync(typeof(TValue), xml, encoding, cancellationToken);
        return (TValue)value;
    }

    /// <summary>
    /// Encode the xml to a bytes and initialize a memory stream by it,deserialize to a object.
    /// </summary>
    /// <param name="xml"></param>
    /// <param name="type"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<object> FromXmlAsync(Type type, string xml, Encoding encoding = default, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(xml))
            return default;
        var stream = encoding.ToEncoding().GetBytes(xml).ToMemoryStream();
        return await FromStreamAsync(type, stream, cancellationToken);
    }
}