using System.Text;

namespace Cosmos.Serialization.FastJson;

public static partial class FastJsonExtensions
{
    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <param name="parameters"></param>
    /// <param name="encoding"></param>
    /// <typeparam name="TValue"></typeparam>
    public static void PackTo<TValue>(this TValue value, Stream stream, JSONParameters parameters = null, Encoding encoding = null)
    {
        FastJsonHelper.Pack(value, stream, parameters, encoding);
    }

    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <param name="paramAct"></param>
    /// <param name="encoding"></param>
    /// <typeparam name="TValue"></typeparam>
    public static void PackTo<TValue>(this TValue value, Stream stream, Action<JSONParameters> paramAct, Encoding encoding = null)
    {
        FastJsonHelper.Pack(value, stream, paramAct, encoding);
    }

    /// <summary>
    /// Pack async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <param name="parameters"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task PackToAsync<TValue>(this TValue value, Stream stream, JSONParameters parameters = null, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return FastJsonHelper.PackAsync(value, stream, parameters, encoding, cancellationToken);
    }

    /// <summary>
    /// Pack async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <param name="paramAct"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task PackToAsync<TValue>(this TValue value, Stream stream, Action<JSONParameters> paramAct, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return FastJsonHelper.PackAsync(value, stream, paramAct, encoding, cancellationToken);
    }
}