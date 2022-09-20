namespace Cosmos.Serialization.Nett;

public static partial class TomlHelper
{
    public static async Task<Stream> ToStreamAsync<TValue>(TValue value, TomlSettings settings = default, CancellationToken cancellationToken = default)
    {
        var stream = new MemoryStream();
        if (value is null) return stream;

        return await Async(() =>
        {
            Tommy.WriteStream(value, stream, settings ?? Man.DefaultSettings);
            return stream;
        }, cancellationToken);
    }
}