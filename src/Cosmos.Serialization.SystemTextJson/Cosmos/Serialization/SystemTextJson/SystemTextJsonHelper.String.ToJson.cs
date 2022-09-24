using System.Text.Json;

namespace Cosmos.Serialization.SystemTextJson;

public static partial class SystemTextJsonHelper
{
    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="value"></param>
    /// <param name="options"></param>
    /// <returns></returns>
    public static string ToJson(object value, JsonSerializerOptions options = null)
    {
        return value is null
            ? string.Empty
            : JsonSerializer.Serialize(value, options.ToOptions());
    }

    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="value"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<string> ToJsonAsync(object value, JsonSerializerOptions options = null, CancellationToken cancellationToken = default)
    {
        return value is null
            ? string.Empty
            : await Task.Run(() => JsonSerializer.Serialize(value, options.ToOptions()), cancellationToken);
    }
}