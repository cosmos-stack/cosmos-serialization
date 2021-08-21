using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Cosmos.Conversions;
using S = YamlDotNet.Serialization.ISerializer;
using D = YamlDotNet.Serialization.IDeserializer;

namespace Cosmos.Serialization.Yaml.YamlDotNet
{
    /// <summary>
    /// Yaml Helper
    /// </summary>
    public static partial class YamlHelper
    {
        /// <summary>
        /// Pack async
        /// </summary>
        /// <param name="o"></param>
        /// <param name="serializer"></param>
        /// <param name="encoding"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static async Task<Stream> PackAsync<T>(T o, S serializer = null, Encoding encoding = null)
        {
            var ms = new MemoryStream();

            if (o is null)
                return ms;

            await PackAsync(o, ms, serializer, encoding);

            return ms;
        }

        /// <summary>
        /// Pack
        /// </summary>
        /// <param name="o"></param>
        /// <param name="type"></param>
        /// <param name="serializer"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static async Task<Stream> PackAsync(object o, Type type, S serializer = null, Encoding encoding = null)
        {
            var ms = new MemoryStream();

            if (o is null)
                return ms;

            await PackAsync(o, type, ms, serializer, encoding);

            return ms;
        }

        /// <summary>
        /// Pack async
        /// </summary>
        /// <param name="o"></param>
        /// <param name="stream"></param>
        /// <param name="serializer"></param>
        /// <param name="encoding"></param>
        /// <typeparam name="T"></typeparam>
        public static async Task PackAsync<T>(T o, Stream stream, S serializer = null, Encoding encoding = null)
        {
            if (o is null || !stream.CanWrite)
                return;

            var bytes = await SerializeToBytesAsync(o, serializer, encoding);

            await stream.WriteAsync(bytes, 0, bytes.Length);
        }

        /// <summary>
        /// Pack
        /// </summary>
        /// <param name="o"></param>
        /// <param name="type"></param>
        /// <param name="stream"></param>
        /// <param name="serializer"></param>
        /// <param name="encoding"></param>
        public static async Task PackAsync(object o, Type type, Stream stream, S serializer = null, Encoding encoding = null)
        {
            if (o is null || !stream.CanWrite)
                return;

            var bytes = await SerializeToBytesAsync(o, serializer, encoding);

            await stream.WriteAsync(bytes, 0, bytes.Length);
        }

        /// <summary>
        /// Unpack async
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="deserializer"></param>
        /// <param name="encoding"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static async Task<T> UnpackAsync<T>(Stream stream, D deserializer = null, Encoding encoding = null)
        {
            return stream is null
                ? default
                : await DeserializeFromBytesAsync<T>(await stream.CastToBytesAsync(), deserializer, encoding);
        }

        /// <summary>
        /// Unpack async
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="type"></param>
        /// <param name="deserializer"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static async Task<object> UnpackAsync(Stream stream, Type type, D deserializer = null, Encoding encoding = null)
        {
            return stream is null
                ? null
                : await DeserializeFromBytesAsync(await stream.CastToBytesAsync(), type, deserializer, encoding);
        }
    }
}