﻿using Cosmos.Reflection;
using MessagePack;
using MessagePack.Formatters;

namespace Cosmos.EnumUtils.DynamicEnumServices;

public class DynamicFlagEnumValueResolver : IFormatterResolver
{
    /// <summary>
    /// Return the instance.
    /// </summary>
    public static readonly DynamicFlagEnumValueResolver Instance = new();

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
            if (DynamicEnumVisit.IsDynamicEnum(typeof(T), out var genericArguments))
            {
                var formatterType = typeof(DynamicFlagEnumValueFormatter<,>).MakeGenericType(genericArguments);
                Formatter = (IMessagePackFormatter<T>) TypeVisit.CreateInstance(formatterType);
            }
        }
    }
}