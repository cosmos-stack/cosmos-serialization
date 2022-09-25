using System.Xml;

namespace Cosmos.Serialization.DataContract;

public static partial class DataContractExtensions
{
    public static TValue ReadDataContractXml<TValue>(this XmlDictionaryReader xmlDictionaryReader)
    {
        return DataContractHelper.Deserialize<TValue>(xmlDictionaryReader);
    }

    public static object ReadDataContractXml(this XmlDictionaryReader xmlDictionaryReader, Type type)
    {
        return DataContractHelper.Deserialize(type, xmlDictionaryReader);
    }
}