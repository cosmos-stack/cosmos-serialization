using System;
using System.IO;
using System.Text;
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
        /// Pack
        /// </summary>
        /// <param name="o"></param>
        /// <param name="settings"></param>
        /// <param name="withNodaTime"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static Stream Pack(object o, JsonSerializerSettings settings = null, bool withNodaTime = false, Encoding encoding = null)
        {
            var ms = new MemoryStream();

            if (o is null)
                return ms;

            Pack(o, ms, settings, withNodaTime, encoding);

            return ms;
        }

        /// <summary>
        /// Pack
        /// </summary>
        /// <param name="o"></param>
        /// <param name="stream"></param>
        /// <param name="settings"></param>
        /// <param name="withNodaTime"></param>
        /// <param name="encoding"></param>
        public static void Pack(object o, Stream stream, JsonSerializerSettings settings = null, bool withNodaTime = false, Encoding encoding = null)
        {
            if (o is null)
                return;

            var bytes = SerializeToBytes(o, settings, withNodaTime, encoding);

            stream.Write(bytes, 0, bytes.Length);
        }

        /// <summary>
        /// Unpack
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="settings"></param>
        /// <param name="withNodaTime"></param>
        /// <param name="encoding"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T Unpack<T>(Stream stream, JsonSerializerSettings settings = null, bool withNodaTime = false, Encoding encoding = null)
        {
            return stream is null
                ? default
                : Deserialize<T>(encoding.SafeEncodingValue(JsonManager.DefaultEncoding).GetString(stream.CastToBytes()), settings, withNodaTime);
        }

        /// <summary>
        /// Unpack
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="type"></param>
        /// <param name="settings"></param>
        /// <param name="withNodaTime"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static object Unpack(Stream stream, Type type, JsonSerializerSettings settings = null, bool withNodaTime = false, Encoding encoding = null)
        {
            return stream is null
                ? default
                : Deserialize(encoding.SafeEncodingValue(JsonManager.DefaultEncoding).GetString(stream.CastToBytes()), type, settings, withNodaTime);
        }
    }
}