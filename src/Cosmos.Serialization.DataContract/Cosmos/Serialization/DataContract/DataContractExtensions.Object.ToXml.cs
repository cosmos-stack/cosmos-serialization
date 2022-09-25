namespace Cosmos.Serialization.DataContract;

public static partial class DataContractExtensions
{
    public static string ToDataContractXml<TValue>(this TValue value)
    {
        return DataContractHelper.ToXml(value);
    }

    public static string ToDataContractXml(this object value, Type type)
    {
        return DataContractHelper.ToXml(type, value);
    }
}