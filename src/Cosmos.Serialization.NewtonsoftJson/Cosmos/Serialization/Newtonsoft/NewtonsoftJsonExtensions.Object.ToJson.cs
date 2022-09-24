namespace Cosmos.Serialization.Newtonsoft;

public static partial class NewtonsoftJsonExtensions
{
    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="value"></param>
    /// <param name="settings"></param>
    /// <param name="enableNodaTime"></param>
    /// <returns></returns>
    public static string ToNewtonsoftJson(this object value, JsonSerializerSettings settings = null, bool enableNodaTime = false)
    {
        return NewtonsoftJsonHelper.ToJson(value, settings, enableNodaTime);
    }

    /// <summary>
    /// Serialize async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="settings"></param>
    /// <param name="enableNodaTime"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<string> ToNewtonsoftJsonAsync(this object value, JsonSerializerSettings settings = null, bool enableNodaTime = false, CancellationToken cancellationToken = default)
    {
        return NewtonsoftJsonHelper.ToJsonAsync(value, settings, enableNodaTime, cancellationToken);
    }
}