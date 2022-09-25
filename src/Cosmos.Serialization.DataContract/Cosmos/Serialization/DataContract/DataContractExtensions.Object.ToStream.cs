namespace Cosmos.Serialization.DataContract;

public static partial class DataContractExtensions
{
    public static Stream ToDataContractStream<TValue>(this TValue value)
    {
        return DataContractHelper.ToStream(value);
    }

    public static Stream ToDataContractStream(this object value, Type type)
    {
        return DataContractHelper.ToStream(type, value);
    }
}