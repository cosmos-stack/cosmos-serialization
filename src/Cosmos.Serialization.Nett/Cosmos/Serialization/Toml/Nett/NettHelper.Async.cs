using System;
using System.Text;
using System.Threading.Tasks;
using Cosmos.Optionals;
using Nett;

namespace Cosmos.Serialization.Toml.Nett
{
    /// <summary>
    /// Yaml Helper
    /// </summary>
    public static partial class NettHelper
    {
        /// <summary>
        /// Serialize async
        /// </summary>
        /// <param name="o"></param>
        /// <param name="settings"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Task<string> SerializeAsync<T>(T o, TomlSettings settings = null)
        {
            return Task.Run(() => Serialize(o, settings));
        }

        /// <summary>
        /// Serialize to bytes async
        /// </summary>
        /// <param name="o"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static async Task<byte[]> SerializeToBytesAsync<T>(T o, Encoding encoding = null)
        {
            return o is null
                ? new byte[0]
                : encoding.SafeEncodingValue(NettManager.DefaultEncoding).GetBytes(await SerializeAsync(o));
        }

        /// <summary>
        /// Deserialize async
        /// </summary>
        /// <param name="data"></param>
        /// <param name="settings"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static async Task<T> DeserializeAsync<T>(string data, TomlSettings settings = null)
        {
            return string.IsNullOrWhiteSpace(data)
                ? default
                : await Task.Run(() => Deserialize<T>(data, settings));
        }

        /// <summary>
        /// Deserialize async
        /// </summary>
        /// <param name="data"></param>
        /// <param name="type"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        public static async Task<object> DeserializeAsync(string data, Type type, TomlSettings settings = null)
        {
            return string.IsNullOrWhiteSpace(data)
                ? null
                : await Task.Run(() => Deserialize(data, type, settings));
        }

        /// <summary>
        /// Deserialize
        /// </summary>
        /// <param name="data"></param>
        /// <param name="encoding"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static async Task<T> DeserializeFromBytesAsync<T>(byte[] data, Encoding encoding = null)
        {
            return data is null || data.Length is 0
                ? default
                : await DeserializeAsync<T>(encoding.SafeEncodingValue(NettManager.DefaultEncoding).GetString(data));
        }

        /// <summary>
        /// Deserialize
        /// </summary>
        /// <param name="data"></param>
        /// <param name="type"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static async Task<object> DeserializeFromBytesAsync(byte[] data, Type type, Encoding encoding = null)
        {
            return data is null || data.Length is 0
                ? null
                : await DeserializeAsync(encoding.SafeEncodingValue(NettManager.DefaultEncoding).GetString(data), type);
        }
    }
}