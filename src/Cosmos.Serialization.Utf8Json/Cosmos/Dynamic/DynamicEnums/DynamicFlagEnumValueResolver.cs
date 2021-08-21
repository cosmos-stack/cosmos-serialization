using Cosmos.Reflection;
using Utf8Json;

namespace Cosmos.Dynamic.DynamicEnums
{
    public class DynamicFlagEnumValueResolver : IJsonFormatterResolver
    {
        public static readonly DynamicFlagEnumValueResolver Instance = new DynamicFlagEnumValueResolver();

        private DynamicFlagEnumValueResolver() { }

        public IJsonFormatter<T> GetFormatter<T>() => FormatterCache<T>.Formatter;

        private static class FormatterCache<T>
        {
            public static readonly IJsonFormatter<T> Formatter;

            static FormatterCache()
            {
                if (DynamicEnumVisit.IsDynamicEnum(typeof(T), out var genericArguments))
                {
                    var formatterType = typeof(DynamicFlagEnumValueFormatter<,>).MakeGenericType(genericArguments);
                    Formatter = (IJsonFormatter<T>) TypeVisit.CreateInstance(formatterType);
                }
            }
        }
    }
}