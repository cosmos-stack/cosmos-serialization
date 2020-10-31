using System;
using System.IO;
using Bssom.Serializer;

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
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static byte[] Serialize<T>(T o, BssomSerializerOptions options = null)
        {
            return BssomSerializer.Serialize(o, options ?? BssomManager.DefaultOptions);
        }

        /// <summary>
        /// Serialize
        /// </summary>
        /// <param name="o"></param>
        /// <param name="optionAct"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static byte[] Serialize<T>(T o, Action<BssomSerializerOptions> optionAct)
        {
            var options = BssomSerializerOptions.Default;
            optionAct?.Invoke(options);
            return Serialize(o, options);
        }

        /// <summary>
        /// Deserialize
        /// </summary>
        /// <param name="byteArray"></param>
        /// <param name="options"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T Deserialize<T>(byte[] byteArray, BssomSerializerOptions options = null)
        {
            return BssomSerializer.Deserialize<T>(byteArray, options ?? BssomManager.DefaultOptions);
        }

        /// <summary>
        /// Deserialize
        /// </summary>
        /// <param name="byteArray"></param>
        /// <param name="optionAct"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T Deserialize<T>(byte[] byteArray, Action<BssomSerializerOptions> optionAct)
        {
            var options = BssomSerializerOptions.Default;
            optionAct?.Invoke(options);
            return Deserialize<T>(byteArray, options);
        }

        /// <summary>
        /// Deserialize
        /// </summary>
        /// <param name="byteArray"></param>
        /// <param name="type"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public static object Deserialize(byte[] byteArray, Type type, BssomSerializerOptions options = null)
        {
            using var stream = new MemoryStream(byteArray);
            return Unpack(stream, type, options);
        }

        /// <summary>
        /// Deserialize
        /// </summary>
        /// <param name="byteArray"></param>
        /// <param name="type"></param>
        /// <param name="optionAct"></param>
        /// <returns></returns>
        public static object Deserialize(byte[] byteArray, Type type, Action<BssomSerializerOptions> optionAct)
        {
            var options = BssomSerializerOptions.Default;
            optionAct?.Invoke(options);
            return Deserialize(byteArray, type, options);
        }
    }
}