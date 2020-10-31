using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Bssom.Serializer;
using Cosmos.Conversions;

namespace Cosmos.Serialization.Binary.Bssom
{
    /// <summary>
    /// Bssom helper
    /// </summary>
    public static partial class BssomHelper
    {
        /// <summary>
        /// Serialize
        /// </summary>
        /// <param name="o"></param>
        /// <param name="options"></param>
        /// <param name="cancellationToken"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static async Task<byte[]> SerializeAsync<T>(T o, BssomSerializerOptions options = null, CancellationToken cancellationToken = default)
        {
            using (var stream = new MemoryStream())
            {
                await PackAsync(o, stream, options, cancellationToken);
                return await stream.CastToBytesAsync();
            }
        }

        /// <summary>
        /// Serialize
        /// </summary>
        /// <param name="o"></param>
        /// <param name="optionAct"></param>
        /// <param name="cancellationToken"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static async Task<byte[]> SerializeAsync<T>(T o, Action<BssomSerializerOptions> optionAct, CancellationToken cancellationToken = default)
        {
            var options = BssomSerializerOptions.Default;
            optionAct?.Invoke(options);
            return await SerializeAsync(o, options, cancellationToken);
        }

        /// <summary>
        /// Deserialize
        /// </summary>
        /// <param name="byteArray"></param>
        /// <param name="options"></param>
        /// <param name="cancellationToken"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static async Task<T> DeserializeAsync<T>(byte[] byteArray, BssomSerializerOptions options = null, CancellationToken cancellationToken = default)
        {
            if (byteArray is null || byteArray.Length is 0)
                return default;
#if NETFRAMEWORK || NETSTANDARD2_0
            using var ms = new MemoryStream(byteArray);
#else
            await using var ms = new MemoryStream(byteArray);
#endif
            return await BssomSerializer.DeserializeAsync<T>(ms, options, cancellationToken);
        }

        /// <summary>
        /// Deserialize
        /// </summary>
        /// <param name="byteArray"></param>
        /// <param name="optionAct"></param>
        /// <param name="cancellationToken"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static async Task<T> DeserializeAsync<T>(byte[] byteArray, Action<BssomSerializerOptions> optionAct, CancellationToken cancellationToken = default)
        {
            var options = BssomSerializerOptions.Default;
            optionAct?.Invoke(options);
            return await DeserializeAsync<T>(byteArray, options, cancellationToken);
        }

        /// <summary>
        /// Deserialize
        /// </summary>
        /// <param name="byteArray"></param>
        /// <param name="type"></param>
        /// <param name="options"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<object> DeserializeAsync(byte[] byteArray, Type type, BssomSerializerOptions options = null, CancellationToken cancellationToken = default)
        {
            if (byteArray is null || byteArray.Length is 0)
                return default;
#if NETFRAMEWORK || NETSTANDARD2_0
            using var ms = new MemoryStream(byteArray);
#else
            await using var ms = new MemoryStream(byteArray);
#endif
            return await BssomSerializer.DeserializeAsync(ms, type, options, cancellationToken);
        }

        /// <summary>
        /// Deserialize
        /// </summary>
        /// <param name="byteArray"></param>
        /// <param name="type"></param>
        /// <param name="optionAct"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<object> DeserializeAsync(byte[] byteArray, Type type, Action<BssomSerializerOptions> optionAct, CancellationToken cancellationToken = default)
        {
            var options = BssomSerializerOptions.Default;
            optionAct?.Invoke(options);
            return await DeserializeAsync(byteArray, type, options, cancellationToken);
        }
    }
}