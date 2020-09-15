using System;
using Utf8Json;

namespace Cosmos.Dynamic.DynamicEnums
{
    public class DynamicEnumNameFormatter<TEnum, TValue> : IJsonFormatter<TEnum>
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

            writer.WriteString(value.Name);
        }

        public TEnum Deserialize(ref JsonReader reader, IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
                return null;

            var name = reader.ReadString();
            return DynamicEnum<TEnum, TValue>.FromName(name);
        }
    }
}