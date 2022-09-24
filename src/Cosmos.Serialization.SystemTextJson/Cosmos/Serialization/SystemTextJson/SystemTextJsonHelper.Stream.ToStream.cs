using System.Text.Json;

namespace Cosmos.Serialization.SystemTextJson;

public static partial class SystemTextJsonHelper
{
    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <param name="options"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Stream ToStream<TValue>(TValue value, JsonSerializerOptions options = null)
    {
        var stream = new MemoryStream();
        Pack(value, stream, options);
        return stream;
    }

    /// <summary>
    /// Pack async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static async Task<Stream> ToStreamAsync<TValue>(TValue value, JsonSerializerOptions options = null, CancellationToken cancellationToken = default)
    {
        var stream = new MemoryStream();
        await PackAsync(value, stream, options, cancellationToken);
        return stream;
    }
}