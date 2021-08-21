using System;
using System.Text;
using Cosmos.Optionals;
using fastJSON;

namespace Cosmos.Serialization.Json.FastJson
{
    /// <summary>
    /// FastJson helper
    /// </summary>
    public static partial class FastJsonHelper
    {
        /// <summary>
        /// Serialize
        /// </summary>
        /// <param name="o"></param>
        /// <param name="options"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static string Serialize<T>(T o, JSONParameters options = null)
        {
            return o is null
                ? string.Empty
                : JSON.ToJSON(o, options ?? FastJsonManager.DefaultParameters);
        }

        /// <summary>
        /// Serialize
        /// </summary>
        /// <param name="o"></param>
        /// <param name="optionAct"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static string Serialize<T>(T o, Action<JSONParameters> optionAct)
        {
            var options = new JSONParameters();
            optionAct?.Invoke(options);
            return Serialize(o, options);
        }

        /// <summary>
        /// Serialize to bytes
        /// </summary>
        /// <param name="o"></param>
        /// <param name="options"></param>
        /// <param name="encoding"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static byte[] SerializeToBytes<T>(T o, JSONParameters options = null, Encoding encoding = null)
        {
            return o is null
                ? new byte[0]
                : encoding.SafeEncodingValue(FastJsonManager.DefaultEncoding).GetBytes(Serialize(o, options ?? FastJsonManager.DefaultParameters));
        }

        /// <summary>
        /// Serialize to bytes
        /// </summary>
        /// <param name="o"></param>
        /// <param name="optionAct"></param>
        /// <param name="encoding"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static byte[] SerializeToBytes<T>(T o, Action<JSONParameters> optionAct, Encoding encoding = null)
        {
            return o is null
                ? new byte[0]
                : encoding.SafeEncodingValue(FastJsonManager.DefaultEncoding).GetBytes(Serialize(o, optionAct));
        }

        /// <summary>
        /// Deserialize
        /// </summary>
        /// <param name="json"></param>
        /// <param name="options"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T Deserialize<T>(string json, JSONParameters options = null)
        {
            return string.IsNullOrWhiteSpace(json)
                ? default
                : JSON.ToObject<T>(json, options ?? FastJsonManager.DefaultParameters);
        }

        /// <summary>
        /// Deserialize
        /// </summary>
        /// <param name="json"></param>
        /// <param name="optionAct"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T Deserialize<T>(string json, Action<JSONParameters> optionAct)
        {
            var options = new JSONParameters();
            optionAct?.Invoke(options);
            return string.IsNullOrWhiteSpace(json)
                ? default
                : JSON.ToObject<T>(json, options);
        }

        /// <summary>
        /// Deserialize
        /// </summary>
        /// <param name="json"></param>
        /// <param name="type"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public static object Deserialize(string json, Type type, JSONParameters options = null)
        {
            if (string.IsNullOrWhiteSpace(json))
                return null;
            return JSON.ToObject(json, type, options ?? FastJsonManager.DefaultParameters);
        }

        /// <summary>
        /// Deserialize
        /// </summary>
        /// <param name="json"></param>
        /// <param name="type"></param>
        /// <param name="optionAct"></param>
        /// <returns></returns>
        public static object Deserialize(string json, Type type, Action<JSONParameters> optionAct)
        {
            if (string.IsNullOrWhiteSpace(json))
                return null;
            var options = new JSONParameters();
            optionAct?.Invoke(options);
            return JSON.ToObject(json, type, options);
        }

        /// <summary>
        /// Deserialize from bytes
        /// </summary>
        /// <param name="data"></param>
        /// <param name="options"></param>
        /// <param name="encoding"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T DeserializeFromBytes<T>(byte[] data, JSONParameters options = null, Encoding encoding = null)
        {
            return data is null || data.Length is 0
                ? default
                : JSON.ToObject<T>(encoding.SafeEncodingValue(FastJsonManager.DefaultEncoding).GetString(data), options ?? FastJsonManager.DefaultParameters);
        }

        /// <summary>
        /// Deserialize from bytes
        /// </summary>
        /// <param name="data"></param>
        /// <param name="optionAct"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T DeserializeFromBytes<T>(byte[] data, Action<JSONParameters> optionAct)
        {
            var options = new JSONParameters();
            optionAct?.Invoke(options);
            return DeserializeFromBytes<T>(data, options);
        }

        /// <summary>
        /// Deserialize from bytes
        /// </summary>
        /// <param name="data"></param>
        /// <param name="type"></param>
        /// <param name="options"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static object DeserializeFromBytes(byte[] data, Type type, JSONParameters options = null, Encoding encoding = null)
        {
            return data is null || data.Length is 0
                ? null
                : JSON.ToObject(encoding.SafeEncodingValue(FastJsonManager.DefaultEncoding).GetString(data), type, options ?? FastJsonManager.DefaultParameters);
        }

        /// <summary>
        /// Deserialize from bytes
        /// </summary>
        /// <param name="data"></param>
        /// <param name="type"></param>
        /// <param name="optionAct"></param>
        /// <returns></returns>
        public static object DeserializeFromBytes(byte[] data, Type type, Action<JSONParameters> optionAct)
        {
            var options = new JSONParameters();
            optionAct?.Invoke(options);
            return DeserializeFromBytes(data, type, options);
        }
    }
}