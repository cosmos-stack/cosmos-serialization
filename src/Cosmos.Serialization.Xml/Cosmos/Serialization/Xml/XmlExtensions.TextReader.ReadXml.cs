namespace Cosmos.Serialization.Xml;

public static partial class XmlExtensions
{
    public static TValue ReadXml<TValue>(this TextReader textReader)
    {
        return XmlHelper.Deserialize<TValue>(textReader);
    }

    public static object ReadXml(this TextReader textReader, Type type)
    {
        return XmlHelper.Deserialize(type, textReader);
    }

    public static Task<TValue> ReadXmlAsync<TValue>(this TextReader textReader, CancellationToken cancellationToken = default)
    {
        return XmlHelper.DeserializeAsync<TValue>(textReader, cancellationToken);
    }

    public static Task<object> ReadXmlAsync(this TextReader textReader, Type type, CancellationToken cancellationToken = default)
    {
        return XmlHelper.DeserializeAsync(type, textReader, cancellationToken);
    }
}