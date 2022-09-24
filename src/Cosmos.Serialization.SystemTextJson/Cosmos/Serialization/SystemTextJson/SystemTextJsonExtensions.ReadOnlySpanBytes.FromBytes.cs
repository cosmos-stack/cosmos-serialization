using System.Text.Json;

namespace Cosmos.Serialization.SystemTextJson;

public static partial class SystemTextJsonExtensions
{
    public static TValue FromMsJsonBytes<TValue>(this ReadOnlySpan<byte> bytes, JsonSerializerOptions options = null)
    {
        return SystemTextJsonHelper.FromBytes<TValue>(bytes, options);
    }

    public static object FromMsJsonBytes(this ReadOnlySpan<byte> bytes, Type type, JsonSerializerOptions options = null)
    {
        return SystemTextJsonHelper.FromBytes(type, bytes, options);
    }
}