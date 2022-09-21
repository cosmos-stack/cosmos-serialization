namespace Cosmos.Serialization.Nett;

public static partial class TomlHelper
{
    public static void Pack<TValue>(TValue value, Stream stream, TomlSettings settings = default)
    {
        if (value is null || stream is null)
            return;
        Tommy.WriteStream(value, stream, settings ?? Man.DefaultSettings);
    }

    public static async Task PackAsync<TValue>(TValue value, Stream stream, TomlSettings settings = default, CancellationToken cancellationToken = default)
    {
        if (value is null || stream is null)
            return;
        var task = Task.Run(() => Tommy.WriteStream(value, stream, settings ?? Man.DefaultSettings), cancellationToken);
        await task;
    }
}