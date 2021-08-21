using System;
using System.IO;
using System.Threading.Tasks;
using Cosmos.Serialization.Json.Kooboo;
using Kooboo.Json;

namespace Cosmos.Serialization
{
    /// <summary>
    /// Kooboo Serializer
    /// </summary>
    // ReSharper disable once IdentifierTypo
    public class KoobooObjectSerializer : IJsonSerializer
    {
        private readonly JsonSerializerOption _options1;
        private readonly JsonDeserializeOption _options2;

        public KoobooObjectSerializer()
        {
            _options1 = KoobooManager.DefaultSerializerOptions;
            _options2 = KoobooManager.DefaultDeserializeOptions;
        }

        public KoobooObjectSerializer(JsonSerializerOption options1, JsonDeserializeOption options2)
        {
            _options1 = options1 ?? KoobooManager.DefaultSerializerOptions;
            _options2 = options2 ?? KoobooManager.DefaultDeserializeOptions;
        }

        public KoobooObjectSerializer(Func<JsonSerializerOption> optionsFactory1, Func<JsonDeserializeOption> optionsFactory2)
        {
            _options1 = optionsFactory1 is null ? KoobooManager.DefaultSerializerOptions : optionsFactory1();
            _options2 = optionsFactory2 is null ? KoobooManager.DefaultDeserializeOptions : optionsFactory2();
        }

        /// <inheritdoc />
        public string Serialize<T>(T o)
        {
            return KoobooJsonHelper.Serialize(o, _options1);
        }

        /// <inheritdoc />
        public Stream SerializeToStream<T>(T o)
        {
            return KoobooJsonHelper.Pack(o, _options1);
        }

        /// <inheritdoc />
        public T Deserialize<T>(string json)
        {
            return KoobooJsonHelper.Deserialize<T>(json, _options2);
        }

        /// <inheritdoc />
        public object Deserialize(string json, Type type)
        {
            return KoobooJsonHelper.Deserialize(json, type, _options2);
        }

        /// <inheritdoc />
        public T DeserializeFromStream<T>(Stream stream)
        {
            return KoobooJsonHelper.Unpack<T>(stream, _options2);
        }

        /// <inheritdoc />
        public object DeserializeFromStream(Stream stream, Type type)
        {
            return KoobooJsonHelper.Unpack(stream, type, _options2);
        }

        /// <inheritdoc />
        public Task<string> SerializeAsync<T>(T o)
        {
            return KoobooJsonHelper.SerializeAsync(o, _options1);
        }

        /// <inheritdoc />
        public Task<Stream> SerializeToStreamAsync<T>(T o)
        {
            return KoobooJsonHelper.PackAsync(o, _options1);
        }

        /// <inheritdoc />
        public Task<T> DeserializeAsync<T>(string data)
        {
            return KoobooJsonHelper.DeserializeAsync<T>(data, _options2);
        }

        /// <inheritdoc />
        public Task<object> DeserializeAsync(string data, Type type)
        {
            return KoobooJsonHelper.DeserializeAsync(data, type, _options2);
        }

        /// <inheritdoc />
        public Task<T> DeserializeFromStreamAsync<T>(Stream stream)
        {
            return KoobooJsonHelper.UnpackAsync<T>(stream, _options2);
        }

        /// <inheritdoc />
        public Task<object> DeserializeFromStreamAsync(Stream stream, Type type)
        {
            return KoobooJsonHelper.UnpackAsync(stream, type, _options2);
        }
    }
}