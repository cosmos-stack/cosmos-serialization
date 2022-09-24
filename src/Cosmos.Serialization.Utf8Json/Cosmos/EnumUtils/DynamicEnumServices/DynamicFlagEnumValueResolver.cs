using Cosmos.Reflection;

namespace Cosmos.EnumUtils.DynamicEnumServices;

public class DynamicFlagEnumValueResolver : IJsonFormatterResolver
{
    public static readonly DynamicFlagEnumValueResolver Instance = new();

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