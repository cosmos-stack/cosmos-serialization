using System;
using System.IO;
using Nett;
using Tommy = Nett.Toml;

namespace Cosmos.Serialization.Toml.Nett
{
    /// <summary>
    /// Yaml Helper
    /// </summary>
    public static partial class NettHelper
    {
        /// <summary>
        /// Pack
        /// </summary>
        /// <param name="o"></param>
        /// <param name="settings"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Stream Pack<T>(T o, TomlSettings settings = null)
        {
            var ms = new MemoryStream();

            if (o is null)
                return ms;

            Pack(o, ms, settings);

            return ms;
        }

        /// <summary>
        /// Pack
        /// </summary>
        /// <param name="o"></param>
        /// <param name="type"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        public static Stream Pack(object o, Type type, TomlSettings settings = null)
        {
            var ms = new MemoryStream();

            if (o is null)
                return ms;

            Pack(o, type, ms, settings);

            return ms;
        }

        /// <summary>
        /// Pack
        /// </summary>
        /// <param name="o"></param>
        /// <param name="stream"></param>
        /// <param name="settings"></param>
        /// <typeparam name="T"></typeparam>
        public static void Pack<T>(T o, Stream stream, TomlSettings settings = null)
        {
            if (o is null || !stream.CanWrite)
                return;

            Tommy.WriteStream(o, stream, settings ?? NettManager.DefaultSettings);
        }

        /// <summary>
        /// Pack
        /// </summary>
        /// <param name="o"></param>
        /// <param name="type"></param>
        /// <param name="stream"></param>
        /// <param name="settings"></param>
        public static void Pack(object o, Type type, Stream stream, TomlSettings settings = null)
        {
            if (o is null || !stream.CanWrite)
                return;

            Tommy.WriteStream(o, stream, settings ?? NettManager.DefaultSettings);
        }

        /// <summary>
        /// Unpack
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="settings"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T Unpack<T>(Stream stream, TomlSettings settings = null)
        {
            return stream is null
                ? default
                : Tommy.ReadStream<T>(stream, settings ?? NettManager.DefaultSettings);
        }

        /// <summary>
        /// Unpack
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="type"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        public static object Unpack(Stream stream, Type type, TomlSettings settings = null)
        {
            return stream is null
                ? null
                : Tommy.ReadStream(stream, settings ?? NettManager.DefaultSettings).Get(type);
        }
    }
}