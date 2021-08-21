using System;
using System.IO;
using System.Threading.Tasks;
using Cosmos.Serialization.Json.FastJson;
using fastJSON;

namespace Cosmos.Serialization
{
    /// <summary>
    /// FastJson serializer
    /// </summary>
    public class FastJsonObjectSerializer : IJsonSerializer
    {
        private readonly JSONParameters _options;

        public FastJsonObjectSerializer()
        {
            _options = FastJsonManager.DefaultParameters;
        }

        public FastJsonObjectSerializer(JSONParameters options)
        {
            _options = options ?? FastJsonManager.DefaultParameters;
        }

        public FastJsonObjectSerializer(Func<JSONParameters> optionsFactory)
        {
            _options = optionsFactory is null ? FastJsonManager.DefaultParameters : optionsFactory();
        }

        /// <inheritdoc />
        public string Serialize<T>(T o)
        {
            return FastJsonHelper.Serialize(o, _options);
        }

        /// <inheritdoc />
        public Stream SerializeToStream<T>(T o)
        {
            return FastJsonHelper.Pack(o, _options);
        }

        /// <inheritdoc />
        public T Deserialize<T>(string json)
        {
            return FastJsonHelper.Deserialize<T>(json, _options);
        }

        /// <inheritdoc />
        public object Deserialize(string json, Type type)
        {
            return FastJsonHelper.Deserialize(json, type, _options);
        }

        /// <inheritdoc />
        public T DeserializeFromStream<T>(Stream stream)
        {
            return FastJsonHelper.Unpack<T>(stream, _options);
        }

        /// <inheritdoc />
        public object DeserializeFromStream(Stream stream, Type type)
        {
            return FastJsonHelper.Unpack(stream, type, _options);
        }

        /// <inheritdoc />
        public Task<string> SerializeAsync<T>(T o)
        {
            return FastJsonHelper.SerializeAsync(o, _options);
        }

        /// <inheritdoc />
        public Task<Stream> SerializeToStreamAsync<T>(T o)
        {
            return FastJsonHelper.PackAsync(o, _options);
        }

        /// <inheritdoc />
        public Task<T> DeserializeAsync<T>(string data)
        {
            return FastJsonHelper.DeserializeAsync<T>(data, _options);
        }

        /// <inheritdoc />
        public Task<object> DeserializeAsync(string data, Type type)
        {
            return FastJsonHelper.DeserializeAsync(data, type, _options);
        }

        /// <inheritdoc />
        public Task<T> DeserializeFromStreamAsync<T>(Stream stream)
        {
            return FastJsonHelper.UnpackAsync<T>(stream, _options);
        }

        /// <inheritdoc />
        public Task<object> DeserializeFromStreamAsync(Stream stream, Type type)
        {
            return FastJsonHelper.UnpackAsync(stream, type, _options);
        }
    }
}