namespace Cosmos.Serialization.Nett;

public static partial class TomlExtensions
{
    public static void TomlPackTo<TValue>(this TValue value, Stream stream, TomlSettings settings = default)
    {
        TomlHelper.Pack(value, stream, settings);
    }

    public static Task TomlPackToAsync<TValue>(this TValue value, Stream stream, TomlSettings settings = default, CancellationToken cancellationToken = default)
    {
        return TomlHelper.PackAsync(value, stream, settings, cancellationToken);
    }
}