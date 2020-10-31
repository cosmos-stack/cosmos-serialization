using Bssom.Serializer;

namespace Cosmos.Serialization.Binary.Bssom
{
    public class BssomManager
    {
        private static BssomSerializerOptions _serializerOptions = BssomSerializerOptions.Default;
        
        /// <summary>
        /// Gets or sets default JilOptions
        /// </summary>
        public static BssomSerializerOptions DefaultOptions
        {
            get => _serializerOptions;
            set => _serializerOptions = value ?? _serializerOptions;
        }
    }
}