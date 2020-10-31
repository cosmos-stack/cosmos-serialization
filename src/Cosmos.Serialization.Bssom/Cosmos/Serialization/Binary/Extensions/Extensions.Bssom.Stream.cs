using System;
using System.IO;
using System.Threading.Tasks;
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
        /// <param name="type"></param>
        /// <returns></returns>
        public static object BssomUnpack(this Stream stream, Type type)
        {
            return BssomHelper.Unpack(stream, type);
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
        /// <param name="type"></param>
        /// <returns></returns>
        public static Task<object> BssomUnpackAsync(this Stream stream, Type type)
        {
            return BssomHelper.UnpackAsync(stream, type);
        }
    }
}