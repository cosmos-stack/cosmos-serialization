using System;
using System.IO;
using System.Threading.Tasks;
using Cosmos.Serialization.Yaml.YamlDotNet;

namespace Cosmos.Serialization {
    /// <summary>
    /// Yaml Serializer
    /// </summary>
    public class YamlSerializer : IYamlSerializer {

        /// <inheritdoc />
        public string Serialize<T>(T o) => YamlHelper.Serialize(o);

        /// <inheritdoc />
        public Stream SerializeToStream<T>(T o) => YamlHelper.Pack(o);

        /// <inheritdoc />
        public T Deserialize<T>(string data) => YamlHelper.Deserialize<T>(data);

        /// <inheritdoc />
        public object Deserialize(string data, Type type) => YamlHelper.Deserialize(data, type);

        /// <inheritdoc />
        public T DeserializeFromStream<T>(Stream stream) => YamlHelper.Unpack<T>(stream);

        /// <inheritdoc />
        public object DeserializeFromStream(Stream stream, Type type) => YamlHelper.Unpack(stream, type);

        /// <inheritdoc />
        public Task<string> SerializeAsync<T>(T o) => YamlHelper.SerializeAsync(o);

        /// <inheritdoc />
        public Task<Stream> SerializeToStreamAsync<T>(T o) => YamlHelper.PackAsync(o);

        /// <inheritdoc />
        public Task<T> DeserializeAsync<T>(string data) => YamlHelper.DeserializeAsync<T>(data);

        /// <inheritdoc />
        public Task<object> DeserializeAsync(string data, Type type) => YamlHelper.DeserializeAsync(data, type);

        /// <inheritdoc />
        public Task<T> DeserializeFromStreamAsync<T>(Stream stream) => YamlHelper.UnpackAsync<T>(stream);

        /// <inheritdoc />
        public Task<object> DeserializeFromStreamAsync(Stream stream, Type type) => YamlHelper.UnpackAsync(stream, type);
    }
}