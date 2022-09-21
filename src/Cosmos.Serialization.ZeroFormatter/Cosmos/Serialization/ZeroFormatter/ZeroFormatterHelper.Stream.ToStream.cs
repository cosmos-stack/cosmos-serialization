namespace Cosmos.Serialization.ZeroFormatter;

public static partial class ZeroFormatterHelper
{
    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Stream ToStream<TValue>(TValue value)
    {
        var stream = new MemoryStream();
        if (value is null) return stream;
        ZeroFormatterSerializer.Serialize(stream, value);
        return stream;
    }

    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="type"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    public static Stream ToStream(Type type, object value)
    {
        var stream = new MemoryStream();
        if (value is null) return stream;
        ZeroFormatterSerializer.NonGeneric.Serialize(type, stream, value);
        return stream;
    }

    /// <summary>
    /// Pack async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static async Task<Stream> ToStreamAsync<TValue>(TValue value, CancellationToken cancellationToken = default)
    {
        var stream = new MemoryStream();
        if (value is null) return stream;
        await Task.Run(() => ZeroFormatterSerializer.Serialize(stream, value), cancellationToken);
        return stream;
    }

    /// <summary>
    /// Pack async
    /// </summary>
    /// <param name="type"></param>
    /// <param name="value"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<Stream> ToStreamAsync(Type type, object value, CancellationToken cancellationToken = default)
    {
        var stream = new MemoryStream();
        if (value is null) return stream;
        await Task.Run(() => ZeroFormatterSerializer.NonGeneric.Serialize(type, stream, value), cancellationToken);
        return stream;
    }
}