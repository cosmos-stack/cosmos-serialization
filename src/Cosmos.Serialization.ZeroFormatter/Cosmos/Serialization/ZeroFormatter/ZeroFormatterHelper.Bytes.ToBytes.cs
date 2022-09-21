namespace Cosmos.Serialization.ZeroFormatter;

/// <summary>
/// ZeroFormatter helper
/// </summary>
public static partial class ZeroFormatterHelper
{
    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="value"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static byte[] ToBytes<TValue>(TValue value)
    {
        return value is null
            ? Arrays.Empty<byte>()
            : ZeroFormatterSerializer.Serialize(value);
    }

    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="value"></param>
    /// <param name="type"></param>
    /// <returns></returns>
    public static byte[] ToBytes(Type type, object value)
    {
        return value is null
            ? Arrays.Empty<byte>()
            : ZeroFormatterSerializer.NonGeneric.Serialize(type, value);
    }

    /// <summary>
    /// Serialize async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static async Task<byte[]> ToBytesAsync<TValue>(TValue value, CancellationToken cancellationToken = default)
    {
        return value is null
            ? Arrays.Empty<byte>()
            : await Task.Run(() => ZeroFormatterSerializer.Serialize(value), cancellationToken);
    }

    /// <summary>
    /// Serialize async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="type"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<byte[]> ToBytesAsync(Type type, object value, CancellationToken cancellationToken = default)
    {
        return value is null
            ? Arrays.Empty<byte>()
            : await Task.Run(() => ZeroFormatterSerializer.NonGeneric.Serialize(type, value), cancellationToken);
    }
}