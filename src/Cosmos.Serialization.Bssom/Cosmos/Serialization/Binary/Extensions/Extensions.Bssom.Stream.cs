using System;
using System.IO;
using System.Threading.Tasks;
using Bssom.Serializer;
using Cosmos.Serialization.Binary.Bssom;

// ReSharper disable once CheckNamespace
namespace Cosmos.Serialization.Binary
{
    /// <summary>
    /// Binary extensions
    /// </summary>
    public static partial class BssomExtensions
    {
        /// <summary>
        /// Pack by
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="obj"></param>
        /// <typeparam name="T"></typeparam>
        public static void BssomPackBy<T>(this Stream stream, T obj)
        {
            BssomHelper.Pack(obj, stream);
        }

        /// <summary>
        /// Pack by
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="obj"></param>
        /// <param name="options"></param>
        /// <typeparam name="T"></typeparam>
        public static void BssomPackBy<T>(this Stream stream, T obj, BssomSerializerOptions options)
        {
            BssomHelper.Pack(obj, stream, options);
        }

        /// <summary>
        /// Unpack
        /// </summary>
        /// <param name="stream"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T BssomUnpack<T>(this Stream stream)
        {
            return BssomHelper.Unpack<T>(stream);
        }

        /// <summary>
        /// Unpack
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="options"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T BssomUnpack<T>(this Stream stream, BssomSerializerOptions options)
        {
            return BssomHelper.Unpack<T>(stream, options);
        }

        /// <summary>
        /// Unpack
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static object BssomUnpack(this Stream stream, Type type)
        {
            return BssomHelper.Unpack(stream, type);
        }

        /// <summary>
        /// Unpack
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="type"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public static object BssomUnpack(this Stream stream, Type type, BssomSerializerOptions options)
        {
            return BssomHelper.Unpack(stream, type, options);
        }

        /// <summary>
        /// Pack by async
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="obj"></param>
        /// <typeparam name="T"></typeparam>
        public static Task BssomPackByAsync<T>(this Stream stream, T obj)
        {
            return BssomHelper.PackAsync(obj, stream);
        }

        /// <summary>
        /// Pack by async
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="obj"></param>
        /// <param name="options"></param>
        /// <typeparam name="T"></typeparam>
        public static Task BssomPackByAsync<T>(this Stream stream, T obj, BssomSerializerOptions options)
        {
            return BssomHelper.PackAsync(obj, stream, options);
        }

        /// <summary>
        /// Unpack async
        /// </summary>
        /// <param name="stream"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Task<T> BssomUnpackAsync<T>(this Stream stream)
        {
            return BssomHelper.UnpackAsync<T>(stream);
        }

        /// <summary>
        /// Unpack async
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="options"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Task<T> BssomUnpackAsync<T>(this Stream stream, BssomSerializerOptions options)
        {
            return BssomHelper.UnpackAsync<T>(stream, options);
        }

        /// <summary>
        /// Unpack async
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static Task<object> BssomUnpackAsync(this Stream stream, Type type)
        {
            return BssomHelper.UnpackAsync(stream, type);
        }

        /// <summary>
        /// Unpack async
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="type"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public static Task<object> BssomUnpackAsync(this Stream stream, Type type, BssomSerializerOptions options)
        {
            return BssomHelper.UnpackAsync(stream, type, options);
        }
    }
}