namespace Cosmos.Serialization.ProtoBuf;

public static partial class ProtobufExtensions
{
    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static Stream ToProtobufStream(this object value)
    {
        return ProtobufHelper.ToStream(value);
    }

    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<Stream> ToProtobufStreamAsync(this object value, CancellationToken cancellationToken = default)
    {
        return ProtobufHelper.ToStreamAsync(value, cancellationToken);
    }
}