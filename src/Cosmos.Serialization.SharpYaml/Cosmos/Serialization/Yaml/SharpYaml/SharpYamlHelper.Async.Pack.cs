using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
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
        /// Pack async
        /// </summary>
        /// <param name="o"></param>
        /// <param name="encoding"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static async Task<Stream> PackAsync<T>(T o, Serializer serializer = null, Encoding encoding = null)
        {
            var ms = new MemoryStream();

            if (o is null)
                return ms;

            await PackAsync(o, ms,serializer, encoding);

            return ms;
        }

        /// <summary>
        /// Pack async
        /// </summary>
        /// <param name="o"></param>
        /// <param name="type"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static async Task<Stream> PackAsync(object o, Type type, Serializer serializer = null, Encoding encoding = null)
        {
            var ms = new MemoryStream();

            if (o is null)
                return ms;

            await PackAsync(o, type, ms,serializer, encoding);

            return ms;
        }

        /// <summary>
        /// Pack async
        /// </summary>
        /// <param name="o"></param>
        /// <param name="stream"></param>
        /// <param name="encoding"></param>
        /// <typeparam name="T"></typeparam>
        public static async Task PackAsync<T>(T o, Stream stream, Serializer serializer = null, Encoding encoding = null)
        {
            if (o is null || !stream.CanWrite)
                return;

            var bytes = await SerializeToBytesAsync(o,serializer, encoding);

            await stream.WriteAsync(bytes, 0, bytes.Length);
        }

        /// <summary>
        /// Pack async
        /// </summary>
        /// <param name="o"></param>
        /// <param name="stream"></param>
        /// <param name="type"></param>
        /// <param name="encoding"></param>
        public static async Task PackAsync(object o, Type type, Stream stream, Serializer serializer = null, Encoding encoding = null)
        {
            if (o is null || !stream.CanWrite)
                return;

            var bytes = await SerializeToBytesAsync(o, type,serializer, encoding);

            await stream.WriteAsync(bytes, 0, bytes.Length);
        }

        /// <summary>
        /// Unpack async
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="encoding"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static async Task<T> UnpackAsync<T>(Stream stream, Serializer serializer = null, Encoding encoding = null)
        {
            return stream is null
                ? default
                : await DeserializeFromBytesAsync<T>(await stream.CastToBytesAsync(), serializer,encoding);
        }

        /// <summary>
        /// Unpack async
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="type"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static async Task<object> UnpackAsync(Stream stream, Type type, Serializer serializer = null, Encoding encoding = null)
        {
            return stream is null
                ? null
                : await DeserializeFromBytesAsync(await stream.CastToBytesAsync(), type,serializer, encoding);
        }
    }
}