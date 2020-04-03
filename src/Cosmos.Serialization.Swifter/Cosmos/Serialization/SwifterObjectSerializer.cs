using System;
using System.IO;
using System.Threading.Tasks;
using Cosmos.Serialization.Json.Swifter;

namespace Cosmos.Serialization {
    /// <summary>
    /// SwiftJson Serializer
    /// </summary>
    public class SwifterObjectSerializer : IJsonSerializer {
        /// <inheritdoc />
        public string Serialize<T>(T o) => SwifterHelper.Serialize(o);

        /// <inheritdoc />
        public Stream SerializeToStream<T>(T o) => SwifterHelper.Pack(o);

        /// <inheritdoc />
        public T Deserialize<T>(string json) => SwifterHelper.Deserialize<T>(json);

        /// <inheritdoc />
        public object Deserialize(string json, Type type) => SwifterHelper.Deserialize(json, type);

        /// <inheritdoc />
        public T DeserializeFromStream<T>(Stream stream) => SwifterHelper.Unpack<T>(stream);

        /// <inheritdoc />
        public object DeserializeFromStream(Stream stream, Type type) => SwifterHelper.Unpack(stream, type);

        /// <inheritdoc />
        public Task<string> SerializeAsync<T>(T o) => SwifterHelper.SerializeAsync(o);

        /// <inheritdoc />
        public Task<Stream> SerializeToStreamAsync<T>(T o) => SwifterHelper.PackAsync(o);

        /// <inheritdoc />
        public Task<T> DeserializeAsync<T>(string data) => SwifterHelper.DeserializeAsync<T>(data);

        /// <inheritdoc />
        public Task<object> DeserializeAsync(string data, Type type) => SwifterHelper.DeserializeAsync(data, type);

        /// <inheritdoc />
        public Task<T> DeserializeFromStreamAsync<T>(Stream stream) => SwifterHelper.UnpackAsync<T>(stream);

        /// <inheritdoc />
        public Task<object> DeserializeFromStreamAsync(Stream stream, Type type) => SwifterHelper.UnpackAsync(stream, type);
    }
}