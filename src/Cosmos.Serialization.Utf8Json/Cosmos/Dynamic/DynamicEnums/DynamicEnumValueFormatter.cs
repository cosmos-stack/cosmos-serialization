using System;
using Cosmos.Reflection;
using Utf8Json;

namespace Cosmos.Dynamic.DynamicEnums
{
    public class DynamicEnumValueFormatter<TEnum, TValue> : IJsonFormatter<TEnum>
        where TEnum : DynamicEnum<TEnum, TValue>
        where TValue : struct, IEquatable<TValue>, IComparable<TValue>
    {
        public void Serialize(ref JsonWriter writer, TEnum value, IJsonFormatterResolver formatterResolver)
        {
            if (value is null)
            {
                writer.WriteNull();
                return;
            }

            if (typeof(TValue) == TypeClass.BooleanClazz)
                writer.WriteBoolean((bool) (object) value.Value);
            else if (typeof(TValue) == TypeClass.ByteClazz)
                writer.WriteByte((byte) (object) value.Value);
            else if (typeof(TValue) == TypeClass.SByteClazz)
                writer.WriteSByte((sbyte) (object) value.Value);
            else if (typeof(TValue) == TypeClass.ShortClazz)
                writer.WriteInt16((short) (object) value.Value);
            else if (typeof(TValue) == TypeClass.UShortClazz)
                writer.WriteUInt16((ushort) (object) value.Value);
            else if (typeof(TValue) == TypeClass.Int32Clazz)
                writer.WriteInt32((int) (object) value.Value);
            else if (typeof(TValue) == TypeClass.UInt32Clazz)
                writer.WriteUInt32((uint) (object) value.Value);
            else if (typeof(TValue) == TypeClass.Int64Clazz)
                writer.WriteInt64((long) (object) value.Value);
            else if (typeof(TValue) == TypeClass.UInt64Clazz)
                writer.WriteUInt64((ulong) (object) value.Value);
            else if (typeof(TValue) == TypeClass.FloatClazz)
                writer.WriteSingle((float) (object) value.Value);
            else if (typeof(TValue) == TypeClass.DoubleClazz)
                writer.WriteDouble((double) (object) value.Value);
            else
                throw new ArgumentOutOfRangeException(typeof(TValue).ToString(), $"{typeof(TValue).Name} is not supported.");
        }

        public TEnum Deserialize(ref JsonReader reader, IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
                return null;

            return DynamicEnum<TEnum, TValue>.FromValueSingle(ReadValue(ref reader));
        }

        TValue ReadValue(ref JsonReader reader)
        {
            if (typeof(TValue) == TypeClass.BooleanClazz)
                return (TValue) (object) reader.ReadBoolean();
            if (typeof(TValue) == TypeClass.ByteClazz)
                return (TValue) (object) reader.ReadByte();
            if (typeof(TValue) == TypeClass.SByteClazz)
                return (TValue) (object) reader.ReadSByte();
            if (typeof(TValue) == TypeClass.ShortClazz)
                return (TValue) (object) reader.ReadInt16();
            if (typeof(TValue) == TypeClass.UShortClazz)
                return (TValue) (object) reader.ReadUInt16();
            if (typeof(TValue) == TypeClass.Int32Clazz)
                return (TValue) (object) reader.ReadInt32();
            if (typeof(TValue) == TypeClass.UInt32Clazz)
                return (TValue) (object) reader.ReadUInt32();
            if (typeof(TValue) == TypeClass.Int64Clazz)
                return (TValue) (object) reader.ReadInt64();
            if (typeof(TValue) == TypeClass.UInt64Clazz)
                return (TValue) (object) reader.ReadUInt64();
            if (typeof(TValue) == TypeClass.FloatClazz)
                return (TValue) (object) reader.ReadSingle();
            if (typeof(TValue) == TypeClass.DoubleClazz)
                return (TValue) (object) reader.ReadDouble();
            throw new ArgumentOutOfRangeException(typeof(TValue).ToString(), $"{typeof(TValue).Name} is not supported.");
        }
    }
}