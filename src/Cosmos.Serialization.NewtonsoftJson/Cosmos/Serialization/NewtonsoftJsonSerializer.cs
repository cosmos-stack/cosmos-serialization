using System;
using System.IO;
using System.Threading.Tasks;
using JsonHelper = Cosmos.Serialization.Json.Newtonsoft.JsonHelper;

namespace Cosmos.Serialization {
    /// <summary>
    /// Newtonsoft Json Serializer
    /// </summary>
    public class NewtonsoftJsonSerializer : IJsonSerializer {
        /// <inheritdoc />
        public string Serialize<T>(T o) => JsonHelper.Serialize(o);

        /// <inheritdoc />
        public Stream SerializeToStream<T>(T o) => JsonHelper.Pack(o);

        /// <inheritdoc />
        public T Deserialize<T>(string json) => JsonHelper.Deserialize<T>(json);

        /// <inheritdoc />
        public object Deserialize(string json, Type type) => JsonHelper.Deserialize(json, type);

        /// <inheritdoc />
        public T DeserializeFromStream<T>(Stream stream) => JsonHelper.Unpack<T>(stream);

        /// <inheritdoc />
        public object DeserializeFromStream(Stream stream, Type type) => JsonHelper.Unpack(stream, type);

        /// <inheritdoc />
        public Task<string> SerializeAsync<T>(T o) => JsonHelper.SerializeAsync(o);

        /// <inheritdoc />
        public Task<Stream> SerializeToStreamAsync<T>(T o) => JsonHelper.PackAsync(o);

        /// <inheritdoc />
        public Task<T> DeserializeAsync<T>(string data) => JsonHelper.DeserializeAsync<T>(data);

        /// <inheritdoc />
        public Task<object> DeserializeAsync(string data, Type type) => JsonHelper.DeserializeAsync(data, type);

        /// <inheritdoc />
        public Task<T> DeserializeFromStreamAsync<T>(Stream stream) => JsonHelper.UnpackAsync<T>(stream);

        /// <inheritdoc />
        public Task<object> DeserializeFromStreamAsync(Stream stream, Type type) => JsonHelper.UnpackAsync(stream, type);
    }
}