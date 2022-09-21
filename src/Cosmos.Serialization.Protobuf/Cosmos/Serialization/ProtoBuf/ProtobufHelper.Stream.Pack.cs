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
    /// <param name="stream"></param>
    public static void Pack(object value, Stream stream)
    {
        if (value is null) return;
        Man.TypeModel.Serialize(stream, value);
    }

    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <param name="cancellationToken"></param>
    public static async Task PackAsync(object value, Stream stream, CancellationToken cancellationToken = default)
    {
        if (value is null) return;
        await Task.Run(() => Man.TypeModel.Serialize(stream, value), cancellationToken);
    }
}