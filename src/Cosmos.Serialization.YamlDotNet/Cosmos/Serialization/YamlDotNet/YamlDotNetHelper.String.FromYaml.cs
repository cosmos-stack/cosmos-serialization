namespace Cosmos.Serialization.YamlDotNet;

public static partial class YamlDotNetHelper
{
    /// <summary>
    /// Deserialize the yaml string to an instance of the <typeparamref name="TValue"/>.
    /// </summary>
    /// <param name="yaml"></param>
    /// <param name="deserializer"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromYaml<TValue>(string yaml, D deserializer = null)
    {
        return string.IsNullOrWhiteSpace(yaml)
            ? default
            : (deserializer ?? Man.DefaultDeserializer).Deserialize<TValue>(yaml);
    }

    /// <summary>
    /// Deserialize the yaml string to an instance of the <paramref name="type"/>.
    /// </summary>
    /// <param name="yaml"></param>
    /// <param name="type"></param>
    /// <param name="deserializer"></param>
    /// <returns></returns>
    public static object FromYaml(Type type, string yaml, D deserializer = null)
    {
        return string.IsNullOrWhiteSpace(yaml)
            ? default
            : (deserializer ?? Man.DefaultDeserializer).Deserialize(yaml, type);
    }

    /// <summary>
    /// Deserialize the yaml string to an instance of the <typeparamref name="TValue"/>.
    /// </summary>
    /// <param name="yaml"></param>
    /// <param name="deserializer"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static async Task<TValue> FromYamlAsync<TValue>(string yaml, D deserializer = null, CancellationToken cancellationToken = default)
    {
        return string.IsNullOrWhiteSpace(yaml)
            ? default
            : await Async(() => (deserializer ?? Man.DefaultDeserializer).Deserialize<TValue>(yaml), cancellationToken);
    }

    /// <summary>
    /// Deserialize the yaml string to an instance of the <paramref name="type"/>.
    /// </summary>
    /// <param name="yaml"></param>
    /// <param name="type"></param>
    /// <param name="deserializer"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<object> FromYamlAsync(Type type, string yaml, D deserializer = null, CancellationToken cancellationToken = default)
    {
        return string.IsNullOrWhiteSpace(yaml)
            ? default
            : await Async(() => (deserializer ?? Man.DefaultDeserializer).Deserialize(yaml, type), cancellationToken);
    }
}