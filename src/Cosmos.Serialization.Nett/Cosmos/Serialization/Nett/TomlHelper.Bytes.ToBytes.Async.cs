using Cosmos.Conversions;

namespace Cosmos.Serialization.Nett;

public static partial class TomlHelper
{
    public static async Task<byte[]> ToBytesAsync<TValue>(TValue value, TomlSettings settings = default, CancellationToken cancellationToken = default)
    {
        if (value is null) return Arrays.Empty<byte>();
        using var stream = new MemoryStream();
        Tommy.WriteStream(value, stream, settings);
        //TODO 此处需要重构
        return await stream.CastToBytesAsync();
    }
}