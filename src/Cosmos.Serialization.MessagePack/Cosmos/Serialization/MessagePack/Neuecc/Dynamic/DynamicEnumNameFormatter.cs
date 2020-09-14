using System;
using Cosmos.Dynamic;
using MessagePack;
using MessagePack.Formatters;

namespace Cosmos.Serialization.MessagePack.Neuecc.Dynamic
{
    public class DynamicEnumNameFormatter<TEnum, TValue> : IMessagePackFormatter<TEnum>
        where TEnum : DynamicEnum<TEnum, TValue>
        where TValue : struct, IEquatable<TValue>, IComparable<TValue>
    {
#if NET451 || NET452
        public int Serialize(ref byte[] bytes, int offset, TEnum value, IFormatterResolver formatterResolver)
        {
            if (value is null)
            {
                return MessagePackBinary.WriteNil(ref bytes, offset);
            }

            return MessagePackBinary.WriteString(ref bytes, offset, value.Name);
        }

        public TEnum Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
        {
            if (MessagePackBinary.IsNil(bytes, offset))
            {
                readSize = 1;
                return null;
            }

            var name = MessagePackBinary.ReadString(bytes, offset, out readSize);
            return DynamicEnum<TEnum, TValue>.FromName(name);
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
                writer.Write(value.Name);
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
                var name = reader.ReadString();
                return DynamicEnum<TEnum, TValue>.FromName(name);
            }
        }
#endif
    }
}