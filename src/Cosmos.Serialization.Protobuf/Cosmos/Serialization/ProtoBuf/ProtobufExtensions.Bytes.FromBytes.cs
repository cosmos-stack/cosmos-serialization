namespace Cosmos.Serialization.ProtoBuf;

public static partial class ProtobufExtensions
{
    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="bytes"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromProtobufBytes<TValue>(this byte[] bytes)
    {
        return ProtobufHelper.FromBytes<TValue>(bytes);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="type"></param>
    /// <returns></returns>
    public static object FromProtobufBytes(this byte[] bytes, Type type)
    {
        return ProtobufHelper.FromBytes(type, bytes);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<TValue> FromProtobufBytesAsync<TValue>(this byte[] bytes, CancellationToken cancellationToken = default)
    {
        return ProtobufHelper.FromBytesAsync<TValue>(bytes, cancellationToken);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="type"></param>
    /// <param name="bytes"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<object> FromProtobufBytesAsync(this byte[] bytes, Type type, CancellationToken cancellationToken = default)
    {
        return ProtobufHelper.FromBytesAsync(type, bytes, cancellationToken);
    }
}