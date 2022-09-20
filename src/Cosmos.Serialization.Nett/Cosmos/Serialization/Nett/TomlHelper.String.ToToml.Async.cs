namespace Cosmos.Serialization.Nett;

public static partial class TomlHelper
{
    public static async Task<string> ToTomlAsync<TValue>(TValue value, TomlSettings settings = default, CancellationToken cancellationToken = default)
    {
        if (value is null) return string.Empty;
        return await Async(() => Tommy.WriteString(value, settings ?? Man.DefaultSettings), cancellationToken);
    }
}