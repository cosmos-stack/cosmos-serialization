using System;
using System.IO;
using System.Threading.Tasks;
using Cosmos.Serialization.Toml.Nett;
using Nett;

namespace Cosmos.Serialization
{
    /// <summary>
    /// Nett TOML Serializer
    /// </summary>
    public class NettSerializer : ITomlSerializer
    {
        private readonly TomlSettings _settings;

        public NettSerializer()
        {
            _settings = NettManager.DefaultSettings;
        }

        public NettSerializer(TomlSettings settings)
        {
            _settings = settings ?? NettManager.DefaultSettings;
        }

        /// <inheritdoc />
        public string Serialize<T>(T o)
        {
            return NettHelper.Serialize(o, _settings);
        }

        /// <inheritdoc />
        public Stream SerializeToStream<T>(T o)
        {
            return NettHelper.Pack(o, _settings);
        }

        /// <inheritdoc />
        public T Deserialize<T>(string data)
        {
            return NettHelper.Deserialize<T>(data, _settings);
        }

        /// <inheritdoc />
        public object Deserialize(string data, Type type)
        {
            return NettHelper.Deserialize(data, type, _settings);
        }

        /// <inheritdoc />
        public T DeserializeFromStream<T>(Stream stream)
        {
            return NettHelper.Unpack<T>(stream, _settings);
        }

        /// <inheritdoc />
        public object DeserializeFromStream(Stream stream, Type type)
        {
            return NettHelper.Unpack(stream, type, _settings);
        }

        /// <inheritdoc />
        public Task<string> SerializeAsync<T>(T o)
        {
            return NettHelper.SerializeAsync(o, _settings);
        }

        /// <inheritdoc />
        public Task<Stream> SerializeToStreamAsync<T>(T o)
        {
            return NettHelper.PackAsync(o, _settings);
        }

        /// <inheritdoc />
        public Task<T> DeserializeAsync<T>(string data)
        {
            return NettHelper.DeserializeAsync<T>(data, _settings);
        }

        /// <inheritdoc />
        public Task<object> DeserializeAsync(string data, Type type)
        {
            return NettHelper.DeserializeAsync(data, type, _settings);
        }

        /// <inheritdoc />
        public Task<T> DeserializeFromStreamAsync<T>(Stream stream)
        {
            return NettHelper.UnpackAsync<T>(stream, _settings);
        }

        /// <inheritdoc />
        public Task<object> DeserializeFromStreamAsync(Stream stream, Type type)
        {
            return NettHelper.UnpackAsync(stream, type, _settings);
        }
    }
}