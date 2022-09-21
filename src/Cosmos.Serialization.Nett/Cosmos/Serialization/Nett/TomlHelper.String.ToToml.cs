namespace Cosmos.Serialization.Nett;

public static partial class TomlHelper
{
    public static string ToToml<TValue>(TValue value, TomlSettings settings = default)
    {
        if (value is null) return string.Empty;
        return Tommy.WriteString(value, settings ?? Man.DefaultSettings);
    }

    public static async Task<string> ToTomlAsync<TValue>(TValue value, TomlSettings settings = default, CancellationToken cancellationToken = default)
    {
        if (value is null) return string.Empty;
        return await Async(() => Tommy.WriteString(value, settings ?? Man.DefaultSettings), cancellationToken);
    }
}