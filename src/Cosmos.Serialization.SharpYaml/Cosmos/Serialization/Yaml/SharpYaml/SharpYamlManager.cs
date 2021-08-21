using System.Text;
using SharpYaml.Serialization;

namespace Cosmos.Serialization.Yaml.SharpYaml
{
    /// <summary>
    /// SharpYaml manager
    /// </summary>
    public static class SharpYamlManager
    {
        private static Encoding _encoding = Encoding.UTF8;
        private static SerializerSettings _settings = new();
        private static Serializer _serializer = new(_settings);

        /// <summary>
        /// Gets or sets default Newtonsoft Json serializer settings
        /// </summary>
        public static SerializerSettings DefaultSettings
        {
            get => _settings;
            set => _settings = value ?? _settings;
        }

        /// <summary>
        /// Gets default SharpYaml serializer
        /// </summary>
        public static Serializer DefaultSerializer
        {
            get => _serializer;
            set => _serializer = value ?? _serializer;
        }

        /// <summary>
        /// Gets or sets default encoding
        /// </summary>
        public static Encoding DefaultEncoding
        {
            get => _encoding;
            set => _encoding = value ?? _encoding;
        }
    }
}