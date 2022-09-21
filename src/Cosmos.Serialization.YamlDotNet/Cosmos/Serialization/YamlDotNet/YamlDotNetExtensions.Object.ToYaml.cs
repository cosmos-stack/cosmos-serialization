namespace Cosmos.Serialization.YamlDotNet;

public static partial class YamlDotNetExtensions
{
    /// <summary>
    /// Serialize the value to yaml string.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="serializer"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static string ToYamlDotNet<TValue>(this TValue value, S serializer = null)
    {
        return YamlDotNetHelper.ToYaml(value, serializer);
    }

    /// <summary>
    /// Serialize the value to yaml string.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="serializer"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<string> ToYamlDotNetAsync<TValue>(this TValue value, S serializer = null, CancellationToken cancellationToken = default)
    {
        return YamlDotNetHelper.ToYamlAsync(value, serializer, cancellationToken);
    }
}