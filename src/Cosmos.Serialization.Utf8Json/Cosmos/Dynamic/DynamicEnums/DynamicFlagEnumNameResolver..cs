using Cosmos.Reflection;
using Utf8Json;

namespace Cosmos.Dynamic.DynamicEnums
{
    public class DynamicFlagEnumNameResolver : IJsonFormatterResolver
    {
        public static readonly DynamicFlagEnumNameResolver Instance = new DynamicFlagEnumNameResolver();

        private DynamicFlagEnumNameResolver() { }

        public IJsonFormatter<T> GetFormatter<T>() => FormatterCache<T>.Formatter;

        private static class FormatterCache<T>
        {
            public static readonly IJsonFormatter<T> Formatter;

            static FormatterCache()
            {
                if (Enums.IsDynamicEnum(typeof(T), out var genericArguments))
                {
                    var formatterType = typeof(DynamicFlagEnumNameFormatter<,>).MakeGenericType(genericArguments);
                    Formatter = (IJsonFormatter<T>) Types.CreateInstance(formatterType);
                }
            }
        }
    }
}