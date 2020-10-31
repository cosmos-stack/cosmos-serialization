using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
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
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Stream> PackAsync<T>(T obj, BssomSerializerOptions options = null,
            CancellationToken cancellationToken = default)
        {
            var ms = new MemoryStream();

            if (obj != null)
                await PackAsync(obj, ms, options, cancellationToken);

            return ms;
        }

        /// <summary>
        /// Pack
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="stream"></param>
        /// <param name="options"></param>
        /// <param name="cancellationToken"></param>
        public static async Task PackAsync<T>(T obj, Stream stream, BssomSerializerOptions options = null,
            CancellationToken cancellationToken = default)
        {
            if (obj is null)
                return;

            await BssomSerializer.SerializeAsync(stream, obj, options ?? BssomManager.DefaultOptions, cancellationToken);
        }

        /// <summary>
        /// Unpack
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="options"></param>
        /// <param name="cancellationToken"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static async Task<T> UnpackAsync<T>(Stream stream, BssomSerializerOptions options = null,
            CancellationToken cancellationToken = default)
        {
            if (stream is null || stream.Length is 0)
                return default;

            if (stream.CanSeek && stream.Position > 0)
                stream.Position = 0;

            return await BssomSerializer.DeserializeAsync<T>(stream, options ?? BssomManager.DefaultOptions, cancellationToken);
        }

        /// <summary>
        /// Unpack
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="type"></param>
        /// <param name="options"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<object> UnpackAsync(Stream stream, Type type, BssomSerializerOptions options = null,
            CancellationToken cancellationToken = default)
        {
            if (stream is null || stream.Length is 0)
                return null;

            if (stream.CanSeek && stream.Position > 0)
                stream.Position = 0;

            return await BssomSerializer.DeserializeAsync(stream, type, options ?? BssomManager.DefaultOptions, cancellationToken);
        }
    }
}