namespace Cosmos.Serialization.Nett;

public static partial class TomlExtensions
{
    public static TValue FromToml<TValue>(this string toml, TomlSettings settings = default)
    {
        return TomlHelper.FromToml<TValue>(toml, settings);
    }

    public static object FromToml(this string toml, Type type, TomlSettings settings = default)
    {
        return TomlHelper.FromToml(type, toml, settings);
    }

    public static Task<TValue> FromTomlAsync<TValue>(this string toml, TomlSettings settings = default, CancellationToken cancellationToken = default)
    {
        return TomlHelper.FromTomlAsync<TValue>(toml, settings, cancellationToken);
    }

    public static Task<object> FromTomlAsync(this string toml, Type type, TomlSettings settings = default, CancellationToken cancellationToken = default)
    {
        return TomlHelper.FromTomlAsync(type, toml, settings, cancellationToken);
    }
}