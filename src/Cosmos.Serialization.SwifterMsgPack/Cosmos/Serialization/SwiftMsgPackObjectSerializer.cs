using System;
using System.IO;
using System.Threading.Tasks;
using Cosmos.Serialization.MessagePack.Swifter;

namespace Cosmos.Serialization
{
    /// <summary>
    /// MsgPack-cli object serializer
    /// </summary>
    public class MsgPackCliObjectSerializer : IMessagePackSerializer
    {
        /// <inheritdoc />
        public byte[] Serialize<T>(T o)
        {
            return SwifterMsgPackHelper.Serialize(o);
        }

        /// <inheritdoc />
        public Stream SerializeToStream<T>(T o)
        {
            return SwifterMsgPackHelper.Pack(o);
        }

        /// <inheritdoc />
        public T Deserialize<T>(byte[] data)
        {
            return SwifterMsgPackHelper.Deserialize<T>(data);
        }

        /// <inheritdoc />
        public object Deserialize(byte[] data, Type type)
        {
            return SwifterMsgPackHelper.Deserialize(data, type);
        }

        /// <inheritdoc />
        public T DeserializeFromStream<T>(Stream stream)
        {
            return SwifterMsgPackHelper.Unpack<T>(stream);
        }

        /// <inheritdoc />
        public object DeserializeFromStream(Stream stream, Type type)
        {
            return SwifterMsgPackHelper.Unpack(stream, type);
        }

        /// <inheritdoc />
        public Task<byte[]> SerializeAsync<T>(T o)
        {
            return SwifterMsgPackHelper.SerializeAsync(o);
        }

        /// <inheritdoc />
        public Task<Stream> SerializeToStreamAsync<T>(T o)
        {
            return SwifterMsgPackHelper.PackAsync(o);
        }

        /// <inheritdoc />
        public Task<T> DeserializeAsync<T>(byte[] data)
        {
            return SwifterMsgPackHelper.DeserializeAsync<T>(data);
        }

        /// <inheritdoc />
        public Task<object> DeserializeAsync(byte[] data, Type type)
        {
            return SwifterMsgPackHelper.DeserializeAsync(data, type);
        }

        /// <inheritdoc />
        public Task<T> DeserializeFromStreamAsync<T>(Stream stream)
        {
            return SwifterMsgPackHelper.UnpackAsync<T>(stream);
        }

        /// <inheritdoc />
        public Task<object> DeserializeFromStreamAsync(Stream stream, Type type)
        {
            return SwifterMsgPackHelper.UnpackAsync(stream, type);
        }
    }
}