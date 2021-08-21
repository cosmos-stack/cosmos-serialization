using System;
using System.IO;
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
        /// FastJson pack to
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="options"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Stream FastJsonPack<T>(this T obj, JSONParameters options = null)
        {
            return FastJsonHelper.Pack(obj, options);
        }

        /// <summary>
        /// FastJson pack to
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="stream"></param>
        /// <param name="options"></param>
        /// <typeparam name="T"></typeparam>
        public static void FastJsonPackTo<T>(this T obj, Stream stream, JSONParameters options = null)
        {
            FastJsonHelper.Pack(obj, stream, options);
        }

        /// <summary>
        /// FastJson pack by
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="obj"></param>
        /// <param name="options"></param>
        public static void FastJsonPackBy(this Stream stream, object obj, JSONParameters options = null)
        {
            FastJsonHelper.Pack(obj, stream, options);
        }

        /// <summary>
        /// FastJson pack to
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="options"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Task<Stream> FastJsonPackAsync<T>(this T obj, JSONParameters options = null)
        {
            return FastJsonHelper.PackAsync(obj, options);
        }

        /// <summary>
        /// FastJson pack to
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="stream"></param>
        /// <param name="options"></param>
        /// <typeparam name="T"></typeparam>
        public static Task FastJsonPackToAsync<T>(this T obj, Stream stream, JSONParameters options = null)
        {
            return FastJsonHelper.PackAsync(obj, stream, options);
        }

        /// <summary>
        /// FastJson pack by async
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="obj"></param>
        /// <param name="options"></param>
        public static Task FastJsonPackByAsync(this Stream stream, object obj, JSONParameters options = null)
        {
            return FastJsonHelper.PackAsync(obj, stream, options);
        }

        /// <summary>
        /// FastJson unpack
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="options"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T FastJsonUnpack<T>(this Stream stream, JSONParameters options = null)
        {
            return FastJsonHelper.Unpack<T>(stream, options);
        }

        /// <summary>
        /// FastJson unpack
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="type"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public static object FastJsonUnpack(this Stream stream, Type type, JSONParameters options = null)
        {
            return FastJsonHelper.Unpack(stream, type, options);
        }

        /// <summary>
        /// FastJson unpack async
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="options"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static async Task<T> FastJsonUnpackAsync<T>(this Stream stream, JSONParameters options = null)
        {
            return await FastJsonHelper.UnpackAsync<T>(stream, options);
        }

        /// <summary>
        /// FastJson unpack async
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="type"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public static async Task<object> FastJsonUnpackAsync(this Stream stream, Type type, JSONParameters options = null)
        {
            return await FastJsonHelper.UnpackAsync(stream, type, options);
        }
    }
}