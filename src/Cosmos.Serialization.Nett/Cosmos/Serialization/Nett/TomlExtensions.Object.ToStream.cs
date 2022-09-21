namespace Cosmos.Serialization.Nett;

public static partial class TomlExtensions
{
    public static Stream ToTomlStream<TValue>(this TValue value, TomlSettings settings = default)
    {
        return TomlHelper.ToStream(value, settings);
    }

    public static Task<Stream> ToTomlStreamAsync<TValue>(this TValue value, TomlSettings settings = default, CancellationToken cancellationToken = default)
    {
        return TomlHelper.ToStreamAsync(value, settings, cancellationToken);
    }
}