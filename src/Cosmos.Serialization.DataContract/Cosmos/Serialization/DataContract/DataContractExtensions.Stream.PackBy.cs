namespace Cosmos.Serialization.DataContract;

public static partial class DataContractExtensions
{
    public static void DataContractPackBy<TValue>(this Stream stream, TValue value)
    {
        DataContractHelper.Pack(value, stream);
    }

    public static void DataContractPackBy(this Stream stream, Type type, object value)
    {
        DataContractHelper.Pack(type, value, stream);
    }
}