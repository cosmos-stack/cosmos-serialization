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
    public static void MsgPackTo<TValue>(this TValue value, Stream stream)
    {
        MsgPackHelper.Pack(value, stream);
    }

    /// <summary>
    /// Deserialize object from the <see cref="T:System.IO.Stream" />.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="type"></param>
    /// <param name="stream"></param>
    public static void MsgPackTo(this object value, Type type, Stream stream)
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
    public static Task MsgPackToAsync<TValue>(this TValue value, Stream stream, CancellationToken cancellationToken = default)
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
    public static Task MsgPackToAsync(this object value, Type type, Stream stream, PackerCompatibilityOptions options = PackerCompatibilityOptions.None, CancellationToken cancellationToken = default)
    {
        return MsgPackHelper.PackAsync(type, value, stream, options, cancellationToken);
    }
}