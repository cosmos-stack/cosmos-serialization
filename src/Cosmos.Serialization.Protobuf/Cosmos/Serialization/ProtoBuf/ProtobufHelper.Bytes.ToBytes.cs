using Cosmos.Conversions;

namespace Cosmos.Serialization.ProtoBuf;

public static partial class ProtobufHelper
{
    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static byte[] ToBytes(object value)
    {
        var stream = ToStream(value);
        return stream.CastToBytes();
    }

    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="value"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<byte[]> ToBytesAsync(object value, CancellationToken cancellationToken = default)
    {
        var stream = await ToStreamAsync(value, cancellationToken);
        return await stream.CastToBytesAsync();
    }
}