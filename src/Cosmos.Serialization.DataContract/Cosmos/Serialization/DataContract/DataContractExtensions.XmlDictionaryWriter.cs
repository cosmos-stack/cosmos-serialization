using System.Xml;

namespace Cosmos.Serialization.DataContract;

public static partial class DataContractExtensions
{
    public static void WriteDataContractXml<TValue>(this XmlDictionaryWriter xmlDictionaryWriter, TValue value)
    {
        DataContractHelper.Serialize(xmlDictionaryWriter, value);
    }

    public static void WriteDataContractXml(this XmlDictionaryWriter xmlDictionaryWriter, Type type, object value)
    {
        DataContractHelper.Serialize(type, xmlDictionaryWriter, value);
    }
}