using System.Text.Json;

namespace Cosmos.Serialization.SystemTextJson;

public static partial class SystemTextJsonExtensions
{
    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <param name="options"></param>
    /// <typeparam name="TValue"></typeparam>
    public static void MsJsonPackTo<TValue>(this TValue value, Stream stream, JsonSerializerOptions options = null)
    {
        SystemTextJsonHelper.Pack(value, stream, options);
    }

    /// <summary>
    /// Pack async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    public static Task MsJsonPackToAsync<TValue>(this TValue value, Stream stream, JsonSerializerOptions options = null, CancellationToken cancellationToken = default)
    {
        return SystemTextJsonHelper.PackAsync(value, stream, options, cancellationToken);
    }
}