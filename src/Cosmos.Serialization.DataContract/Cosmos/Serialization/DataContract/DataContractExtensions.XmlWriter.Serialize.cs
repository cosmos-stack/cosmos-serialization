using System.Xml;

namespace Cosmos.Serialization.DataContract;

public static partial class DataContractExtensions
{
    public static void WriteDataContractXml<TValue>(this XmlWriter xmlWriter, TValue value)
    {
        DataContractHelper.Serialize(xmlWriter, value);
    }

    public static void WriteDataContractXml(this XmlWriter xmlWriter, Type type, object value)
    {
        DataContractHelper.Serialize(type, xmlWriter, value);
    }
}