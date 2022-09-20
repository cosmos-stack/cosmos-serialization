namespace Cosmos.Serialization.Nett;

public static partial class TomlHelper
{
    public static async Task<TValue> FromStreamAsync<TValue>(Stream stream, TomlSettings settings = default, CancellationToken cancellationToken = default)
    {
        if (stream is null || stream.CanSeek && stream.Length is 0)
            return default;
        if (stream.CanSeek && stream.Position > 0)
            stream.Position = 0;
        return await Async(() => Tommy.ReadStream<TValue>(stream, settings ?? Man.DefaultSettings), cancellationToken);
    }

    public static async Task<object> FromStreamAsync(Type type, Stream stream, TomlSettings settings = default, CancellationToken cancellationToken = default)
    {
        if (stream is null || stream.CanSeek && stream.Length is 0)
            return default;
        if (stream.CanSeek && stream.Position > 0)
            stream.Position = 0;
        return await Async(() => Tommy.ReadStream(stream, settings ?? Man.DefaultSettings).Get(type), cancellationToken);
    }
}