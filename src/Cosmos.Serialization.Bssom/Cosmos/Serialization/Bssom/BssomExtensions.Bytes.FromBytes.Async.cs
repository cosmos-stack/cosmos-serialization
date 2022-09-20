namespace Cosmos.Serialization.Bssom;

public static partial class BssomExtensions
{
    /// <summary>
    /// Deserialize the bytes to object
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<TValue> FromBssomBytesAsync<TValue>(this byte[] bytes, BssomSerializerOptions options = default, CancellationToken cancellationToken = default)
    {
        return BssomHelper.FromBytesAsync<TValue>(bytes, options, cancellationToken);
    }

    /// <summary>
    /// Deserialize the bytes to object
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="optionAct"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<TValue> FromBssomBytesAsync<TValue>(this byte[] bytes, Action<BssomSerializerOptions> optionAct, CancellationToken cancellationToken = default)
    {
        return BssomHelper.FromBytesAsync<TValue>(bytes, optionAct, cancellationToken);
    }

    /// <summary>
    /// Deserialize the bytes to object
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="type"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<object> FromBssomBytesAsync(byte[] bytes, Type type, BssomSerializerOptions options, CancellationToken cancellationToken = default)
    {
        return BssomHelper.FromBytesAsync(type, bytes, options, cancellationToken);
    }

    /// <summary>
    /// Deserialize the bytes to object
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="type"></param>
    /// <param name="optionAct"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<object> FromBssomBytesAsync(byte[] bytes, Type type, Action<BssomSerializerOptions> optionAct, CancellationToken cancellationToken = default)
    {
        return BssomHelper.FromBytesAsync(type, bytes, optionAct, cancellationToken);
    }
}