namespace Cosmos.Serialization.DataContract;

public static partial class DataContractExtensions
{
    public static TValue FromDataContractBytes<TValue>(this byte[] bytes)
    {
        return DataContractHelper.FromBytes<TValue>(bytes);
    }

    public static object FromDataContractBytes(this byte[] bytes, Type type)
    {
        return DataContractHelper.FromBytes(type, bytes);
    }
}