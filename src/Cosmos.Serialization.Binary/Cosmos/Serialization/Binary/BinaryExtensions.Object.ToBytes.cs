namespace Cosmos.Serialization.Binary;

public static partial class BinaryExtensions
{
    /// <summary>
    /// Pack the object into a memory stream and return a bytes contains the stream contents.
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    [Obsolete("BinaryFormatter serialization is obsolete and should not be used. See https://aka.ms/binaryformatter for more information.")]
    public static byte[] ToBytes(this object value)
    {
        return BinaryHelper.ToBytes(value);
    }
}