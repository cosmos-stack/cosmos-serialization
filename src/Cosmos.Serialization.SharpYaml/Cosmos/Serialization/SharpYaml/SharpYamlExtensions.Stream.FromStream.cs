namespace Cosmos.Serialization.SharpYaml;

public static partial class SharpYamlExtensions
{
    /// <summary>
    /// Unpack
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="serializer"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromSharpYamlStream<TValue>(this Stream stream, Serializer serializer = null)
    {
        return SharpYamlHelper.FromStream<TValue>(stream, serializer);
    }

    /// <summary>
    /// Unpack
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="type"></param>
    /// <param name="serializer"></param>
    /// <returns></returns>
    public static object FromSharpYamlStream(this Stream stream, Type type, Serializer serializer = null)
    {
        return SharpYamlHelper.FromStream(type, stream, serializer);
    }

    /// <summary>
    /// Unpack
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="serializer"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<TValue> FromSharpYamlStreamAsync<TValue>(this Stream stream, Serializer serializer = null, CancellationToken cancellationToken = default)
    {
        return SharpYamlHelper.FromStreamAsync<TValue>(stream, serializer, cancellationToken);
    }

    /// <summary>
    /// Unpack
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="type"></param>
    /// <param name="serializer"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<object> FromSharpYamlStreamAsync(this Stream stream, Type type, Serializer serializer = null, CancellationToken cancellationToken = default)
    {
        return SharpYamlHelper.FromStreamAsync(type, stream, serializer, cancellationToken);
    }
}