namespace Cosmos.Serialization.Utf8Json;

public static partial class Utf8JsonExtensions
{
    /// <summary>
    /// Unpack
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="resolver"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromUtf8JsonStream<TValue>(this Stream stream, IJsonFormatterResolver resolver = null)
    {
        return Utf8JsonHelper.FromStream<TValue>(stream, resolver);
    }

    /// <summary>
    /// Unpack
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="type"></param>
    /// <param name="resolver"></param>
    /// <returns></returns>
    public static object FromUtf8JsonStream(this Stream stream, Type type, IJsonFormatterResolver resolver = null)
    {
        return Utf8JsonHelper.FromStream(type, stream, resolver);
    }

    /// <summary>
    /// Unpack async
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="resolver"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static async Task<TValue> FromUtf8JsonStreamAsync<TValue>(this Stream stream, IJsonFormatterResolver resolver = null)
    {
        return await Utf8JsonHelper.FromStreamAsync<TValue>(stream, resolver);
    }

    /// <summary>
    /// Unpack async
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="type"></param>
    /// <param name="resolver"></param>
    /// <returns></returns>
    public static async Task<object> FromUtf8JsonStreamAsync(this Stream stream, Type type, IJsonFormatterResolver resolver = null)
    {
        return await Utf8JsonHelper.FromStreamAsync(type, stream, resolver);
    }
}