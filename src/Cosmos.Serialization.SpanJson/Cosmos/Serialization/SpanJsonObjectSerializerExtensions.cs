namespace Cosmos.Serialization;

/// <summary>
/// SpanJson Serializer extensions
/// </summary>
public static class SpanJsonObjectSerializerExtensions
{
    /// <summary>
    /// Use SpanJsonObjectSerializer
    /// </summary>
    /// <param name="entry"></param>
    public static void UseSpanJson(this IJsonSerializerConfigureEntry entry)
    {
        entry.CheckNull(nameof(entry));
        entry.ConfigureJsonSerializer(new SpanJsonObjectSerializer());
    }

    /// <summary>
    /// Use SpanJsonObjectSerializer
    /// </summary>
    /// <param name="entry"></param>
    /// <param name="serializerFactory"></param>
    public static void UseSpanJson(this IJsonSerializerConfigureEntry entry, Func<SpanJsonObjectSerializer> serializerFactory)
    {
        entry.CheckNull(nameof(entry));
        serializerFactory.CheckNull(nameof(serializerFactory));
        entry.ConfigureJsonSerializer(serializerFactory);
    }
}