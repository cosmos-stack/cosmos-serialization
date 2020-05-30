using System;
using System.IO;
using System.Threading.Tasks;
using Cosmos.Serialization.Toml.Nett;

namespace Cosmos.Serialization
{
    /// <summary>
    /// Nett TOML Serializer
    /// </summary>
    public class NettSerializer : ITomlSerializer
    {
        /// <inheritdoc />
        public string Serialize<T>(T o)
        {
            return NettHelper.Serialize(o);
        }

        /// <inheritdoc />
        public Stream SerializeToStream<T>(T o)
        {
            return NettHelper.Pack(o);
        }

        /// <inheritdoc />
        public T Deserialize<T>(string data)
        {
            return NettHelper.Deserialize<T>(data);
        }

        /// <inheritdoc />
        public object Deserialize(string data, Type type)
        {
            return NettHelper.Deserialize(data, type);
        }

        /// <inheritdoc />
        public T DeserializeFromStream<T>(Stream stream)
        {
            return NettHelper.Unpack<T>(stream);
        }

        /// <inheritdoc />
        public object DeserializeFromStream(Stream stream, Type type)
        {
            return NettHelper.Unpack(stream, type);
        }

        /// <inheritdoc />
        public Task<string> SerializeAsync<T>(T o)
        {
            return NettHelper.SerializeAsync(o);
        }

        /// <inheritdoc />
        public Task<Stream> SerializeToStreamAsync<T>(T o)
        {
            return NettHelper.PackAsync(o);
        }

        /// <inheritdoc />
        public Task<T> DeserializeAsync<T>(string data)
        {
            return NettHelper.DeserializeAsync<T>(data);
        }

        /// <inheritdoc />
        public Task<object> DeserializeAsync(string data, Type type)
        {
            return NettHelper.DeserializeAsync(data, type);
        }

        /// <inheritdoc />
        public Task<T> DeserializeFromStreamAsync<T>(Stream stream)
        {
            return NettHelper.UnpackAsync<T>(stream);
        }

        /// <inheritdoc />
        public Task<object> DeserializeFromStreamAsync(Stream stream, Type type)
        {
            return NettHelper.UnpackAsync(stream, type);
        }
    }
}