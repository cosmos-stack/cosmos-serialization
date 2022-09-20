namespace Cosmos.Serialization.Nett;

public static partial class TomlExtensions
{
    public static TValue FromTomlStream<TValue>(this Stream stream, TomlSettings settings = default)
    {
        return TomlHelper.FromStream<TValue>(stream, settings);
    }

    public static object FromTomlStream(this Stream stream, Type type, TomlSettings settings = default)
    {
        return TomlHelper.FromStream(type, stream, settings);
    }
}