using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Cosmos.Conversions;
using Cosmos.Optionals;
using Newtonsoft.Json;

namespace Cosmos.Serialization.Json.Newtonsoft
{
    /// <summary>
    /// Newtonsoft Json Helper
    /// </summary>
    public static partial class JsonHelper
    {
        /// <summary>
        /// Pack async
        /// </summary>
        /// <param name="o"></param>
        /// <param name="settings"></param>
        /// <param name="withNodaTime"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static async Task<Stream> PackAsync(object o, JsonSerializerSettings settings = null, bool withNodaTime = false, Encoding encoding = null)
        {
            var ms = new MemoryStream();

            if (o is null)
                return ms;

            await PackAsync(o, ms, settings, withNodaTime, encoding);

            return ms;
        }

        /// <summary>
        /// Pack async
        /// </summary>
        /// <param name="o"></param>
        /// <param name="stream"></param>
        /// <param name="settings"></param>
        /// <param name="withNodaTime"></param>
        /// <param name="encoding"></param>
        public static async Task PackAsync(object o, Stream stream, JsonSerializerSettings settings = null, bool withNodaTime = false, Encoding encoding = null)
        {
            if (o is null)
                return;

            var bytes = await SerializeToBytesAsync(o, settings, withNodaTime, encoding);

            await stream.WriteAsync(bytes, 0, bytes.Length);
        }

        /// <summary>
        /// Unpack async
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="settings"></param>
        /// <param name="withNodaTime"></param>
        /// <param name="encoding"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static async Task<T> UnpackAsync<T>(Stream stream, JsonSerializerSettings settings = null, bool withNodaTime = false, Encoding encoding = null)
        {
            return stream is null
                ? default
                : await DeserializeAsync<T>(encoding.SafeEncodingValue(JsonManager.DefaultEncoding).GetString(await stream.CastToBytesAsync()), settings, withNodaTime);
        }

        /// <summary>
        /// Unpack async
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="type"></param>
        /// <param name="settings"></param>
        /// <param name="withNodaTime"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static async Task<object> UnpackAsync(Stream stream, Type type, JsonSerializerSettings settings = null, bool withNodaTime = false, Encoding encoding = null)
        {
            return stream is null
                ? default
                : await DeserializeAsync(encoding.SafeEncodingValue(JsonManager.DefaultEncoding).GetString(await stream.CastToBytesAsync()), type, settings, withNodaTime);
        }
    }
}