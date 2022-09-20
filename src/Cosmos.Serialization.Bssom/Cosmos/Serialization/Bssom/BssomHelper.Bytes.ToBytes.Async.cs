namespace Cosmos.Serialization.Bssom;

public static partial class BssomHelper
{
    /// <summary>
    /// Serializes an object into a set of byte.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="options"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static async Task<byte[]> ToBytesAsync<TValue>(TValue value, BssomSerializerOptions options = default, CancellationToken cancellationToken = default)
    {
        using var stream = new MemoryStream();
        await BssomSerializer.SerializeAsync(stream, value, options ?? Man.DefaultOptions, cancellationToken);
        return await stream.CastToBytesAsync();
    }

    /// <summary>
    /// Serializes an object into a set of byte.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="optionAct"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static async Task<byte[]> ToBytesAsync<TValue>(TValue value, Action<BssomSerializerOptions> optionAct, CancellationToken cancellationToken = default)
    {
        using var stream = new MemoryStream();
        await BssomSerializer.SerializeAsync(stream, value, optionAct.ToOptions(), cancellationToken);
        return await stream.CastToBytesAsync();
    }
}