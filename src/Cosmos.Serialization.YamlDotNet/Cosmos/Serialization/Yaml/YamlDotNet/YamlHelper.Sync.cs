using System;
using System.Text;
using Cosmos.Optionals;
using S = YamlDotNet.Serialization.ISerializer;
using D = YamlDotNet.Serialization.IDeserializer;

namespace Cosmos.Serialization.Yaml.YamlDotNet
{
    /// <summary>
    /// Yaml Helper
    /// </summary>
    public static partial class YamlHelper
    {
        /// <summary>
        /// Serialize
        /// </summary>
        /// <param name="o"></param>
        /// <param name="serializer"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static string Serialize<T>(T o, S serializer = null)
        {
            return (serializer ?? YamlManager.DefaultSerializer).Serialize(o);
        }

        /// <summary>
        /// Serialize to bytes
        /// </summary>
        /// <param name="o"></param>
        /// <param name="serializer"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static byte[] SerializeToBytes<T>(T o, S serializer = null, Encoding encoding = null)
        {
            return o is null
                ? new byte[0]
                : encoding.SafeEncodingValue(YamlManager.DefaultEncoding).GetBytes(Serialize(o, serializer));
        }

        /// <summary>
        /// Deserialize
        /// </summary>
        /// <param name="data"></param>
        /// <param name="deserializer"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T Deserialize<T>(string data, D deserializer = null)
        {
            return string.IsNullOrWhiteSpace(data)
                ? default
                : (deserializer ?? YamlManager.DefaultDeserializer).Deserialize<T>(data);
        }

        /// <summary>
        /// Deserialize
        /// </summary>
        /// <param name="data"></param>
        /// <param name="type"></param>
        /// <param name="deserializer"></param>
        /// <returns></returns>
        public static object Deserialize(string data, Type type, D deserializer = null)
        {
            return string.IsNullOrWhiteSpace(data)
                ? null
                : (deserializer ?? YamlManager.DefaultDeserializer).Deserialize(data, type);
        }

        /// <summary>
        /// Deserialize
        /// </summary>
        /// <param name="data"></param>
        /// <param name="deserializer"></param>
        /// <param name="encoding"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T DeserializeFromBytes<T>(byte[] data, D deserializer = null, Encoding encoding = null)
        {
            return data is null || data.Length is 0
                ? default
                : Deserialize<T>(encoding.SafeEncodingValue(YamlManager.DefaultEncoding).GetString(data), deserializer);
        }

        /// <summary>
        /// Deserialize
        /// </summary>
        /// <param name="data"></param>
        /// <param name="type"></param>
        /// <param name="deserializer"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static object DeserializeFromBytes(byte[] data, Type type, D deserializer = null, Encoding encoding = null)
        {
            return data is null || data.Length is 0
                ? null
                : Deserialize(encoding.SafeEncodingValue(YamlManager.DefaultEncoding).GetString(data), type, deserializer);
        }
    }
}