﻿using System.Runtime.Serialization;
using System.Xml;

namespace Cosmos.Serialization.DataContract;

public static partial class DataContractHelper
{
    /// <summary>
    /// Serializes the specified object and writes the XML document to a file using the specified XmlWriter.
    /// </summary>
    /// <param name="xmlDictionaryWriter"></param>
    /// <param name="value"></param>
    /// <param name="dataContractResolver"></param>
    /// <typeparam name="TValue"></typeparam>
    public static void Serialize<TValue>(XmlDictionaryWriter xmlDictionaryWriter, TValue value, DataContractResolver dataContractResolver = null)
    {
        if (xmlDictionaryWriter is null) return;
        Man.GetSerializer<TValue>().WriteObject(xmlDictionaryWriter, value, dataContractResolver);
    }

    /// <summary>
    /// Serializes the specified object and writes the XML document to a file using the specified XmlWriter.
    /// </summary>
    /// <param name="type"></param>
    /// <param name="xmlDictionaryWriter"></param>
    /// <param name="value"></param>
    /// <param name="dataContractResolver"></param>
    public static void Serialize(Type type, XmlDictionaryWriter xmlDictionaryWriter, object value, DataContractResolver dataContractResolver = null)
    {
        if (xmlDictionaryWriter is null) return;
        Man.GetSerializer(type).WriteObject(xmlDictionaryWriter, value, dataContractResolver);
    }
}