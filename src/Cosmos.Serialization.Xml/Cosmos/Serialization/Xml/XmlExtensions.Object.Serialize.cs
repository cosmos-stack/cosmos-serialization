using System.Xml;

namespace Cosmos.Serialization.Xml;

public static partial class XmlExtensions
{
    public static void XmlSerialize<TValue>(this TValue value, TextWriter textWriter)
    {
        XmlHelper.Serialize(textWriter, value);
    }

    public static void XmlSerialize(this object value, Type type, TextWriter textWriter)
    {
        XmlHelper.Serialize(type, textWriter, value);
    }

    public static void XmlSerialize<TValue>(this TValue value, XmlWriter xmlWriter)
    {
        XmlHelper.Serialize(xmlWriter, value);
    }

    public static void XmlSerialize(this object value, Type type, XmlWriter xmlWriter)
    {
        XmlHelper.Serialize(type, xmlWriter, value);
    }

    public static Task XmlSerializeAsync<TValue>(this TValue value, TextWriter textWriter, CancellationToken cancellationToken = default)
    {
        return XmlHelper.SerializeAsync(textWriter, value, cancellationToken);
    }

    public static Task XmlSerializeAsync(this object value, Type type, TextWriter textWriter, CancellationToken cancellationToken = default)
    {
        return XmlHelper.SerializeAsync(type, textWriter, value, cancellationToken);
    }

    public static Task XmlSerializeAsync<TValue>(this TValue value, XmlWriter xmlWriter, CancellationToken cancellationToken = default)
    {
        return XmlHelper.SerializeAsync(xmlWriter, value, cancellationToken);
    }

    public static Task XmlSerializeAsync(this object value, Type type, XmlWriter xmlWriter, CancellationToken cancellationToken = default)
    {
        return XmlHelper.SerializeAsync(type, xmlWriter, value, cancellationToken);
    }
}