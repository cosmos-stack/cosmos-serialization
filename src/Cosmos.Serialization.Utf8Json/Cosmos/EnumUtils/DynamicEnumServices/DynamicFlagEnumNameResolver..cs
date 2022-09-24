using Cosmos.Reflection;

namespace Cosmos.EnumUtils.DynamicEnumServices;

public class DynamicFlagEnumNameResolver : IJsonFormatterResolver
{
    public static readonly DynamicFlagEnumNameResolver Instance = new();

    private DynamicFlagEnumNameResolver() { }

    public IJsonFormatter<T> GetFormatter<T>() => FormatterCache<T>.Formatter;

    private static class FormatterCache<T>
    {
        public static readonly IJsonFormatter<T> Formatter;

        static FormatterCache()
        {
            if (DynamicEnumVisit.IsDynamicEnum(typeof(T), out var genericArguments))
            {
                var formatterType = typeof(DynamicFlagEnumNameFormatter<,>).MakeGenericType(genericArguments);
                Formatter = (IJsonFormatter<T>) TypeVisit.CreateInstance(formatterType);
            }
        }
    }
}