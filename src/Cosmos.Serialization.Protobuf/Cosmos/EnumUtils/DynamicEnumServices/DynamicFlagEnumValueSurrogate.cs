using ProtoBuf;

namespace Cosmos.EnumUtils.DynamicEnumServices;

[ProtoContract]
public class DynamicFlagEnumValueSurrogate<TEnum, TValue>
    where TEnum : DynamicFlagEnum<TEnum, TValue>
    where TValue : struct, IEquatable<TValue>, IComparable<TValue>
{
    [ProtoMember(1, IsRequired = true)] TValue Value { get; set; }

    public static implicit operator DynamicFlagEnumValueSurrogate<TEnum, TValue>(TEnum smartEnum)
    {
        if (smartEnum is null)
            return null;
        return new DynamicFlagEnumValueSurrogate<TEnum, TValue> {Value = smartEnum.Value};
    }

    public static implicit operator TEnum(DynamicFlagEnumValueSurrogate<TEnum, TValue> surrogate)
    {
        if (surrogate is null)
            return null;
        return DynamicFlagEnum<TEnum, TValue>.FromValueSingle(surrogate.Value);
    }
}