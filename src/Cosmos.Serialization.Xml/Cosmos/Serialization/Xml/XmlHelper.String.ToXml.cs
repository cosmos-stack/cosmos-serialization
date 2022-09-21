using System.Text;
using Cosmos.Conversions;

namespace Cosmos.Serialization.Xml;

public static partial class XmlHelper
{
    /// <summary>
    /// Serialize the object into a memory stream,get bytes from it and return the decode result.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="encoding"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static string ToXml<TValue>(TValue value, Encoding encoding = default)
    {
        return ToXml(typeof(TValue), value, encoding);
    }

    /// <summary>
    /// Serialize the object into a memory stream,get bytes from it and return the decode result.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="type"></param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    public static string ToXml(Type type, object value, Encoding encoding = default)
    {
        var stream = ToStream(type, value);
        return encoding.ToEncoding().GetString(stream.CastToBytes());
    }

    /// <summary>
    /// Serialize the object into a memory stream,get bytes from it and return the decode result.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Task<string> ToXmlAsync<TValue>(TValue value, Encoding encoding = default, CancellationToken cancellationToken = default)
    {
        return ToXmlAsync(typeof(TValue), value, encoding, cancellationToken);
    }

    /// <summary>
    /// Serialize the object into a memory stream,get bytes from it and return the decode result.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="type"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<string> ToXmlAsync(Type type, object value, Encoding encoding = default, CancellationToken cancellationToken = default)
    {
        var stream = await ToStreamAsync(type, value, cancellationToken);
        return encoding.ToEncoding().GetString(await stream.CastToBytesAsync());
    }
}