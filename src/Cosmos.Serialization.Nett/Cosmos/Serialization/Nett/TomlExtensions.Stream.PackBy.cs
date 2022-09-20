namespace Cosmos.Serialization.Nett;

public static partial class TomlExtensions
{
    public static void TomlPackBy<TValue>(this Stream stream, TValue value, TomlSettings settings = default)
    {
        TomlHelper.Pack(value, stream, settings);
    }
}