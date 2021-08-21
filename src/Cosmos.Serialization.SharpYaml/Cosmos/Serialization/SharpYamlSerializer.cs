using System;
using System.IO;
using System.Threading.Tasks;
using Cosmos.Serialization.Yaml.SharpYaml;
using SharpYaml.Serialization;

namespace Cosmos.Serialization
{
    /// <summary>
    /// SharpYaml Serializer
    /// </summary>
    public class SharpYamlSerializer : IYamlSerializer
    {
        private readonly Serializer _serializer;

        public SharpYamlSerializer()
        {
            _serializer = SharpYamlManager.DefaultSerializer;
        }

        public SharpYamlSerializer(SerializerSettings settings)
        {
            _serializer = settings is null
                ? SharpYamlManager.DefaultSerializer
                : new(settings);
        }

        public SharpYamlSerializer(Serializer serializer)
        {
            _serializer = serializer ?? SharpYamlManager.DefaultSerializer;
        }

        /// <inheritdoc />
        public string Serialize<T>(T o)
        {
            return SharpYamlHelper.Serialize(o, _serializer);
        }

        /// <inheritdoc />
        public Stream SerializeToStream<T>(T o)
        {
            return SharpYamlHelper.Pack(o, _serializer);
        }

        /// <inheritdoc />
        public T Deserialize<T>(string data)
        {
            return SharpYamlHelper.Deserialize<T>(data, _serializer);
        }

        /// <inheritdoc />
        public object Deserialize(string data, Type type)
        {
            return SharpYamlHelper.Deserialize(data, type, _serializer);
        }

        /// <inheritdoc />
        public T DeserializeFromStream<T>(Stream stream)
        {
            return SharpYamlHelper.Unpack<T>(stream, _serializer);
        }

        /// <inheritdoc />
        public object DeserializeFromStream(Stream stream, Type type)
        {
            return SharpYamlHelper.Unpack(stream, type, _serializer);
        }

        /// <inheritdoc />
        public Task<string> SerializeAsync<T>(T o)
        {
            return SharpYamlHelper.SerializeAsync(o, _serializer);
        }

        /// <inheritdoc />
        public Task<Stream> SerializeToStreamAsync<T>(T o)
        {
            return SharpYamlHelper.PackAsync(o, _serializer);
        }

        /// <inheritdoc />
        public Task<T> DeserializeAsync<T>(string data)
        {
            return SharpYamlHelper.DeserializeAsync<T>(data, _serializer);
        }

        /// <inheritdoc />
        public Task<object> DeserializeAsync(string data, Type type)
        {
            return SharpYamlHelper.DeserializeAsync(data, type, _serializer);
        }

        /// <inheritdoc />
        public Task<T> DeserializeFromStreamAsync<T>(Stream stream)
        {
            return SharpYamlHelper.UnpackAsync<T>(stream, _serializer);
        }

        /// <inheritdoc />
        public Task<object> DeserializeFromStreamAsync(Stream stream, Type type)
        {
            return SharpYamlHelper.UnpackAsync(stream, type, _serializer);
        }
    }
}