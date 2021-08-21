using System;
using System.Text;
using Cosmos.Optionals;
using Nett;
using Tommy = Nett.Toml;

namespace Cosmos.Serialization.Toml.Nett
{
    /// <summary>
    /// Yaml Helper
    /// </summary>
    public static partial class NettHelper
    {
        /// <summary>
        /// Serialize
        /// </summary>
        /// <param name="o"></param>
        /// <param name="settings"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static string Serialize<T>(T o, TomlSettings settings = null)
        {
            return Tommy.WriteString(o, settings ?? NettManager.DefaultSettings);
        }

        /// <summary>
        /// Serialize to bytes
        /// </summary>
        /// <param name="o"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static byte[] SerializeToBytes<T>(T o, Encoding encoding = null)
        {
            return o is null
                ? new byte[0]
                : encoding.SafeEncodingValue(NettManager.DefaultEncoding).GetBytes(Serialize(o));
        }

        /// <summary>
        /// Deserialize
        /// </summary>
        /// <param name="data"></param>
        /// <param name="settings"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T Deserialize<T>(string data, TomlSettings settings = null)
        {
            return string.IsNullOrWhiteSpace(data)
                ? default
                : Tommy.ReadString<T>(data, settings ?? NettManager.DefaultSettings);
        }

        /// <summary>
        /// Deserialize
        /// </summary>
        /// <param name="data"></param>
        /// <param name="type"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        public static object Deserialize(string data, Type type, TomlSettings settings = null)
        {
            return string.IsNullOrWhiteSpace(data)
                ? null
                : Tommy.ReadString(data, settings ?? NettManager.DefaultSettings).Get(type);
        }

        /// <summary>
        /// Deserialize
        /// </summary>
        /// <param name="data"></param>
        /// <param name="encoding"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T DeserializeFromBytes<T>(byte[] data, Encoding encoding = null)
        {
            return data is null || data.Length is 0
                ? default
                : Deserialize<T>(encoding.SafeEncodingValue(NettManager.DefaultEncoding).GetString(data));
        }

        /// <summary>
        /// Deserialize
        /// </summary>
        /// <param name="data"></param>
        /// <param name="type"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static object DeserializeFromBytes(byte[] data, Type type, Encoding encoding = null)
        {
            return data is null || data.Length is 0
                ? null
                : Deserialize(encoding.SafeEncodingValue(NettManager.DefaultEncoding).GetString(data), type);
        }
    }
}