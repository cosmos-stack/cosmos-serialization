using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using Cosmos.Serialization.Json.MicrosoftJson;

namespace Cosmos.Serialization
{
    /// <summary>
    /// Microsoft System.Text.Json object serializer
    /// </summary>
    public class MicrosoftJsonObjectSerializer : IJsonSerializer
    {
        private readonly JsonSerializerOptions _options;

        public MicrosoftJsonObjectSerializer()
        {
            _options = MicrosoftJsonManager.DefaultOptions;
        }

        public MicrosoftJsonObjectSerializer(JsonSerializerOptions options)
        {
            _options = options ?? MicrosoftJsonManager.DefaultOptions;
        }

        public MicrosoftJsonObjectSerializer(Func<JsonSerializerOptions> optionsFactory)
        {
            _options = optionsFactory is null ? MicrosoftJsonManager.DefaultOptions : optionsFactory();
        }

        /// <inheritdoc />
        public string Serialize<T>(T o)
        {
            return MicrosoftJsonHelper.Serialize(o, _options);
        }

        /// <inheritdoc />
        public Stream SerializeToStream<T>(T o)
        {
            return MicrosoftJsonHelper.Pack(o, _options);
        }

        /// <inheritdoc />
        public T Deserialize<T>(string json)
        {
            return MicrosoftJsonHelper.Deserialize<T>(json, _options);
        }

        /// <inheritdoc />
        public object Deserialize(string json, Type type)
        {
            return MicrosoftJsonHelper.Deserialize(json, type, _options);
        }

        /// <inheritdoc />
        public T DeserializeFromStream<T>(Stream stream)
        {
            return MicrosoftJsonHelper.Unpack<T>(stream, _options);
        }

        /// <inheritdoc />
        public object DeserializeFromStream(Stream stream, Type type)
        {
            return MicrosoftJsonHelper.Unpack(stream, type, _options);
        }

        /// <inheritdoc />
        public Task<string> SerializeAsync<T>(T o)
        {
            return MicrosoftJsonHelper.SerializeAsync(o, _options);
        }

        /// <inheritdoc />
        public Task<Stream> SerializeToStreamAsync<T>(T o)
        {
            return MicrosoftJsonHelper.PackAsync(o, _options);
        }

        /// <inheritdoc />
        public Task<T> DeserializeAsync<T>(string data)
        {
            return MicrosoftJsonHelper.DeserializeAsync<T>(data, _options);
        }

        /// <inheritdoc />
        public Task<object> DeserializeAsync(string data, Type type)
        {
            return MicrosoftJsonHelper.DeserializeAsync(data, type, _options);
        }

        /// <inheritdoc />
        public Task<T> DeserializeFromStreamAsync<T>(Stream stream)
        {
            return MicrosoftJsonHelper.UnpackAsync<T>(stream, _options);
        }

        /// <inheritdoc />
        public Task<object> DeserializeFromStreamAsync(Stream stream, Type type)
        {
            return MicrosoftJsonHelper.UnpackAsync(stream, type, _options);
        }
    }
}