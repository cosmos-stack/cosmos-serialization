using System.Text;
using fastJSON;

namespace Cosmos.Serialization.Json.FastJson
{
    /// <summary>
    /// Jil manager
    /// </summary>
    public static class FastJsonManager
    {
        private static Encoding _encoding = Encoding.UTF8;

        private static JSONParameters _options = new();
        
        /// <summary>
        /// Gets or sets default encoding
        /// </summary>
        public static Encoding DefaultEncoding
        {
            get => _encoding;
            set => _encoding = value ?? _encoding;
        }

        /// <summary>
        /// Gets or sets default JSONParameters
        /// </summary>
        public static JSONParameters DefaultParameters
        {
            get => _options;
            set => _options = value ?? _options;
        }
    }
}