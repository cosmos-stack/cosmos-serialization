namespace Cosmos.Serialization.Nett;

public static partial class TomlHelper
{
    public static TValue FromStream<TValue>(Stream stream, TomlSettings settings = default)
    {
        if (stream is null || stream.CanSeek && stream.Length is 0)
            return default;
        if (stream.CanSeek && stream.Position > 0)
            stream.Position = 0;
        return Tommy.ReadStream<TValue>(stream, settings ?? Man.DefaultSettings);
    }

    public static object FromStream(Type type, Stream stream, TomlSettings settings = default)
    {
        if (stream is null || stream.CanSeek && stream.Length is 0)
            return default;
        if (stream.CanSeek && stream.Position > 0)
            stream.Position = 0;
        return Tommy.ReadStream(stream, settings ?? Man.DefaultSettings).Get(type);
    }
}