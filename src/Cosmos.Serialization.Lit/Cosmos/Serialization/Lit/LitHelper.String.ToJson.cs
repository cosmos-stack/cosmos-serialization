namespace Cosmos.Serialization.Lit;

public static partial class LitHelper
{
    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static string ToJson(object value)
    {
        return value is null
            ? string.Empty
            : JsonMapper.ToJson(value);
    }

    /// <summary>
    /// Serialize async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<string> ToJsonAsync(object value, CancellationToken cancellationToken = default)
    {
        return value is null
            ? string.Empty
            : await Task.Run(() => JsonMapper.ToJson(value), cancellationToken);
    }
}