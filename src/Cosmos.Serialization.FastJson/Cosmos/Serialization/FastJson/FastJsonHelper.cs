using System.Text;

namespace Cosmos.Serialization.FastJson;

public static partial class FastJsonHelper
{
    /// <summary>
    /// FastJson manager
    /// </summary>
    public static class Man
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

    public static Encoding GetDefaultEncoding()
    {
        return Man.DefaultEncoding;
    }

    public static void SetDefaultEncoding(Encoding encoding)
    {
        Man.DefaultEncoding = encoding;
    }

    public static JSONParameters GetDefaultParameters()
    {
        return Man.DefaultParameters;
    }

    public static void SetDefaultParameters(JSONParameters parameters)
    {
        Man.DefaultParameters = parameters;
    }

    private static JSONParameters ToParams(this JSONParameters parameters)
    {
        return parameters ?? Man.DefaultParameters;
    }

    private static JSONParameters GetParams(this Action<JSONParameters> paramAct)
    {
        var parameters = new JSONParameters();
        paramAct?.Invoke(parameters);
        return parameters;
    }

    private static Encoding GetEncoding(this Encoding encoding)
    {
        return encoding ?? Man.DefaultEncoding;
    }
}