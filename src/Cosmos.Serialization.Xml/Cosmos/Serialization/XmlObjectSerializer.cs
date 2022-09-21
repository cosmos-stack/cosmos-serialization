using Cosmos.Serialization.Xml;

namespace Cosmos.Serialization;

/// <summary>
/// Xml Serializer
/// </summary>
public class XmlObjectSerializer : IXmlSerializer
{
    /// <inheritdoc />
    public string Serialize<T>(T o)
    {
        return XmlHelper.ToXml(o);
    }

    /// <inheritdoc />
    public Stream SerializeToStream<T>(T o)
    {
        return XmlHelper.ToStream(o);
    }

    /// <inheritdoc />
    public T Deserialize<T>(string data)
    {
        return XmlHelper.FromXml<T>(data);
    }

    /// <inheritdoc />
    public object Deserialize(string data, Type type)
    {
        return XmlHelper.FromXml(type, data);
    }

    /// <inheritdoc />
    public T DeserializeFromStream<T>(Stream stream)
    {
        return XmlHelper.FromStream<T>(stream);
    }

    /// <inheritdoc />
    public object DeserializeFromStream(Stream stream, Type type)
    {
        return XmlHelper.FromStream(type, stream);
    }

    /// <inheritdoc />
    public Task<string> SerializeAsync<T>(T o)
    {
        return XmlHelper.ToXmlAsync(o);
    }

    /// <inheritdoc />
    public Task<Stream> SerializeToStreamAsync<T>(T o)
    {
        return XmlHelper.ToStreamAsync(o);
    }

    /// <inheritdoc />
    public Task<T> DeserializeAsync<T>(string data)
    {
        return XmlHelper.FromXmlAsync<T>(data);
    }

    /// <inheritdoc />
    public Task<object> DeserializeAsync(string data, Type type)
    {
        return XmlHelper.FromXmlAsync(type, data);
    }

    /// <inheritdoc />
    public Task<T> DeserializeFromStreamAsync<T>(Stream stream)
    {
        return XmlHelper.FromStreamAsync<T>(stream);
    }

    /// <inheritdoc />
    public Task<object> DeserializeFromStreamAsync(Stream stream, Type type)
    {
        return XmlHelper.FromStreamAsync(type, stream);
    }
}