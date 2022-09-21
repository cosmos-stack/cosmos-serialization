using ProtoBuf;

namespace Cosmos.EnumUtils.DynamicEnumServices;

[ProtoContract]
public class DynamicFlagEnumNameSurrogate<TEnum, TValue>
    where TEnum : DynamicFlagEnum<TEnum, TValue>, IDynamicEnum
    where TValue : struct, IEquatable<TValue>, IComparable<TValue>
{
    [ProtoMember(1, IsRequired = true)] public string Name { get; set; }

    public static implicit operator DynamicFlagEnumNameSurrogate<TEnum, TValue>(TEnum smartFlagEnum)
    {
        if (smartFlagEnum is null)
            return null;
        return new DynamicFlagEnumNameSurrogate<TEnum, TValue> {Name = smartFlagEnum.Name};
    }

    public static implicit operator TEnum(DynamicFlagEnumNameSurrogate<TEnum, TValue> surrogate)
    {
        if (surrogate is null)
            return null;
        return DynamicFlagEnum<TEnum, TValue>.FromName(surrogate.Name);
    }
}