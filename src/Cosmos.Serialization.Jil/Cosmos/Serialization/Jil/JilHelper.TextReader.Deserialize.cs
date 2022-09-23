namespace Cosmos.Serialization.Jil;

public static partial class JilHelper
{
    public static TValue Deserialize<TValue>(TextReader reader, Options options = null)
    {
        return reader is null
            ? default
            : JSON.Deserialize<TValue>(reader, options.ToOptions());
    }

    public static object Deserialize(Type type, TextReader reader, Options options = null)
    {
        return reader is null
            ? default
            : JSON.Deserialize(reader, type, options.ToOptions());
    }
}