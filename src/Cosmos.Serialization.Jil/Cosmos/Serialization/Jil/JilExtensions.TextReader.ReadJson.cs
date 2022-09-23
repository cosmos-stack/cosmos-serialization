namespace Cosmos.Serialization.Jil;

public static partial class JilExtensions
{
    public static TValue ReadJilJson<TValue>(this TextReader reader, Options options = null)
    {
        return JilHelper.Deserialize<TValue>(reader, options);
    }

    public static object ReadJilJson(this TextReader reader, Type type, Options options = null)
    {
        return JilHelper.Deserialize(type, reader, options);
    }
}