using Cosmos.Reflection;
using MessagePack;
using MessagePack.Formatters;

namespace Cosmos.Dynamic.DynamicEnums
{
    public class DynamicEnumNameResolver : IFormatterResolver
    {
        public static readonly DynamicEnumNameResolver Instance = new DynamicEnumNameResolver();

        private DynamicEnumNameResolver() { }

        public IMessagePackFormatter<T> GetFormatter<T>() => FormatterCache<T>.Formatter;

        private static class FormatterCache<T>
        {
            public static readonly IMessagePackFormatter<T> Formatter;

            static FormatterCache()
            {
                if (DynamicEnumVisit.IsDynamicEnum(typeof(T), out var genericArguments))
                {
                    var formatterType = typeof(DynamicEnumNameFormatter<,>).MakeGenericType(genericArguments);
                    Formatter = (IMessagePackFormatter<T>) TypeVisit.CreateInstance(formatterType);
                }
            }
        }
    }
}