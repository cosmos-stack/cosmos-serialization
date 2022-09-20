namespace Cosmos.Serialization.Bssom;

public static partial class BssomHelper
{
    /// <summary>
    /// Serializes an object into a Stream.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="options"></param>
    /// <returns></returns>
    public static Stream ToStream(object value, BssomSerializerOptions options = default)
    {
        var stream = new MemoryStream();
        if (value is null) return stream;
        BssomSerializer.Serialize(stream, value, options ?? Man.DefaultOptions);
        return stream;
    }

    /// <summary>
    /// Serializes an object into a Stream.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="optionAct"></param>
    /// <returns></returns>
    public static Stream ToStream(object value, Action<BssomSerializerOptions> optionAct)
    {
        var stream = new MemoryStream();
        if (value is null) return stream;
        BssomSerializer.Serialize(stream, value, optionAct.ToOptions());
        return stream;
    }
}