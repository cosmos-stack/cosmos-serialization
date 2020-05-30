using System;
using System.IO;
using System.Threading.Tasks;
using Cosmos.Serialization.ProtoBuf;

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
            return ProtobufHelper.Serialize(o);
        }

        /// <inheritdoc />
        public Stream SerializeToStream<T>(T o)
        {
            return ProtobufHelper.Pack(o);
        }

        /// <inheritdoc />
        public T Deserialize<T>(byte[] data)
        {
            return ProtobufHelper.Deserialize<T>(data);
        }

        /// <inheritdoc />
        public object Deserialize(byte[] data, Type type)
        {
            return ProtobufHelper.Deserialize(data, type);
        }

        /// <inheritdoc />
        public T DeserializeFromStream<T>(Stream stream)
        {
            return ProtobufHelper.Unpack<T>(stream);
        }

        /// <inheritdoc />
        public object DeserializeFromStream(Stream stream, Type type)
        {
            return ProtobufHelper.Unpack(stream, type);
        }

        /// <inheritdoc />
        public Task<byte[]> SerializeAsync<T>(T o)
        {
            return ProtobufHelper.SerializeAsync(o);
        }

        /// <inheritdoc />
        public Task<Stream> SerializeToStreamAsync<T>(T o)
        {
            return ProtobufHelper.PackAsync(o);
        }

        /// <inheritdoc />
        public Task<T> DeserializeAsync<T>(byte[] data)
        {
            return ProtobufHelper.DeserializeAsync<T>(data);
        }

        /// <inheritdoc />
        public Task<object> DeserializeAsync(byte[] data, Type type)
        {
            return ProtobufHelper.DeserializeAsync(data, type);
        }

        /// <inheritdoc />
        public Task<T> DeserializeFromStreamAsync<T>(Stream stream)
        {
            return ProtobufHelper.UnpackAsync<T>(stream);
        }

        /// <inheritdoc />
        public Task<object> DeserializeFromStreamAsync(Stream stream, Type type)
        {
            return ProtobufHelper.UnpackAsync(stream, type);
        }
    }
}