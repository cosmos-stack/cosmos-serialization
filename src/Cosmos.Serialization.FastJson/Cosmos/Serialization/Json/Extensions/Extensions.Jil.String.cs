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
        /// From FastJson
        /// </summary>
        /// <param name="json"></param>
        /// <param name="options"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T FromFastJson<T>(this string json, JSONParameters options = null)
        {
            return FastJsonHelper.Deserialize<T>(json, options);
        }

        /// <summary>
        /// From FastJson
        /// </summary>
        /// <param name="json"></param>
        /// <param name="optionsAct"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T FromFastJson<T>(this string json, Action<JSONParameters> optionsAct)
        {
            return FastJsonHelper.Deserialize<T>(json, optionsAct);
        }

        /// <summary>
        /// From FastJson
        /// </summary>
        /// <param name="json"></param>
        /// <param name="type"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public static object FromFastJson(this string json, Type type, JSONParameters options = null)
        {
            return FastJsonHelper.Deserialize(json, type, options);
        }

        /// <summary>
        /// From FastJson
        /// </summary>
        /// <param name="json"></param>
        /// <param name="type"></param>
        /// <param name="optionsAct"></param>
        /// <returns></returns>
        public static object FromFastJson(this string json, Type type, Action<JSONParameters> optionsAct)
        {
            return FastJsonHelper.Deserialize(json, type, optionsAct);
        }

        /// <summary>
        /// From FastJson async
        /// </summary>
        /// <param name="json"></param>
        /// <param name="options"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Task<T> FromFastJsonAsync<T>(this string json, JSONParameters options = null)
        {
            return FastJsonHelper.DeserializeAsync<T>(json, options);
        }

        /// <summary>
        /// From FastJson async
        /// </summary>
        /// <param name="json"></param>
        /// <param name="optionsAct"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Task<T> FromFastJsonAsync<T>(this string json, Action<JSONParameters> optionsAct)
        {
            return FastJsonHelper.DeserializeAsync<T>(json, optionsAct);
        }

        /// <summary>
        /// From FastJson async
        /// </summary>
        /// <param name="json"></param>
        /// <param name="typpe"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public static Task<object> FromFastJsonAsync(this string json, Type typpe, JSONParameters options = null)
        {
            return FastJsonHelper.DeserializeAsync(json, typpe, options);
        }

        /// <summary>
        /// From FastJson async
        /// </summary>
        /// <param name="json"></param>
        /// <param name="type"></param>
        /// <param name="optionsAct"></param>
        /// <returns></returns>
        public static Task<object> FromFastJsonAsync(this string json, Type type, Action<JSONParameters> optionsAct)
        {
            return FastJsonHelper.DeserializeAsync(json, type, optionsAct);
        }
    }
}