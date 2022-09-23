using Cosmos.Reflection;
using Cosmos.Text;

namespace Cosmos.EnumUtils.DynamicEnumServices;

public class DynamicFlagEnumValueFormatAttribute : ValueFormatAttribute
{
    public override string WriteValueFormat(object value, Type type, JsonSerializerHandler handler, out bool isValueFormat)
    {
        isValueFormat = true;

        if (DynamicEnumVisit.IsDynamicEnum(type, out var genericArguments))
        {
            var val = value.GetValueAccessor(type).GetValue("Value");

            var valType = genericArguments[1];

            if (valType == TypeClass.BooleanClazz)
                return ((bool) val).CastToString();
            if (valType == TypeClass.ByteClazz)
                return ((byte) val).CastToString();
            if (valType == TypeClass.SByteClazz)
                return ((sbyte) val).CastToString();
            if (valType == TypeClass.ShortClazz)
                return ((short) val).CastToString();
            if (valType == TypeClass.UShortClazz)
                return ((ushort) val).CastToString();
            if (valType == TypeClass.Int32Clazz)
                return ((int) val).CastToString();
            if (valType == TypeClass.UInt32Clazz)
                return ((uint) val).CastToString();
            if (valType == TypeClass.Int64Clazz)
                return ((long) val).CastToString();
            if (valType == TypeClass.UInt64Clazz)
                return ((ulong) val).CastToString();
            if (valType == TypeClass.FloatClazz)
                return ((float) val).CastToString();
            if (valType == TypeClass.DoubleClazz)
                return ((double) val).CastToString();

            throw new ArgumentOutOfRangeException(valType.ToString(), $"{valType.Name} is not supported.");
        }

        return null;
    }

    public override object ReadValueFormat(string value, Type type, JsonDeserializeHandler handler, out bool isValueFormat)
    {
        isValueFormat = true;

        if (DynamicEnumVisit.IsDynamicEnum(type, out var genericArguments))
        {
            if (value is null || string.IsNullOrEmpty(value))
                return default;

            var targetType = typeof(DynamicFlagEnum<,>).MakeGenericType(genericArguments);
            var methodInfo = targetType.GetMethod("FromValueSingle")!;
            return methodInfo!.Invoke(null, new object[] {value});
        }

        return default;
    }
}