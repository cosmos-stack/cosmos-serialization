using System;
using System.Reflection;
using Kooboo.Json;

namespace Cosmos.Dynamic.DynamicEnums
{
    public class DynamicFlagEnumNameFormatAttribute : ValueFormatAttribute
    {
        public override string WriteValueFormat(object value, Type type, JsonSerializerHandler handler, out bool isValueFormat)
        {
            isValueFormat = true;

            if (Enums.IsDynamicEnum(type, out _))
            {
                var val = value.GetPropertyValue("Name");

                if (val is string stringVal)
                    return stringVal;

                return null;
            }

            return null;
        }

        public override object ReadValueFormat(string value, Type type, JsonDeserializeHandler handler, out bool isValueFormat)
        {
            isValueFormat = true;

            if (Enums.IsDynamicEnum(type, out var genericArguments))
            {
                if (value is null || string.IsNullOrEmpty(value))
                    return default;

                var targetType = typeof(DynamicFlagEnum<,>).MakeGenericType(genericArguments);
                var methodInfo = targetType.GetMethod("FromName")!;
                return methodInfo!.Invoke(null, new object[] {value});
            }

            return default;
        }
    }
}