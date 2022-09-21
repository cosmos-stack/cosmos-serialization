namespace Cosmos.Serialization.ZeroFormatter;

/// <summary>
/// ZeroFormatter helper
/// </summary>
public static partial class ZeroFormatterHelper
{
    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="bytes"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromBytes<TValue>(byte[] bytes)
    {
        return bytes is null || bytes.Length == 0
            ? default
            : ZeroFormatterSerializer.Deserialize<TValue>(bytes);
    }

    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="type"></param>
    /// <returns></returns>
    public static object FromBytes(Type type, byte[] bytes)
    {
        return bytes is null || bytes.Length == 0
            ? null
            : ZeroFormatterSerializer.NonGeneric.Deserialize(type, bytes);
    }

    /// <summary>
    /// Deserialize async
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static async Task<TValue> FromBytesAsync<TValue>(byte[] bytes, CancellationToken cancellationToken = default)
    {
        return bytes is null || bytes.Length is 0
            ? default
            : await Task.Run(() => ZeroFormatterSerializer.Deserialize<TValue>(bytes), cancellationToken);
    }

    /// <summary>
    /// Deserialize async
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="type"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<object> FromBytesAsync(Type type, byte[] bytes, CancellationToken cancellationToken = default)
    {
        return bytes is null || bytes.Length is 0
            ? default
            : await Task.Run(() => ZeroFormatterSerializer.NonGeneric.Deserialize(type, bytes), cancellationToken);
    }
}