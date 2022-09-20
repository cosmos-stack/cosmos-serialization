namespace Cosmos.Serialization.Nett;

public static partial class TomlExtensions
{
    public static TValue FromTomlBytes<TValue>(this byte[] bytes, TomlSettings settings = default)
    {
        return TomlHelper.FromBytes<TValue>(bytes, settings);
    }

    public static object FromTomlBytes(this byte[] bytes, Type type, TomlSettings settings = default)
    {
        return TomlHelper.FromBytes(type, bytes, settings);
    }
}