namespace Cosmos.Serialization.Nett;

public static partial class TomlExtensions
{
    public static void TomlPackTo<TValue>(this TValue value, Stream stream, TomlSettings settings = default)
    {
        TomlHelper.Pack(value, stream, settings);
    }
}