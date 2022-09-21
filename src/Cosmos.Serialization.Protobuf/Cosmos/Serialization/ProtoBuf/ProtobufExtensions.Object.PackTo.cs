namespace Cosmos.Serialization.ProtoBuf;

public static partial class ProtobufExtensions
{
    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    public static void ProtobufPackTo(this object value, Stream stream)
    {
        ProtobufHelper.Pack(value, stream);
    }

    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <param name="cancellationToken"></param>
    public static Task ProtobufPackToAsync(this object value, Stream stream, CancellationToken cancellationToken = default)
    {
        return ProtobufHelper.PackAsync(value, stream, cancellationToken);
    }
}