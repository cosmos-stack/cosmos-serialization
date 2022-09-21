namespace Cosmos.Serialization.SharpYaml;

public static partial class SharpYamlHelper
{
    /// <summary>
    /// Deserialize the yaml string to an instance of the <typeparamref name="TValue"/>.
    /// </summary>
    /// <param name="yaml"></param>
    /// <param name="serializer"></param>
    /// <param name="existingObj"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromYaml<TValue>(string yaml, Serializer serializer = null, TValue existingObj = default)
    {
        return string.IsNullOrWhiteSpace(yaml)
            ? existingObj ?? default
            : existingObj is null
                ? (serializer ?? Man.DefaultSerializer).Deserialize<TValue>(yaml)
                : (serializer ?? Man.DefaultSerializer).DeserializeInto(yaml, existingObj);
    }

    /// <summary>
    /// Deserialize the yaml string to an instance of the <paramref name="type"/>.
    /// </summary>
    /// <param name="yaml"></param>
    /// <param name="type"></param>
    /// <param name="serializer"></param>
    /// <param name="existingObj"></param>
    /// <returns></returns>
    public static object FromYaml(Type type, string yaml, Serializer serializer = null, object existingObj = default)
    {
        return string.IsNullOrWhiteSpace(yaml)
            ? existingObj ?? default
            : existingObj is null
                ? (serializer ?? Man.DefaultSerializer).Deserialize(yaml, type)
                : (serializer ?? Man.DefaultSerializer).Deserialize(yaml, type, existingObj);
    }

    /// <summary>
    /// Deserialize the yaml string to an instance of the <typeparamref name="TValue"/>.
    /// </summary>
    /// <param name="yaml"></param>
    /// <param name="serializer"></param>
    /// <param name="existingObj"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static async Task<TValue> FromYamlAsync<TValue>(string yaml, Serializer serializer = null, TValue existingObj = default, CancellationToken cancellationToken = default)
    {
        return string.IsNullOrWhiteSpace(yaml)
            ? existingObj ?? default
            : existingObj is null
                ? await Async(() => (serializer ?? Man.DefaultSerializer).Deserialize<TValue>(yaml), cancellationToken)
                : await Async(() => (serializer ?? Man.DefaultSerializer).DeserializeInto(yaml, existingObj), cancellationToken);
    }

    /// <summary>
    /// Deserialize the yaml string to an instance of the <paramref name="type"/>.
    /// </summary>
    /// <param name="yaml"></param>
    /// <param name="type"></param>
    /// <param name="serializer"></param>
    /// <param name="existingObj"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<object> FromYamlAsync(Type type, string yaml, Serializer serializer = null, object existingObj = default, CancellationToken cancellationToken = default)
    {
        return string.IsNullOrWhiteSpace(yaml)
            ? existingObj ?? default
            : existingObj is null
                ? await Async(() => (serializer ?? Man.DefaultSerializer).Deserialize(yaml, type), cancellationToken)
                : await Async(() => (serializer ?? Man.DefaultSerializer).Deserialize(yaml, type, existingObj), cancellationToken);
    }
}