using System.Xml;

namespace Cosmos.Serialization.DataContract;

public static partial class DataContractExtensions
{
    public static TValue ReadDataContractXml<TValue>(this XmlReader xmlReader)
    {
        return DataContractHelper.Deserialize<TValue>(xmlReader);
    }

    public static object ReadDataContractXml(this XmlReader xmlReader, Type type)
    {
        return DataContractHelper.Deserialize(type, xmlReader);
    }
}