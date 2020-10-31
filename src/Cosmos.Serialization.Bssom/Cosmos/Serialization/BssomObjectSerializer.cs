using System;
using System.IO;
using System.Threading.Tasks;
using Cosmos.Serialization.Binary;
using Cosmos.Serialization.Binary.Bssom;

namespace Cosmos.Serialization
{
    /// <summary>
    /// Bssom object serializer
    /// </summary>
    public class BssomObjectSerializer : IObjectSerializer<byte[]>
    {
        /// <inheritdoc />
        public byte[] Serialize<T>(T o)
        {
            return BssomHelper.Serialize(o);
        }

        /// <inheritdoc />
        public Stream SerializeToStream<T>(T o)
        {
            return BssomHelper.Pack(o);
        }

        /// <inheritdoc />
        public T Deserialize<T>(byte[] data)
        {
            return BssomHelper.Deserialize<T>(data);
        }

        /// <inheritdoc />
        public object Deserialize(byte[] data, Type type)
        {
            return BssomHelper.Deserialize(data, type);
        }

        /// <inheritdoc />
        public T DeserializeFromStream<T>(Stream stream)
        {
            return BssomHelper.Unpack<T>(stream);
        }

        /// <inheritdoc />
        public object DeserializeFromStream(Stream stream, Type type)
        {
            return BssomHelper.Unpack(stream, type);
        }

        /// <inheritdoc />
        public Task<byte[]> SerializeAsync<T>(T o)
        {
            return BssomHelper.SerializeAsync(o);
        }

        /// <inheritdoc />
        public Task<Stream> SerializeToStreamAsync<T>(T o)
        {
            return BssomHelper.PackAsync(o);
        }

        /// <inheritdoc />
        public Task<T> DeserializeAsync<T>(byte[] data)
        {
            return BssomHelper.DeserializeAsync<T>(data);
        }

        /// <inheritdoc />
        public Task<object> DeserializeAsync(byte[] data, Type type)
        {
            return BssomHelper.DeserializeAsync(data, type);
        }

        /// <inheritdoc />
        public Task<T> DeserializeFromStreamAsync<T>(Stream stream)
        {
            return BssomHelper.UnpackAsync<T>(stream);
        }

        /// <inheritdoc />
        public Task<object> DeserializeFromStreamAsync(Stream stream, Type type)
        {
            return BssomHelper.UnpackAsync(stream, type);
        }
    }
}