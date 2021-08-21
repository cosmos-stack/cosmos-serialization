using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Cosmos.Conversions;
using Jil;

namespace Cosmos.Serialization.Json.Jil
{
    /// <summary>
    /// JilJson helper
    /// </summary>
    public static partial class JilHelper
    {
        /// <summary>
        /// Pack async
        /// </summary>
        /// <param name="o"></param>
        /// <param name="options"></param>
        /// <param name="encoding"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static async Task<Stream> PackAsync<T>(T o, Options options = null, Encoding encoding = null)
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
        public static async Task PackAsync<T>(T o, Stream stream, Options options = null, Encoding encoding = null)
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
        public static async Task<T> UnpackAsync<T>(Stream stream, Options options = null, Encoding encoding = null)
        {
            return stream is null
                ? default
                : await DeserializeFromBytesAsync<T>(await stream.CastToBytesAsync(), options ?? JilManager.DefaultOptions, encoding);
        }

        /// <summary>
        /// Unpack async
        /// </summary>
        /// <param name="type"></param>
        /// <param name="stream"></param>
        /// <param name="options"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static async Task<object> UnpackAsync(Stream stream, Type type, Options options = null, Encoding encoding = null)
        {
            return stream is null
                ? default
                : await DeserializeFromBytesAsync(await stream.CastToBytesAsync(), type, options ?? JilManager.DefaultOptions, encoding);
        }
    }
}