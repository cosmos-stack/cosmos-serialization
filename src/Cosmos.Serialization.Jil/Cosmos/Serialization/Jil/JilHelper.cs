using System.Text;

namespace Cosmos.Serialization.Jil;

public static partial class JilHelper
{
    /// <summary>
    /// Jil manager
    /// </summary>
    private static class Man
    {
        private static Encoding _encoding = Encoding.UTF8;

        private static Options _options = Options.Default;

        /// <summary>
        /// Gets or sets default encoding
        /// </summary>
        public static Encoding DefaultEncoding
        {
            get => _encoding;
            set => _encoding = value ?? _encoding;
        }

        /// <summary>
        /// Gets or sets default JilOptions
        /// </summary>
        public static Options DefaultOptions
        {
            get => _options;
            set => _options = value ?? _options;
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

    public static Options GetDefaultOptions()
    {
        return Man.DefaultOptions;
    }

    public static void SetDefaultOptions(Options options)
    {
        Man.DefaultOptions = options;
    }

    private static Options ToOptions(this Options options)
    {
        return options ?? Man.DefaultOptions;
    }

    private static Options GetOptions(this Action<Options> optionAct)
    {
        var options = new Options();
        optionAct?.Invoke(options);
        return options;
    }

    private static Encoding GetEncoding(this Encoding encoding)
    {
        return encoding ?? Man.DefaultEncoding;
    }
}