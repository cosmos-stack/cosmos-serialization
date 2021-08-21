using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Cosmos.Conversions;

namespace Cosmos.Serialization.Json.Lit
{
    /// <summary>
    /// Lit Helper
    /// </summary>
    public static partial class LitHelper
    {
        /// <summary>
        /// Pack async
        /// </summary>
        /// <param name="o"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static async Task<Stream> PackAsync<T>(T o, Encoding encoding = null)
        {
            var ms = new MemoryStream();

            if (o is null)
                return ms;

            await PackAsync(o, ms, encoding);

            return ms;
        }

        /// <summary>
        /// Pack async
        /// </summary>
        /// <param name="o"></param>
        /// <param name="stream"></param>
        /// <param name="encoding"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static async Task PackAsync<T>(T o, Stream stream, Encoding encoding = null)
        {
            if (o is null || !stream.CanWrite)
                return;

            var bytes = await SerializeToBytesAsync(o, encoding);

            await stream.WriteAsync(bytes, 0, bytes.Length);
        }

        /// <summary>
        /// Unpack async
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="encoding"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static async Task<T> UnpackAsync<T>(Stream stream, Encoding encoding = null)
        {
            return stream is null
                ? default
                : await DeserializeFromBytesAsync<T>(await stream.CastToBytesAsync(), encoding);
        }

        /// <summary>
        /// Unpack async
        /// </summary>
        /// <param name="type"></param>
        /// <param name="stream"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static async Task<object> UnpackAsync(Stream stream, Type type, Encoding encoding = null)
        {
            return stream is null
                ? default
                : await DeserializeFromBytesAsync(await stream.CastToBytesAsync(), type, encoding);
        }
    }
}