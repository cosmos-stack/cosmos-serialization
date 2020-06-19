using System;
using System.IO;

namespace Cosmos.Serialization.MessagePack.Swifter
{
    using F = global::Swifter.MessagePack.MessagePackFormatter;

    /// <summary>
    /// Swifter MessagePack helper
    /// </summary>
    public static partial class SwifterMsgPackHelper
    {
        /// <summary>
        /// Pack
        /// </summary>
        /// <param name="t"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Stream Pack<T>(T t)
        {
            var ms = new MemoryStream();

            if (t is null)
                return ms;

            Pack(t, ms);

            ms.Seek(0, SeekOrigin.Begin);

            return ms;
        }

        /// <summary>
        /// Pack
        /// </summary>
        /// <param name="t"></param>
        /// <param name="stream"></param>
        /// <typeparam name="T"></typeparam>
        public static void Pack<T>(T t, Stream stream)
        {
            if (t is null)
                return;

            F.SerializeObject(t, stream);
        }

        /// <summary>
        /// Pack
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static Stream Pack(object obj, Type type)
        {
            var ms = new MemoryStream();

            if (obj is null)
                return ms;

            Pack(obj, type, ms);

            ms.Seek(0, SeekOrigin.Begin);

            return ms;
        }

        /// <summary>
        /// Pack
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="type"></param>
        /// <param name="stream"></param>
        public static void Pack(object obj, Type type, Stream stream)
        {
            if (obj is null)
                return;

            F.SerializeObject(obj, stream);
        }

        /// <summary>
        /// Unpack
        /// </summary>
        /// <param name="stream"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T Unpack<T>(Stream stream)
        {
            if (stream is null)
                return default;

            return F.DeserializeObject<T>(stream);
        }

        /// <summary>
        /// Unpack
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static object Unpack(Stream stream, Type type)
        {
            if (stream is null)
                return null;

            return F.DeserializeObject(stream, type);
        }
    }
}