using Cosmos.Conversions;

namespace Cosmos.Serialization.DataContract;

public static partial class DataContractHelper
{
    /// <summary>
    /// Serialize the object to a memory stream and return a bytes contain the stream content.
    /// </summary>
    /// <param name="value"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static byte[] ToBytes<TValue>(TValue value)
    {
        using var stream = ToStream(value);
        return stream.CastToBytes();
    }

    /// <summary>
    /// Serialize the object to a memory stream and return a bytes contain the stream content.
    /// </summary>
    /// <param name="type"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    public static byte[] ToBytes(Type type, object value)
    {
        using var stream = ToStream(type, value);
        return stream.CastToBytes();
    }
}