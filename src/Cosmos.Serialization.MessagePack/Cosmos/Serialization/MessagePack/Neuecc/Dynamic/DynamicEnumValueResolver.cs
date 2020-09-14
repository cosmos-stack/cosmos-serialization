using Cosmos.Reflection;
using MessagePack;
using MessagePack.Formatters;

namespace Cosmos.Serialization.MessagePack.Neuecc.Dynamic
{
    public class DynamicEnumValueResolver : IFormatterResolver
    {
        public static readonly DynamicEnumValueResolver Instance = new DynamicEnumValueResolver();

        private DynamicEnumValueResolver() { }

        public IMessagePackFormatter<T> GetFormatter<T>() =>
            FormatterCache<T>.Formatter;

        private static class FormatterCache<T>
        {
            public static readonly IMessagePackFormatter<T> Formatter;

            static FormatterCache()
            {
                if (Enums.IsDynamicEnum(typeof(T), out var genericArguments))
                {
                    var formatterType = typeof(DynamicEnumValueFormatter<,>).MakeGenericType(genericArguments);
                    Formatter = (IMessagePackFormatter<T>) Types.CreateInstance(formatterType);
                }
            }
        }
    }
}