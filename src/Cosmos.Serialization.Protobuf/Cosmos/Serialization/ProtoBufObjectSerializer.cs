using Cosmos.Serialization.ProtoBuf;
using Cosmos.Serialization.Variousness;

namespace Cosmos.Serialization
{
    /// <summary>
    /// Google Protobuf object serializer
    /// </summary>
    public class ProtoBufObjectSerializer : IProtobufSerializer
    {
        /// <inheritdoc />
        public byte[] Serialize<T>(T o)
        {
            return ProtobufHelper.ToBytes(o);
        }

        /// <inheritdoc />
        public Stream SerializeToStream<T>(T o)
        {
            return ProtobufHelper.ToStream(o);
        }

        /// <inheritdoc />
        public T Deserialize<T>(byte[] data)
        {
            return ProtobufHelper.FromBytes<T>(data);
        }

        /// <inheritdoc />
        public object Deserialize(byte[] data, Type type)
        {
            return ProtobufHelper.FromBytes(type, data);
        }

        /// <inheritdoc />
        public T DeserializeFromStream<T>(Stream stream)
        {
            return ProtobufHelper.FromStream<T>(stream);
        }

        /// <inheritdoc />
        public object DeserializeFromStream(Stream stream, Type type)
        {
            return ProtobufHelper.FromStream(type, stream);
        }

        /// <inheritdoc />
        public Task<byte[]> SerializeAsync<T>(T o)
        {
            return ProtobufHelper.ToBytesAsync(o);
        }

        /// <inheritdoc />
        public Task<Stream> SerializeToStreamAsync<T>(T o)
        {
            return ProtobufHelper.ToStreamAsync(o);
        }

        /// <inheritdoc />
        public Task<T> DeserializeAsync<T>(byte[] data)
        {
            return ProtobufHelper.FromBytesAsync<T>(data);
        }

        /// <inheritdoc />
        public Task<object> DeserializeAsync(byte[] data, Type type)
        {
            return ProtobufHelper.FromBytesAsync(type, data);
        }

        /// <inheritdoc />
        public Task<T> DeserializeFromStreamAsync<T>(Stream stream)
        {
            return ProtobufHelper.FromStreamAsync<T>(stream);
        }

        /// <inheritdoc />
        public Task<object> DeserializeFromStreamAsync(Stream stream, Type type)
        {
            return ProtobufHelper.FromStreamAsync(type, stream);
        }
    }
}