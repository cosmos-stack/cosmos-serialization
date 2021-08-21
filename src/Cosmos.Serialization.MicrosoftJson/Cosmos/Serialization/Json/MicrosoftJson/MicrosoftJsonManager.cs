using System.Text.Json;

namespace Cosmos.Serialization.Json.MicrosoftJson
{
    /// <summary>
    /// Microsoft System.Text.Json manager
    /// </summary>
    public static class MicrosoftJsonManager
    {
        private static JsonSerializerOptions _options = new();

        /// <summary>
        /// Gets or sets default json serializer options
        /// </summary>
        public static JsonSerializerOptions DefaultOptions
        {
            get => _options;
            set => _options = value ?? _options;
        }
    }
}