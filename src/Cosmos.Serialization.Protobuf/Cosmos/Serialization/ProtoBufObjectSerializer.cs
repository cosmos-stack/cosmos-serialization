using System;
using System.IO;
using System.Threading.Tasks;
using Cosmos.Serialization.ProtoBuf;

namespace Cosmos.Serialization {
    /// <summary>
    /// Google Protobuf object serializer
    /// </summary>
    public class ProtoBufObjectSerializer : IProtobufSerializer {
        /// <inheritdoc />
        public byte[] Serialize<T>(T o) => ProtobufHelper.Serialize(o);

        /// <inheritdoc />
        public Stream SerializeToStream<T>(T o) => ProtobufHelper.Pack(o);

        /// <inheritdoc />
        public T Deserialize<T>(byte[] data) => ProtobufHelper.Deserialize<T>(data);

        /// <inheritdoc />
        public object Deserialize(byte[] data, Type type) => ProtobufHelper.Deserialize(data, type);

        /// <inheritdoc />
        public T DeserializeFromStream<T>(Stream stream) => ProtobufHelper.Unpack<T>(stream);

        /// <inheritdoc />
        public object DeserializeFromStream(Stream stream, Type type) => ProtobufHelper.Unpack(stream, type);

        /// <inheritdoc />
        public Task<byte[]> SerializeAsync<T>(T o) => ProtobufHelper.SerializeAsync(o);

        /// <inheritdoc />
        public Task<Stream> SerializeToStreamAsync<T>(T o) => ProtobufHelper.PackAsync(o);

        /// <inheritdoc />
        public Task<T> DeserializeAsync<T>(byte[] data) => ProtobufHelper.DeserializeAsync<T>(data);

        /// <inheritdoc />
        public Task<object> DeserializeAsync(byte[] data, Type type) => ProtobufHelper.DeserializeAsync(data, type);

        /// <inheritdoc />
        public Task<T> DeserializeFromStreamAsync<T>(Stream stream) => ProtobufHelper.UnpackAsync<T>(stream);

        /// <inheritdoc />
        public Task<object> DeserializeFromStreamAsync(Stream stream, Type type) => ProtobufHelper.UnpackAsync(stream, type);
    }
}