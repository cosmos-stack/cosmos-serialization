using System;
using System.IO;
using System.Threading.Tasks;
using Cosmos.Serialization.Binary;

namespace Cosmos.Serialization {
    /// <summary>
    /// Binary object serializer
    /// </summary>
    public class BinaryObjectSerializer : IObjectSerializer<byte[]> {
        /// <inheritdoc />
        public byte[] Serialize<T>(T o) => BinaryHelper.Serialize(o);

        /// <inheritdoc />
        public Stream SerializeToStream<T>(T o) => BinaryHelper.Pack(o);

        /// <inheritdoc />
        public T Deserialize<T>(byte[] data) => BinaryHelper.Deserialize<T>(data);

        /// <inheritdoc />
        public object Deserialize(byte[] data, Type type) => BinaryHelper.Deserialize(data);
        
        /// <inheritdoc />
        public T DeserializeFromStream<T>(Stream stream) => BinaryHelper.Unpack<T>(stream);
        
        /// <inheritdoc />
        public object DeserializeFromStream(Stream stream, Type type) => BinaryHelper.Unpack(stream);

        /// <inheritdoc />
        public Task<byte[]> SerializeAsync<T>(T o) => BinaryHelper.SerializeAsync(o);

        /// <inheritdoc />
        public Task<Stream> SerializeToStreamAsync<T>(T o) => BinaryHelper.PackAsync(o);

        /// <inheritdoc />
        public Task<T> DeserializeAsync<T>(byte[] data) => BinaryHelper.DeserializeAsync<T>(data);

        /// <inheritdoc />
        public Task<object> DeserializeAsync(byte[] data, Type type) => BinaryHelper.DeserializeAsync(data);
        
        /// <inheritdoc />
        public Task<T> DeserializeFromStreamAsync<T>(Stream stream) => BinaryHelper.UnpackAsync<T>(stream);
        
        /// <inheritdoc />
        public Task<object> DeserializeFromStreamAsync(Stream stream, Type type) => BinaryHelper.UnpackAsync(stream);
    }
}