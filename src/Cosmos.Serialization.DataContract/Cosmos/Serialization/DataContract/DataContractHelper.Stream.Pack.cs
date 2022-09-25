﻿using Cosmos.IO;

namespace Cosmos.Serialization.DataContract;

public static partial class DataContractHelper
{
    /// <summary>
    /// Serializes the specified object and writes the XML document to a file using the specified stream.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <typeparam name="TValue"></typeparam>
    public static void Pack<TValue>(TValue value, Stream stream)
    {
        if (stream is null) return;
        Man.GetSerializer<TValue>().WriteObject(stream, value);
        stream.TrySeek(0, SeekOrigin.Begin);
    }

    /// <summary>
    /// Serializes the specified object and writes the XML document to a file using the specified stream.
    /// </summary>
    /// <param name="type"></param>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    public static void Pack(Type type, object value, Stream stream)
    {
        if (stream is null) return;
        Man.GetSerializer(type).WriteObject(stream, value);
        stream.TrySeek(0, SeekOrigin.Begin);
    }
}