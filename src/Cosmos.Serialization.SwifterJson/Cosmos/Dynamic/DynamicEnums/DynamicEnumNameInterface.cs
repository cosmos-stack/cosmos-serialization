using System;
using Swifter.RW;

namespace Cosmos.Dynamic.DynamicEnums
{
    public class DynamicEnumNameInterface<TEnum, TValue> : IValueInterface<TEnum>
        where TEnum : DynamicEnum<TEnum, TValue>, IDynamicEnum
        where TValue : struct, IEquatable<TValue>, IComparable<TValue>
    {
        public TEnum ReadValue(IValueReader valueReader)
        {
            var name = valueReader.ReadString();
            return DynamicEnum<TEnum, TValue>.FromName(name);
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