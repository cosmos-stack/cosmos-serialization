namespace Cosmos.Serialization.DataContract;

public static partial class DataContractHelper
{
    /// <summary>
    /// Serializes the specified object and writes the XML document to a file using a memory stream.
    /// </summary>
    /// <param name="value"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Stream ToStream<TValue>(TValue value)
    {
        var stream = new MemoryStream();
        Pack(value, stream);
        return stream;
    }

    /// <summary>
    /// Serializes the specified object and writes the XML document to a file using a memory stream.
    /// </summary>
    /// <param name="type"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    public static Stream ToStream(Type type, object value)
    {
        var stream = new MemoryStream();
        Pack(type, value, stream);
        return stream;
    }
}