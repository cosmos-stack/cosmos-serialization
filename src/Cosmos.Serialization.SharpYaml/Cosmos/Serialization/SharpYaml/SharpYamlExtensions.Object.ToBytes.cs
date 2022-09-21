namespace Cosmos.Serialization.SharpYaml;

public static partial class SharpYamlExtensions
{
    /// <summary>
    /// Serialize to bytes
    /// </summary>
    /// <param name="value"></param>
    /// <param name="serializer"></param>
    /// <returns></returns>
    public static byte[] ToSharpYamlBytes<TValue>(this TValue value, Serializer serializer = null)
    {
        return SharpYamlHelper.ToBytes(value, serializer);
    }

    /// <summary>
    /// Serialize to bytes
    /// </summary>
    /// <param name="value"></param>
    /// <param name="type"></param>
    /// <param name="serializer"></param>
    /// <returns></returns>
    public static byte[] ToSharpYamlBytes(this object value, Type type, Serializer serializer = null)
    {
        return SharpYamlHelper.ToBytes(type, value, serializer);
    }

    /// <summary>
    /// Serialize to bytes
    /// </summary>
    /// <param name="value"></param>
    /// <param name="serializer"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<byte[]> ToSharpYamlBytesAsync<TValue>(this TValue value, Serializer serializer = null, CancellationToken cancellationToken = default)
    {
        return SharpYamlHelper.ToBytesAsync(value, serializer, cancellationToken);
    }

    /// <summary>
    /// Serialize to bytes
    /// </summary>
    /// <param name="value"></param>
    /// <param name="type"></param>
    /// <param name="serializer"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<byte[]> ToSharpYamlBytesAsync(this object value, Type type, Serializer serializer = null, CancellationToken cancellationToken = default)
    {
        return SharpYamlHelper.ToBytesAsync(type, value, serializer, cancellationToken);
    }
}