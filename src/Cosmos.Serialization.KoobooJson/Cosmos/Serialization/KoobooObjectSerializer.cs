using System;
using System.IO;
using System.Threading.Tasks;
using Cosmos.Serialization.Json.Kooboo;

namespace Cosmos.Serialization {
    /// <summary>
    /// Kooboo Serializer
    /// </summary>
    // ReSharper disable once IdentifierTypo
    public class KoobooObjectSerializer : IJsonSerializer {
        /// <inheritdoc />
        public string Serialize<T>(T o) => KoobooJsonHelper.Serialize(o);

        /// <inheritdoc />
        public Stream SerializeToStream<T>(T o) => KoobooJsonHelper.Pack(o);

        /// <inheritdoc />
        public T Deserialize<T>(string json) => KoobooJsonHelper.Deserialize<T>(json);

        /// <inheritdoc />
        public object Deserialize(string json, Type type) => KoobooJsonHelper.Deserialize(json, type);

        /// <inheritdoc />
        public T DeserializeFromStream<T>(Stream stream) => KoobooJsonHelper.Unpack<T>(stream);

        /// <inheritdoc />
        public object DeserializeFromStream(Stream stream, Type type) => KoobooJsonHelper.Unpack(stream, type);

        /// <inheritdoc />
        public Task<string> SerializeAsync<T>(T o) => KoobooJsonHelper.SerializeAsync(o);

        /// <inheritdoc />
        public Task<Stream> SerializeToStreamAsync<T>(T o) => KoobooJsonHelper.PackAsync(o);

        /// <inheritdoc />
        public Task<T> DeserializeAsync<T>(string data) => KoobooJsonHelper.DeserializeAsync<T>(data);

        /// <inheritdoc />
        public Task<object> DeserializeAsync(string data, Type type) => KoobooJsonHelper.DeserializeAsync(data, type);

        /// <inheritdoc />
        public Task<T> DeserializeFromStreamAsync<T>(Stream stream) => KoobooJsonHelper.UnpackAsync<T>(stream);

        /// <inheritdoc />
        public Task<object> DeserializeFromStreamAsync(Stream stream, Type type) => KoobooJsonHelper.UnpackAsync(stream, type);
    }
}