namespace Cosmos.Serialization.Bssom;

public static partial class BssomHelper
{
    /// <summary>
    /// Deserialize the bytes to object
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="options"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromBytes<TValue>(byte[] bytes, BssomSerializerOptions options = default)
    {
        return BssomSerializer.Deserialize<TValue>(bytes, options ?? Man.DefaultOptions);
    }

    /// <summary>
    /// Deserialize the bytes to object
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="optionAct"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static TValue FromBytes<TValue>(byte[] bytes, Action<BssomSerializerOptions> optionAct)
    {
        return BssomSerializer.Deserialize<TValue>(bytes, optionAct.ToOptions());
    }

    /// <summary>
    /// Deserialize the bytes to object
    /// </summary>
    /// <param name="type"></param>
    /// <param name="bytes"></param>
    /// <param name="options"></param>
    /// <returns></returns>
    public static object FromBytes(Type type, byte[] bytes, BssomSerializerOptions options = default)
    {
        return BssomSerializer.Deserialize(bytes, 0, out _, type, options ?? Man.DefaultOptions);
    }

    /// <summary>
    /// Deserialize the bytes to object
    /// </summary>
    /// <param name="type"></param>
    /// <param name="bytes"></param>
    /// <param name="optionAct"></param>
    /// <returns></returns>
    public static object FromBytes(Type type, byte[] bytes, Action<BssomSerializerOptions> optionAct)
    {
        return BssomSerializer.Deserialize(bytes, 0, out _, type, optionAct.ToOptions());
    }
}