using Cosmos.Reflection;
using MessagePack;
using MessagePack.Formatters;

namespace Cosmos.EnumUtils.DynamicEnumServices;

public class DynamicFlagEnumNameResolver : IFormatterResolver
{
    public static readonly DynamicFlagEnumNameResolver Instance = new();

    private DynamicFlagEnumNameResolver() { }

    public IMessagePackFormatter<T> GetFormatter<T>() =>
        FormatterCache<T>.Formatter;

    private static class FormatterCache<T>
    {
        public static readonly IMessagePackFormatter<T> Formatter;

        static FormatterCache()
        {
            if (DynamicEnumVisit.IsDynamicEnum(typeof(T), out var genericArguments))
            {
                var formatterType = typeof(DynamicFlagEnumNameFormatter<,>).MakeGenericType(genericArguments);
                Formatter = (IMessagePackFormatter<T>) TypeVisit.CreateInstance(formatterType);
            }
        }
    }
}