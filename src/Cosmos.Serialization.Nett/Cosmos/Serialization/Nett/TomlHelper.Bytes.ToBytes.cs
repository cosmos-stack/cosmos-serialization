using Cosmos.Conversions;

namespace Cosmos.Serialization.Nett;

public static partial class TomlHelper
{
    public static byte[] ToBytes<TValue>(TValue value, TomlSettings settings = default)
    {
        if (value is null) return Arrays.Empty<byte>();
        using var stream = new MemoryStream();
        Tommy.WriteStream(value, stream, settings);
        return stream.CastToBytes();
    }
}