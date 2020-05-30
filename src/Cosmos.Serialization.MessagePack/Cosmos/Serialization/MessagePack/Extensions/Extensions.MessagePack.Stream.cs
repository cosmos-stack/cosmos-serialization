using System;
using System.IO;
using System.Threading.Tasks;
using Cosmos.Serialization.MessagePack.Neuecc;

// ReSharper disable once CheckNamespace
namespace Cosmos.Serialization.MessagePack
{
    using N = NeueccMsgPackHelper;

    /// <summary>
    /// MessagePack extensions
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        /// To stream
        /// </summary>
        /// <param name="t"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Stream ToMessagePackStream<T>(this T t)
        {
            return N.Pack(t);
        }

        /// <summary>
        /// To stream
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static Stream ToMessagePackStream(this object obj, Type type)
        {
            return N.Pack(obj, type);
        }

        /// <summary>
        /// To stream
        /// </summary>
        /// <param name="t"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static async Task<Stream> ToMessagePackStreamAsync<T>(this T t)
        {
            return await N.PackAsync(t);
        }

        /// <summary>
        /// To stream
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static async Task<Stream> ToMessagePackStreamAsync(this object obj, Type type)
        {
            return await N.PackAsync(obj, type);
        }
    }
}