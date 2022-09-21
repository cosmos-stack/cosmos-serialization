namespace Cosmos.Serialization.YamlDotNet;

public static partial class YamlDotNetExtensions
{
    /// <summary>
    /// Deserialize the yaml string to an instance of the <typeparamref name="TValue"/>.
    /// </summary>
    /// <param name="yaml"></param>
    /// <param name="deserializer"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromYamlDotNet<TValue>(this string yaml, D deserializer = null)
    {
        return YamlDotNetHelper.FromYaml<TValue>(yaml, deserializer);
    }

    /// <summary>
    /// Deserialize the yaml string to an instance of the <paramref name="type"/>.
    /// </summary>
    /// <param name="yaml"></param>
    /// <param name="type"></param>
    /// <param name="deserializer"></param>
    /// <returns></returns>
    public static object FromYamlDotNet(this string yaml, Type type, D deserializer = null)
    {
        return YamlDotNetHelper.FromYaml(type, yaml, deserializer);
    }

    /// <summary>
    /// Deserialize the yaml string to an instance of the <typeparamref name="TValue"/>.
    /// </summary>
    /// <param name="yaml"></param>
    /// <param name="deserializer"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<TValue> FromYamlDotNetAsync<TValue>(this string yaml, D deserializer = null, CancellationToken cancellationToken = default)
    {
        return YamlDotNetHelper.FromYamlAsync<TValue>(yaml, deserializer, cancellationToken);
    }

    /// <summary>
    /// Deserialize the yaml string to an instance of the <paramref name="type"/>.
    /// </summary>
    /// <param name="yaml"></param>
    /// <param name="type"></param>
    /// <param name="deserializer"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<object> FromYamlDotNetAsync(this string yaml, Type type, D deserializer = null, CancellationToken cancellationToken = default)
    {
        return YamlDotNetHelper.FromYamlAsync(type, yaml, deserializer, cancellationToken);
    }
}