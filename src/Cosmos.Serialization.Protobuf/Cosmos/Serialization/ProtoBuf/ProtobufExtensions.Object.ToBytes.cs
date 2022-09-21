namespace Cosmos.Serialization.ProtoBuf;

public static partial class ProtobufExtensions
{
    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static byte[] ToProtobufBytes(this object value)
    {
        return ProtobufHelper.ToBytes(value);
    }

    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="value"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<byte[]> ToProtobufBytesAsync(this object value, CancellationToken cancellationToken = default)
    {
        return ProtobufHelper.ToBytesAsync(value, cancellationToken);
    }
}