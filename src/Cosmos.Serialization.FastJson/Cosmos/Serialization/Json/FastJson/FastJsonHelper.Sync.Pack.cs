using System;
using System.IO;
using System.Text;
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
        /// Pack
        /// </summary>
        /// <param name="o"></param>
        /// <param name="options"></param>
        /// <param name="encoding"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Stream Pack<T>(T o, JSONParameters options = null, Encoding encoding = null)
        {
            var ms = new MemoryStream();

            if (o is null)
                return ms;

            Pack(o, ms, options, encoding);

            return ms;
        }

        /// <summary>
        /// Pack
        /// </summary>
        /// <param name="t"></param>
        /// <param name="stream"></param>
        /// <param name="options"></param>
        /// <param name="encoding"></param>
        /// <typeparam name="T"></typeparam>
        public static void Pack<T>(T t, Stream stream, JSONParameters options = null, Encoding encoding = null)
        {
            if (t is null || !stream.CanWrite)
                return;

            var bytes = SerializeToBytes(t, options, encoding);

            stream.Write(bytes, 0, bytes.Length);
        }

        /// <summary>
        /// Unpack
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="options"></param>
        /// <param name="encoding"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T Unpack<T>(Stream stream, JSONParameters options = null, Encoding encoding = null)
        {
            return stream is null
                ? default
                : DeserializeFromBytes<T>(stream.CastToBytes(), options, encoding);
        }

        /// <summary>
        /// Unpack
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="type"></param>
        /// <param name="options"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static object Unpack(Stream stream, Type type, JSONParameters options = null, Encoding encoding = null)
        {
            return stream is null
                ? null
                : DeserializeFromBytes(stream.CastToBytes(), type, options, encoding);
        }
    }
}