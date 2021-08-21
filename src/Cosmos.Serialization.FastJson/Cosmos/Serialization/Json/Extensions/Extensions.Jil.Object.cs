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
        /// To fastJSON
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="options"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static string ToFastJson<T>(this T obj, JSONParameters options = null)
        {
            return FastJsonHelper.Serialize(obj, options);
        }

        /// <summary>
        /// To fastJSON
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="optionsAct"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static string ToFastJson<T>(this T obj, Action<JSONParameters> optionsAct)
        {
            return FastJsonHelper.Serialize(obj, optionsAct);
        }

        /// <summary>
        /// To fastJSON async
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="options"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Task<string> ToFastJsonAsync<T>(this T obj, JSONParameters options = null)
        {
            return FastJsonHelper.SerializeAsync(obj, options);
        }

        /// <summary>
        /// To fastJSON async
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="optionsAct"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Task<string> ToFastJsonAsync<T>(this T obj, Action<JSONParameters> optionsAct)
        {
            return FastJsonHelper.SerializeAsync(obj, optionsAct);
        }
    }
}