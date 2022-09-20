namespace Cosmos.Serialization.Nett;

public static partial class TomlExtensions
{
    public static Task<byte[]> ToTomlBytesAsync<TValue>(this TValue value, TomlSettings settings = default, CancellationToken cancellationToken = default)
    {
        return TomlHelper.ToBytesAsync(value, settings, cancellationToken);
    }
}