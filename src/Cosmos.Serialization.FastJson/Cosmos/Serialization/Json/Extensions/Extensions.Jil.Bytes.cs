using System;
using System.Threading.Tasks;
using Cosmos.Serialization.Json.FastJson;
using fastJSON;

// ReSharper disable once CheckNamespace
namespace Cosmos.Serialization.Json
{
    /// <summary>
    /// FastJson extensions
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        /// To fastJSON bytes
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="options"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static byte[] ToFastJsonBytes<T>(this T obj, JSONParameters options = null)
        {
            return FastJsonHelper.SerializeToBytes(obj, options);
        }

        /// <summary>
        /// To fastJSON bytes
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="optionsAct"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static byte[] ToFastJsonBytes<T>(this T obj, Action<JSONParameters> optionsAct)
        {
            return FastJsonHelper.SerializeToBytes(obj, optionsAct);
        }

        /// <summary>
        /// To fastJSON bytes async
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="options"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Task<byte[]> ToFastJsonBytesAsync<T>(this T obj, JSONParameters options = null)
        {
            return FastJsonHelper.SerializeToBytesAsync(obj, options);
        }

        /// <summary>
        /// To fastJSON bytes async
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="optionsAct"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Task<byte[]> ToFastJsonBytesAsync<T>(this T obj, Action<JSONParameters> optionsAct)
        {
            return FastJsonHelper.SerializeToBytesAsync(obj, optionsAct);
        }

        /// <summary>
        /// From fastJSON bytes 
        /// </summary>
        /// <param name="data"></param>
        /// <param name="options"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T FromFastJsonBytes<T>(this byte[] data, JSONParameters options = null)
        {
            return FastJsonHelper.DeserializeFromBytes<T>(data, options);
        }

        /// <summary>
        /// From fastJSON bytes 
        /// </summary>
        /// <param name="data"></param>
        /// <param name="optionsAct"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T FromFastJsonBytes<T>(this byte[] data, Action<JSONParameters> optionsAct)
        {
            return FastJsonHelper.DeserializeFromBytes<T>(data, optionsAct);
        }

        /// <summary>
        /// From fastJSON bytes 
        /// </summary>
        /// <param name="data"></param>
        /// <param name="type"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public static object FromFastJsonBytes(this byte[] data, Type type, JSONParameters options = null)
        {
            return FastJsonHelper.DeserializeFromBytes(data, type, options);
        }

        /// <summary>
        /// From fastJSON bytes 
        /// </summary>
        /// <param name="data"></param>
        /// <param name="type"></param>
        /// <param name="optionsAct"></param>
        /// <returns></returns>
        public static object FromFastJsonBytes(this byte[] data, Type type, Action<JSONParameters> optionsAct)
        {
            return FastJsonHelper.DeserializeFromBytes(data, type, optionsAct);
        }

        /// <summary>
        /// From fastJSON bytes async
        /// </summary>
        /// <param name="data"></param>
        /// <param name="options"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Task<T> FromFastJsonBytesAsync<T>(this byte[] data, JSONParameters options = null)
        {
            return FastJsonHelper.DeserializeFromBytesAsync<T>(data, options);
        }

        /// <summary>
        /// From fastJSON bytes async
        /// </summary>
        /// <param name="data"></param>
        /// <param name="optionsAct"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Task<T> FromFastJsonBytesAsync<T>(this byte[] data, Action<JSONParameters> optionsAct)
        {
            return FastJsonHelper.DeserializeFromBytesAsync<T>(data, optionsAct);
        }

        /// <summary>
        /// From fastJSON bytes async
        /// </summary>
        /// <param name="data"></param>
        /// <param name="type"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public static Task<object> FromFastJsonBytesAsync(this byte[] data, Type type, JSONParameters options = null)
        {
            return FastJsonHelper.DeserializeFromBytesAsync(data, type, options);
        }

        /// <summary>
        /// From fastJSON bytes async
        /// </summary>
        /// <param name="data"></param>
        /// <param name="type"></param>
        /// <param name="optionsAct"></param>
        /// <returns></returns>
        public static Task<object> FromFastJsonBytesAsync(this byte[] data, Type type, Action<JSONParameters> optionsAct)
        {
            return FastJsonHelper.DeserializeFromBytesAsync(data, type, optionsAct);
        }
    }
}