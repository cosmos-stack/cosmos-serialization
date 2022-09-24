using System.Text;

namespace Cosmos.Serialization.Newtonsoft;

public static partial class NewtonsoftJsonHelper
{
    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <param name="settings"></param>
    /// <param name="enableNodaTime"></param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    public static Stream ToStream(object value, JsonSerializerSettings settings = null, bool enableNodaTime = false, Encoding encoding = null)
    {
        var stream = new MemoryStream();
        Pack(value, stream, settings, enableNodaTime, encoding);
        return stream;
    }

    /// <summary>
    /// Pack async
    /// </summary>
    /// <param name="value"></param>
    /// <param name="settings"></param>
    /// <param name="enableNodaTime"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<Stream> ToStreamAsync(object value, JsonSerializerSettings settings = null, bool enableNodaTime = false, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        var ms = new MemoryStream();
        await PackAsync(value, ms, settings, enableNodaTime, encoding, cancellationToken);
        return ms;
    }
}