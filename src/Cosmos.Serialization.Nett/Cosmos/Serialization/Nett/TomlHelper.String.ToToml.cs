namespace Cosmos.Serialization.Nett;

public static partial class TomlHelper
{
    public static string ToToml<TValue>(TValue value, TomlSettings settings = default)
    {
        if (value is null) return string.Empty;
        return Tommy.WriteString(value, settings ?? Man.DefaultSettings);
    }
}