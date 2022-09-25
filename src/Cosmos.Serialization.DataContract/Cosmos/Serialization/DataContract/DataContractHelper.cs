using System.Collections.Concurrent;
using System.Text;
using DCS = System.Runtime.Serialization.DataContractSerializer;

namespace Cosmos.Serialization.DataContract;

public static partial class DataContractHelper
{
    private static class Man
    {
        private static readonly ConcurrentDictionary<Type, DCS> SerializerCache = new();

        public static DCS GetSerializer(Type type)
        {
            return SerializerCache.GetOrAdd(type, new DCS(type));
        }

        public static DCS GetSerializer<TValue>()
        {
            return GetSerializer(typeof(TValue));
        }
    }

    public static DCS GetDataContractSerializer(Type type)
    {
        return Man.GetSerializer(type);
    }

    public static DCS GetDataContractSerializer<TValue>()
    {
        return Man.GetSerializer<TValue>();
    }

    private static Encoding GetEncoding(this Encoding encoding)
    {
        return encoding ?? Encoding.UTF8;
    }
}