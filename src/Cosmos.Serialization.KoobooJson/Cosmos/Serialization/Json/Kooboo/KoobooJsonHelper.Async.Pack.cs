using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Cosmos.Conversions;
using Cosmos.Optionals;
using Kooboo.Json;

namespace Cosmos.Serialization.Json.Kooboo
{
    /// <summary>
    /// KoobooJson helper
    /// </summary>
    public static partial class KoobooJsonHelper
    {
        /// <summary>
        /// Pack async
        /// </summary>
        /// <param name="o"></param>
        /// <param name="option"></param>
        /// <param name="encoding"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static async Task<Stream> PackAsync<T>(T o, JsonSerializerOption option = null, Encoding encoding = null)
        {
            var ms = new MemoryStream();

            if (o is null)
                return ms;

            await PackAsync(o, ms, option, encoding);

            return ms;
        }

        /// <summary>
        /// Pack async
        /// </summary>
        /// <param name="o"></param>
        /// <param name="stream"></param>
        /// <param name="option"></param>
        /// <param name="encoding"></param>
        /// <typeparam name="T"></typeparam>
        public static async Task PackAsync<T>(T o, Stream stream, JsonSerializerOption option = null, Encoding encoding = null)
        {
            if (o is null)
                return;

            var bytes = await SerializeToBytesAsync(o, option, encoding);

            await stream.WriteAsync(bytes, 0, bytes.Length);
        }

        /// <summary>
        /// Unpack async
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="option"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static async Task<T> UnpackAsync<T>(Stream stream, JsonDeserializeOption option = null, Encoding encoding = null)
        {
            return stream is null
                ? default
                : await DeserializeAsync<T>(encoding.SafeEncodingValue(KoobooManager.DefaultEncoding).GetString(await stream.CastToBytesAsync()), option);
        }

        /// <summary>
        /// Unpack async
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="type"></param>
        /// <param name="option"></param>
        /// <returns></returns>
        public static async Task<object> UnpackAsync(Stream stream, Type type, JsonDeserializeOption option = null, Encoding encoding = null)
        {
            return stream is null
                ? default
                : await DeserializeAsync(encoding.SafeEncodingValue(KoobooManager.DefaultEncoding).GetString(await stream.CastToBytesAsync()), type, option);
        }
    }
}