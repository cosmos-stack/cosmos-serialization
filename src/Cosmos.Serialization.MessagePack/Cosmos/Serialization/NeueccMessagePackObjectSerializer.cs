using System;
using System.IO;
using System.Threading.Tasks;
using Cosmos.Serialization.MessagePack.Neuecc;

namespace Cosmos.Serialization
{
    /// <summary>
    /// Neuecc's MessagePack Serializer
    /// </summary>
    public class NeueccMessagePackObjectSerializer : IMessagePackSerializer
    {
        /// <inheritdoc />
        public byte[] Serialize<T>(T o)
        {
            return NeueccMsgPackHelper.Serialize(o);
        }

        /// <inheritdoc />
        public Stream SerializeToStream<T>(T o)
        {
            return NeueccMsgPackHelper.Pack(o);
        }

        /// <inheritdoc />
        public T Deserialize<T>(byte[] data)
        {
            return NeueccMsgPackHelper.Deserialize<T>(data);
        }

        /// <inheritdoc />
        public object Deserialize(byte[] data, Type type)
        {
            return NeueccMsgPackHelper.Deserialize(data, type);
        }

        /// <inheritdoc />
        public T DeserializeFromStream<T>(Stream stream)
        {
            return NeueccMsgPackHelper.Unpack<T>(stream);
        }

        /// <inheritdoc />
        public object DeserializeFromStream(Stream stream, Type type)
        {
            return NeueccMsgPackHelper.Unpack(stream, type);
        }

        /// <inheritdoc />
        public Task<byte[]> SerializeAsync<T>(T o)
        {
            return NeueccMsgPackHelper.SerializeAsync(o);
        }

        /// <inheritdoc />
        public Task<Stream> SerializeToStreamAsync<T>(T o)
        {
            return NeueccMsgPackHelper.PackAsync(o);
        }

        /// <inheritdoc />
        public Task<T> DeserializeAsync<T>(byte[] data)
        {
            return NeueccMsgPackHelper.DeserializeAsync<T>(data);
        }

        /// <inheritdoc />
        public Task<object> DeserializeAsync(byte[] data, Type type)
        {
            return NeueccMsgPackHelper.DeserializeAsync(data, type);
        }

        /// <inheritdoc />
        public Task<T> DeserializeFromStreamAsync<T>(Stream stream)
        {
            return NeueccMsgPackHelper.UnpackAsync<T>(stream);
        }

        /// <inheritdoc />
        public Task<object> DeserializeFromStreamAsync(Stream stream, Type type)
        {
            return NeueccMsgPackHelper.UnpackAsync(stream, type);
        }
    }
}