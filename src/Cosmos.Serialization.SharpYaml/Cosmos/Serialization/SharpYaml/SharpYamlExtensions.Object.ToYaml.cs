namespace Cosmos.Serialization.SharpYaml;

public static partial class SharpYamlExtensions
{
    /// <summary>
    /// Serialize the value to yaml string.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="serializer"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static string ToYaml<TValue>(this TValue value, Serializer serializer = null)
    {
        return SharpYamlHelper.ToYaml(value, serializer);
    }

    /// <summary>
    /// Serialize the value to yaml string.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="type"></param>
    /// <param name="serializer"></param>
    /// <returns></returns>
    public static string ToYaml(this object value, Type type, Serializer serializer = null)
    {
        return SharpYamlHelper.ToYaml(type, value, serializer);
    }

    /// <summary>
    /// Serialize the value to yaml string.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="serializer"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<string> ToYamlAsync<TValue>(this TValue value, Serializer serializer = null, CancellationToken cancellationToken = default)
    {
        return SharpYamlHelper.ToYamlAsync(value, serializer, cancellationToken);
    }

    /// <summary>
    /// Serialize the value to yaml string.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="type"></param>
    /// <param name="serializer"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<string> ToYamlAsync(this object value, Type type, Serializer serializer = null, CancellationToken cancellationToken = default)
    {
        return SharpYamlHelper.ToYamlAsync(type, value, serializer, cancellationToken);
    }
}