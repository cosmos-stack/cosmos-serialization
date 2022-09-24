namespace Cosmos.Serialization;

/// <summary>
/// Utf8JsonObjectSerializer extensions.
/// </summary>
public static class Utf8JsonObjectSerializerExtensions
{
    /// <summary>
    /// Use Utf8JsonObjectSerializer
    /// </summary>
    /// <param name="entry"></param>
    public static void UseUtf8Json(this IJsonSerializerConfigureEntry entry)
    {
        entry.CheckNull(nameof(entry));
        entry.ConfigureJsonSerializer(new Utf8JsonObjectSerializer());
    }

    /// <summary>
    /// Use Utf8JsonObjectSerializer
    /// </summary>
    /// <param name="entry"></param>
    /// <param name="serializerFactory"></param>
    public static void UseUtf8Json(this IJsonSerializerConfigureEntry entry, Func<Utf8JsonObjectSerializer> serializerFactory)
    {
        entry.CheckNull(nameof(entry));
        serializerFactory.CheckNull(nameof(serializerFactory));
        entry.ConfigureJsonSerializer(serializerFactory);
    }
}