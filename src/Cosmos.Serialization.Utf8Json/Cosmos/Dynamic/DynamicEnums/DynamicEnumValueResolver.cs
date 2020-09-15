using Cosmos.Reflection;
using Utf8Json;

namespace Cosmos.Dynamic.DynamicEnums
{
    public class DynamicEnumValueResolver : IJsonFormatterResolver
    {
        public static readonly DynamicEnumValueResolver Instance = new DynamicEnumValueResolver();

        private DynamicEnumValueResolver() { }

        public IJsonFormatter<T> GetFormatter<T>() => FormatterCache<T>.Formatter;

        private static class FormatterCache<T>
        {
            public static readonly IJsonFormatter<T> Formatter;

            static FormatterCache()
            {
                if (Enums.IsDynamicEnum(typeof(T), out var genericArguments))
                {
                    var formatterType = typeof(DynamicEnumValueFormatter<,>).MakeGenericType(genericArguments);
                    Formatter = (IJsonFormatter<T>) Types.CreateInstance(formatterType);
                }
            }
        }
    }
}