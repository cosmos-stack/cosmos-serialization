using System;
using System.IO;
using System.Threading.Tasks;
using Bssom.Serializer;
using Cosmos.Serialization.Binary.Bssom;

namespace Cosmos.Serialization
{
    /// <summary>
    /// Bssom object serializer
    /// </summary>
    public class BssomObjectSerializer : IObjectSerializer<byte[]>
    {
        private readonly BssomSerializerOptions _options;

        public BssomObjectSerializer()
        {
            _options = BssomManager.DefaultOptions;
        }

        public BssomObjectSerializer(BssomSerializerOptions options)
        {
            _options = options ?? BssomManager.DefaultOptions;
        }

        /// <inheritdoc />
        public byte[] Serialize<T>(T o)
        {
            return BssomHelper.Serialize(o, _options);
        }

        /// <inheritdoc />
        public Stream SerializeToStream<T>(T o)
        {
            return BssomHelper.Pack(o, _options);
        }

        /// <inheritdoc />
        public T Deserialize<T>(byte[] data)
        {
            return BssomHelper.Deserialize<T>(data, _options);
        }

        /// <inheritdoc />
        public object Deserialize(byte[] data, Type type)
        {
            return BssomHelper.Deserialize(data, type, _options);
        }

        /// <inheritdoc />
        public T DeserializeFromStream<T>(Stream stream)
        {
            return BssomHelper.Unpack<T>(stream, _options);
        }

        /// <inheritdoc />
        public object DeserializeFromStream(Stream stream, Type type)
        {
            return BssomHelper.Unpack(stream, type, _options);
        }

        /// <inheritdoc />
        public Task<byte[]> SerializeAsync<T>(T o)
        {
            return BssomHelper.SerializeAsync(o, _options);
        }

        /// <inheritdoc />
        public Task<Stream> SerializeToStreamAsync<T>(T o)
        {
            return BssomHelper.PackAsync(o, _options);
        }

        /// <inheritdoc />
        public Task<T> DeserializeAsync<T>(byte[] data)
        {
            return BssomHelper.DeserializeAsync<T>(data, _options);
        }

        /// <inheritdoc />
        public Task<object> DeserializeAsync(byte[] data, Type type)
        {
            return BssomHelper.DeserializeAsync(data, type, _options);
        }

        /// <inheritdoc />
        public Task<T> DeserializeFromStreamAsync<T>(Stream stream)
        {
            return BssomHelper.UnpackAsync<T>(stream, _options);
        }

        /// <inheritdoc />
        public Task<object> DeserializeFromStreamAsync(Stream stream, Type type)
        {
            return BssomHelper.UnpackAsync(stream, type, _options);
        }
    }
}