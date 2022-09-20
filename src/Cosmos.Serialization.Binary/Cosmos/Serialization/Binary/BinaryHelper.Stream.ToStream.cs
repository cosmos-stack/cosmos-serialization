namespace Cosmos.Serialization.Binary;

public static partial class BinaryHelper
{
    /// <summary>
    /// Serializes an object into a MemoryStream.
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    [Obsolete("BinaryFormatter serialization is obsolete and should not be used. See https://aka.ms/binaryformatter for more information.")]
    public static MemoryStream ToStream(object value)
    {
        var ms = new MemoryStream();
        if (value is null) return ms;
        Pack(value, ms);
        return ms;
    }
}