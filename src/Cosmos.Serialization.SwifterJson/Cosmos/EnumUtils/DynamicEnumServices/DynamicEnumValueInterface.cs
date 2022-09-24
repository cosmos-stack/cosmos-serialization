using Cosmos.Reflection;

namespace Cosmos.EnumUtils.DynamicEnumServices;

public class DynamicEnumValueInterface<TEnum, TValue> : IValueInterface<TEnum>
    where TEnum : DynamicEnum<TEnum, TValue>, IDynamicEnum
    where TValue : struct, IEquatable<TValue>, IComparable<TValue>
{
    public TEnum ReadValue(IValueReader valueReader)
    {
        var value = ReadValueImpl(valueReader);
        return DynamicEnum<TEnum, TValue>.FromValueSingle(value);
    }

    private static TValue ReadValueImpl(IValueReader valueReader)
    {
        if (typeof(TValue) == TypeClass.BooleanClazz)
            return (TValue) (object) valueReader.ReadBoolean();
        if (typeof(TValue) == TypeClass.ByteClazz)
            return (TValue) (object) valueReader.ReadByte();
        if (typeof(TValue) == TypeClass.SByteClazz)
            return (TValue) (object) valueReader.ReadSByte();
        if (typeof(TValue) == TypeClass.ShortClazz)
            return (TValue) (object) valueReader.ReadInt16();
        if (typeof(TValue) == TypeClass.UShortClazz)
            return (TValue) (object) valueReader.ReadUInt16();
        if (typeof(TValue) == TypeClass.Int32Clazz)
            return (TValue) (object) valueReader.ReadInt32();
        if (typeof(TValue) == TypeClass.UInt32Clazz)
            return (TValue) (object) valueReader.ReadUInt32();
        if (typeof(TValue) == TypeClass.Int64Clazz)
            return (TValue) (object) valueReader.ReadInt64();
        if (typeof(TValue) == TypeClass.UInt64Clazz)
            return (TValue) (object) valueReader.ReadUInt64();
        if (typeof(TValue) == TypeClass.FloatClazz)
            return (TValue) (object) valueReader.ReadSingle();
        if (typeof(TValue) == TypeClass.DoubleClazz)
            return (TValue) (object) valueReader.ReadDouble();
        throw new ArgumentOutOfRangeException(nameof(valueReader), $"{typeof(TValue)} is not supported."); // should not get to here
    }

    public void WriteValue(IValueWriter valueWriter, TEnum value)
    {
        if (value is null)
            valueWriter.DirectWrite(null);
        else
            valueWriter.DirectWrite(value.Value);
    }
}