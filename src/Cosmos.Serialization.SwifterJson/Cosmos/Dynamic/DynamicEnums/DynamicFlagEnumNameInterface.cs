using System;
using Swifter.RW;

namespace Cosmos.Dynamic.DynamicEnums
{
    public class DynamicFlagEnumNameInterface<TEnum, TValue> : IValueInterface<TEnum>
        where TEnum : DynamicFlagEnum<TEnum, TValue>, IDynamicEnum
        where TValue : struct, IEquatable<TValue>, IComparable<TValue>
    {
        public TEnum ReadValue(IValueReader valueReader)
        {
            var name = valueReader.ReadString();
            return DynamicFlagEnum<TEnum, TValue>.FromName(name);
        }

        public void WriteValue(IValueWriter valueWriter, TEnum value)
        {
            if (value is null)
                valueWriter.DirectWrite(null);
            else
                valueWriter.WriteString(value.Name);
        }
    }
}