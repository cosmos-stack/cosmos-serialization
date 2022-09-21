namespace Cosmos.Serialization.ZeroFormatter;

public static partial class ZeroFormatterHelper
{
    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <typeparam name="TValue"></typeparam>
    public static void Pack<TValue>(TValue value, Stream stream)
    {
        if (value is null) return;
        ZeroFormatterSerializer.Serialize(stream, value);
    }

    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <param name="type"></param>
    /// <param name="stream"></param>
    public static void Pack(Type type, object value, Stream stream)
    {
        if (value is null) return;
        ZeroFormatterSerializer.NonGeneric.Serialize(type, stream, value);
    }

    /// <summary>
    /// Pack async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    public static async Task PackAsync<TValue>(TValue value, Stream stream, CancellationToken cancellationToken = default)
    {
        if (value is null) return;
        await Task.Run(() => ZeroFormatterSerializer.Serialize(stream, value), cancellationToken);
    }

    /// <summary>
    /// Pack async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="type"></param>
    /// <param name="stream"></param>
    /// <param name="cancellationToken"></param>
    public static async Task PackAsync(Type type, object value, Stream stream, CancellationToken cancellationToken = default)
    {
        if (value is null) return;
        await Task.Run(() => ZeroFormatterSerializer.NonGeneric.Serialize(type, stream, value), cancellationToken);
    }
}