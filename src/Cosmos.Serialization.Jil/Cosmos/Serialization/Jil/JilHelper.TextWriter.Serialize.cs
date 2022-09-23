namespace Cosmos.Serialization.Jil;

public static partial class JilHelper
{
    public static void Serialize<TValue>(TValue value, TextWriter output, Options options = null)
    {
        if (output is null) return;
        JSON.Serialize(value, output, options.ToOptions());
    }

    public static void Serialize(object value, TextWriter output, Options options = null)
    {
        if (output is null) return;
        JSON.SerializeDynamic(value, output, options.ToOptions());
    }
}