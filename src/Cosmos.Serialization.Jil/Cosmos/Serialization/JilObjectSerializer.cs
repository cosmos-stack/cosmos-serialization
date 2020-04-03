using System;
using System.IO;
using System.Threading.Tasks;
using Cosmos.Serialization.Json.Jil;

namespace Cosmos.Serialization {
    /// <summary>
    /// Jil serializer
    /// </summary>
    public class JilObjectSerializer : IJsonSerializer {
        /// <inheritdoc />
        public string Serialize<T>(T o) => JilHelper.Serialize(o);

        /// <inheritdoc />
        public Stream SerializeToStream<T>(T o) => JilHelper.Pack(o);

        /// <inheritdoc />
        public T Deserialize<T>(string json) => JilHelper.Deserialize<T>(json);

        /// <inheritdoc />
        public object Deserialize(string json, Type type) => JilHelper.Deserialize(json, type);

        /// <inheritdoc />
        public T DeserializeFromStream<T>(Stream stream) => JilHelper.Unpack<T>(stream);

        /// <inheritdoc />
        public object DeserializeFromStream(Stream stream, Type type) => JilHelper.Unpack(stream, type);

        /// <inheritdoc />
        public Task<string> SerializeAsync<T>(T o) => JilHelper.SerializeAsync(o);

        /// <inheritdoc />
        public Task<Stream> SerializeToStreamAsync<T>(T o) => JilHelper.PackAsync(o);

        /// <inheritdoc />
        public Task<T> DeserializeAsync<T>(string data) => JilHelper.DeserializeAsync<T>(data);

        /// <inheritdoc />
        public Task<object> DeserializeAsync(string data, Type type) => JilHelper.DeserializeAsync(data, type);

        /// <inheritdoc />
        public Task<T> DeserializeFromStreamAsync<T>(Stream stream) => JilHelper.UnpackAsync<T>(stream);

        /// <inheritdoc />
        public Task<object> DeserializeFromStreamAsync(Stream stream, Type type) => JilHelper.UnpackAsync(stream, type);
    }
}