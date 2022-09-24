using Cosmos.Reflection;

namespace Cosmos.EnumUtils.DynamicEnumServices;

public class DynamicEnumNameResolver : IJsonFormatterResolver
{
    public static readonly DynamicEnumNameResolver Instance = new();

    private DynamicEnumNameResolver() { }

    public IJsonFormatter<T> GetFormatter<T>() => FormatterCache<T>.Formatter;

    private static class FormatterCache<T>
    {
        public static readonly IJsonFormatter<T> Formatter;

        static FormatterCache()
        {
            if (DynamicEnumVisit.IsDynamicEnum(typeof(T), out var genericArguments))
            {
                var formatterType = typeof(DynamicEnumNameFormatter<,>).MakeGenericType(genericArguments);
                Formatter = (IJsonFormatter<T>) TypeVisit.CreateInstance(formatterType);
            }
        }
    }
}