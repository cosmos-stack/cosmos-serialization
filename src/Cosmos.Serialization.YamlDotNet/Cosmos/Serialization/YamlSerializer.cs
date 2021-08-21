using System;
using System.IO;
using System.Threading.Tasks;
using Cosmos.Serialization.Yaml.YamlDotNet;
using S = YamlDotNet.Serialization.ISerializer;
using D = YamlDotNet.Serialization.IDeserializer;

namespace Cosmos.Serialization
{
    /// <summary>
    /// Yaml Serializer
    /// </summary>
    public class YamlSerializer : IYamlSerializer
    {
        private readonly S _serializer;
        private readonly D _deserializer;

        public YamlSerializer()
        {
            _serializer = YamlManager.DefaultSerializer;
            _deserializer = YamlManager.DefaultDeserializer;
        }

        public YamlSerializer(S serializer, D deserializer)
        {
            _serializer = serializer ?? YamlManager.DefaultSerializer;
            _deserializer = deserializer ?? YamlManager.DefaultDeserializer;
        }

        /// <inheritdoc />
        public string Serialize<T>(T o)
        {
            return YamlHelper.Serialize(o, _serializer);
        }

        /// <inheritdoc />
        public Stream SerializeToStream<T>(T o)
        {
            return YamlHelper.Pack(o, _serializer);
        }

        /// <inheritdoc />
        public T Deserialize<T>(string data)
        {
            return YamlHelper.Deserialize<T>(data, _deserializer);
        }

        /// <inheritdoc />
        public object Deserialize(string data, Type type)
        {
            return YamlHelper.Deserialize(data, type, _deserializer);
        }

        /// <inheritdoc />
        public T DeserializeFromStream<T>(Stream stream)
        {
            return YamlHelper.Unpack<T>(stream, _deserializer);
        }

        /// <inheritdoc />
        public object DeserializeFromStream(Stream stream, Type type)
        {
            return YamlHelper.Unpack(stream, type, _deserializer);
        }

        /// <inheritdoc />
        public Task<string> SerializeAsync<T>(T o)
        {
            return YamlHelper.SerializeAsync(o, _serializer);
        }

        /// <inheritdoc />
        public Task<Stream> SerializeToStreamAsync<T>(T o)
        {
            return YamlHelper.PackAsync(o, _serializer);
        }

        /// <inheritdoc />
        public Task<T> DeserializeAsync<T>(string data)
        {
            return YamlHelper.DeserializeAsync<T>(data, _deserializer);
        }

        /// <inheritdoc />
        public Task<object> DeserializeAsync(string data, Type type)
        {
            return YamlHelper.DeserializeAsync(data, type, _deserializer);
        }

        /// <inheritdoc />
        public Task<T> DeserializeFromStreamAsync<T>(Stream stream)
        {
            return YamlHelper.UnpackAsync<T>(stream, _deserializer);
        }

        /// <inheritdoc />
        public Task<object> DeserializeFromStreamAsync(Stream stream, Type type)
        {
            return YamlHelper.UnpackAsync(stream, type, _deserializer);
        }
    }
}