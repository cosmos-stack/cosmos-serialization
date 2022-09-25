using System.Text;

namespace Cosmos.Serialization.DataContract;

public static partial class DataContractHelper
{
    /// <summary>
    /// Encode the xml to a bytes and initialize a memory stream by it,deserialize to a object.
    /// </summary>
    /// <param name="xml"></param>
    /// <param name="encoding"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromXml<TValue>(string xml, Encoding encoding = null)
    {
        if (string.IsNullOrWhiteSpace(xml))
            return default;
        using var stream = encoding.GetEncoding().GetBytes(xml).ToMemoryStream();
        return FromStream<TValue>(stream);
    }

    /// <summary>
    /// Encode the xml to a bytes and initialize a memory stream by it,deserialize to a object.
    /// </summary>
    /// <param name="type"></param>
    /// <param name="xml"></param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    public static object FromXml(Type type, string xml, Encoding encoding = null)
    {
        if (string.IsNullOrWhiteSpace(xml))
            return default;
        using var stream = encoding.GetEncoding().GetBytes(xml).ToMemoryStream();
        return FromStream(type, stream);
    }
}