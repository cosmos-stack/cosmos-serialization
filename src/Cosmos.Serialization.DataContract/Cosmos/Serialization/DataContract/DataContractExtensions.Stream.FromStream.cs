namespace Cosmos.Serialization.DataContract;

public static partial class DataContractExtensions
{
    public static TValue FromDataContractStream<TValue>(this Stream stream)
    {
        return DataContractHelper.FromStream<TValue>(stream);
    }

    public static object FromDataContractStream(this Stream stream, Type type)
    {
        return DataContractHelper.FromStream(type, stream);
    }
}