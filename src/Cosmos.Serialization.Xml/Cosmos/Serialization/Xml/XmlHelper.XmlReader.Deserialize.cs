using System.Xml;

namespace Cosmos.Serialization.Xml;

public static partial class XmlHelper
{
    /// <summary>
    /// Deserializes the XML document contained by the specified XmlReader.
    /// </summary>
    /// <param name="xmlReader"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue Deserialize<TValue>(XmlReader xmlReader)
    {
        return xmlReader is null
            ? default
            : (TValue)Deserialize(typeof(TValue), xmlReader);
    }

    /// <summary>
    /// Deserializes the XML document contained by the specified XmlReader.
    /// </summary>
    /// <param name="type"></param>
    /// <param name="xmlReader"></param>
    /// <returns></returns>
    public static object Deserialize(Type type, XmlReader xmlReader)
    {
        return xmlReader is null
            ? default
            : Man.GetSerializer(type).Deserialize(xmlReader);
    }

    /// <summary>
    /// Deserializes the XML document contained by the specified XmlReader.
    /// </summary>
    /// <param name="xmlReader"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static async Task<TValue> DeserializeAsync<TValue>(XmlReader xmlReader, CancellationToken cancellationToken = default)
    {
        return xmlReader is null
            ? default
            : (TValue)await DeserializeAsync(typeof(TValue), xmlReader, cancellationToken);
    }

    /// <summary>
    /// Deserializes the XML document contained by the specified XmlReader.
    /// </summary>
    /// <param name="type"></param>
    /// <param name="xmlReader"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<object> DeserializeAsync(Type type, XmlReader xmlReader, CancellationToken cancellationToken = default)
    {
        return xmlReader is null
            ? default
            : await Async(() => Man.GetSerializer(type).Deserialize(xmlReader), cancellationToken);
    }
}