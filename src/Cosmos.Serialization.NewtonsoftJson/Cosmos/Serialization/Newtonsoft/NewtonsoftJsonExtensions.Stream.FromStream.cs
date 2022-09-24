using System.Text;

namespace Cosmos.Serialization.Newtonsoft;

public static partial class NewtonsoftJsonExtensions
{
  /// <summary>
    /// Unpack
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="settings"></param>
    /// <param name="enableNodaTime"></param>
    /// <param name="encoding"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromNewtonsoftStream<TValue>(this Stream stream, JsonSerializerSettings settings = null, bool enableNodaTime = false, Encoding encoding = null)
    {
       return NewtonsoftJsonHelper.FromStream<TValue>(stream, settings, enableNodaTime, encoding);
    }

  /// <summary>
  /// Unpack
  /// </summary>
  /// <param name="stream"></param>
  /// <param name="type"></param>
  /// <param name="settings"></param>
  /// <param name="enableNodaTime"></param>
  /// <param name="encoding"></param>
  /// <returns></returns>
  public static object FromNewtonsoftStream(this Stream stream, Type type, JsonSerializerSettings settings = null, bool enableNodaTime = false, Encoding encoding = null)
    {
         return NewtonsoftJsonHelper.FromStream(type, stream, settings, enableNodaTime, encoding);
    }

    /// <summary>
    /// Unpack async
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="settings"></param>
    /// <param name="enableNodaTime"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static  Task<TValue> FromNewtonsoftStreamAsync<TValue>(this Stream stream, JsonSerializerSettings settings = null, bool enableNodaTime = false, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return NewtonsoftJsonHelper.FromStreamAsync<TValue>(stream, settings, enableNodaTime, encoding, cancellationToken);
    }

    /// <summary>
    /// Unpack async
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="type"></param>
    /// <param name="settings"></param>
    /// <param name="enableNodaTime"></param>
    /// <param name="encoding"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<object> FromNewtonsoftStreamAsync(this Stream stream, Type type, JsonSerializerSettings settings = null, bool enableNodaTime = false, Encoding encoding = null, CancellationToken cancellationToken = default)
    {
        return NewtonsoftJsonHelper.FromStreamAsync(type, stream, settings, enableNodaTime, encoding, cancellationToken);
    }
}