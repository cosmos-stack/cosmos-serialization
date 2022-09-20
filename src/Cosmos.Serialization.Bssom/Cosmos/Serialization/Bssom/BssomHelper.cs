namespace Cosmos.Serialization.Bssom;

/// <summary>
/// Bssom Helper
/// </summary>
public static partial class BssomHelper
{
    private class Man
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

    public static void SetDefaultOptions(BssomSerializerOptions options)
    {
        Man.DefaultOptions = options;
    }

    public static BssomSerializerOptions GetDefaultOptions()
    {
        return Man.DefaultOptions;
    }

    private static BssomSerializerOptions ToOptions(this Action<BssomSerializerOptions> optionAct)
    {
        var options = BssomSerializerOptions.Default;
        optionAct?.Invoke(options);
        return options;
    }
}