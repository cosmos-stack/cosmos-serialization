namespace Cosmos.Serialization.Bssom;

public static partial class BssomExtensions
{
    /// <summary>
    /// Deserializes a stream into a generic object.
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="options"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromBssomStream<TValue>(this Stream stream, BssomSerializerOptions options = default)
    {
        return BssomHelper.FromStream<TValue>(stream, options);
    }

    /// <summary>
    /// Deserializes a stream into a generic object.
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="optionAct"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromBssomStream<TValue>(this Stream stream, Action<BssomSerializerOptions> optionAct)
    {
        return BssomHelper.FromStream<TValue>(stream, optionAct);
    }

    /// <summary>
    /// Deserializes a stream into an object graph.
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="type"></param>
    /// <param name="options"></param>
    /// <returns></returns>
    public static object FromBssomStream(this Stream stream, Type type, BssomSerializerOptions options = default)
    {
        return BssomHelper.FromStream(type, stream, options);
    }

    /// <summary>
    /// Deserializes a stream into an object graph.
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="type"></param>
    /// <param name="optionAct"></param>
    /// <returns></returns>
    public static object FromBssomStream(this Stream stream, Type type, Action<BssomSerializerOptions> optionAct)
    {
        return BssomHelper.FromStream(type, stream, optionAct);
    }
}