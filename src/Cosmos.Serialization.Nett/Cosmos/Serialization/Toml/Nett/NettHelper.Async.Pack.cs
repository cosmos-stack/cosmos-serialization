using System;
using System.IO;
using System.Threading.Tasks;
using Nett;

namespace Cosmos.Serialization.Toml.Nett
{
    /// <summary>
    /// Yaml Helper
    /// </summary>
    public static partial class NettHelper
    {
        /// <summary>
        /// Pack async
        /// </summary>
        /// <param name="o"></param>
        /// <param name="settings"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static async Task<Stream> PackAsync<T>(T o, TomlSettings settings = null)
        {
            var ms = new MemoryStream();

            if (o is null)
                return ms;

            await PackAsync(o, ms, settings);

            return ms;
        }

        /// <summary>
        /// Pack
        /// </summary>
        /// <param name="o"></param>
        /// <param name="type"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        public static async Task<Stream> PackAsync(object o, Type type, TomlSettings settings = null)
        {
            var ms = new MemoryStream();

            if (o is null)
                return ms;

            await PackAsync(o, type, ms, settings);

            return ms;
        }

        /// <summary>
        /// Pack async
        /// </summary>
        /// <param name="o"></param>
        /// <param name="stream"></param>
        /// <param name="settings"></param>
        /// <typeparam name="T"></typeparam>
        public static async Task PackAsync<T>(T o, Stream stream, TomlSettings settings = null)
        {
            if (o is null || !stream.CanWrite)
                return;

            await Task.Run(() => Pack(o, stream, settings));
        }

        /// <summary>
        /// Pack
        /// </summary>
        /// <param name="o"></param>
        /// <param name="type"></param>
        /// <param name="stream"></param>
        /// <param name="settings"></param>
        public static async Task PackAsync(object o, Type type, Stream stream, TomlSettings settings = null)
        {
            if (o is null || !stream.CanWrite)
                return;

            await Task.Run(() => Pack(o, type, stream, settings));
        }

        /// <summary>
        /// Unpack async
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="settings"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static async Task<T> UnpackAsync<T>(Stream stream, TomlSettings settings = null)
        {
            return stream is null
                ? default
                : await Task.Run(() => Unpack<T>(stream, settings));
        }

        /// <summary>
        /// Unpack async
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="type"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        public static async Task<object> UnpackAsync(Stream stream, Type type, TomlSettings settings = null)
        {
            return stream is null
                ? null
                : await Task.Run(() => Unpack(stream, type, settings));
        }
    }
}