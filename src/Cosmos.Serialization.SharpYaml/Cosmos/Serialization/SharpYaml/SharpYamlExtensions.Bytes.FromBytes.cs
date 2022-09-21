namespace Cosmos.Serialization.SharpYaml;

public static partial class SharpYamlExtensions
{
    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="serializer"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromSharpYamlBytes<TValue>(this byte[] bytes, Serializer serializer = null)
    {
        return SharpYamlHelper.FromBytes<TValue>(bytes, serializer);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="type"></param>
    /// <param name="serializer"></param>
    /// <returns></returns>
    public static object FromSharpYamlBytes(this byte[] bytes, Type type, Serializer serializer = null)
    {
        return SharpYamlHelper.FromBytes(type, bytes, serializer);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="serializer"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<TValue> FromSharpYamlBytesAsync<TValue>(this byte[] bytes, Serializer serializer = null, CancellationToken cancellationToken = default)
    {
        return SharpYamlHelper.FromBytesAsync<TValue>(bytes, serializer, cancellationToken);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="type"></param>
    /// <param name="serializer"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<object> FromSharpYamlBytesAsync(this byte[] bytes, Type type, Serializer serializer = null, CancellationToken cancellationToken = default)
    {
        return SharpYamlHelper.FromBytesAsync(type, bytes, serializer, cancellationToken);
    }
}