using System.Text;

namespace Cosmos.Serialization.Newtonsoft;

public static partial class NewtonsoftJsonExtensions
{
    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <param name="settings"></param>
    /// <param name="enableNodaTime"></param>
    /// <param name="encoding"></param>
    public static void NewtonsoftPackTo(this object value, Stream stream, JsonSerializerSettings settings = null, bool enableNodaTime = false, Encoding encoding = null)
    {
        NewtonsoftJsonHelper.Pack(value, stream, settings, enableNodaTime, encoding);
    }

    /// <summary>
    /// Pack async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <param name="settings"></param>
    /// <param name="enableNodaTime"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    public static Task NewtonsoftPackToAsync(this object value, Stream stream, JsonSerializerSettings settings = null, bool enableNodaTime = false, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return NewtonsoftJsonHelper.PackAsync(value, stream, settings, enableNodaTime, encoding, cancellationToken);
    }
}