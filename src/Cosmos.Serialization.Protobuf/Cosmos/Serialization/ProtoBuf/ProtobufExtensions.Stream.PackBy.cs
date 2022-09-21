namespace Cosmos.Serialization.ProtoBuf;

public static partial class ProtobufExtensions
{
    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    public static void ProtobufPackBy(this Stream stream, object value)
    {
        ProtobufHelper.Pack(value, stream);
    }

    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <param name="cancellationToken"></param>
    public static Task ProtobufPackByAsync(this Stream stream, object value, CancellationToken cancellationToken = default)
    {
        return ProtobufHelper.PackAsync(value, stream, cancellationToken);
    }
}