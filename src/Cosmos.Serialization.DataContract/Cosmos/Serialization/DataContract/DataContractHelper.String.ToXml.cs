using System.Text;
using Cosmos.Conversions;

namespace Cosmos.Serialization.DataContract;

public static partial class DataContractHelper
{
    /// <summary>
    ///  Serialize the object into a memory stream,get bytes from it and return the decode result.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="encoding"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static string ToXml<TValue>(TValue value, Encoding encoding = null)
    {
        using var stream = ToStream(value);
        return encoding.GetEncoding().GetString(stream.CastToBytes());
    }

    /// <summary>
    /// Serialize the object into a memory stream,get bytes from it and return the decode result.
    /// </summary>
    /// <param name="type"></param>
    /// <param name="value"></param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    public static string ToXml(Type type, object value, Encoding encoding = null)
    {
        using var stream = ToStream(type, value);
        return encoding.GetEncoding().GetString(stream.CastToBytes());
    }
}