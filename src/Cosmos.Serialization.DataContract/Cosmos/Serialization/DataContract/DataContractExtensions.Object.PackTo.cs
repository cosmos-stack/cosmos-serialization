namespace Cosmos.Serialization.DataContract;

public static partial class DataContractExtensions
{
    public static void DataContractPackTo<TValue>(this TValue value, Stream stream)
    {
        DataContractHelper.Pack(value, stream);
    }

    public static void DataContractPackTo(this object value, Type type, Stream stream)
    {
        DataContractHelper.Pack(type, value, stream);
    }
}