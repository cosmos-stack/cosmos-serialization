using System.Xml;

namespace Cosmos.Serialization.Xml;

public static partial class XmlExtensions
{
    public static void WriteXml<TValue>(this XmlWriter xmlWriter, TValue value)
    {
        XmlHelper.Serialize(xmlWriter, value);
    }

    public static void WriteXml(this XmlWriter xmlWriter, Type type, object value)
    {
        XmlHelper.Serialize(type, xmlWriter, value);
    }

    public static Task WriteXmlAsync<TValue>(this XmlWriter xmlWriter, TValue value, CancellationToken cancellationToken = default)
    {
        return XmlHelper.SerializeAsync(xmlWriter, value, cancellationToken);
    }

    public static Task WriteXmlAsync(this XmlWriter xmlWriter, Type type, object value, CancellationToken cancellationToken = default)
    {
        return XmlHelper.SerializeAsync(type, xmlWriter, value, cancellationToken);
    }
}