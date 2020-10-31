using System;
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
        /// From bytes
        /// </summary>
        /// <param name="bytes"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T FromBssomBytes<T>(this byte[] bytes)
        {
            return BssomHelper.Deserialize<T>(bytes);
        }

        /// <summary>
        /// From bytes
        /// </summary>
        /// <param name="bytes"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static object FromBssomBytes(this byte[] bytes, Type type)
        {
            return BssomHelper.Deserialize(bytes, type);
        }

        /// <summary>
        /// From bytes async
        /// </summary>
        /// <param name="bytes"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Task<T> FromBssomBytesAsync<T>(this byte[] bytes)
        {
            return BssomHelper.DeserializeAsync<T>(bytes);
        }

        /// <summary>
        /// From bytes async
        /// </summary>
        /// <param name="bytes"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static Task<object> FromBssomBytesAsync(this byte[] bytes, Type type)
        {
            return BssomHelper.DeserializeAsync(bytes, type);
        }
    }
}