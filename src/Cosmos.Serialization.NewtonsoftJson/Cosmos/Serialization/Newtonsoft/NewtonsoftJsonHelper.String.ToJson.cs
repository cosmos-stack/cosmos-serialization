namespace Cosmos.Serialization.Newtonsoft;

public static partial class NewtonsoftJsonHelper
{
    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="value"></param>
    /// <param name="settings"></param>
    /// <param name="enableNodaTime"></param>
    /// <returns></returns>
    public static string ToJson(object value, JsonSerializerSettings settings = null, bool enableNodaTime = false)
    {
        return value is null
            ? string.Empty
            : JsonConvert.SerializeObject(value, settings.ToSettings(enableNodaTime));
    }

    /// <summary>
    /// Serialize async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="settings"></param>
    /// <param name="enableNodaTime"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<string> ToJsonAsync(object value, JsonSerializerSettings settings = null, bool enableNodaTime = false, CancellationToken cancellationToken = default)
    {
        return value is null
            ? string.Empty
            : await Task.Run(() => JsonConvert.SerializeObject(value, settings.ToSettings(enableNodaTime)), cancellationToken);
    }
}