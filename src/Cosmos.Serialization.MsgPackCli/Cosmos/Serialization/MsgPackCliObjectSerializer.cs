using System;
using System.IO;
using System.Threading.Tasks;
using Cosmos.Serialization.MessagePack.MsgPackCli;

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
            return MsgPackCliHelper.Serialize(o);
        }

        /// <inheritdoc />
        public Stream SerializeToStream<T>(T o)
        {
            return MsgPackCliHelper.Pack(o);
        }

        /// <inheritdoc />
        public T Deserialize<T>(byte[] data)
        {
            return MsgPackCliHelper.Deserialize<T>(data);
        }

        /// <inheritdoc />
        public object Deserialize(byte[] data, Type type)
        {
            return MsgPackCliHelper.Deserialize(data, type);
        }

        /// <inheritdoc />
        public T DeserializeFromStream<T>(Stream stream)
        {
            return MsgPackCliHelper.Unpack<T>(stream);
        }

        /// <inheritdoc />
        public object DeserializeFromStream(Stream stream, Type type)
        {
            return MsgPackCliHelper.Unpack(stream, type);
        }

        /// <inheritdoc />
        public Task<byte[]> SerializeAsync<T>(T o)
        {
            return MsgPackCliHelper.SerializeAsync(o);
        }

        /// <inheritdoc />
        public Task<Stream> SerializeToStreamAsync<T>(T o)
        {
            return MsgPackCliHelper.PackAsync(o);
        }

        /// <inheritdoc />
        public Task<T> DeserializeAsync<T>(byte[] data)
        {
            return MsgPackCliHelper.DeserializeAsync<T>(data);
        }

        /// <inheritdoc />
        public Task<object> DeserializeAsync(byte[] data, Type type)
        {
            return MsgPackCliHelper.DeserializeAsync(data, type);
        }

        /// <inheritdoc />
        public Task<T> DeserializeFromStreamAsync<T>(Stream stream)
        {
            return MsgPackCliHelper.UnpackAsync<T>(stream);
        }

        /// <inheritdoc />
        public Task<object> DeserializeFromStreamAsync(Stream stream, Type type)
        {
            return MsgPackCliHelper.UnpackAsync(stream, type);
        }
    }
}