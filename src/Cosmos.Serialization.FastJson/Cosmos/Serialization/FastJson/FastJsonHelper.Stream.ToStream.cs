using System.Text;

namespace Cosmos.Serialization.FastJson;

public static partial class FastJsonHelper
{
    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <param name="parameters"></param>
    /// <param name="encoding"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Stream ToStream<TValue>(TValue value, JSONParameters parameters = null, Encoding encoding = null)
    {
        var stream = new MemoryStream();
        Pack(value, stream, parameters, encoding);
        return stream;
    }

    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <param name="paramAct"></param>
    /// <param name="encoding"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Stream ToStream<TValue>(TValue value, Action<JSONParameters> paramAct, Encoding encoding = null)
    {
        var stream = new MemoryStream();
        Pack(value, stream, paramAct, encoding);
        return stream;
    }

    /// <summary>
    /// Pack async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="parameters"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static async Task<Stream> ToStreamAsync<TValue>(TValue value, JSONParameters parameters = null, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        var stream = new MemoryStream();
        await PackAsync(value, stream, parameters, encoding, cancellationToken);
        return stream;
    }

    /// <summary>
    /// Pack async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="paramAct"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static async Task<Stream> ToStreamAsync<TValue>(TValue value, Action<JSONParameters> paramAct, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        var stream = new MemoryStream();
        await PackAsync(value, stream, paramAct, encoding, cancellationToken);
        return stream;
    }
}