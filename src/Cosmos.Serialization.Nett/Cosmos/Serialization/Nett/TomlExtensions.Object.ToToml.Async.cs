namespace Cosmos.Serialization.Nett;

public static partial class TomlExtensions
{
    public static Task<string> ToTomlAsync<TValue>(this TValue value, TomlSettings settings = default, CancellationToken cancellationToken = default)
    {
        return TomlHelper.ToTomlAsync(value, settings, cancellationToken);
    }
}