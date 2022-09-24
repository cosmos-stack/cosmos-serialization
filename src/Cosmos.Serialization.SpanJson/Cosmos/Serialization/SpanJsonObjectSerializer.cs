using System.Security.Cryptography;
using Cosmos.Serialization.SpanJson;

namespace Cosmos.Serialization;

/// <summary>
/// SpanJson Serializer
/// </summary>
public class SpanJsonObjectSerializer : IJsonSerializer
{
    /// <inheritdoc />
    public string Serialize<T>(T o)
    {
        return SpanJsonHelper.ToJson(o);
    }

    /// <inheritdoc />
    public Stream SerializeToStream<T>(T o)
    {
        return SpanJsonHelper.ToStream(o);
    }

    /// <inheritdoc />
    public T Deserialize<T>(string json)
    {
        return SpanJsonHelper.FromJson<T>(json);
    }

    /// <inheritdoc />
    public object Deserialize(string json, Type type)
    {
        return SpanJsonHelper.FromJson(type, json);
    }

    /// <inheritdoc />
    public T DeserializeFromStream<T>(Stream stream)
    {
        return SpanJsonHelper.FromStream<T>(stream);
    }

    /// <inheritdoc />
    public object DeserializeFromStream(Stream stream, Type type)
    {
        return SpanJsonHelper.FromStream(type, stream);
    }

    /// <inheritdoc />
    public Task<string> SerializeAsync<T>(T o)
    {
        return SpanJsonHelper.ToJsonAsync(o).AsTask();
    }

    /// <inheritdoc />
    public Task<Stream> SerializeToStreamAsync<T>(T o)
    {
        return SpanJsonHelper.ToStreamAsync(o).AsTask();
    }

    /// <inheritdoc />
    public Task<T> DeserializeAsync<T>(string data)
    {
        return SpanJsonHelper.FromJsonAsync<T>(data).AsTask();
    }

    /// <inheritdoc />
    public Task<object> DeserializeAsync(string data, Type type)
    {
        return SpanJsonHelper.FromJsonAsync(type, data).AsTask();
    }

    /// <inheritdoc />
    public Task<T> DeserializeFromStreamAsync<T>(Stream stream)
    {
        return SpanJsonHelper.FromStreamAsync<T>(stream).AsTask();
    }

    /// <inheritdoc />
    public Task<object> DeserializeFromStreamAsync(Stream stream, Type type)
    {
        return SpanJsonHelper.FromStreamAsync(type, stream).AsTask();
    }
}