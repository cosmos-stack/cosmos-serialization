using System.Text.Json;

namespace Cosmos.Serialization.SystemTextJson;

public static partial class SystemTextJsonExtensions
{
    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <param name="options"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Stream ToMsJsonStream<TValue>(this TValue value, JsonSerializerOptions options = null)
    {
        return SystemTextJsonHelper.ToStream(value, options);
    }

    /// <summary>
    /// Pack async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<Stream> ToMsJsonStreamAsync<TValue>(this TValue value, JsonSerializerOptions options = null, CancellationToken cancellationToken = default)
    {
        return SystemTextJsonHelper.ToStreamAsync(value, options, cancellationToken);
    }
}