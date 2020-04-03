using System;
using System.IO;
using System.Threading.Tasks;
using Cosmos.Serialization.Toml.Nett;

namespace Cosmos.Serialization {
    /// <summary>
    /// Nett TOML Serializer
    /// </summary>
    public class NettSerializer : ITomlSerializer {

        /// <inheritdoc />
        public string Serialize<T>(T o) => NettHelper.Serialize(o);

        /// <inheritdoc />
        public Stream SerializeToStream<T>(T o) => NettHelper.Pack(o);

        /// <inheritdoc />
        public T Deserialize<T>(string data) => NettHelper.Deserialize<T>(data);

        /// <inheritdoc />
        public object Deserialize(string data, Type type) => NettHelper.Deserialize(data, type);

        /// <inheritdoc />
        public T DeserializeFromStream<T>(Stream stream) => NettHelper.Unpack<T>(stream);

        /// <inheritdoc />
        public object DeserializeFromStream(Stream stream, Type type) => NettHelper.Unpack(stream, type);

        /// <inheritdoc />
        public Task<string> SerializeAsync<T>(T o) => NettHelper.SerializeAsync(o);

        /// <inheritdoc />
        public Task<Stream> SerializeToStreamAsync<T>(T o) => NettHelper.PackAsync(o);

        /// <inheritdoc />
        public Task<T> DeserializeAsync<T>(string data) => NettHelper.DeserializeAsync<T>(data);

        /// <inheritdoc />
        public Task<object> DeserializeAsync(string data, Type type) => NettHelper.DeserializeAsync(data, type);

        /// <inheritdoc />
        public Task<T> DeserializeFromStreamAsync<T>(Stream stream) => NettHelper.UnpackAsync<T>(stream);

        /// <inheritdoc />
        public Task<object> DeserializeFromStreamAsync(Stream stream, Type type) => NettHelper.UnpackAsync(stream, type);
    }
}