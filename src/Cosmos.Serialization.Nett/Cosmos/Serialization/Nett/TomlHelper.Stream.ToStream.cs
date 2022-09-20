namespace Cosmos.Serialization.Nett;

public static partial class TomlHelper
{
    public static Stream ToStream<TValue>(TValue value, TomlSettings settings = default)
    {
        var stream = new MemoryStream();
        if (value is null) return stream;
        Tommy.WriteStream(value, stream, settings ?? Man.DefaultSettings);
        return stream;
    }
}