namespace Cosmos.Serialization.Nett;

public static partial class TomlExtensions
{
    public static void TomlPackBy<TValue>(this Stream stream, TValue value, TomlSettings settings = default)
    {
        TomlHelper.Pack(value, stream, settings);
    }

    public static Task TomlPackByAsync<TValue>(this Stream stream, TValue value, TomlSettings settings = default, CancellationToken cancellationToken = default)
    {
        return TomlHelper.PackAsync(value, stream, settings, cancellationToken);
    }
}