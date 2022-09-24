using Cosmos.Reflection;

namespace Cosmos.EnumUtils.DynamicEnumServices;

public class DynamicEnumValueResolver : IJsonFormatterResolver
{
    public static readonly DynamicEnumValueResolver Instance = new();

    private DynamicEnumValueResolver() { }

    public IJsonFormatter<T> GetFormatter<T>() => FormatterCache<T>.Formatter;

    private static class FormatterCache<T>
    {
        public static readonly IJsonFormatter<T> Formatter;

        static FormatterCache()
        {
            if (DynamicEnumVisit.IsDynamicEnum(typeof(T), out var genericArguments))
            {
                var formatterType = typeof(DynamicEnumValueFormatter<,>).MakeGenericType(genericArguments);
                Formatter = (IJsonFormatter<T>) TypeVisit.CreateInstance(formatterType);
            }
        }
    }
}