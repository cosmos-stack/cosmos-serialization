using System;
using System.IO;
using System.Text;
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
        /// Pack
        /// </summary>
        /// <param name="o"></param>
        /// <param name="option"></param>
        /// <param name="encoding"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Stream Pack<T>(T o, JsonSerializerOption option = null, Encoding encoding = null)
        {
            var ms = new MemoryStream();

            if (o is null)
                return ms;

            Pack(o, ms, option, encoding);

            return ms;
        }

        /// <summary>
        /// Pack
        /// </summary>
        /// <param name="o"></param>
        /// <param name="stream"></param>
        /// <param name="option"></param>
        /// <param name="encoding"></param>
        /// <typeparam name="T"></typeparam>
        public static void Pack<T>(T o, Stream stream, JsonSerializerOption option = null, Encoding encoding = null)
        {
            if (o is null)
                return;

            var bytes = SerializeToBytes(o, option, encoding);

            stream.Write(bytes, 0, bytes.Length);
        }

        /// <summary>
        /// Unpack
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="option"></param>
        /// <param name="encoding"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T Unpack<T>(Stream stream, JsonDeserializeOption option = null, Encoding encoding = null)
        {
            return stream is null
                ? default
                : Deserialize<T>(encoding.SafeEncodingValue(KoobooManager.DefaultEncoding).GetString(stream.CastToBytes()), option);
        }

        /// <summary>
        /// Unpack
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="type"></param>
        /// <param name="option"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static object Unpack(Stream stream, Type type, JsonDeserializeOption option = null, Encoding encoding = null)
        {
            return stream is null
                ? default
                : Deserialize(encoding.SafeEncodingValue(KoobooManager.DefaultEncoding).GetString(stream.CastToBytes()), type, option);
        }
    }
}