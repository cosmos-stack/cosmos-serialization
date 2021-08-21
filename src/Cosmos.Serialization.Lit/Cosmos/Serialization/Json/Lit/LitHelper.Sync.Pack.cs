using System;
using System.IO;
using System.Text;
using Cosmos.Conversions;

namespace Cosmos.Serialization.Json.Lit
{
    /// <summary>
    /// Lit Helper
    /// </summary>
    public static partial class LitHelper
    {
        /// <summary>
        /// Pack
        /// </summary>
        /// <param name="o"></param>
        /// <param name="encoding"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Stream Pack<T>(T o, Encoding encoding = null)
        {
            var ms = new MemoryStream();

            if (o is null)
                return ms;

            Pack(o, ms, encoding);

            return ms;
        }

        /// <summary>
        /// Pack
        /// </summary>
        /// <param name="t"></param>
        /// <param name="stream"></param>
        /// <param name="encoding"></param>
        /// <typeparam name="T"></typeparam>
        public static void Pack<T>(T t, Stream stream, Encoding encoding = null)
        {
            if (t is null || !stream.CanWrite)
                return;

            var bytes = SerializeToBytes(t, encoding);

            stream.Write(bytes, 0, bytes.Length);
        }

        /// <summary>
        /// Unpack
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="encoding"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T Unpack<T>(Stream stream, Encoding encoding = null)
        {
            return stream is null
                ? default
                : DeserializeFromBytes<T>(stream.CastToBytes(), encoding);
        }

        /// <summary>
        /// Unpack
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="type"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static object Unpack(Stream stream, Type type, Encoding encoding = null)
        {
            return stream is null
                ? null
                : DeserializeFromBytes(stream.CastToBytes(), type, encoding);
        }
    }
}