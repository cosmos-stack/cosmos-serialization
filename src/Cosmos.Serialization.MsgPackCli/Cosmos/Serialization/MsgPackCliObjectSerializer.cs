using Cosmos.Serialization.MsgPackCli;
using Cosmos.Serialization.Variousness;

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
            return MsgPackHelper.ToBytes(o);
        }

        /// <inheritdoc />
        public Stream SerializeToStream<T>(T o)
        {
            return MsgPackHelper.ToStream(o);
        }

        /// <inheritdoc />
        public T Deserialize<T>(byte[] data)
        {
            return MsgPackHelper.FromBytes<T>(data);
        }

        /// <inheritdoc />
        public object Deserialize(byte[] data, Type type)
        {
            return MsgPackHelper.FromBytes(type, data);
        }

        /// <inheritdoc />
        public T DeserializeFromStream<T>(Stream stream)
        {
            return MsgPackHelper.FromStream<T>(stream);
        }

        /// <inheritdoc />
        public object DeserializeFromStream(Stream stream, Type type)
        {
            return MsgPackHelper.FromStream(type, stream);
        }

        /// <inheritdoc />
        public Task<byte[]> SerializeAsync<T>(T o)
        {
            return MsgPackHelper.ToBytesAsync(o);
        }

        /// <inheritdoc />
        public Task<Stream> SerializeToStreamAsync<T>(T o)
        {
            return MsgPackHelper.ToStreamAsync(o);
        }

        /// <inheritdoc />
        public Task<T> DeserializeAsync<T>(byte[] data)
        {
            return MsgPackHelper.FromBytesAsync<T>(data);
        }

        /// <inheritdoc />
        public Task<object> DeserializeAsync(byte[] data, Type type)
        {
            return MsgPackHelper.FromBytesAsync(type, data);
        }

        /// <inheritdoc />
        public Task<T> DeserializeFromStreamAsync<T>(Stream stream)
        {
            return MsgPackHelper.FromStreamAsync<T>(stream);
        }

        /// <inheritdoc />
        public Task<object> DeserializeFromStreamAsync(Stream stream, Type type)
        {
            return MsgPackHelper.FromStreamAsync(type, stream);
        }
    }
}