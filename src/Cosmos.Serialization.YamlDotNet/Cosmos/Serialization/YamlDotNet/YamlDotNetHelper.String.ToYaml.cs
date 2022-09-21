namespace Cosmos.Serialization.YamlDotNet;

public static partial class YamlDotNetHelper
{
    /// <summary>
    /// Serialize the value to yaml string.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="serializer"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static string ToYaml<TValue>(TValue value, S serializer = null)
    {
        return (serializer ?? Man.DefaultSerializer).Serialize(value);
    }

    /// <summary>
    /// Serialize the value to yaml string.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="serializer"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<string> ToYamlAsync<TValue>(TValue value, S serializer = null, CancellationToken cancellationToken = default)
    {
        return Async(() => (serializer ?? Man.DefaultSerializer).Serialize(value), cancellationToken);
    }
}