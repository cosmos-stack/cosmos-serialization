namespace Cosmos.Serialization.Bssom;

public static partial class BssomExtensions
{
    /// <summary>
    /// Serializes an object into a set of byte.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="options"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static byte[] ToBssomBytes<TValue>(this TValue value, BssomSerializerOptions options = default)
    {
        return BssomHelper.ToBytes(value, options);
    }

    /// <summary>
    /// Serializes an object into a set of byte.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="optionAct"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static byte[] ToBssomBytes<TValue>(this TValue value, Action<BssomSerializerOptions> optionAct)
    {
        return BssomHelper.ToBytes(value, optionAct);
    }
}