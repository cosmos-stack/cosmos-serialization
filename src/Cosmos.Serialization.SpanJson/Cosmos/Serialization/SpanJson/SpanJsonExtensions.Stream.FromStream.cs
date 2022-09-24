namespace Cosmos.Serialization.SpanJson;

public static partial class SpanJsonExtensions
{
  /// <summary>
    /// Unpack
    /// </summary>
    /// <param name="stream"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromSpanJsonStream<TValue>(this Stream stream)
  {
      return SpanJsonHelper.FromStream<TValue>(stream);
  }

  /// <summary>
  /// Unpack
  /// </summary>
  /// <param name="stream"></param>
  /// <param name="type"></param>
  /// <returns></returns>
  public static object FromSpanJsonStream(this Stream stream, Type type)
    {
        return SpanJsonHelper.FromStream(type, stream);
    }

    /// <summary>
    /// Unpack
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static  ValueTask<TValue> FromSpanJsonStreamAsync<TValue>(this Stream stream, CancellationToken cancellationToken = default)
    {
        return  SpanJsonHelper.FromStreamAsync<TValue>(stream, cancellationToken);
    }

    /// <summary>
    /// Unpack
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="type"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static ValueTask<object> FromSpanJsonStreamAsync(this Stream stream, Type type, CancellationToken cancellationToken = default)
    {
        return  SpanJsonHelper.FromStreamAsync(type, stream, cancellationToken);
    }
}