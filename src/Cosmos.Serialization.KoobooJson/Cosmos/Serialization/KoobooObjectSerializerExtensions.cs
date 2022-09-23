namespace Cosmos.Serialization;

/// <summary>
/// KoobooObjectSerializer extensions.
/// </summary>
public static class KoobooObjectSerializerExtensions
{
    /// <summary>
    /// Use KoobooObjectSerializer
    /// </summary>
    /// <param name="entry"></param>
    public static void UseKooboo(this IJsonSerializerConfigureEntry entry)
    {
        entry.CheckNull(nameof(entry));
        entry.ConfigureJsonSerializer(new KoobooObjectSerializer());
    }

    /// <summary>
    /// Use KoobooObjectSerializer
    /// </summary>
    /// <param name="entry"></param>
    /// <param name="options1"></param>
    /// <param name="options2"></param>
    public static void UseKooboo(this IJsonSerializerConfigureEntry entry, JsonSerializerOption options1, JsonDeserializeOption options2)
    {
        entry.CheckNull(nameof(entry));
        entry.ConfigureJsonSerializer(new KoobooObjectSerializer(options1, options2));
    }

    /// <summary>
    /// Use KoobooObjectSerializer
    /// </summary>
    /// <param name="entry"></param>
    /// <param name="optionsFactory1"></param>
    /// <param name="optionsFactory2"></param>
    public static void UseKooboo(this IJsonSerializerConfigureEntry entry, Func<JsonSerializerOption> optionsFactory1, Func<JsonDeserializeOption> optionsFactory2)
    {
        entry.CheckNull(nameof(entry));
        entry.ConfigureJsonSerializer(new KoobooObjectSerializer(optionsFactory1, optionsFactory2));
    }

    /// <summary>
    /// Use KoobooObjectSerializer
    /// </summary>
    /// <param name="entry"></param>
    /// <param name="serializerFactory"></param>
    public static void UseKooboo(this IJsonSerializerConfigureEntry entry, Func<KoobooObjectSerializer> serializerFactory)
    {
        entry.CheckNull(nameof(entry));
        serializerFactory.CheckNull(nameof(serializerFactory));
        entry.ConfigureJsonSerializer(serializerFactory);
    }
}