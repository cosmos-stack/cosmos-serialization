namespace Cosmos.Serialization.Bssom;

public static partial class BssomExtensions
{
    /// <summary>
    /// Serializes the object, or graph of objects with the specified top (root), to the given stream.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    public static Task BssomPackToAsync<TValue>(this TValue value, Stream stream, BssomSerializerOptions options = default, CancellationToken cancellationToken = default)
    {
        return BssomHelper.PackAsync(value, stream, options, cancellationToken);
    }

    /// <summary>
    /// Serializes the object, or graph of objects with the specified top (root), to the given stream.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <param name="optionAct"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    public static Task BssomPackToAsync<TValue>(this TValue value, Stream stream, Action<BssomSerializerOptions> optionAct, CancellationToken cancellationToken = default)
    {
        return BssomHelper.PackAsync(value, stream, optionAct, cancellationToken);
    }
}