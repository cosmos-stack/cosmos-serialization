using System;
using Cosmos.Dynamic;
using ProtoBuf;

namespace Cosmos.Serialization.ProtoBuf.Dynamic
{
    [ProtoContract]
    public class DynamicEnumValueSurrogate<TEnum, TValue>
        where TEnum : DynamicEnum<TEnum, TValue>
        where TValue : struct, IEquatable<TValue>, IComparable<TValue>
    {
        [ProtoMember(1, IsRequired = true)] TValue Value { get; set; }

        public static implicit operator DynamicEnumValueSurrogate<TEnum, TValue>(TEnum dynamicEnum)
        {
            if (dynamicEnum is null)
                return null;
            return new DynamicEnumValueSurrogate<TEnum, TValue> {Value = dynamicEnum.Value};
        }

        public static implicit operator TEnum(DynamicEnumValueSurrogate<TEnum, TValue> surrogate)
        {
            if (surrogate is null)
                return null;
            return DynamicEnum<TEnum, TValue>.SingleFromValue(surrogate.Value);
        }
    }
}