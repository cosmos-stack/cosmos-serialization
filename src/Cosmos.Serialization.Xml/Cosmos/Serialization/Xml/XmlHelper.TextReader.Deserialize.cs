namespace Cosmos.Serialization.Xml;

public static partial class XmlHelper
{
    /// <summary>
    /// Deserializes the XML document contained by the specified TextReader.
    /// </summary>
    /// <param name="textReader"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue Deserialize<TValue>(TextReader textReader)
    {
        return textReader is null
            ? default
            : (TValue)Deserialize(typeof(TValue), textReader);
    }

    /// <summary>
    /// Deserializes the XML document contained by the specified TextReader.
    /// </summary>
    /// <param name="type"></param>
    /// <param name="textReader"></param>
    /// <returns></returns>
    public static object Deserialize(Type type, TextReader textReader)
    {
        return textReader is null
            ? default
            : Man.GetSerializer(type).Deserialize(textReader);
    }

    /// <summary>
    /// Deserializes the XML document contained by the specified TextReader.
    /// </summary>
    /// <param name="textReader"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static async Task<TValue> DeserializeAsync<TValue>(TextReader textReader, CancellationToken cancellationToken = default)
    {
        return textReader is null
            ? default
            : (TValue)await DeserializeAsync(typeof(TValue), textReader, cancellationToken);
    }

    /// <summary>
    /// Deserializes the XML document contained by the specified TextReader.
    /// </summary>
    /// <param name="type"></param>
    /// <param name="textReader"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<object> DeserializeAsync(Type type, TextReader textReader, CancellationToken cancellationToken = default)
    {
        return textReader is null
            ? default
            : await Async(() => Man.GetSerializer(type).Deserialize(textReader), cancellationToken);
    }
}