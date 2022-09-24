using System.Text;

namespace Cosmos.Serialization.Lit;

public static partial class LitHelper
{
    /// <summary>
    /// LitJson manager
    /// </summary>
    private static class Man
    {
        private static Encoding _encoding = Encoding.UTF8;

        /// <summary>
        /// Gets or sets default encoding
        /// </summary>
        public static Encoding DefaultEncoding
        {
            get => _encoding;
            set => _encoding = value ?? _encoding;
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

    private static Encoding GetEncoding(this Encoding encoding)
    {
        return encoding ?? Man.DefaultEncoding;
    }
}