using System.Text;
using NodaTime;
using NodaTime.Serialization.JsonNet;

namespace Cosmos.Serialization.Newtonsoft;

public static partial class NewtonsoftJsonHelper
{
    /// <summary>
    /// Newtonsoft Json manager
    /// </summary>
    private static class Man
    {
        private static Encoding _encoding = Encoding.UTF8;

        private static JsonSerializerSettings _settings = new();

        private static JsonSerializerSettings _settingsWithNodaTime = new JsonSerializerSettings().ConfigureForNodaTime(DateTimeZoneProviders.Tzdb);

        /// <summary>
        /// Gets or sets default encoding
        /// </summary>
        public static Encoding DefaultEncoding
        {
            get => _encoding;
            set => _encoding = value ?? _encoding;
        }

        /// <summary>
        /// Gets or sets default Newtonsoft Json serializer settings
        /// </summary>
        public static JsonSerializerSettings DefaultSettings
        {
            get => _settings;
            set => _settings = value ?? _settings;
        }

        /// <summary>
        /// Gets or sets default Newtonsoft Json serializer settings with NodaTime
        /// </summary>
        public static JsonSerializerSettings DefaultSettingsWithNodaTime
        {
            get => _settingsWithNodaTime;
            set => _settingsWithNodaTime = value ?? _settingsWithNodaTime;
        }
    }

    public static Encoding GetDefaultEncoding()
    {
        return Man.DefaultEncoding;
    }

    public static void SetDefaultEncoding(Encoding encoding)
    {
        Man.DefaultEncoding = encoding;
    }

    public static JsonSerializerSettings GetDefaultSettings()
    {
        return Man.DefaultSettings;
    }

    public static void SetDefaultSettings(JsonSerializerSettings settings)
    {
        Man.DefaultSettings = settings;
    }

    public static JsonSerializerSettings GetDefaultSettingsWithNodaTime()
    {
        return Man.DefaultSettingsWithNodaTime;
    }

    public static void SetDefaultSettingsWithNodaTime(JsonSerializerSettings settings)
    {
        Man.DefaultSettingsWithNodaTime = settings;
    }

    private static JsonSerializerSettings ToSettings(this JsonSerializerSettings settings, bool enableNodaTime)
    {
        if (settings is null)
        {
            return enableNodaTime
                ? Man.DefaultSettingsWithNodaTime
                : Man.DefaultSettings;
        }

        UseNodaTimeIfNeed(settings, enableNodaTime);

        return settings;
    }

    private static void UseNodaTimeIfNeed(this JsonSerializerSettings settings, bool enableNodaTime)
    {
        if (enableNodaTime)
        {
            settings.ConfigureForNodaTime(DateTimeZoneProviders.Tzdb);
        }
    }

    private static Encoding GetEncoding(this Encoding encoding)
    {
        return encoding ?? Man.DefaultEncoding;
    }
}