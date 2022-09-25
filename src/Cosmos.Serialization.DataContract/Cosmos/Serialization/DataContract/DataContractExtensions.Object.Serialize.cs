using System.Xml;

namespace Cosmos.Serialization.DataContract;

public static partial class DataContractExtensions
{
    public static void DataContractSerialize<TValue>(this TValue value, XmlWriter xmlWriter)
    {
        DataContractHelper.Serialize(xmlWriter, value);
    }

    public static void DataContractSerialize(this object value, Type type, XmlWriter xmlWriter)
    {
        DataContractHelper.Serialize(type, xmlWriter, value);
    }

    public static void DataContractSerialize<TValue>(this TValue value, XmlDictionaryWriter xmlDictionaryWriter)
    {
        DataContractHelper.Serialize(xmlDictionaryWriter, value);
    }

    public static void DataContractSerialize(this object value, Type type, XmlDictionaryWriter xmlDictionaryWriter)
    {
        DataContractHelper.Serialize(type, xmlDictionaryWriter, value);
    }
}