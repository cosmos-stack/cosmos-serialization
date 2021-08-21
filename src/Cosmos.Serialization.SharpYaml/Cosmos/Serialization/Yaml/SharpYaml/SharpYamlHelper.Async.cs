using System;
using System.Text;
using System.Threading.Tasks;
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
        /// Serialize async
        /// </summary>
        /// <param name="o"></param>
        /// <param name="serializer"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Task<string> SerializeAsync<T>(T o, Serializer serializer = null)
        {
            return Task.Run(() => (serializer ?? SharpYamlManager.DefaultSerializer).Serialize(o));
        }

        /// <summary>
        /// Serialize async
        /// </summary>
        /// <param name="o"></param>
        /// <param name="expectedType"></param>
        /// <param name="serializer"></param>
        /// <returns></returns>
        public static Task<string> SerializeAsync(object o, Type expectedType, Serializer serializer = null)
        {
            return Task.Run(() => (serializer ?? SharpYamlManager.DefaultSerializer).Serialize(o, expectedType));
        }

        /// <summary>
        /// Serialize to bytes async
        /// </summary>
        /// <param name="o"></param>
        /// <param name="serializer"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static async Task<byte[]> SerializeToBytesAsync<T>(T o, Serializer serializer = null, Encoding encoding = null)
        {
            return o is null
                ? new byte[0]
                : encoding.SafeEncodingValue(SharpYamlManager.DefaultEncoding).GetBytes(await SerializeAsync(o, serializer));
        }

        /// <summary>
        /// Serialize to bytes async
        /// </summary>
        /// <param name="o"></param>
        /// <param name="expectedType"></param>
        /// <param name="serializer"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static async Task<byte[]> SerializeToBytesAsync(object o, Type expectedType, Serializer serializer = null, Encoding encoding = null)
        {
            return o is null
                ? new byte[0]
                : encoding.SafeEncodingValue(SharpYamlManager.DefaultEncoding).GetBytes(await SerializeAsync(o, expectedType, serializer));
        }

        /// <summary>
        /// Deserialize async
        /// </summary>
        /// <param name="data"></param>
        /// <param name="serializer"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static async Task<T> DeserializeAsync<T>(string data, Serializer serializer = null)
        {
            return string.IsNullOrWhiteSpace(data)
                ? default
                : await Task.Run(() => (serializer ?? SharpYamlManager.DefaultSerializer).Deserialize<T>(data));
        }

        /// <summary>
        /// Deserialize async
        /// </summary>
        /// <param name="data"></param>
        /// <param name="type"></param>
        /// <param name="serializer"></param>
        /// <returns></returns>
        public static async Task<object> DeserializeAsync(string data, Type type, Serializer serializer = null)
        {
            return string.IsNullOrWhiteSpace(data)
                ? null
                : await Task.Run(() => (serializer ?? SharpYamlManager.DefaultSerializer).Deserialize(data, type));
        }

        /// <summary>
        /// Deserialize
        /// </summary>
        /// <param name="data"></param>
        /// <param name="serializer"></param>
        /// <param name="encoding"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static async Task<T> DeserializeFromBytesAsync<T>(byte[] data, Serializer serializer = null, Encoding encoding = null)
        {
            return data is null || data.Length is 0
                ? default
                : await DeserializeAsync<T>(encoding.SafeEncodingValue(SharpYamlManager.DefaultEncoding).GetString(data), serializer);
        }

        /// <summary>
        /// Deserialize
        /// </summary>
        /// <param name="data"></param>
        /// <param name="type"></param>
        /// <param name="serializer"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static async Task<object> DeserializeFromBytesAsync(byte[] data, Type type, Serializer serializer = null, Encoding encoding = null)
        {
            return data is null || data.Length is 0
                ? null
                : await DeserializeAsync(encoding.SafeEncodingValue(SharpYamlManager.DefaultEncoding).GetString(data), type, serializer);
        }

        /// <summary>
        /// Deserialize async
        /// </summary>
        /// <param name="data"></param>
        /// <param name="targetObj"></param>
        /// <param name="serializer"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static async Task<T> DeserializeIntoAsync<T>(string data, T targetObj, Serializer serializer = null)
        {
            return string.IsNullOrWhiteSpace(data)
                ? targetObj
                : await Task.Run(() => (serializer ?? SharpYamlManager.DefaultSerializer).DeserializeInto(data, targetObj));
        }

        /// <summary>
        /// Deserialize async
        /// </summary>
        /// <param name="data"></param>
        /// <param name="type"></param>
        /// <param name="targetObj"></param>
        /// <param name="serializer"></param>
        /// <returns></returns>
        public static async Task<object> DeserializeIntoAsync(string data, Type type, object targetObj, Serializer serializer = null)
        {
            return string.IsNullOrWhiteSpace(data)
                ? targetObj
                : await Task.Run(() => (serializer ?? SharpYamlManager.DefaultSerializer).Deserialize(data, type, targetObj));
        }
    }
}