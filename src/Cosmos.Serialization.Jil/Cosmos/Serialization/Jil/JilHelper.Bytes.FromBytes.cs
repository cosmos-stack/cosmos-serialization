using System.Text;
using Cosmos.Text;

namespace Cosmos.Serialization.Jil;

public static partial class JilHelper
{
    /// <summary>
    /// Deserialize from bytes
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="options"></param>
    /// <param name="encoding"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromBytes<TValue>(byte[] bytes, Options options = null, Encoding encoding = null)
    {
        return bytes is null || bytes.Length is 0
            ? default
            : JSON.Deserialize<TValue>(bytes.GetString(encoding.GetEncoding()), options.ToOptions());
    }

    /// <summary>
    /// Deserialize from bytes
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="optionAct"></param>
    /// <param name="encoding"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromBytes<TValue>(byte[] bytes, Action<Options> optionAct, Encoding encoding = null)
    {
        return bytes is null || bytes.Length is 0
            ? default
            : JSON.Deserialize<TValue>(bytes.GetString(encoding.GetEncoding()), optionAct.GetOptions());
    }

    /// <summary>
    /// Deserialize from bytes
    /// </summary>
    /// <param name="type"></param>
    /// <param name="bytes"></param>
    /// <param name="options"></param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    public static object FromBytes(Type type, byte[] bytes, Options options = null, Encoding encoding = null)
    {
        return bytes is null || bytes.Length is 0
            ? default
            : JSON.Deserialize(bytes.GetString(encoding.GetEncoding()), type, options.ToOptions());
    }

    /// <summary>
    /// Deserialize from bytes
    /// </summary>
    /// <param name="type"></param>
    /// <param name="bytes"></param>
    /// <param name="optionAct"></param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    public static object FromBytes(Type type, byte[] bytes, Action<Options> optionAct, Encoding encoding = null)
    {
        return bytes is null || bytes.Length is 0
            ? default
            : JSON.Deserialize(bytes.GetString(encoding.GetEncoding()), type, optionAct.GetOptions());
    }

    /// <summary>
    /// Deserialize from bytes async
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="options"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static async Task<TValue> FromBytesAsync<TValue>(byte[] bytes, Options options = null, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return bytes is null || bytes.Length is 0
            ? default
            : await Task.Run(() => JSON.Deserialize<TValue>(bytes.GetString(encoding.GetEncoding()), options.ToOptions()), cancellationToken);
    }

    /// <summary>
    /// Deserialize from bytes async
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="optionAct"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static async Task<TValue> FromBytesAsync<TValue>(byte[] bytes, Action<Options> optionAct, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return bytes is null || bytes.Length is 0
            ? default
            : await Task.Run(() => JSON.Deserialize<TValue>(bytes.GetString(encoding.GetEncoding()), optionAct.GetOptions()), cancellationToken);
    }

    /// <summary>
    /// Deserialize from bytes async
    /// </summary>
    /// <param name="type"></param>
    /// <param name="bytes"></param>
    /// <param name="options"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<object> FromBytesAsync(Type type, byte[] bytes, Options options = null, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return bytes is null || bytes.Length is 0
            ? default
            : await Task.Run(() => JSON.Deserialize(bytes.GetString(encoding.GetEncoding()), type, options.ToOptions()), cancellationToken);
    }

    /// <summary>
    /// Deserialize from bytes async
    /// </summary>
    /// <param name="type"></param>
    /// <param name="bytes"></param>
    /// <param name="optionAct"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<object> FromBytesAsync(Type type, byte[] bytes, Action<Options> optionAct, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return bytes is null || bytes.Length is 0
            ? default
            : await Task.Run(() => JSON.Deserialize(bytes.GetString(encoding.GetEncoding()), type, optionAct.GetOptions()), cancellationToken);
    }
}