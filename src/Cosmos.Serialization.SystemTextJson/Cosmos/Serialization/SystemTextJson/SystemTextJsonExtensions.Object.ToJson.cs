using System.Text.Json;

namespace Cosmos.Serialization.SystemTextJson;

public static partial class SystemTextJsonExtensions
{
    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="value"></param>
    /// <param name="options"></param>
    /// <returns></returns>
    public static string ToMsJson(this object value, JsonSerializerOptions options = null)
    {
        return SystemTextJsonHelper.ToJson(value, options);
    }

    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="value"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<string> ToMsJsonAsync(this object value, JsonSerializerOptions options = null, CancellationToken cancellationToken = default)
    {
        return SystemTextJsonHelper.ToJsonAsync(value, options, cancellationToken);
    }
}