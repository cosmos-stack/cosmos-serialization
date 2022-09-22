using Cosmos.IO;
using MsgPack;
using MsgPack.Serialization;
using M = MsgPack.Serialization.MessagePackSerializer;

namespace Cosmos.Serialization.MsgPackCli;

public static partial class MsgPackHelper
{
    /// <summary>
    /// Deserialize object from the <see cref="T:System.IO.Stream" />.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <typeparam name="TValue"></typeparam>
    public static void Pack<TValue>(TValue value, Stream stream)
    {
        if (value is null) return;
        M.Get<TValue>().Pack(stream, value);
        stream.TrySeek(0, SeekOrigin.Begin);
    }

    /// <summary>
    /// Deserialize object from the <see cref="T:System.IO.Stream" />.
    /// </summary>
    /// <param name="type"></param>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    public static void Pack(Type type, object value, Stream stream)
    {
        if (value is null) return;
        M.Get(type).Pack(stream, value);
        stream.TrySeek(0, SeekOrigin.Begin);
    }

    /// <summary>
    /// Deserialize object from the <see cref="T:System.IO.Stream" />.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    public static async Task PackAsync<TValue>(TValue value, Stream stream, CancellationToken cancellationToken = default)
    {
        if (value is null) return;
        await M.Get<TValue>().PackAsync(stream, value, cancellationToken);
        stream.TrySeek(0, SeekOrigin.Begin);
    }

    /// <summary>
    /// Deserialize object from the <see cref="T:System.IO.Stream" />.
    /// </summary>
    /// <param name="type"></param>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    public static async Task PackAsync(Type type, object value, Stream stream, PackerCompatibilityOptions options = PackerCompatibilityOptions.None, CancellationToken cancellationToken = default)
    {
        if (value is null) return;
        var packer = Packer.Create(stream, options);
        await M.Get(type).PackToAsync(packer, value, cancellationToken);
        stream.TrySeek(0, SeekOrigin.Begin);
    }
}