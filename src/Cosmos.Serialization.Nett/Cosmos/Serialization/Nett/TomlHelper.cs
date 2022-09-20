using System.Text;

namespace Cosmos.Serialization.Nett;

public static partial class TomlHelper
{
    /// <summary>
    /// Nett TOML manager
    /// </summary>
    private static class Man
    {
        private static Encoding _encoding = Encoding.UTF8;
        private static TomlSettings _settings = TomlSettings.Create();

        /// <summary>
        /// Gets or sets default TomlSettings
        /// </summary>
        public static TomlSettings DefaultSettings
        {
            get => _settings;
            set => _settings = value ?? _settings;
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

    public static TomlSettings GetDefaultSettings()
    {
        return Man.DefaultSettings;
    }

    public static void SetDefaultSettings(TomlSettings settings)
    {
        Man.DefaultSettings = settings;
    }

    public static Encoding GetDefaultEncoding()
    {
        return Man.DefaultEncoding;
    }

    public static void SetDefaultEncoding(Encoding encoding)
    {
        Man.DefaultEncoding = encoding;
    }

    private static Encoding ToEncoding(this Encoding encoding)
    {
        return encoding ??= Encoding.UTF8;
    }

    private static Task<T> Async<T>(Func<T> func, CancellationToken cancellationToken = default)
    {
        return Task.Run(func.Invoke, cancellationToken);
    }
}