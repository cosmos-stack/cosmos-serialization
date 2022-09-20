namespace Cosmos.Serialization.Bssom;

public static partial class BssomExtensions
{
    /// <summary>
    /// Deserialize the bytes to object
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="options"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromBssomBytes<TValue>(this byte[] bytes, BssomSerializerOptions options = default)
    {
        return BssomHelper.FromBytes<TValue>(bytes, options);
    }

    /// <summary>
    /// Deserialize the bytes to object
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="optionAct"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromBssomBytes<TValue>(this byte[] bytes, Action<BssomSerializerOptions> optionAct)
    {
        return BssomHelper.FromBytes<TValue>(bytes, optionAct);
    }

    /// <summary>
    /// Deserialize the bytes to object
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="type"></param>
    /// <param name="options"></param>
    /// <returns></returns>
    public static object FromBssomBytes(byte[] bytes, Type type, BssomSerializerOptions options)
    {
        return BssomHelper.FromBytes(type, bytes, options);
    }

    /// <summary>
    /// Deserialize the bytes to object
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="type"></param>
    /// <param name="optionAct"></param>
    /// <returns></returns>
    public static object FromBssomBytes(byte[] bytes, Type type, Action<BssomSerializerOptions> optionAct)
    {
        return BssomHelper.FromBytes(type, bytes, optionAct);
    }
}