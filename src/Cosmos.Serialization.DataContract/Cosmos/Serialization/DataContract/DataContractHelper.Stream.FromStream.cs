using Cosmos.IO;

namespace Cosmos.Serialization.DataContract;

public static partial class DataContractHelper
{
    /// <summary>
    /// Deserializes the XML document contained by the specified stream.
    /// </summary>
    /// <param name="stream"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromStream<TValue>(Stream stream)
    {
        if (stream is null || stream.CanSeek && stream.Length is 0)
            return default;
        if (stream.CanSeek && stream.Position > 0)
            stream.Position = 0;
        var result = Man.GetSerializer<TValue>().ReadObject(stream);
        stream.TrySeek(0, SeekOrigin.Begin);
        return result.As<TValue>();
    }

    /// <summary>
    /// Deserializes the XML document contained by the specified stream.
    /// </summary>
    /// <param name="type"></param>
    /// <param name="stream"></param>
    /// <returns></returns>
    public static object FromStream(Type type, Stream stream)
    {
        if (stream is null || stream.CanSeek && stream.Length is 0)
            return default;
        if (stream.CanSeek && stream.Position > 0)
            stream.Position = 0;
        var result = Man.GetSerializer(type).ReadObject(stream);
        stream.TrySeek(0, SeekOrigin.Begin);
        return result;
    }
}