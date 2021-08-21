using System;
using System.IO;
using System.Threading.Tasks;
using Cosmos.Serialization.Json.Newtonsoft;
using Newtonsoft.Json;
using JsonHelper = Cosmos.Serialization.Json.Newtonsoft.JsonHelper;

namespace Cosmos.Serialization
{
    /// <summary>
    /// Newtonsoft Json Serializer
    /// </summary>
    public class NewtonsoftJsonSerializer : IJsonSerializer
    {
        private readonly JsonSerializerSettings _settings;

        public NewtonsoftJsonSerializer()
        {
            _settings = JsonManager.DefaultSettings;
        }

        public NewtonsoftJsonSerializer(JsonSerializerSettings settings)
        {
            _settings = settings ?? JsonManager.DefaultSettings;
        }

        public NewtonsoftJsonSerializer(Func<JsonSerializerSettings> settingsFactory)
        {
            _settings = settingsFactory is null ? JsonManager.DefaultSettings : settingsFactory();
        }

        /// <inheritdoc />
        public string Serialize<T>(T o)
        {
            return JsonHelper.Serialize(o, _settings);
        }

        /// <inheritdoc />
        public Stream SerializeToStream<T>(T o)
        {
            return JsonHelper.Pack(o, _settings);
        }

        /// <inheritdoc />
        public T Deserialize<T>(string json)
        {
            return JsonHelper.Deserialize<T>(json, _settings);
        }

        /// <inheritdoc />
        public object Deserialize(string json, Type type)
        {
            return JsonHelper.Deserialize(json, type, _settings);
        }

        /// <inheritdoc />
        public T DeserializeFromStream<T>(Stream stream)
        {
            return JsonHelper.Unpack<T>(stream, _settings);
        }

        /// <inheritdoc />
        public object DeserializeFromStream(Stream stream, Type type)
        {
            return JsonHelper.Unpack(stream, type, _settings);
        }

        /// <inheritdoc />
        public Task<string> SerializeAsync<T>(T o)
        {
            return JsonHelper.SerializeAsync(o, _settings);
        }

        /// <inheritdoc />
        public Task<Stream> SerializeToStreamAsync<T>(T o)
        {
            return JsonHelper.PackAsync(o, _settings);
        }

        /// <inheritdoc />
        public Task<T> DeserializeAsync<T>(string data)
        {
            return JsonHelper.DeserializeAsync<T>(data, _settings);
        }

        /// <inheritdoc />
        public Task<object> DeserializeAsync(string data, Type type)
        {
            return JsonHelper.DeserializeAsync(data, type, _settings);
        }

        /// <inheritdoc />
        public Task<T> DeserializeFromStreamAsync<T>(Stream stream)
        {
            return JsonHelper.UnpackAsync<T>(stream, _settings);
        }

        /// <inheritdoc />
        public Task<object> DeserializeFromStreamAsync(Stream stream, Type type)
        {
            return JsonHelper.UnpackAsync(stream, type, _settings);
        }
    }
}