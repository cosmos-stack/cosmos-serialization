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
        /// To bytes
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static byte[] ToBssomBytes(this object obj)
        {
            return BssomHelper.Serialize(obj);
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
        /// Pack to
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="stream"></param>
        public static void BssomPackTo(this object obj, Stream stream)
        {
            BssomHelper.Pack(obj, stream);
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
        /// Pack async
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static Task<Stream> BssomPackAsync(this object obj)
        {
            return BssomHelper.PackAsync(obj);
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
    }
}