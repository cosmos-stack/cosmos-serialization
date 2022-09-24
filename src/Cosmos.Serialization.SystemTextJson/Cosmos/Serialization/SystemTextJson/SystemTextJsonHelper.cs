using System.Text.Json;

namespace Cosmos.Serialization.SystemTextJson;

public static partial class SystemTextJsonHelper
{
    /// <summary>
    /// Microsoft System.Text.Json manager
    /// </summary>
    private static class Man
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

    public static JsonSerializerOptions GetDefaultOptions()
    {
        return Man.DefaultOptions;
    }

    public static void SetDefaultOptions(JsonSerializerOptions options)
    {
        Man.DefaultOptions = options;
    }

    private static JsonSerializerOptions ToOptions(this JsonSerializerOptions options)
    {
        return options ?? Man.DefaultOptions;
    }

    private static JsonSerializerOptions GetOptions(this Action<JsonSerializerOptions> optionAct)
    {
        var options = new JsonSerializerOptions();
        optionAct?.Invoke(options);
        return options;
    }
}