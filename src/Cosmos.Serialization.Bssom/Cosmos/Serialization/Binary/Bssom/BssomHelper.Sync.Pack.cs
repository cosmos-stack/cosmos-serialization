using System;
using System.IO;
using Bssom.Serializer;

namespace Cosmos.Serialization.Binary.Bssom
{
    /// <summary>
    /// Bssom helper
    /// </summary>
    public static partial class BssomHelper
    {
        /// <summary>
        /// Pack
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public static Stream Pack<T>(T obj, BssomSerializerOptions options = null)
        {
            var ms = new MemoryStream();

            if (obj != null)
                Pack(obj, ms, options);

            return ms;
        }

        /// <summary>
        /// Pack
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="stream"></param>
        /// <param name="options"></param>
        public static void Pack<T>(T obj, Stream stream, BssomSerializerOptions options = null)
        {
            if (obj is null)
                return;

            BssomSerializer.Serialize(stream, obj, options ?? BssomManager.DefaultOptions);
        }

        /// <summary>
        /// Unpack
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="options"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T Unpack<T>(Stream stream, BssomSerializerOptions options = null)
        {
            if (stream is null || stream.Length is 0)
                return default;

            if (stream.CanSeek && stream.Position > 0)
                stream.Position = 0;

            return BssomSerializer.Deserialize<T>(stream, options ?? BssomManager.DefaultOptions);
        }

        /// <summary>
        /// Unpack
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="type"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public static object Unpack(Stream stream, Type type, BssomSerializerOptions options = null)
        {
            if (stream is null || stream.Length is 0)
                return null;

            if (stream.CanSeek && stream.Position > 0)
                stream.Position = 0;

            return BssomSerializer.Deserialize(stream, type, options ?? BssomManager.DefaultOptions);
        }
    }
}