namespace Cosmos.Serialization.SharpYaml;

public static partial class SharpYamlExtensions
{
    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <param name="serializer"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Stream ToSharpYamlStream<TValue>(this TValue value, Serializer serializer = null)
    {
        return SharpYamlHelper.ToStream(value, serializer);
    }

    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <param name="type"></param>
    /// <param name="serializer"></param>
    /// <returns></returns>
    public static Stream ToSharpYamlStream(this object value, Type type, Serializer serializer = null)
    {
        return SharpYamlHelper.ToStream(type, value, serializer);
    }

    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <param name="serializer"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<Stream> ToSharpYamlStreamAsync<TValue>(this TValue value, Serializer serializer = null, CancellationToken cancellationToken = default)
    {
        return SharpYamlHelper.ToStreamAsync(value, serializer, cancellationToken);
    }

    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <param name="type"></param>
    /// <param name="serializer"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<Stream> ToSharpYamlStreamAsync(this object value, Type type, Serializer serializer = null, CancellationToken cancellationToken = default)
    {
        return SharpYamlHelper.ToStreamAsync(type, value, serializer, cancellationToken);
    }
}