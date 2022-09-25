namespace Cosmos.Serialization.DataContract;

public static partial class DataContractExtensions
{
    public static byte[] ToDataContractBytes<TValue>(this TValue value)
    {
        return DataContractHelper.ToBytes(value);
    }

    public static byte[] ToDataContractBytes(this object value, Type type)
    {
        return DataContractHelper.ToBytes(type, value);
    }
}