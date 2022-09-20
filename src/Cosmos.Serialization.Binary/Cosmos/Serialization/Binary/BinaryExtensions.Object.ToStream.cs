namespace Cosmos.Serialization.Binary;

public static partial class BinaryExtensions
{
    /// <summary>
    /// Serializes an object into a MemoryStream.
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    [Obsolete("BinaryFormatter serialization is obsolete and should not be used. See https://aka.ms/binaryformatter for more information.")]
    public static MemoryStream ToStream(this object value)
    {
        return BinaryHelper.ToStream(value);
    }
}