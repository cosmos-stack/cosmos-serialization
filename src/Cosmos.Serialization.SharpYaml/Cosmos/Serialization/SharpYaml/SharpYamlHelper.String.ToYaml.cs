namespace Cosmos.Serialization.SharpYaml;

public static partial class SharpYamlHelper
{
    /// <summary>
    /// Serialize the value to yaml string.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="serializer"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static string ToYaml<TValue>(TValue value, Serializer serializer = null)
    {
        return (serializer ?? Man.DefaultSerializer).Serialize(value);
    }

    /// <summary>
    /// Serialize the value to yaml string.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="type"></param>
    /// <param name="serializer"></param>
    /// <returns></returns>
    public static string ToYaml(Type type, object value, Serializer serializer = null)
    {
        return (serializer ?? Man.DefaultSerializer).Serialize(value, type);
    }

    /// <summary>
    /// Serialize the value to yaml string.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="serializer"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<string> ToYamlAsync<TValue>(TValue value, Serializer serializer = null, CancellationToken cancellationToken = default)
    {
        return Async(() => (serializer ?? Man.DefaultSerializer).Serialize(value), cancellationToken);
    }

    /// <summary>
    /// Serialize the value to yaml string.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="type"></param>
    /// <param name="serializer"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<string> ToYamlAsync(Type type, object value, Serializer serializer = null, CancellationToken cancellationToken = default)
    {
        return Async(() => (serializer ?? Man.DefaultSerializer).Serialize(value, type), cancellationToken);
    }
}