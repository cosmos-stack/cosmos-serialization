namespace Cosmos.Serialization.Nett;

public static partial class TomlHelper
{
    public static TValue FromToml<TValue>(string toml, TomlSettings settings = default)
    {
        if (string.IsNullOrWhiteSpace(toml)) return default;
        return Tommy.ReadString<TValue>(toml, settings ?? Man.DefaultSettings);
    }

    public static object FromToml(Type type, string toml, TomlSettings settings = default)
    {
        if (string.IsNullOrWhiteSpace(toml)) return default;
        return Tommy.ReadString(toml, settings ?? Man.DefaultSettings).Get(type);
    }

    public static async Task<TValue> FromTomlAsync<TValue>(string toml, TomlSettings settings = default, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(toml)) return default;
        return await Async(() => Tommy.ReadString<TValue>(toml, settings ?? Man.DefaultSettings), cancellationToken);
    }

    public static async Task<object> FromTomlAsync(Type type, string toml, TomlSettings settings = default, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(toml)) return default;
        return await Async(() => Tommy.ReadString(toml, settings ?? Man.DefaultSettings).Get(type), cancellationToken);
    }
}