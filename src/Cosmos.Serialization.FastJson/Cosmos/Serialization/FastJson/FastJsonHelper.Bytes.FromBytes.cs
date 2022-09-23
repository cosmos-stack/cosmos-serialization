using System.Text;
using Cosmos.Text;

namespace Cosmos.Serialization.FastJson;

public static partial class FastJsonHelper
{
    /// <summary>
    /// Deserialize from bytes
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="parameters"></param>
    /// <param name="encoding"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromBytes<TValue>(byte[] bytes, JSONParameters parameters = null, Encoding encoding = null)
    {
        return bytes is null || bytes.Length is 0
            ? default
            : JSON.ToObject<TValue>(bytes.GetString(encoding.GetEncoding()), parameters.ToParams());
    }

    /// <summary>
    /// Deserialize from bytes
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="paramAct"></param>
    /// <param name="encoding"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromBytes<TValue>(byte[] bytes, Action<JSONParameters> paramAct, Encoding encoding = null)
    {
        return bytes is null || bytes.Length is 0
            ? default
            : JSON.ToObject<TValue>(bytes.GetString(encoding.GetEncoding()), paramAct.GetParams());
    }

    /// <summary>
    /// Deserialize from bytes
    /// </summary>
    /// <param name="type"></param>
    /// <param name="bytes"></param>
    /// <param name="parameters"></param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    public static object FromBytes(Type type, byte[] bytes, JSONParameters parameters = null, Encoding encoding = null)
    {
        return bytes is null || bytes.Length is 0
            ? default
            : JSON.ToObject(bytes.GetString(encoding.GetEncoding()), type, parameters.ToParams());
    }

    /// <summary>
    /// Deserialize from bytes
    /// </summary>
    /// <param name="type"></param>
    /// <param name="bytes"></param>
    /// <param name="paramAct"></param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    public static object FromBytes(Type type, byte[] bytes, Action<JSONParameters> paramAct, Encoding encoding = null)
    {
        return bytes is null || bytes.Length is 0
            ? default
            : JSON.ToObject(bytes.GetString(encoding.GetEncoding()), type, paramAct.GetParams());
    }

    /// <summary>
    /// Deserialize from bytes async
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="parameters"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static async Task<TValue> FromBytesAsync<TValue>(byte[] bytes, JSONParameters parameters = null, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return bytes is null || bytes.Length is 0
            ? default
            : await Task.Run(() => JSON.ToObject<TValue>(bytes.GetString(encoding.GetEncoding()), parameters.ToParams()), cancellationToken);
    }

    /// <summary>
    /// Deserialize from bytes async
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="paramAct"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static async Task<TValue> FromBytesAsync<TValue>(byte[] bytes, Action<JSONParameters> paramAct, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return bytes is null || bytes.Length is 0
            ? default
            : await Task.Run(() => JSON.ToObject<TValue>(bytes.GetString(encoding.GetEncoding()), paramAct.GetParams()), cancellationToken);
    }

    /// <summary>
    /// Deserialize from bytes async
    /// </summary>
    /// <param name="type"></param>
    /// <param name="bytes"></param>
    /// <param name="parameters"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<object> FromBytesAsync(Type type, byte[] bytes, JSONParameters parameters = null, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return bytes is null || bytes.Length is 0
            ? default
            : await Task.Run(() => JSON.ToObject(bytes.GetString(encoding.GetEncoding()), type, parameters.ToParams()), cancellationToken);
    }

    /// <summary>
    /// Deserialize from bytes async
    /// </summary>
    /// <param name="type"></param>
    /// <param name="bytes"></param>
    /// <param name="paramAct"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<object> FromBytesAsync(Type type, byte[] bytes, Action<JSONParameters> paramAct, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return bytes is null || bytes.Length is 0
            ? default
            : await Task.Run(() => JSON.ToObject(bytes.GetString(encoding.GetEncoding()), type, paramAct.GetParams()), cancellationToken);
    }
}