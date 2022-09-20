namespace Cosmos.Serialization.Bssom;

public static partial class BssomExtensions
{
    /// <summary>
    /// Deserializes a stream into a generic object.
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<TValue> FromBssomStreamAsync<TValue>(this Stream stream, BssomSerializerOptions options = default, CancellationToken cancellationToken = default)
    {
        return BssomHelper.FromStreamAsync<TValue>(stream, options, cancellationToken);
    }

    /// <summary>
    /// Deserializes a stream into a generic object.
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="optionAct"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<TValue> FromBssomStreamAsync<TValue>(this Stream stream, Action<BssomSerializerOptions> optionAct, CancellationToken cancellationToken = default)
    {
        return BssomHelper.FromStreamAsync<TValue>(stream, optionAct, cancellationToken);
    }

    /// <summary>
    /// Deserializes a stream into an object graph.
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="type"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<object> FromBssomStreamAsync(this Stream stream, Type type, BssomSerializerOptions options = default, CancellationToken cancellationToken = default)
    {
        return BssomHelper.FromStreamAsync(type, stream, options, cancellationToken);
    }

    /// <summary>
    /// Deserializes a stream into an object graph.
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="type"></param>
    /// <param name="optionAct"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<object> FromBssomStreamAsync(this Stream stream, Type type, Action<BssomSerializerOptions> optionAct, CancellationToken cancellationToken = default)
    {
        return BssomHelper.FromStreamAsync(type, stream, optionAct, cancellationToken);
    }
}