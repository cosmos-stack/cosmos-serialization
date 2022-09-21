using Cosmos.Conversions;

namespace Cosmos.Serialization.SharpYaml;

public static partial class SharpYamlHelper
{
    /// <summary>
    /// Serialize to bytes
    /// </summary>
    /// <param name="value"></param>
    /// <param name="serializer"></param>
    /// <returns></returns>
    public static byte[] ToBytes<TValue>(TValue value, Serializer serializer = null)
    {
        return ToStream(value, serializer).CastToBytes();
    }

    /// <summary>
    /// Serialize to bytes
    /// </summary>
    /// <param name="value"></param>
    /// <param name="type"></param>
    /// <param name="serializer"></param>
    /// <returns></returns>
    public static byte[] ToBytes(Type type, object value, Serializer serializer = null)
    {
        return ToStream(type, value, serializer).CastToBytes();
    }

    /// <summary>
    /// Serialize to bytes
    /// </summary>
    /// <param name="value"></param>
    /// <param name="serializer"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<byte[]> ToBytesAsync<TValue>(TValue value, Serializer serializer = null, CancellationToken cancellationToken = default)
    {
        var stream = await ToStreamAsync(value, serializer, cancellationToken);
        return await stream.CastToBytesAsync(); //TODO
    }

    /// <summary>
    /// Serialize to bytes
    /// </summary>
    /// <param name="value"></param>
    /// <param name="type"></param>
    /// <param name="serializer"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<byte[]> ToBytesAsync(Type type, object value, Serializer serializer = null, CancellationToken cancellationToken = default)
    {
        var stream = await ToStreamAsync(type, value, serializer, cancellationToken);
        return await stream.CastToBytesAsync(); //TODO
    }
}