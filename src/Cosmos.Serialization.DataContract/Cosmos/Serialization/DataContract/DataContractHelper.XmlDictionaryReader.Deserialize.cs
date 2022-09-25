using System.Runtime.Serialization;
using System.Xml;

namespace Cosmos.Serialization.DataContract;

public static partial class DataContractHelper
{
    /// <summary>
    /// Deserializes the XML document contained by the specified XmlReader.
    /// </summary>
    /// <param name="xmlDictionaryReader"></param>
    /// <param name="verifyObjectName"></param>
    /// <param name="dataContractResolver"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue Deserialize<TValue>(XmlDictionaryReader xmlDictionaryReader, bool verifyObjectName = true, DataContractResolver dataContractResolver = null)
    {
        return xmlDictionaryReader is null
            ? default
            : (TValue)Man.GetSerializer<TValue>().ReadObject(xmlDictionaryReader, verifyObjectName, dataContractResolver);
    }

    /// <summary>
    /// Deserializes the XML document contained by the specified XmlReader.
    /// </summary>
    /// <param name="type"></param>
    /// <param name="xmlDictionaryReader"></param>
    /// <param name="verifyObjectName"></param>
    /// <param name="dataContractResolver"></param>
    /// <returns></returns>
    public static object Deserialize(Type type, XmlDictionaryReader xmlDictionaryReader, bool verifyObjectName = true, DataContractResolver dataContractResolver = null)
    {
        return xmlDictionaryReader is null
            ? default
            : Man.GetSerializer(type).ReadObject(xmlDictionaryReader, verifyObjectName, dataContractResolver);
    }
}