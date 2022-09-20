using System.Runtime.Serialization.Formatters.Binary;

namespace Cosmos.Serialization.Binary;

/// <summary>
/// Binary helper
/// </summary>
public static partial class BinaryHelper
{
    private static class Man
    {
        [ThreadStatic]
        private static BinaryFormatter _binaryFormatter;

        public static BinaryFormatter GetBinaryFormatter()
        {
            return _binaryFormatter ??= new BinaryFormatter();
        }
    }
}