using System;
using System.Text;
using System.Threading.Tasks;
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
        /// Serialize async
        /// </summary>
        /// <param name="o"></param>
        /// <param name="options"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static async Task<string> SerializeAsync<T>(T o, JSONParameters options = null)
        {
            return o is null
                ? string.Empty
                : await Task.Run(() => JSON.ToJSON(o, options ?? FastJsonManager.DefaultParameters));
        }

        /// <summary>
        /// Serialize async
        /// </summary>
        /// <param name="o"></param>
        /// <param name="optionAct"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Task<string> SerializeAsync<T>(T o, Action<JSONParameters> optionAct)
        {
            var options = new JSONParameters();
            optionAct?.Invoke(options);
            return SerializeAsync(o, options);
        }

        /// <summary>
        /// Serialize to bytes async
        /// </summary>
        /// <param name="o"></param>
        /// <param name="options"></param>
        /// <param name="encoding"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static async Task<byte[]> SerializeToBytesAsync<T>(T o, JSONParameters options = null, Encoding encoding = null)
        {
            return o is null
                ? new byte[0]
                : encoding.SafeEncodingValue(FastJsonManager.DefaultEncoding).GetBytes(await SerializeAsync(o, options));
        }

        /// <summary>
        /// Serialize to bytes async
        /// </summary>
        /// <param name="o"></param>
        /// <param name="optionAct"></param>
        /// <param name="encoding"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Task<byte[]> SerializeToBytesAsync<T>(T o, Action<JSONParameters> optionAct, Encoding encoding = null)
        {
            var options = new JSONParameters();
            optionAct?.Invoke(options);
            return SerializeToBytesAsync(o, options, encoding);
        }

        /// <summary>
        /// Deserialize async
        /// </summary>
        /// <param name="json"></param>
        /// <param name="options"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static async Task<T> DeserializeAsync<T>(string json, JSONParameters options = null)
        {
            return string.IsNullOrWhiteSpace(json)
                ? default
                : await Task.Run(() => JSON.ToObject<T>(json, options ?? FastJsonManager.DefaultParameters));
        }

        /// <summary>
        /// Deserialize async
        /// </summary>
        /// <param name="json"></param>
        /// <param name="optionAct"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static async Task<T> DeserializeAsync<T>(string json, Action<JSONParameters> optionAct)
        {
            var options = new JSONParameters();
            optionAct?.Invoke(options);
            return string.IsNullOrWhiteSpace(json)
                ? default
                : await DeserializeAsync<T>(json, options);
        }

        /// <summary>
        /// Deserialize async
        /// </summary>
        /// <param name="json"></param>
        /// <param name="type"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public static async Task<object> DeserializeAsync(string json, Type type, JSONParameters options = null)
        {
            if (string.IsNullOrWhiteSpace(json))
                return null;
            return string.IsNullOrWhiteSpace(json)
                ? default
                : await Task.Run(() => JSON.ToObject(json, type, options ?? FastJsonManager.DefaultParameters));
        }

        /// <summary>
        /// Deserialize async
        /// </summary>
        /// <param name="json"></param>
        /// <param name="type"></param>
        /// <param name="optionAct"></param>
        /// <returns></returns>
        public static Task<object> DeserializeAsync(string json, Type type, Action<JSONParameters> optionAct)
        {
            if (string.IsNullOrWhiteSpace(json))
                return null;

            var options = new JSONParameters();
            optionAct?.Invoke(options);

            return DeserializeAsync(json, type, options);
        }

        /// <summary>
        /// Deserialize from bytes async
        /// </summary>
        /// <param name="data"></param>
        /// <param name="options"></param>
        /// <param name="encoding"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static async Task<T> DeserializeFromBytesAsync<T>(byte[] data, JSONParameters options = null, Encoding encoding = null)
        {
            return data is null || data.Length is 0
                ? default
                : await Task.Run(() =>JSON.ToObject<T>(encoding.SafeEncodingValue(FastJsonManager.DefaultEncoding).GetString(data), options ?? FastJsonManager.DefaultParameters));
        }

        /// <summary>
        /// Deserialize from bytes async
        /// </summary>
        /// <param name="data"></param>
        /// <param name="optionAct"></param>
        /// <param name="encoding"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Task<T> DeserializeFromBytesAsync<T>(byte[] data, Action<JSONParameters> optionAct, Encoding encoding = null)
        {
            var options = new JSONParameters();
            optionAct?.Invoke(options);
            return DeserializeFromBytesAsync<T>(data, options, encoding);
        }

        /// <summary>
        /// Deserialize from bytes async
        /// </summary>
        /// <param name="data"></param>
        /// <param name="type"></param>
        /// <param name="options"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static async Task<object> DeserializeFromBytesAsync(byte[] data, Type type, JSONParameters options = null, Encoding encoding = null)
        {
            return data is null || data.Length is 0
                ? default
                : await Task.Run(() => JSON.ToObject(encoding.SafeEncodingValue(FastJsonManager.DefaultEncoding).GetString(data), type, options ?? FastJsonManager.DefaultParameters));
        }

        /// <summary>
        /// Deserialize from bytes async
        /// </summary>
        /// <param name="data"></param>
        /// <param name="type"></param>
        /// <param name="optionAct"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static Task<object> DeserializeFromBytesAsync(byte[] data, Type type, Action<JSONParameters> optionAct, Encoding encoding = null)
        {
            var options = new JSONParameters();
            optionAct?.Invoke(options);
            return DeserializeFromBytesAsync(data, type, options, encoding);
        }
    }
}