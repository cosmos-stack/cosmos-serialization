namespace Cosmos.EnumUtils.DynamicEnumServices;

public class DynamicFlagEnumNameFormatter<TEnum, TValue> : IJsonFormatter<TEnum>
    where TEnum : DynamicFlagEnum<TEnum, TValue>, IDynamicEnum
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
        return DynamicFlagEnum<TEnum, TValue>.FromName(name);
    }
}