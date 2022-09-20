namespace Cosmos.Serialization.Nett;

public static partial class TomlExtensions
{
    public static Task<TValue> FromTomlBytesAsync<TValue>(this byte[] bytes, TomlSettings settings = default, CancellationToken cancellationToken = default)
    {
        return TomlHelper.FromBytesAsync<TValue>(bytes, settings, cancellationToken);
    }

    public static Task<object> FromTomlBytesAsync(this byte[] bytes, Type type, TomlSettings settings = default, CancellationToken cancellationToken = default)
    {
        return TomlHelper.FromBytesAsync(type, bytes, settings, cancellationToken);
    }
}