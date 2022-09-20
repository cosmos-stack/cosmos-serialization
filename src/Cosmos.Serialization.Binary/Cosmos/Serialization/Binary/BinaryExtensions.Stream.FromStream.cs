namespace Cosmos.Serialization.Binary;

public static partial class BinaryExtensions
{
    /// <summary>
    /// Deserializes a stream into a generic object.
    /// </summary>
    /// <param name="stream"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    [Obsolete("BinaryFormatter serialization is obsolete and should not be used. See https://aka.ms/binaryformatter for more information.")]
    public static TValue FromStream<TValue>(this Stream stream)
    {
        return BinaryHelper.FromStream<TValue>(stream);
    }

    /// <summary>
    /// Deserializes a stream into an object graph.
    /// </summary>
    /// <param name="stream"></param>
    /// <returns></returns>
    [Obsolete("BinaryFormatter serialization is obsolete and should not be used. See https://aka.ms/binaryformatter for more information.")]
    public static object FromStream(this Stream stream)
    {
        return BinaryHelper.FromStream(stream);
    }
}