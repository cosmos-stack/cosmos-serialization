namespace Cosmos.Serialization.Bssom;

public static partial class BssomHelper
{
    /// <summary>
    /// Deserializes a stream into a generic object.
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="options"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromStream<TValue>(Stream stream, BssomSerializerOptions options = default)
    {
        if (stream is null || stream.CanSeek && stream.Length is 0)
            return default;
        if (stream.CanSeek && stream.Position > 0)
            stream.Position = 0;
        return BssomSerializer.Deserialize<TValue>(stream, options ?? Man.DefaultOptions);
    }

    /// <summary>
    /// Deserializes a stream into a generic object.
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="optionAct"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromStream<TValue>(Stream stream, Action<BssomSerializerOptions> optionAct)
    {
        if (stream is null || stream.CanSeek && stream.Length is 0)
            return default;
        if (stream.CanSeek && stream.Position > 0)
            stream.Position = 0;
        return BssomSerializer.Deserialize<TValue>(stream, optionAct.ToOptions());
    }

    /// <summary>
    /// Deserializes a stream into an object graph.
    /// </summary>
    /// <param name="type"></param>
    /// <param name="stream"></param>
    /// <param name="options"></param>
    /// <returns></returns>
    public static object FromStream(Type type, Stream stream, BssomSerializerOptions options = default)
    {
        if (stream is null || stream.CanSeek && stream.Length is 0)
            return default;
        if (stream.CanSeek && stream.Position > 0)
            stream.Position = 0;
        return BssomSerializer.Deserialize(stream, type, options ?? Man.DefaultOptions);
    }

    /// <summary>
    /// Deserializes a stream into an object graph.
    /// </summary>
    /// <param name="type"></param>
    /// <param name="stream"></param>
    /// <param name="optionAct"></param>
    /// <returns></returns>
    public static object FromStream(Type type, Stream stream, Action<BssomSerializerOptions> optionAct)
    {
        if (stream is null || stream.CanSeek && stream.Length is 0)
            return default;
        if (stream.CanSeek && stream.Position > 0)
            stream.Position = 0;
        return BssomSerializer.Deserialize(stream, type, optionAct.ToOptions());
    }

    /// <summary>
    /// Deserializes a stream into a generic object.
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static async Task<TValue> FromStreamAsync<TValue>(Stream stream, BssomSerializerOptions options = default, CancellationToken cancellationToken = default)
    {
        if (stream is null || stream.CanSeek && stream.Length is 0)
            return default;
        if (stream.CanSeek && stream.Position > 0)
            stream.Position = 0;
        return await BssomSerializer.DeserializeAsync<TValue>(stream, options ?? Man.DefaultOptions, cancellationToken);
    }

    /// <summary>
    /// Deserializes a stream into a generic object.
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="optionAct"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static async Task<TValue> FromStreamAsync<TValue>(Stream stream, Action<BssomSerializerOptions> optionAct, CancellationToken cancellationToken = default)
    {
        if (stream is null || stream.CanSeek && stream.Length is 0)
            return default;
        if (stream.CanSeek && stream.Position > 0)
            stream.Position = 0;
        return await BssomSerializer.DeserializeAsync<TValue>(stream, optionAct.ToOptions(), cancellationToken);
    }

    /// <summary>
    /// Deserializes a stream into an object graph.
    /// </summary>
    /// <param name="type"></param>
    /// <param name="stream"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<object> FromStreamAsync(Type type, Stream stream, BssomSerializerOptions options = default, CancellationToken cancellationToken = default)
    {
        if (stream is null || stream.CanSeek && stream.Length is 0)
            return default;
        if (stream.CanSeek && stream.Position > 0)
            stream.Position = 0;
        return await BssomSerializer.DeserializeAsync(stream, type, options ?? Man.DefaultOptions, cancellationToken);
    }

    /// <summary>
    /// Deserializes a stream into an object graph.
    /// </summary>
    /// <param name="type"></param>
    /// <param name="stream"></param>
    /// <param name="optionAct"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<object> FromStreamAsync(Type type, Stream stream, Action<BssomSerializerOptions> optionAct, CancellationToken cancellationToken = default)
    {
        if (stream is null || stream.CanSeek && stream.Length is 0)
            return default;
        if (stream.CanSeek && stream.Position > 0)
            stream.Position = 0;
        return await BssomSerializer.DeserializeAsync(stream, type, optionAct.ToOptions(), cancellationToken);
    }
}