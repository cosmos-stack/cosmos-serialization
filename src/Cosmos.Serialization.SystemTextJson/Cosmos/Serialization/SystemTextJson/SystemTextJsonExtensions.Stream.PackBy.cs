using System.Text.Json;

namespace Cosmos.Serialization.SystemTextJson;

public static partial class SystemTextJsonExtensions
{
    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="value"></param>
    /// <param name="options"></param>
    /// <typeparam name="TValue"></typeparam>
    public static void MsJsonPackBy<TValue>(this Stream stream, TValue value, JsonSerializerOptions options = null)
    {
        SystemTextJsonHelper.Pack(value, stream, options);
    }

    /// <summary>
    /// Pack async
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="value"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    public static Task MsJsonPackByAsync<TValue>(this Stream stream, TValue value, JsonSerializerOptions options = null, CancellationToken cancellationToken = default)
    {
        return SystemTextJsonHelper.PackAsync(value, stream, options, cancellationToken);
    }
}