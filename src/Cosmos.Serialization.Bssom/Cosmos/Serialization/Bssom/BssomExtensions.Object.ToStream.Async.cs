namespace Cosmos.Serialization.Bssom;

public static partial class BssomExtensions
{
    ///  <summary>
    /// Serializes an object into a Stream.
    ///  </summary>
    ///  <param name="value"></param>
    ///  <param name="options"></param>
    ///  <param name="cancellationToken"></param>
    ///  <returns></returns>
    public static Task<Stream> ToBssomStreamAsync(this object value, BssomSerializerOptions options = default, CancellationToken cancellationToken = default)
    {
        return BssomHelper.ToStreamAsync(value, options, cancellationToken);
    }

    ///  <summary>
    /// Serializes an object into a Stream.
    ///  </summary>
    ///  <param name="value"></param>
    ///  <param name="optionAct"></param>
    ///  <param name="cancellationToken"></param>
    ///  <returns></returns>
    public static Task<Stream> ToBssomStreamAsync(this object value, Action<BssomSerializerOptions> optionAct, CancellationToken cancellationToken = default)
    {
        return BssomHelper.ToStreamAsync(value, optionAct, cancellationToken);
    }
}