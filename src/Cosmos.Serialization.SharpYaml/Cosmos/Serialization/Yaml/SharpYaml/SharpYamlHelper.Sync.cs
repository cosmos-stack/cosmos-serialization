using System;
using System.Text;
using Cosmos.Optionals;
using SharpYaml.Serialization;

namespace Cosmos.Serialization.Yaml.SharpYaml
{
    /// <summary>
    /// SharpYaml helper
    /// </summary>
    public static partial class SharpYamlHelper
    {
        /// <summary>
        /// Serialize
        /// </summary>
        /// <param name="o"></param>
        /// <param name="serializer"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static string Serialize<T>(T o, Serializer serializer = null)
        {
            return (serializer ?? SharpYamlManager.DefaultSerializer).Serialize(o);
        }

        /// <summary>
        /// Serialize
        /// </summary>
        /// <param name="o"></param>
        /// <param name="expectedType"></param>
        /// <param name="serializer"></param>
        /// <returns></returns>
        public static string Serialize(object o, Type expectedType, Serializer serializer = null)
        {
            return (serializer ?? SharpYamlManager.DefaultSerializer).Serialize(o, expectedType);
        }

        /// <summary>
        /// Serialize to bytes
        /// </summary>
        /// <param name="o"></param>
        /// <param name="serializer"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static byte[] SerializeToBytes<T>(T o, Serializer serializer = null, Encoding encoding = null)
        {
            return o is null
                ? new byte[0]
                : encoding.SafeEncodingValue(SharpYamlManager.DefaultEncoding).GetBytes(Serialize(o, serializer));
        }

        /// <summary>
        /// Serialize to bytes
        /// </summary>
        /// <param name="o"></param>
        /// <param name="expectedType"></param>
        /// <param name="serializer"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static byte[] SerializeToBytes(object o, Type expectedType, Serializer serializer = null, Encoding encoding = null)
        {
            return o is null
                ? new byte[0]
                : encoding.SafeEncodingValue(SharpYamlManager.DefaultEncoding).GetBytes(Serialize(o, expectedType, serializer));
        }

        /// <summary>
        /// Deserialize
        /// </summary>
        /// <param name="data"></param>
        /// <param name="serializer"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T Deserialize<T>(string data, Serializer serializer = null)
        {
            return string.IsNullOrWhiteSpace(data)
                ? default
                : (serializer ?? SharpYamlManager.DefaultSerializer).Deserialize<T>(data);
        }

        /// <summary>
        /// Deserialize
        /// </summary>
        /// <param name="data"></param>
        /// <param name="type"></param>
        /// <param name="serializer"></param>
        /// <returns></returns>
        public static object Deserialize(string data, Type type, Serializer serializer = null)
        {
            return string.IsNullOrWhiteSpace(data)
                ? null
                : (serializer ?? SharpYamlManager.DefaultSerializer).Deserialize(data, type);
        }

        /// <summary>
        /// Deserialize
        /// </summary>
        /// <param name="data"></param>
        /// <param name="serializer"></param>
        /// <param name="encoding"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T DeserializeFromBytes<T>(byte[] data, Serializer serializer = null, Encoding encoding = null)
        {
            return data is null || data.Length is 0
                ? default
                : Deserialize<T>(encoding.SafeEncodingValue(SharpYamlManager.DefaultEncoding).GetString(data), serializer);
        }

        /// <summary>
        /// Deserialize
        /// </summary>
        /// <param name="data"></param>
        /// <param name="type"></param>
        /// <param name="serializer"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static object DeserializeFromBytes(byte[] data, Type type, Serializer serializer = null, Encoding encoding = null)
        {
            return data is null || data.Length is 0
                ? null
                : Deserialize(encoding.SafeEncodingValue(SharpYamlManager.DefaultEncoding).GetString(data), type, serializer);
        }

        /// <summary>
        /// Deserialize
        /// </summary>
        /// <param name="data"></param>
        /// <param name="targetObj"></param>
        /// <param name="serializer"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T DeserializeInto<T>(string data, T targetObj, Serializer serializer = null)
        {
            return string.IsNullOrWhiteSpace(data)
                ? targetObj
                : (serializer ?? SharpYamlManager.DefaultSerializer).DeserializeInto(data, targetObj);
        }

        /// <summary>
        /// Deserialize
        /// </summary>
        /// <param name="data"></param>
        /// <param name="type"></param>
        /// <param name="targetObj"></param>
        /// <param name="serializer"></param>
        /// <returns></returns>
        public static object DeserializeInto(string data, Type type, object targetObj, Serializer serializer = null)
        {
            return string.IsNullOrWhiteSpace(data)
                ? targetObj
                : (serializer ?? SharpYamlManager.DefaultSerializer).Deserialize(data, type, targetObj);
        }
    }
}