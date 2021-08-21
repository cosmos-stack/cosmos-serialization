using System;
using System.IO;
using System.Threading.Tasks;
using Cosmos.Serialization.Json.Swifter;
using Swifter.Json;

namespace Cosmos.Serialization
{
    /// <summary>
    /// SwiftJson Serializer
    /// </summary>
    public class SwifterJsonSerializer : IJsonSerializer
    {
        private readonly JsonFormatterOptions _options1;
        private readonly JsonFormatterOptions _options2;

        public SwifterJsonSerializer()
        {
            _options1 = SwifterJsonManager.DefaultOptions;
            _options2 = SwifterJsonManager.DefaltDeserializeOptions;
        }

        public SwifterJsonSerializer(JsonFormatterOptions? options1, JsonFormatterOptions? options2)
        {
            _options1 = options1 ?? SwifterJsonManager.DefaultOptions;
            _options2 = options2 ?? SwifterJsonManager.DefaltDeserializeOptions;
        }

        public SwifterJsonSerializer(Func<JsonFormatterOptions> optionsFactory1, Func<JsonFormatterOptions> optionsFactory2)
        {
            _options1 = optionsFactory1?.Invoke() ?? SwifterJsonManager.DefaultOptions;
            _options2 = optionsFactory2?.Invoke() ?? SwifterJsonManager.DefaltDeserializeOptions;
        }

        /// <inheritdoc />
        public string Serialize<T>(T o)
        {
            return SwifterHelper.Serialize(o, _options1);
        }

        /// <inheritdoc />
        public Stream SerializeToStream<T>(T o)
        {
            return SwifterHelper.Pack(o, _options1);
        }

        /// <inheritdoc />
        public T Deserialize<T>(string json)
        {
            return SwifterHelper.Deserialize<T>(json, _options2);
        }

        /// <inheritdoc />
        public object Deserialize(string json, Type type)
        {
            return SwifterHelper.Deserialize(json, type);
        }

        /// <inheritdoc />
        public T DeserializeFromStream<T>(Stream stream)
        {
            return SwifterHelper.Unpack<T>(stream, _options2);
        }

        /// <inheritdoc />
        public object DeserializeFromStream(Stream stream, Type type)
        {
            return SwifterHelper.Unpack(stream, type, _options2);
        }

        /// <inheritdoc />
        public Task<string> SerializeAsync<T>(T o)
        {
            return SwifterHelper.SerializeAsync(o, _options1);
        }

        /// <inheritdoc />
        public Task<Stream> SerializeToStreamAsync<T>(T o)
        {
            return SwifterHelper.PackAsync(o, _options1);
        }

        /// <inheritdoc />
        public Task<T> DeserializeAsync<T>(string data)
        {
            return SwifterHelper.DeserializeAsync<T>(data, _options2);
        }

        /// <inheritdoc />
        public Task<object> DeserializeAsync(string data, Type type)
        {
            return SwifterHelper.DeserializeAsync(data, type, _options2);
        }

        /// <inheritdoc />
        public Task<T> DeserializeFromStreamAsync<T>(Stream stream)
        {
            return SwifterHelper.UnpackAsync<T>(stream, _options2);
        }

        /// <inheritdoc />
        public Task<object> DeserializeFromStreamAsync(Stream stream, Type type)
        {
            return SwifterHelper.UnpackAsync(stream, type, _options2);
        }
    }
}