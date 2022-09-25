namespace Cosmos.Serialization.DataContract;

public static partial class DataContractExtensions
{
    public static TValue FromDataContractXml<TValue>(this string xml)
    {
        return DataContractHelper.FromXml<TValue>(xml);
    }

    public static object FromDataContractXml(this string xml, Type type)
    {
        return DataContractHelper.FromXml(type, xml);
    }
}