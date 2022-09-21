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

    public static Task<TValue> FromTomlBytesAsync<TValue>(this byte[] bytes, TomlSettings settings = default, CancellationToken cancellationToken = default)
    {
        return TomlHelper.FromBytesAsync<TValue>(bytes, settings, cancellationToken);
    }

    public static Task<object> FromTomlBytesAsync(this byte[] bytes, Type type, TomlSettings settings = default, CancellationToken cancellationToken = default)
    {
        return TomlHelper.FromBytesAsync(type, bytes, settings, cancellationToken);
    }
}