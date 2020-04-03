using System;
using System.IO;
using System.Threading.Tasks;
using Cosmos.Serialization.Yaml.SharpYaml;

namespace Cosmos.Serialization {
    /// <summary>
    /// SharpYaml Serializer
    /// </summary>
    public class SharpYamlSerializer : IYamlSerializer {

        /// <inheritdoc />
        public string Serialize<T>(T o) => SharpYamlHelper.Serialize(o);

        /// <inheritdoc />
        public Stream SerializeToStream<T>(T o) => SharpYamlHelper.Pack(o);

        /// <inheritdoc />
        public T Deserialize<T>(string data) => SharpYamlHelper.Deserialize<T>(data);

        /// <inheritdoc />
        public object Deserialize(string data, Type type) => SharpYamlHelper.Deserialize(data, type);

        /// <inheritdoc />
        public T DeserializeFromStream<T>(Stream stream) => SharpYamlHelper.Unpack<T>(stream);

        /// <inheritdoc />
        public object DeserializeFromStream(Stream stream, Type type) => SharpYamlHelper.Unpack(stream, type);

        /// <inheritdoc />
        public Task<string> SerializeAsync<T>(T o) => SharpYamlHelper.SerializeAsync(o);

        /// <inheritdoc />
        public Task<Stream> SerializeToStreamAsync<T>(T o) => SharpYamlHelper.PackAsync(o);

        /// <inheritdoc />
        public Task<T> DeserializeAsync<T>(string data) => SharpYamlHelper.DeserializeAsync<T>(data);

        /// <inheritdoc />
        public Task<object> DeserializeAsync(string data, Type type) => SharpYamlHelper.DeserializeAsync(data, type);

        /// <inheritdoc />
        public Task<T> DeserializeFromStreamAsync<T>(Stream stream) => SharpYamlHelper.UnpackAsync<T>(stream);

        /// <inheritdoc />
        public Task<object> DeserializeFromStreamAsync(Stream stream, Type type) => SharpYamlHelper.UnpackAsync(stream, type);
    }
}