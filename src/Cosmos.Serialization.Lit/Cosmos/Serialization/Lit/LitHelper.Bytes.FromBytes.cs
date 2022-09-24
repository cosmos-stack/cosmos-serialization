﻿using System.Text;
using Cosmos.Text;

namespace Cosmos.Serialization.Lit;

public static partial class LitHelper
{
    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="encoding"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromBytes<TValue>(byte[] bytes, Encoding encoding = null)
    {
        return bytes is null || bytes.Length is 0
            ? default
            : FromJson<TValue>(bytes.GetString(encoding.GetEncoding()));
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="type"></param>
    /// <param name="bytes"></param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    public static object FromBytes(Type type, byte[] bytes, Encoding encoding = null)
    {
        return bytes is null || bytes.Length is 0
            ? null
            : FromJson(type, bytes.GetString(encoding.GetEncoding()));
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static async Task<TValue> FromBytesAsync<TValue>(byte[] bytes, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return bytes is null || bytes.Length is 0
            ? default
            : await FromJsonAsync<TValue>(bytes.GetString(encoding.GetEncoding()), cancellationToken);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="type"></param>
    /// <param name="bytes"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<object> FromBytesAsync(Type type, byte[] bytes, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return bytes is null || bytes.Length is 0
            ? default
            : await FromJsonAsync(type, bytes.GetString(encoding.GetEncoding()), cancellationToken);
    }
}