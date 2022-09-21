using System.Xml;

namespace Cosmos.Serialization.Xml;

public static partial class XmlExtensions
{
    public static TValue ReadXml<TValue>(this XmlReader xmlReader)
    {
        return XmlHelper.Deserialize<TValue>(xmlReader);
    }

    public static object ReadXml(this XmlReader xmlReader, Type type)
    {
        return XmlHelper.Deserialize(type, xmlReader);
    }

    public static Task<TValue> ReadXmlAsync<TValue>(this XmlReader xmlReader, CancellationToken cancellationToken = default)
    {
        return XmlHelper.DeserializeAsync<TValue>(xmlReader, cancellationToken);
    }

    public static Task<object> ReadXmlAsync(this XmlReader xmlReader, Type type, CancellationToken cancellationToken = default)
    {
        return XmlHelper.DeserializeAsync(type, xmlReader, cancellationToken);
    }
}