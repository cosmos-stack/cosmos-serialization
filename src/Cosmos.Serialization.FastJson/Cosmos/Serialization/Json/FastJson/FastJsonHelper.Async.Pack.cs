using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Cosmos.Conversions;
using fastJSON;

namespace Cosmos.Serialization.Json.FastJson
{
    /// <summary>
    /// FastJson helper
    /// </summary>
    public static partial class FastJsonHelper
    {
        /// <summary>
        /// Pack async
        /// </summary>
        /// <param name="o"></param>
        /// <param name="options"></param>
        /// <param name="encoding"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static async Task<Stream> PackAsync<T>(T o, JSONParameters options = null, Encoding encoding = null)
        {
            var ms = new MemoryStream();

            if (o is null)
                return ms;

            await PackAsync(o, ms, options, encoding);

            return ms;
        }

        /// <summary>
        /// Pack async
        /// </summary>
        /// <param name="o"></param>
        /// <param name="stream"></param>
        /// <param name="options"></param>
        /// <param name="encoding"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static async Task PackAsync<T>(T o, Stream stream, JSONParameters options = null, Encoding encoding = null)
        {
            if (o is null || !stream.CanWrite)
                return;

            var bytes = await SerializeToBytesAsync(o, options, encoding);

            await stream.WriteAsync(bytes, 0, bytes.Length);
        }

        /// <summary>
        /// Unpack async
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="options"></param>
        /// <param name="encoding"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static async Task<T> UnpackAsync<T>(Stream stream, JSONParameters options = null, Encoding encoding = null)
        {
            return stream is null
                ? default
                : await DeserializeFromBytesAsync<T>(await stream.CastToBytesAsync(), options, encoding);
        }

        /// <summary>
        /// Unpack async
        /// </summary>
        /// <param name="type"></param>
        /// <param name="stream"></param>
        /// <param name="options"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static async Task<object> UnpackAsync(Stream stream, Type type, JSONParameters options = null, Encoding encoding = null)
        {
            return stream is null
                ? default
                : await DeserializeFromBytesAsync(await stream.CastToBytesAsync(), type, options, encoding);
        }
    }
}