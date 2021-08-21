using System;
using System.IO;
using System.Threading.Tasks;

namespace Cosmos.Serialization.ProtoBuf
{
    /// <summary>
    /// Google protobuf helper
    /// </summary>
    public static partial class ProtobufHelper
    {
        /// <summary>
        /// Pack
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static async Task<Stream> PackAsync(object obj)
        {
            var ms = new MemoryStream();

            if (obj is not null)
                await PackAsync(obj, ms);

            return ms;
        }

        /// <summary>
        /// Pack
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="stream"></param>
        public static async Task PackAsync(object obj, Stream stream)
        {
            if (obj is not null)
            {
                Action action = () => ProtoBufManager.Model.Serialize(stream, obj);
                await Task.Run(action);
            }
        }

        /// <summary>
        /// Unpack
        /// </summary>
        /// <param name="stream"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static async Task<T> UnpackAsync<T>(Stream stream)
        {
            if (stream is null || stream.Length == 0)
                return default;

            var type = typeof(T);
            return (T) await UnpackAsync(stream, type);
        }

        /// <summary>
        /// Unpack async
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static async Task<object> UnpackAsync(Stream stream, Type type)
        {
            if (stream is null || stream.Length == 0)
                return default;

            if (stream.CanSeek && stream.Position > 0)
                stream.Position = 0;

            Func<object> func = () => ProtoBufManager.Model.Deserialize(stream, null, type);
            return await Task.Run(func);
        }
    }
}