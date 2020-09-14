using System;
using Cosmos.Dynamic;
using ProtoBuf;

namespace Cosmos.Serialization.ProtoBuf.Dynamic
{
    [ProtoContract]
    public class DynamicEnumNameSurrogate<TEnum, TValue>
        where TEnum : DynamicEnum<TEnum, TValue>
        where TValue : struct, IEquatable<TValue>, IComparable<TValue>
    {
        [ProtoMember(1, IsRequired = true)] string Name { get; set; }

        public static implicit operator DynamicEnumNameSurrogate<TEnum, TValue>(TEnum smartEnum)
        {
            if (smartEnum is null)
                return null;
            return new DynamicEnumNameSurrogate<TEnum, TValue> {Name = smartEnum.Name};
        }

        public static implicit operator TEnum(DynamicEnumNameSurrogate<TEnum, TValue> surrogate)
        {
            if (surrogate is null)
                return null;
            return DynamicEnum<TEnum, TValue>.FromName(surrogate.Name);
        }
    }
}