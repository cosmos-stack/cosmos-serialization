using Cosmos.Reflection;
using MessagePack;
using MessagePack.Formatters;

namespace Cosmos.Dynamic.DynamicEnums
{
    public class DynamicFlagEnumValueResolver : IFormatterResolver
    {
        /// <summary>
        /// Return the instance.
        /// </summary>
        public static readonly DynamicFlagEnumValueResolver Instance = new DynamicFlagEnumValueResolver();

        private DynamicFlagEnumValueResolver() { }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public IMessagePackFormatter<T> GetFormatter<T>() =>
            FormatterCache<T>.Formatter;

        private static class FormatterCache<T>
        {
            public static readonly IMessagePackFormatter<T> Formatter;

            static FormatterCache()
            {
                if (Enums.IsDynamicEnum(typeof(T), out var genericArguments))
                {
                    var formatterType = typeof(DynamicFlagEnumValueFormatter<,>).MakeGenericType(genericArguments);
                    Formatter = (IMessagePackFormatter<T>) Types.CreateInstance(formatterType);
                }
            }
        }
    }
}