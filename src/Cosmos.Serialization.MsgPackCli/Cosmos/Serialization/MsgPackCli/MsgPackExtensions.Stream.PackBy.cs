using MsgPack;

namespace Cosmos.Serialization.MsgPackCli;

public static partial class MsgPackExtensions
{
    /// <summary>
    /// Deserialize object from the <see cref="T:System.IO.Stream" />.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <typeparam name="TValue"></typeparam>
    public static void MsgPackBy<TValue>(this Stream stream, TValue value)
    {
        MsgPackHelper.Pack(value, stream);
    }

    /// <summary>
    /// Deserialize object from the <see cref="T:System.IO.Stream" />.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="type"></param>
    /// <param name="stream"></param>
    public static void MsgPackBy(this Stream stream, Type type, object value)
    {
        MsgPackHelper.Pack(type, value, stream);
    }

    /// <summary>
    /// Deserialize object from the <see cref="T:System.IO.Stream" />.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    public static Task MsgPackByAsync<TValue>(this Stream stream, TValue value, CancellationToken cancellationToken = default)
    {
        return MsgPackHelper.PackAsync(value, stream, cancellationToken);
    }

    /// <summary>
    /// Deserialize object from the <see cref="T:System.IO.Stream" />.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="type"></param>
    /// <param name="stream"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    public static Task MsgPackByAsync(this Stream stream, Type type, object value, PackerCompatibilityOptions options = PackerCompatibilityOptions.None, CancellationToken cancellationToken = default)
    {
        return MsgPackHelper.PackAsync(type, value, stream, options, cancellationToken);
    }
}