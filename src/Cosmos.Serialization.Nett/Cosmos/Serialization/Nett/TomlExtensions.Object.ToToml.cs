namespace Cosmos.Serialization.Nett;

public static partial class TomlExtensions
{
    public static string ToToml<TValue>(this TValue value, TomlSettings settings = default)
    {
        return TomlHelper.ToToml(value, settings);
    }
}