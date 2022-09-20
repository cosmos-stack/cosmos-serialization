namespace Cosmos.Serialization.Nett;

public static partial class TomlExtensions
{
    public static Stream ToTomlStream<TValue>(this TValue value, TomlSettings settings = default)
    {
        return TomlHelper.ToStream(value, settings);
    }
}