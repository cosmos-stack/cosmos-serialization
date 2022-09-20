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
    public static void BssomPackBy<TValue>(this Stream stream, TValue value, BssomSerializerOptions options = default, CancellationToken cancellationToken = default)
    {
        BssomHelper.Pack(value, stream, options, cancellationToken);
    }

    /// <summary>
    /// Serializes the object, or graph of objects with the specified top (root), to the given stream.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <param name="optionAct"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    public static void BssomPackBy<TValue>(this Stream stream, TValue value, Action<BssomSerializerOptions> optionAct, CancellationToken cancellationToken = default)
    {
        BssomHelper.Pack(value, stream, optionAct, cancellationToken);
    }
}