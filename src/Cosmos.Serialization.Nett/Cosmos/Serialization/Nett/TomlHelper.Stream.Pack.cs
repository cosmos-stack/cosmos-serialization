namespace Cosmos.Serialization.Nett;

public static partial class TomlHelper
{
    public static void Pack<TValue>(TValue value, Stream stream, TomlSettings settings = default)
    {
        if (value is null || stream is null)
            return;
        Tommy.WriteStream(value, stream, settings ?? Man.DefaultSettings);
    }
}