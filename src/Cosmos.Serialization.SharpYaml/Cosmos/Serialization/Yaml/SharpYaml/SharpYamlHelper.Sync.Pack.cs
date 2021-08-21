using System;
using System.IO;
using System.Text;
using Cosmos.Conversions;
using SharpYaml.Serialization;

namespace Cosmos.Serialization.Yaml.SharpYaml
{
    /// <summary>
    /// SharpYaml helper
    /// </summary>
    public static partial class SharpYamlHelper
    {
        /// <summary>
        /// Pack
        /// </summary>
        /// <param name="o"></param>
        /// <param name="encoding"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Stream Pack<T>(T o, Serializer serializer = null, Encoding encoding = null)
        {
            var ms = new MemoryStream();

            if (o is null)
                return ms;

            Pack(o, ms, serializer, encoding);

            return ms;
        }

        /// <summary>
        /// Pack
        /// </summary>
        /// <param name="o"></param>
        /// <param name="type"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static Stream Pack(object o, Type type, Serializer serializer = null, Encoding encoding = null)
        {
            var ms = new MemoryStream();

            if (o is null)
                return ms;

            Pack(o, type, ms, serializer, encoding);

            return ms;
        }

        /// <summary>
        /// Pack
        /// </summary>
        /// <param name="o"></param>
        /// <param name="stream"></param>
        /// <param name="encoding"></param>
        /// <typeparam name="T"></typeparam>
        public static void Pack<T>(T o, Stream stream, Serializer serializer = null, Encoding encoding = null)
        {
            if (o is null || !stream.CanWrite)
                return;

            var bytes = SerializeToBytes(o, serializer, encoding);

            stream.Write(bytes, 0, bytes.Length);
        }

        /// <summary>
        /// Pack
        /// </summary>
        /// <param name="o"></param>
        /// <param name="stream"></param>
        /// <param name="type"></param>
        /// <param name="encoding"></param>
        public static void Pack(object o, Type type, Stream stream, Serializer serializer = null, Encoding encoding = null)
        {
            if (o is null || !stream.CanWrite)
                return;

            var bytes = SerializeToBytes(o, type, serializer, encoding);

            stream.Write(bytes, 0, bytes.Length);
        }

        /// <summary>
        /// Unpack
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="encoding"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T Unpack<T>(Stream stream, Serializer serializer = null, Encoding encoding = null)
        {
            return stream is null
                ? default
                : DeserializeFromBytes<T>(stream.CastToBytes(), serializer, encoding);
        }

        /// <summary>
        /// Unpack
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="type"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static object Unpack(Stream stream, Type type, Serializer serializer = null, Encoding encoding = null)
        {
            return stream is null
                ? null
                : DeserializeFromBytes(stream.CastToBytes(), type, serializer, encoding);
        }
    }
}