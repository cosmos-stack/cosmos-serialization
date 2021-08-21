using System;
using System.Text;
using System.Threading.Tasks;
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
        /// Serialize async
        /// </summary>
        /// <param name="o"></param>
        /// <param name="serializer"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Task<string> SerializeAsync<T>(T o, S serializer = null)
        {
            return Task.Run(() => (serializer ?? YamlManager.DefaultSerializer).Serialize(o));
        }

        /// <summary>
        /// Serialize to bytes async
        /// </summary>
        /// <param name="o"></param>
        /// <param name="serializer"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static async Task<byte[]> SerializeToBytesAsync<T>(T o, S serializer = null, Encoding encoding = null)
        {
            return o is null
                ? new byte[0]
                : encoding.SafeEncodingValue(YamlManager.DefaultEncoding).GetBytes(await SerializeAsync(o, serializer));
        }

        /// <summary>
        /// Deserialize async
        /// </summary>
        /// <param name="data"></param>
        /// <param name="deserializer"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static async Task<T> DeserializeAsync<T>(string data, D deserializer = null)
        {
            return string.IsNullOrWhiteSpace(data)
                ? default
                : await Task.Run(() => (deserializer ?? YamlManager.DefaultDeserializer).Deserialize<T>(data));
        }

        /// <summary>
        /// Deserialize async
        /// </summary>
        /// <param name="data"></param>
        /// <param name="type"></param>
        /// <param name="deserializer"></param>
        /// <returns></returns>
        public static async Task<object> DeserializeAsync(string data, Type type, D deserializer = null)
        {
            return string.IsNullOrWhiteSpace(data)
                ? null
                : await Task.Run(() => (deserializer ?? YamlManager.DefaultDeserializer).Deserialize(data, type));
        }

        /// <summary>
        /// Deserialize
        /// </summary>
        /// <param name="data"></param>
        /// <param name="deserializer"></param>
        /// <param name="encoding"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static async Task<T> DeserializeFromBytesAsync<T>(byte[] data, D deserializer = null, Encoding encoding = null)
        {
            return data is null || data.Length is 0
                ? default
                : await DeserializeAsync<T>(encoding.SafeEncodingValue(YamlManager.DefaultEncoding).GetString(data), deserializer);
        }

        /// <summary>
        /// Deserialize
        /// </summary>
        /// <param name="data"></param>
        /// <param name="type"></param>
        /// <param name="deserializer"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static async Task<object> DeserializeFromBytesAsync(byte[] data, Type type, D deserializer = null, Encoding encoding = null)
        {
            return data is null || data.Length is 0
                ? null
                : await DeserializeAsync(encoding.SafeEncodingValue(YamlManager.DefaultEncoding).GetString(data), type, deserializer);
        }
    }
}