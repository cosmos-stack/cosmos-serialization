using System;
using System.IO;
using System.Threading.Tasks;
using Cosmos.Serialization.Json.MicrosoftJson;

namespace Cosmos.Serialization {
    /// <summary>
    /// Microsoft System.Text.Json object serializer
    /// </summary>
    public class MicrosoftJsonObjectSerializer : IJsonSerializer {
        /// <inheritdoc />
        public string Serialize<T>(T o) => MicrosoftJsonHelper.Serialize(o);

        /// <inheritdoc />
        public Stream SerializeToStream<T>(T o) => MicrosoftJsonHelper.Pack(o);

        /// <inheritdoc />
        public T Deserialize<T>(string json) => MicrosoftJsonHelper.Deserialize<T>(json);

        /// <inheritdoc />
        public object Deserialize(string json, Type type) => MicrosoftJsonHelper.Deserialize(json, type);

        /// <inheritdoc />
        public T DeserializeFromStream<T>(Stream stream) => MicrosoftJsonHelper.Unpack<T>(stream);

        /// <inheritdoc />
        public object DeserializeFromStream(Stream stream, Type type) => MicrosoftJsonHelper.Unpack(stream, type);

        /// <inheritdoc />
        public Task<string> SerializeAsync<T>(T o) => MicrosoftJsonHelper.SerializeAsync(o);

        /// <inheritdoc />
        public Task<Stream> SerializeToStreamAsync<T>(T o) => MicrosoftJsonHelper.PackAsync(o);

        /// <inheritdoc />
        public Task<T> DeserializeAsync<T>(string data) => MicrosoftJsonHelper.DeserializeAsync<T>(data);

        /// <inheritdoc />
        public Task<object> DeserializeAsync(string data, Type type) => MicrosoftJsonHelper.DeserializeAsync(data, type);

        /// <inheritdoc />
        public Task<T> DeserializeFromStreamAsync<T>(Stream stream) => MicrosoftJsonHelper.UnpackAsync<T>(stream);

        /// <inheritdoc />
        public Task<object> DeserializeFromStreamAsync(Stream stream, Type type) => MicrosoftJsonHelper.UnpackAsync(stream, type);
    }
}