using System.Text;

namespace Cosmos.Serialization.Newtonsoft;

public static partial class NewtonsoftJsonExtensions
{
    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <param name="settings"></param>
    /// <param name="enableNodaTime"></param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    public static Stream ToNewtonsoftStream(this object value, JsonSerializerSettings settings = null, bool enableNodaTime = false, Encoding encoding = null)
    {
        return NewtonsoftJsonHelper.ToStream(value, settings, enableNodaTime, encoding);
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
    public static Task<Stream> ToNewtonsoftStreamAsync(this object value, JsonSerializerSettings settings = null, bool enableNodaTime = false, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return NewtonsoftJsonHelper.ToStreamAsync(value, settings, enableNodaTime, encoding, cancellationToken);
    }
}