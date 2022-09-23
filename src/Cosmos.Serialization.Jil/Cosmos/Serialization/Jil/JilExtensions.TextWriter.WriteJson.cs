namespace Cosmos.Serialization.Jil;

public static partial class JilExtensions
{
    public static void WriteJilJson<TValue>(this TextWriter writer, TValue value, Options options = null)
    {
        JilHelper.Serialize(value, writer, options);
    }

    public static void WriteJilJson(this TextWriter writer, object value, Options options = null)
    {
        JilHelper.Serialize(value, writer, options);
    }
}