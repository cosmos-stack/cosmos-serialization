using System;
using System.IO;
using System.Threading.Tasks;
using Cosmos.Serialization.Json.Kooboo;

namespace Cosmos.Serialization
{
    /// <summary>
    /// Kooboo Serializer
    /// </summary>
    // ReSharper disable once IdentifierTypo
    public class KoobooObjectSerializer : IJsonSerializer
    {
        /// <inheritdoc />
        public string Serialize<T>(T o)
        {
            return KoobooJsonHelper.Serialize(o);
        }

        /// <inheritdoc />
        public Stream SerializeToStream<T>(T o)
        {
            return KoobooJsonHelper.Pack(o);
        }

        /// <inheritdoc />
        public T Deserialize<T>(string json)
        {
            return KoobooJsonHelper.Deserialize<T>(json);
        }

        /// <inheritdoc />
        public object Deserialize(string json, Type type)
        {
            return KoobooJsonHelper.Deserialize(json, type);
        }

        /// <inheritdoc />
        public T DeserializeFromStream<T>(Stream stream)
        {
            return KoobooJsonHelper.Unpack<T>(stream);
        }

        /// <inheritdoc />
        public object DeserializeFromStream(Stream stream, Type type)
        {
            return KoobooJsonHelper.Unpack(stream, type);
        }

        /// <inheritdoc />
        public Task<string> SerializeAsync<T>(T o)
        {
            return KoobooJsonHelper.SerializeAsync(o);
        }

        /// <inheritdoc />
        public Task<Stream> SerializeToStreamAsync<T>(T o)
        {
            return KoobooJsonHelper.PackAsync(o);
        }

        /// <inheritdoc />
        public Task<T> DeserializeAsync<T>(string data)
        {
            return KoobooJsonHelper.DeserializeAsync<T>(data);
        }

        /// <inheritdoc />
        public Task<object> DeserializeAsync(string data, Type type)
        {
            return KoobooJsonHelper.DeserializeAsync(data, type);
        }

        /// <inheritdoc />
        public Task<T> DeserializeFromStreamAsync<T>(Stream stream)
        {
            return KoobooJsonHelper.UnpackAsync<T>(stream);
        }

        /// <inheritdoc />
        public Task<object> DeserializeFromStreamAsync(Stream stream, Type type)
        {
            return KoobooJsonHelper.UnpackAsync(stream, type);
        }
    }
}