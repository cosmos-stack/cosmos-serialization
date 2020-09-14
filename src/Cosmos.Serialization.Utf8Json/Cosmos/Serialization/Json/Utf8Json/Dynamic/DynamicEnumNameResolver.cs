using Cosmos.Reflection;
using Utf8Json;

namespace Cosmos.Serialization.Json.Utf8Json.Dynamic
{
    public class DynamicEnumNameResolver : IJsonFormatterResolver
    {
        public static readonly DynamicEnumNameResolver Instance = new DynamicEnumNameResolver();

        private DynamicEnumNameResolver() { }

        public IJsonFormatter<T> GetFormatter<T>() => FormatterCache<T>.Formatter;

        private static class FormatterCache<T>
        {
            public static readonly IJsonFormatter<T> Formatter;

            static FormatterCache()
            {
                if (Enums.IsDynamicEnum(typeof(T), out var genericArguments))
                {
                    var formatterType = typeof(DynamicEnumNameFormatter<,>).MakeGenericType(genericArguments);
                    Formatter = (IJsonFormatter<T>) Types.CreateInstance(formatterType);
                }
            }
        }
    }
}