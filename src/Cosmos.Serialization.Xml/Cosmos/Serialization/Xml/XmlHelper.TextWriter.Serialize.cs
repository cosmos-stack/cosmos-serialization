namespace Cosmos.Serialization.Xml;

public static partial class XmlHelper
{
    /// <summary>
    /// Serializes the specified object and writes the XML document to a file using the specified TextWriter.
    /// </summary>
    /// <param name="textWriter"></param>
    /// <param name="value"></param>
    /// <typeparam name="TValue"></typeparam>
    public static void Serialize<TValue>(TextWriter textWriter, TValue value)
    {
        if (textWriter is null) return;
        Serialize(typeof(TValue), textWriter, value);
    }

    /// <summary>
    /// Serializes the specified object and writes the XML document to a file using the specified TextWriter.
    /// </summary>
    /// <param name="type"></param>
    /// <param name="textWriter"></param>
    /// <param name="value"></param>
    public static void Serialize(Type type, TextWriter textWriter, object value)
    {
        if (textWriter is null) return;
        Man.GetSerializer(type).Serialize(textWriter, value);
    }

    /// <summary>
    /// Serializes the specified object and writes the XML document to a file using the specified TextWriter.
    /// </summary>
    /// <param name="textWriter"></param>
    /// <param name="value"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    public static async Task SerializeAsync<TValue>(TextWriter textWriter, TValue value, CancellationToken cancellationToken = default)
    {
        if (textWriter is null) return;
        await Task.Run(() => Serialize(typeof(TValue), textWriter, value), cancellationToken);
    }

    /// <summary>
    /// Serializes the specified object and writes the XML document to a file using the specified TextWriter.
    /// </summary>
    /// <param name="type"></param>
    /// <param name="textWriter"></param>
    /// <param name="value"></param>
    /// <param name="cancellationToken"></param>
    public static async Task SerializeAsync(Type type, TextWriter textWriter, object value, CancellationToken cancellationToken = default)
    {
        if (textWriter is null) return;
        await Task.Run(() => Man.GetSerializer(type).Serialize(textWriter, value), cancellationToken);
    }
}