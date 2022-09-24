namespace Cosmos.Serialization.Lit;

public static partial class LitExtensions
{
    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static string ToLitJson(this object value)
    {
        return LitHelper.ToJson(value);
    }

    /// <summary>
    /// Serialize async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<string> ToLitJsonAsync(this object value, CancellationToken cancellationToken = default)
    {
        return LitHelper.ToJsonAsync(value, cancellationToken);
    }
}