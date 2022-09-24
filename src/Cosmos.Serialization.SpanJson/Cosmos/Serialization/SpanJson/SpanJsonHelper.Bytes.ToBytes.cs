using Cosmos.Collections;
using Cosmos.Conversions;
using SpanJson;

namespace Cosmos.Serialization.SpanJson;

public static partial class SpanJsonHelper
{
    /// <summary>
    /// Serialize to bytes
    /// </summary>
    /// <param name="value"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static byte[] ToBytes<TValue>(TValue value)
    {
        return value is null
            ? Arrays.Empty<byte>()
            : JsonSerializer.Generic.Utf8.Serialize(value);
    }

    public static async ValueTask<byte[]> ToBytesAsync<TValue>(TValue value, CancellationToken cancellationToken = default)
    {
        if (value is null)
            return Arrays.Empty<byte>();
        await using Stream stream = new MemoryStream();
        await JsonSerializer.Generic.Utf8.SerializeAsync(value, stream, cancellationToken);
        return await stream.CastToBytesAsync();
    }
}