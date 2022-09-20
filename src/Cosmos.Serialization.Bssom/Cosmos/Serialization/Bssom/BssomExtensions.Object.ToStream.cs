namespace Cosmos.Serialization.Bssom;

public static partial class BssomExtensions
{
    /// <summary>
    ///Serializes an object into a Stream.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="options"></param>
    /// <returns></returns>
    public static Stream ToBssomStream(this object value, BssomSerializerOptions options = default)
    {
        return BssomHelper.ToStream(value, options);
    }

    /// <summary>
    ///Serializes an object into a Stream.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="optionAct"></param>
    /// <returns></returns>
    public static Stream ToBssomStream(this object value, Action<BssomSerializerOptions> optionAct)
    {
        return BssomHelper.ToStream(value, optionAct);
    }
}