namespace Cosmos.Serialization.Bssom;

public static partial class BssomHelper
{
    /// <summary>
    /// Serializes an object into a set of byte.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="options"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static byte[] ToBytes<TValue>(TValue value, BssomSerializerOptions options = default)
    {
        return BssomSerializer.Serialize(value, options ?? Man.DefaultOptions);
    }

    /// <summary>
    /// Serializes an object into a set of byte.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="optionAct"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static byte[] ToBytes<TValue>(TValue value, Action<BssomSerializerOptions> optionAct)
    {
        return BssomSerializer.Serialize(value, optionAct.ToOptions());
    }
}