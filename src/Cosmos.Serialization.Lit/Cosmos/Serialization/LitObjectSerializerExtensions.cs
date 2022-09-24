namespace Cosmos.Serialization;

/// <summary>
/// LitObjectSerializer extensions.
/// </summary>
public static class LitObjectSerializerExtensions
{
    /// <summary>
    /// Use LitObjectSerializer
    /// </summary>
    /// <param name="entry"></param>
    public static void UseLit(this IJsonSerializerConfigureEntry entry)
    {
        entry.CheckNull(nameof(entry));
        entry.ConfigureJsonSerializer(new LitObjectSerializer());
    }

    /// <summary>
    /// Use LitObjectSerializer
    /// </summary>
    /// <param name="entry"></param>
    /// <param name="serializerFactory"></param>
    public static void UseLit(this IJsonSerializerConfigureEntry entry, Func<LitObjectSerializer> serializerFactory)
    {
        entry.CheckNull(nameof(entry));
        serializerFactory.CheckNull(nameof(serializerFactory));
        entry.ConfigureJsonSerializer(serializerFactory);
    }
}