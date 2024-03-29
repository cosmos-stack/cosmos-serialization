﻿namespace Cosmos.Serialization.Jil;

public static partial class JilExtensions
{
    public static void JilSerialize<TValue>(this TValue value, TextWriter output, Options options = null)
    {
        JilHelper.Serialize(value, output, options);
    }

    public static void JilSerialize(this object value, TextWriter output, Options options = null)
    {
        JilHelper.Serialize(value, output, options);
    }
}