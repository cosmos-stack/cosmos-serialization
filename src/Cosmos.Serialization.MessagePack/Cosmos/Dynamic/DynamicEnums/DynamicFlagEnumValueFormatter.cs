using System;
using Cosmos.Reflection;
using MessagePack;
using MessagePack.Formatters;

namespace Cosmos.Dynamic.DynamicEnums
{
    public class DynamicFlagEnumValueFormatter<TEnum, TValue> : IMessagePackFormatter<TEnum>
        where TEnum : DynamicFlagEnum<TEnum, TValue>, IDynamicEnum
        where TValue : struct, IEquatable<TValue>, IComparable<TValue>
    {
#if NET451 || NET452
        public int Serialize(ref byte[] bytes, int offset, TEnum value, IFormatterResolver formatterResolver)
        {
            if (value is null)
                return MessagePackBinary.WriteNil(ref bytes, offset);

            return Write(ref bytes, offset, value.Value);
        }

        public TEnum Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
        {
            if (MessagePackBinary.IsNil(bytes, offset))
            {
                readSize = 1;
                return default;
            }

            return DynamicFlagEnum<TEnum, TValue>.FromValueSingle(Read(ref bytes, offset, out readSize));
        }

         public int Write(ref byte[] bytes, int offset, TValue value)
        {
            if (typeof(TValue) == TypeClass.BooleanClazz)
                return MessagePackBinary.WriteBoolean(ref bytes, offset, (bool) (object) value);
            if (typeof(TValue) == TypeClass.ByteClazz)
                return MessagePackBinary.WriteByte(ref bytes, offset, (byte) (object) value);
            if (typeof(TValue) == TypeClass.SByteClazz)
                return MessagePackBinary.WriteSByte(ref bytes, offset, (sbyte) (object) value);
            if (typeof(TValue) == TypeClass.ShortClazz)
                return MessagePackBinary.WriteInt16(ref bytes, offset, (short) (object) value);
            if (typeof(TValue) == TypeClass.UShortClazz)
                return MessagePackBinary.WriteUInt16(ref bytes, offset, (ushort) (object) value);
            if (typeof(TValue) == TypeClass.Int32Clazz)
                return MessagePackBinary.WriteInt32(ref bytes, offset, (int) (object) value);
            if (typeof(TValue) == TypeClass.UInt32Clazz)
                return MessagePackBinary.WriteUInt32(ref bytes, offset, (uint) (object) value);
            if (typeof(TValue) == TypeClass.Int64Clazz)
                return MessagePackBinary.WriteInt64(ref bytes, offset, (long) (object) value);
            if (typeof(TValue) == TypeClass.UInt64Clazz)
                return MessagePackBinary.WriteUInt64(ref bytes, offset, (ulong) (object) value);
            if (typeof(TValue) == TypeClass.FloatClazz)
                return MessagePackBinary.WriteSingle(ref bytes, offset, (float) (object) value);
            if (typeof(TValue) == TypeClass.DoubleClazz)
                return MessagePackBinary.WriteDouble(ref bytes, offset, (double) (object) value);
            throw new ArgumentOutOfRangeException(nameof(value), $"{typeof(TValue)} is not supported."); // should not get to here
        }

        public TValue Read(ref byte[] bytes, int offset, out int readSize)
        {
            if (typeof(TValue) == TypeClass.BooleanClazz)
                return (TValue) (object) MessagePackBinary.ReadBoolean(bytes, offset, out readSize);
            if (typeof(TValue) == TypeClass.ByteClazz)
                return (TValue) (object) MessagePackBinary.ReadByte(bytes, offset, out readSize);
            if (typeof(TValue) == TypeClass.SByteClazz)
                return (TValue) (object) MessagePackBinary.ReadSByte(bytes, offset, out readSize);
            if (typeof(TValue) == TypeClass.ShortClazz)
                return (TValue) (object) MessagePackBinary.ReadInt16(bytes, offset, out readSize);
            if (typeof(TValue) == TypeClass.UShortClazz)
                return (TValue) (object) MessagePackBinary.ReadUInt16(bytes, offset, out readSize);
            if (typeof(TValue) == TypeClass.Int32Clazz)
                return (TValue) (object) MessagePackBinary.ReadInt32(bytes, offset, out readSize);
            if (typeof(TValue) == TypeClass.UInt32Clazz)
                return (TValue) (object) MessagePackBinary.ReadUInt32(bytes, offset, out readSize);
            if (typeof(TValue) == TypeClass.Int64Clazz)
                return (TValue) (object) MessagePackBinary.ReadInt64(bytes, offset, out readSize);
            if (typeof(TValue) == TypeClass.UInt64Clazz)
                return (TValue) (object) MessagePackBinary.ReadUInt64(bytes, offset, out readSize);
            if (typeof(TValue) == TypeClass.FloatClazz)
                return (TValue) (object) MessagePackBinary.ReadSingle(bytes, offset, out readSize);
            if (typeof(TValue) == TypeClass.DoubleClazz)
                return (TValue) (object) MessagePackBinary.ReadDouble(bytes, offset, out readSize);
            throw new ArgumentOutOfRangeException(typeof(TValue).ToString(), $"{typeof(TValue)} is not supported."); // should not get to here
        }
#else

        public void Serialize(ref MessagePackWriter writer, TEnum value, MessagePackSerializerOptions options)
        {
            if (value is null)
            {
                writer.WriteNil();
            }
            else
            {
                Write(ref writer, value.Value);
            }
        }

        public TEnum Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
        {
            if (reader.TryReadNil())
            {
                return default;
            }
            else
            {
                var value = Read(ref reader);
                return DynamicFlagEnum<TEnum, TValue>.FromValueSingle(value);
            }
        }

        public void Write(ref MessagePackWriter writer, TValue value)
        {
            if (typeof(TValue) == TypeClass.BooleanClazz)
                writer.Write((bool) (object) value);
            if (typeof(TValue) == TypeClass.ByteClazz)
                writer.Write((byte) (object) value);
            if (typeof(TValue) == TypeClass.SByteClazz)
                writer.WriteInt8((sbyte) (object) value);
            if (typeof(TValue) == TypeClass.ShortClazz)
                writer.WriteInt16((short) (object) value);
            if (typeof(TValue) == TypeClass.UShortClazz)
                writer.WriteUInt16((ushort) (object) value);
            if (typeof(TValue) == TypeClass.Int32Clazz)
                writer.WriteInt32((int) (object) value);
            if (typeof(TValue) == TypeClass.UInt32Clazz)
                writer.WriteUInt32((uint) (object) value);
            if (typeof(TValue) == TypeClass.Int64Clazz)
                writer.WriteInt64((long) (object) value);
            if (typeof(TValue) == TypeClass.UInt64Clazz)
                writer.WriteUInt64((ulong) (object) value);
            if (typeof(TValue) == TypeClass.FloatClazz)
                writer.Write((float) (object) value);
            if (typeof(TValue) == TypeClass.DoubleClazz)
                writer.Write((double) (object) value);
            throw new ArgumentOutOfRangeException(nameof(value), $"{typeof(TValue)} is not supported."); // should not get to here
        }

        public TValue Read(ref MessagePackReader reader)
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
            throw new ArgumentOutOfRangeException(typeof(TValue).ToString(), $"{typeof(TValue)} is not supported."); // should not get to here
        }

#endif
    }
}