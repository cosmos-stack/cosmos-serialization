using System.Text;
using Cosmos.Text;

namespace Cosmos.Serialization.FastJson;

public static partial class FastJsonHelper
{
    /// <summary>
    /// Serialize to bytes
    /// </summary>
    /// <param name="value"></param>
    /// <param name="parameters"></param>
    /// <param name="encoding"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static byte[] ToBytes<TValue>(TValue value, JSONParameters parameters = null, Encoding encoding = null)
    {
        return value is null
            ? Arrays.Empty<byte>()
            : JSON.ToJSON(value, parameters.ToParams()).ToBytes(encoding.GetEncoding());
    }

    /// <summary>
    /// Serialize to bytes
    /// </summary>
    /// <param name="value"></param>
    /// <param name="paramAct"></param>
    /// <param name="encoding"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static byte[] ToBytes<TValue>(TValue value, Action<JSONParameters> paramAct, Encoding encoding = null)
    {
        return value is null
            ? Arrays.Empty<byte>()
            : JSON.ToJSON(value, paramAct.GetParams()).ToBytes(encoding.GetEncoding());
    }

    /// <summary>
    /// Serialize to bytes async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="parameters"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static async Task<byte[]> ToBytesAsync<TValue>(TValue value, JSONParameters parameters = null, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return value is null
            ? Arrays.Empty<byte>()
            : await Task.Run(() => JSON.ToJSON(value, parameters.ToParams()).ToBytes(encoding.GetEncoding()), cancellationToken);
    }

    /// <summary>
    /// Serialize to bytes async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="paramAct"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static async Task<byte[]> ToBytesAsync<TValue>(TValue value, Action<JSONParameters> paramAct, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return value is null
            ? Arrays.Empty<byte>()
            : await Task.Run(() => JSON.ToJSON(value, paramAct.GetParams()).ToBytes(encoding.GetEncoding()), cancellationToken);
    }
}