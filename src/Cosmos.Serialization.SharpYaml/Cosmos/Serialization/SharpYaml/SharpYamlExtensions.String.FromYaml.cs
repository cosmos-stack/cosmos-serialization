namespace Cosmos.Serialization.SharpYaml;

public static partial class SharpYamlExtensions
{
    /// <summary>
    /// Deserialize the yaml string to an instance of the <typeparamref name="TValue"/>.
    /// </summary>
    /// <param name="yaml"></param>
    /// <param name="serializer"></param>
    /// <param name="existingObj"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromYaml<TValue>(this string yaml, Serializer serializer = null, TValue existingObj = default)
    {
        return SharpYamlHelper.FromYaml(yaml, serializer, existingObj);
    }

    /// <summary>
    /// Deserialize the yaml string to an instance of the <paramref name="type"/>.
    /// </summary>
    /// <param name="yaml"></param>
    /// <param name="type"></param>
    /// <param name="serializer"></param>
    /// <param name="existingObj"></param>
    /// <returns></returns>
    public static object FromYaml(this string yaml, Type type, Serializer serializer = null, object existingObj = default)
    {
        return SharpYamlHelper.FromYaml(type, yaml, serializer, existingObj);
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
    public static Task<TValue> FromYamlAsync<TValue>(this string yaml, Serializer serializer = null, TValue existingObj = default, CancellationToken cancellationToken = default)
    {
        return SharpYamlHelper.FromYamlAsync(yaml, serializer, existingObj, cancellationToken);
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
    public static Task<object> FromYamlAsync(this string yaml, Type type, Serializer serializer = null, object existingObj = default, CancellationToken cancellationToken = default)
    {
        return SharpYamlHelper.FromYamlAsync(type, yaml, serializer, existingObj, cancellationToken);
    }
}