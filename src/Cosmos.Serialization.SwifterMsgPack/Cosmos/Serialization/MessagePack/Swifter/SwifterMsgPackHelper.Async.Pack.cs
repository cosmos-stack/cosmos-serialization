using System;
using System.IO;
using System.Threading.Tasks;

namespace Cosmos.Serialization.MessagePack.Swifter
{
    using F = global::Swifter.MessagePack.MessagePackFormatter;

    /// <summary>
    /// Swifter MessagePack helper
    /// </summary>
    public static partial class SwifterMsgPackHelper
    {
        /// <summary>
        /// Pack async
        /// </summary>
        /// <param name="t"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static async Task<Stream> PackAsync<T>(T t)
        {
            var ms = new MemoryStream();

            if (t is null)
                return ms;

            await PackAsync(t, ms);

            ms.Seek(0, SeekOrigin.Begin);

            return ms;
        }

        /// <summary>
        /// Pack async
        /// </summary>
        /// <param name="t"></param>
        /// <param name="stream"></param>
        /// <typeparam name="T"></typeparam>
        public static async Task PackAsync<T>(T t, Stream stream)
        {
            if (t is null)
                return;

            await F.SerializeObjectAsync(t, stream);
        }

        /// <summary>
        /// Pack async
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static async Task<Stream> PackAsync(object obj, Type type)
        {
            var ms = new MemoryStream();

            if (obj is null)
                return ms;

            await PackAsync(obj, type, ms);

            ms.Seek(0, SeekOrigin.Begin);

            return ms;
        }

        /// <summary>
        /// Pack async
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="type"></param>
        /// <param name="stream"></param>
        public static async Task PackAsync(object obj, Type type, Stream stream)
        {
            if (obj is null)
                return;

            await F.SerializeObjectAsync(obj, stream);
        }

        /// <summary>
        /// Unpack async
        /// </summary>
        /// <param name="stream"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static async Task<T> UnpackAsync<T>(Stream stream)
        {
            if (stream is null)
                return default;

            return await F.DeserializeObjectAsync<T>(stream);
        }

        /// <summary>
        /// Unpack async
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static async Task<object> UnpackAsync(Stream stream, Type type)
        {
            if (stream is null)
                return null;

            return await F.DeserializeObjectAsync(stream, type);
        }
    }
}