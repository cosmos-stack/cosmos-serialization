using System;
using System.IO;
using System.Threading.Tasks;
using Cosmos.Serialization.Json.Lit;

namespace Cosmos.Serialization
{
    /// <summary>
    /// LitJson Serializer
    /// </summary>
    public class LitObjectSerializer : IJsonSerializer
    {
        /// <inheritdoc />
        public string Serialize<T>(T o)
        {
            return LitHelper.Serialize(o);
        }

        /// <inheritdoc />
        public Stream SerializeToStream<T>(T o)
        {
            return LitHelper.Pack(o);
        }

        /// <inheritdoc />
        public T Deserialize<T>(string json)
        {
            return LitHelper.Deserialize<T>(json);
        }

        /// <inheritdoc />
        public object Deserialize(string json, Type type)
        {
            return LitHelper.Deserialize(json, type);
        }

        /// <inheritdoc />
        public T DeserializeFromStream<T>(Stream stream)
        {
            return LitHelper.Unpack<T>(stream);
        }

        /// <inheritdoc />
        public object DeserializeFromStream(Stream stream, Type type)
        {
            return LitHelper.Unpack(stream, type);
        }

        /// <inheritdoc />
        public Task<string> SerializeAsync<T>(T o)
        {
            return LitHelper.SerializeAsync(o);
        }

        /// <inheritdoc />
        public Task<Stream> SerializeToStreamAsync<T>(T o)
        {
            return LitHelper.PackAsync(o);
        }

        /// <inheritdoc />
        public Task<T> DeserializeAsync<T>(string data)
        {
            return LitHelper.DeserializeAsync<T>(data);
        }

        /// <inheritdoc />
        public Task<object> DeserializeAsync(string data, Type type)
        {
            return LitHelper.DeserializeAsync(data, type);
        }

        /// <inheritdoc />
        public Task<T> DeserializeFromStreamAsync<T>(Stream stream)
        {
            return LitHelper.UnpackAsync<T>(stream);
        }

        /// <inheritdoc />
        public Task<object> DeserializeFromStreamAsync(Stream stream, Type type)
        {
            return LitHelper.UnpackAsync(stream, type);
        }
    }
}