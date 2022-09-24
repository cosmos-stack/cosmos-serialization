using Cosmos.Serialization.Utf8Json;

namespace Cosmos.Serialization;

/// <summary>
/// Utf8Json object serializer
/// </summary>
public class Utf8JsonObjectSerializer : IJsonSerializer
{
    /// <inheritdoc />
    public string Serialize<T>(T o)
    {
        return Utf8JsonHelper.ToJson(o);
    }

    /// <inheritdoc />
    public Stream SerializeToStream<T>(T o)
    {
        return Utf8JsonHelper.ToStream(o);
    }

    /// <inheritdoc />
    public T Deserialize<T>(string json)
    {
        return Utf8JsonHelper.FromJson<T>(json);
    }

    /// <inheritdoc />
    public object Deserialize(string json, Type type)
    {
        return Utf8JsonHelper.FromJson(type, json);
    }

    /// <inheritdoc />
    public T DeserializeFromStream<T>(Stream stream)
    {
        return Utf8JsonHelper.FromStream<T>(stream);
    }

    /// <inheritdoc />
    public object DeserializeFromStream(Stream stream, Type type)
    {
        return Utf8JsonHelper.FromStream(type, stream);
    }

    /// <inheritdoc />
    public Task<string> SerializeAsync<T>(T o)
    {
        return Utf8JsonHelper.ToJsonAsync(o);
    }

    /// <inheritdoc />
    public Task<Stream> SerializeToStreamAsync<T>(T o)
    {
        return Utf8JsonHelper.ToStreamAsync(o);
    }

    /// <inheritdoc />
    public Task<T> DeserializeAsync<T>(string data)
    {
        return Utf8JsonHelper.FromJsonAsync<T>(data);
    }

    /// <inheritdoc />
    public Task<object> DeserializeAsync(string data, Type type)
    {
        return Utf8JsonHelper.FromJsonAsync(type, data);
    }

    /// <inheritdoc />
    public Task<T> DeserializeFromStreamAsync<T>(Stream stream)
    {
        return Utf8JsonHelper.FromStreamAsync<T>(stream);
    }

    /// <inheritdoc />
    public Task<object> DeserializeFromStreamAsync(Stream stream, Type type)
    {
        return Utf8JsonHelper.FromStreamAsync(type, stream);
    }
}