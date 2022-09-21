namespace Cosmos.Serialization.Xml;

public static partial class XmlExtensions
{
    public static void WriteXml<TValue>(this TextWriter textWriter, TValue value)
    {
        XmlHelper.Serialize(textWriter, value);
    }

    public static void WriteXml(this TextWriter textWriter, Type type, object value)
    {
        XmlHelper.Serialize(type, textWriter, value);
    }

    public static Task WriteXmlAsync<TValue>(this TextWriter textWriter, TValue value, CancellationToken cancellationToken = default)
    {
        return XmlHelper.SerializeAsync(textWriter, value, cancellationToken);
    }

    public static Task WriteXmlAsync(this TextWriter textWriter, Type type, object value, CancellationToken cancellationToken = default)
    {
        return XmlHelper.SerializeAsync(type, textWriter, value, cancellationToken);
    }
}