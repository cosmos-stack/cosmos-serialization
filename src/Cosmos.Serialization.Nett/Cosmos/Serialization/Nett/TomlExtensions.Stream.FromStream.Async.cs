namespace Cosmos.Serialization.Nett;

public static partial class TomlExtensions
{
    public static Task<TValue> FromTomlStreamAsync<TValue>(this Stream stream, TomlSettings settings = default)
    {
        return TomlHelper.FromStreamAsync<TValue>(stream, settings);
    }

    public static Task<object> FromTomlStreamAsync(this Stream stream, Type type, TomlSettings settings = default)
    {
        return TomlHelper.FromStreamAsync(type, stream, settings);
    }
}