using System;
using System.IO;
using System.Threading.Tasks;
using Cosmos.Serialization.MessagePack.Swifter;

// ReSharper disable once CheckNamespace
namespace Cosmos.Serialization.MessagePack
{
    /// <summary>
    /// MessagePack extensions
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        /// Pack to
        /// </summary>
        /// <param name="t"></param>
        /// <param name="stream"></param>
        /// <typeparam name="T"></typeparam>
        public static void PackTo<T>(this T t, Stream stream)
        {
            SwifterMsgPackHelper.Pack(t, stream);
        }

        /// <summary>
        /// Pack to
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="type"></param>
        /// <param name="stream"></param>
        public static void PackTo(this object obj, Type type, Stream stream)
        {
            SwifterMsgPackHelper.Pack(obj, type, stream);
        }

        /// <summary>
        /// Pack by
        /// </summary>
        /// <param name="t"></param>
        /// <param name="stream"></param>
        /// <typeparam name="T"></typeparam>
        public static void PackBy<T>(this Stream stream, T t)
        {
            SwifterMsgPackHelper.Pack(t, stream);
        }

        /// <summary>
        /// Pack by
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="type"></param>
        /// <param name="stream"></param>
        public static void PackBy(this Stream stream, object obj, Type type)
        {
            SwifterMsgPackHelper.Pack(obj, type, stream);
        }

        /// <summary>
        /// Pack to async
        /// </summary>
        /// <param name="t"></param>
        /// <param name="stream"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static async Task PackToAsync<T>(this T t, Stream stream)
        {
            await SwifterMsgPackHelper.PackAsync(t, stream);
        }

        /// <summary>
        /// Pack to async
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="type"></param>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static async Task PackToAsync(this object obj, Type type, Stream stream)
        {
            await SwifterMsgPackHelper.PackAsync(obj, type, stream);
        }

        /// <summary>
        /// Pack to async
        /// </summary>
        /// <param name="t"></param>
        /// <param name="stream"></param>
        /// <typeparam name="T"></typeparam>
        public static async Task PackByAsync<T>(this Stream stream, T t)
        {
            await SwifterMsgPackHelper.PackAsync(t, stream);
        }

        /// <summary>
        /// Pack to async
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="type"></param>
        /// <param name="stream"></param>
        public static async Task PackByAsync(this Stream stream, object obj, Type type)
        {
            await SwifterMsgPackHelper.PackAsync(obj, type, stream);
        }

        /// <summary>
        /// Unpack
        /// </summary>
        /// <param name="stream"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T Unpack<T>(this Stream stream)
        {
            return SwifterMsgPackHelper.Unpack<T>(stream);
        }

        /// <summary>
        /// Unpack
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static object Unpack(this Stream stream, Type type)
        {
            return SwifterMsgPackHelper.Unpack(stream, type);
        }

        /// <summary>
        /// Unpack async
        /// </summary>
        /// <param name="stream"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Task<T> UnpackAsync<T>(this Stream stream)
        {
            return SwifterMsgPackHelper.UnpackAsync<T>(stream);
        }

        /// <summary>
        /// Unpack async
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static Task<object> UnpackAsync(this Stream stream, Type type)
        {
            return SwifterMsgPackHelper.UnpackAsync(stream, type);
        }
    }
}