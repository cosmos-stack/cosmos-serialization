namespace Cosmos.Serialization.Binary;

public static partial class BinaryExtensions
{
    /// <summary>
    /// Serializes the object, or graph of objects with the specified top (root), to the given stream.
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="value"></param>
    [Obsolete("BinaryFormatter serialization is obsolete and should not be used. See https://aka.ms/binaryformatter for more information.")]
    public static void PackBy(this Stream stream, object value)
    {
        BinaryHelper.Pack(value, stream);
    }
}