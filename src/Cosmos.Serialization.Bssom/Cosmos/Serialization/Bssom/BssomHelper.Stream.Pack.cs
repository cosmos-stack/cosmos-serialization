namespace Cosmos.Serialization.Bssom;

public static partial class BssomHelper
{
    /// <summary>
    /// Serializes the object, or graph of objects with the specified top (root), to the given stream.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    public static void Pack<TValue>(TValue value, Stream stream, BssomSerializerOptions options = default, CancellationToken cancellationToken = default)
    {
        if (value is null || stream is null)
            return;
        BssomSerializer.Serialize(stream, value, options ?? Man.DefaultOptions, cancellationToken);
    }

    /// <summary>
    /// Serializes the object, or graph of objects with the specified top (root), to the given stream.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <param name="optionAct"></param>
    /// <param name="cancellationToken"></param>
    public static void Pack<TValue>(TValue value, Stream stream, Action<BssomSerializerOptions> optionAct, CancellationToken cancellationToken = default)
    {
        if (value is null || stream is null)
            return;
        BssomSerializer.Serialize(stream, value, optionAct.ToOptions(), cancellationToken);
    }

    /// <summary>
    /// Serializes the object, or graph of objects with the specified top (root), to the given stream.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    public static async Task PackAsync<TValue>(TValue value, Stream stream, BssomSerializerOptions options = default, CancellationToken cancellationToken = default)
    {
        if (value is null || stream is null)
            return;
        await BssomSerializer.SerializeAsync(stream, value, options ?? Man.DefaultOptions, cancellationToken);
    }

    /// <summary>
    /// Serializes the object, or graph of objects with the specified top (root), to the given stream.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <param name="optionAct"></param>
    /// <param name="cancellationToken"></param>
    public static async Task PackAsync<TValue>(TValue value, Stream stream, Action<BssomSerializerOptions> optionAct, CancellationToken cancellationToken = default)
    {
        if (value is null || stream is null)
            return;
        await BssomSerializer.SerializeAsync(stream, value, optionAct.ToOptions(), cancellationToken);
    }
}