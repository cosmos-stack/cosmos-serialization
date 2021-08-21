using System;
using System.IO;
using System.Threading.Tasks;
using Cosmos.Serialization.Json.Jil;
using Jil;

namespace Cosmos.Serialization
{
    /// <summary>
    /// Jil serializer
    /// </summary>
    public class JilObjectSerializer : IJsonSerializer
    {
        private readonly Options _options;

        public JilObjectSerializer()
        {
            _options = JilManager.DefaultOptions;
        }

        public JilObjectSerializer(Options options)
        {
            _options = options ?? JilManager.DefaultOptions;
        }

        public JilObjectSerializer(Func<Options> optionsFactory)
        {
            _options = optionsFactory is null ? JilManager.DefaultOptions : optionsFactory();
        }

        /// <inheritdoc />
        public string Serialize<T>(T o)
        {
            return JilHelper.Serialize(o, _options);
        }

        /// <inheritdoc />
        public Stream SerializeToStream<T>(T o)
        {
            return JilHelper.Pack(o, _options);
        }

        /// <inheritdoc />
        public T Deserialize<T>(string json)
        {
            return JilHelper.Deserialize<T>(json, _options);
        }

        /// <inheritdoc />
        public object Deserialize(string json, Type type)
        {
            return JilHelper.Deserialize(json, type, _options);
        }

        /// <inheritdoc />
        public T DeserializeFromStream<T>(Stream stream)
        {
            return JilHelper.Unpack<T>(stream, _options);
        }

        /// <inheritdoc />
        public object DeserializeFromStream(Stream stream, Type type)
        {
            return JilHelper.Unpack(stream, type, _options);
        }

        /// <inheritdoc />
        public Task<string> SerializeAsync<T>(T o)
        {
            return JilHelper.SerializeAsync(o, _options);
        }

        /// <inheritdoc />
        public Task<Stream> SerializeToStreamAsync<T>(T o)
        {
            return JilHelper.PackAsync(o, _options);
        }

        /// <inheritdoc />
        public Task<T> DeserializeAsync<T>(string data)
        {
            return JilHelper.DeserializeAsync<T>(data, _options);
        }

        /// <inheritdoc />
        public Task<object> DeserializeAsync(string data, Type type)
        {
            return JilHelper.DeserializeAsync(data, type, _options);
        }

        /// <inheritdoc />
        public Task<T> DeserializeFromStreamAsync<T>(Stream stream)
        {
            return JilHelper.UnpackAsync<T>(stream, _options);
        }

        /// <inheritdoc />
        public Task<object> DeserializeFromStreamAsync(Stream stream, Type type)
        {
            return JilHelper.UnpackAsync(stream, type, _options);
        }
    }
}