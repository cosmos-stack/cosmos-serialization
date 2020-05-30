using System;
using System.IO;
using System.Threading.Tasks;
using Cosmos.Serialization.Json.Utf8Json;

namespace Cosmos.Serialization
{
    /// <summary>
    /// Utf8Json object serializer
    /// </summary>
    public class Utf8JsonObjectSerializer : IJsonSerializer
    {
        /// <inheritdoc />
        public string Serialize<T>(T o)
        {
            return Utf8JsonHelper.Serialize(o);
        }

        /// <inheritdoc />
        public Stream SerializeToStream<T>(T o)
        {
            return Utf8JsonHelper.Pack(o);
        }

        /// <inheritdoc />
        public T Deserialize<T>(string json)
        {
            return Utf8JsonHelper.Deserialize<T>(json);
        }

        /// <inheritdoc />
        public object Deserialize(string json, Type type)
        {
            return Utf8JsonHelper.Deserialize(json, type);
        }

        /// <inheritdoc />
        public T DeserializeFromStream<T>(Stream stream)
        {
            return Utf8JsonHelper.Unpack<T>(stream);
        }

        /// <inheritdoc />
        public object DeserializeFromStream(Stream stream, Type type)
        {
            return Utf8JsonHelper.Unpack(stream, type);
        }

        /// <inheritdoc />
        public Task<string> SerializeAsync<T>(T o)
        {
            return Utf8JsonHelper.SerializeAsync(o);
        }

        /// <inheritdoc />
        public Task<Stream> SerializeToStreamAsync<T>(T o)
        {
            return Utf8JsonHelper.PackAsync(o);
        }

        /// <inheritdoc />
        public Task<T> DeserializeAsync<T>(string data)
        {
            return Utf8JsonHelper.DeserializeAsync<T>(data);
        }

        /// <inheritdoc />
        public Task<object> DeserializeAsync(string data, Type type)
        {
            return Utf8JsonHelper.DeserializeAsync(data, type);
        }

        /// <inheritdoc />
        public Task<T> DeserializeFromStreamAsync<T>(Stream stream)
        {
            return Utf8JsonHelper.UnpackAsync<T>(stream);
        }

        /// <inheritdoc />
        public Task<object> DeserializeFromStreamAsync(Stream stream, Type type)
        {
            return Utf8JsonHelper.UnpackAsync(stream, type);
        }
    }
}