namespace Cosmos.Serialization.Bssom;

public static partial class BssomHelper
{
    /// <summary>
    /// Serializes an object into a Stream.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="options"></param>
    /// <returns></returns>
    public static Stream ToStream(object value, BssomSerializerOptions options = default)
    {
        var stream = new MemoryStream();
        if (value is null) return stream;
        BssomSerializer.Serialize(stream, value, options ?? Man.DefaultOptions);
        return stream;
    }

    /// <summary>
    /// Serializes an object into a Stream.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="optionAct"></param>
    /// <returns></returns>
    public static Stream ToStream(object value, Action<BssomSerializerOptions> optionAct)
    {
        var stream = new MemoryStream();
        if (value is null) return stream;
        BssomSerializer.Serialize(stream, value, optionAct.ToOptions());
        return stream;
    }

    /// <summary>
    /// Serializes an object into a Stream.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<Stream> ToStreamAsync(object value, BssomSerializerOptions options = default, CancellationToken cancellationToken = default)
    {
        var stream = new MemoryStream();
        if (value is null) return stream;
        await BssomSerializer.SerializeAsync(stream, value, options ?? Man.DefaultOptions, cancellationToken);
        return stream;
    }

    /// <summary>
    /// Serializes an object into a Stream.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="optionAct"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<Stream> ToStreamAsync(object value, Action<BssomSerializerOptions> optionAct, CancellationToken cancellationToken = default)
    {
        var stream = new MemoryStream();
        if (value is null) return stream;
        await BssomSerializer.SerializeAsync(stream, value, optionAct.ToOptions(), cancellationToken);
        return stream;
    }

}