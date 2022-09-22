using Cosmos.IO;
using Swifter.MessagePack;

namespace Cosmos.Serialization.SwifterMsgPack;

public static partial class SwifterMsgPackHelper
{
    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <param name="options"></param>
    /// <typeparam name="TValue"></typeparam>
    public static void Pack<TValue>(TValue value, Stream stream, MessagePackFormatterOptions options = MessagePackFormatterOptions.Default)
    {
        if (value is null) return;
        F.SerializeObject(value, stream, options);
        stream.TrySeek(0, SeekOrigin.Begin);
    }

    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="type"></param>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <param name="options"></param>
    public static void Pack(Type type, object value, Stream stream, MessagePackFormatterOptions options = MessagePackFormatterOptions.Default)
    {
        if (value is null) return;
        F.SerializeObject(value, stream, options);
        stream.TrySeek(0, SeekOrigin.Begin);
    }

    /// <summary>
    /// Pack async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    public static async Task PackAsync<TValue>(TValue value, Stream stream, MessagePackFormatterOptions options = MessagePackFormatterOptions.Default, CancellationToken cancellationToken = default)
    {
        if (value is null) return;
        await F.SerializeObjectAsync(value, stream, options);
    }

    /// <summary>
    /// Pack async
    /// </summary>
    /// <param name="type"></param>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    public static async Task PackAsync(Type type, object value, Stream stream, MessagePackFormatterOptions options = MessagePackFormatterOptions.Default, CancellationToken cancellationToken = default)
    {
        if (value is null) return;
        await F.SerializeObjectAsync(value, stream, options);
    }
}