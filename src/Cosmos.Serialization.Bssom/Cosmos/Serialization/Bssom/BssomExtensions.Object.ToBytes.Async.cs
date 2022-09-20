namespace Cosmos.Serialization.Bssom;

public static partial class BssomExtensions
{
    /// <summary>
    /// Serializes an object into a set of byte.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<byte[]> ToBssomBytesAsync<TValue>(this TValue value, BssomSerializerOptions options = default, CancellationToken cancellationToken = default)
    {
        return BssomHelper.ToBytesAsync(value, options, cancellationToken);
    }

    /// <summary>
    /// Serializes an object into a set of byte.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="optionAct"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<byte[]> ToBssomBytesAsync<TValue>(this TValue value, Action<BssomSerializerOptions> optionAct, CancellationToken cancellationToken = default)
    {
        return BssomHelper.ToBytesAsync(value, optionAct, cancellationToken);
    }
}