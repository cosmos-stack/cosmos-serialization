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
        /// To bytes
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static byte[] ToBssomBytes(this object obj)
        {
            return BssomHelper.Serialize(obj);
        }

        /// <summary>
        /// To bytes
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public static byte[] ToBssomBytes(this object obj, BssomSerializerOptions options)
        {
            return BssomHelper.Serialize(obj, options);
        }

        /// <summary>
        /// Pack
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static Stream BssomPack(this object obj)
        {
            return BssomHelper.Pack(obj);
        }

        /// <summary>
        /// Pack
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public static Stream BssomPack(this object obj, BssomSerializerOptions options)
        {
            return BssomHelper.Pack(obj, options);
        }

        /// <summary>
        /// Pack to
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="stream"></param>
        public static void BssomPackTo(this object obj, Stream stream)
        {
            BssomHelper.Pack(obj, stream);
        }

        /// <summary>
        /// Pack to
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="stream"></param>
        /// <param name="options"></param>
        public static void BssomPackTo(this object obj, Stream stream, BssomSerializerOptions options)
        {
            BssomHelper.Pack(obj, stream, options);
        }

        /// <summary>
        /// To bytes async
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static Task<byte[]> ToBssomBytesAsync(this object obj)
        {
            return BssomHelper.SerializeAsync(obj);
        }

        /// <summary>
        /// To bytes async
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public static Task<byte[]> ToBssomBytesAsync(this object obj, BssomSerializerOptions options)
        {
            return BssomHelper.SerializeAsync(obj, options);
        }

        /// <summary>
        /// Pack async
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static Task<Stream> BssomPackAsync(this object obj)
        {
            return BssomHelper.PackAsync(obj);
        }

        /// <summary>
        /// Pack async
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public static Task<Stream> BssomPackAsync(this object obj, BssomSerializerOptions options)
        {
            return BssomHelper.PackAsync(obj, options);
        }

        /// <summary>
        /// Pack to async
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="stream"></param>
        public static Task BssomPackToAsync(this object obj, Stream stream)
        {
            return BssomHelper.PackAsync(obj, stream);
        }

        /// <summary>
        /// Pack to async
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="stream"></param>
        /// <param name="options"></param>
        public static Task BssomPackToAsync(this object obj, Stream stream, BssomSerializerOptions options)
        {
            return BssomHelper.PackAsync(obj, stream, options);
        }
    }
}