using Cosmos.Conversions;

namespace Cosmos.Serialization.ProtoBuf;

/// <summary>
/// Google protobuf helper
/// </summary>
public static partial class ProtobufHelper
{
    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static Stream ToStream(object value)
    {
        var stream = new MemoryStream();
        Pack(value, stream);
        return stream;
    }

    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<Stream> ToStreamAsync(object value, CancellationToken cancellationToken = default)
    {
        var ms = new MemoryStream();
        await PackAsync(value, ms, cancellationToken);
        return ms;
    }
}