using Cosmos.Serialization.Lit;

namespace Cosmos.Serialization;

/// <summary>
/// LitJson Serializer
/// </summary>
public class LitObjectSerializer : IJsonSerializer
{
    /// <inheritdoc />
    public string Serialize<T>(T o)
    {
        return LitHelper.ToJson(o);
    }

    /// <inheritdoc />
    public Stream SerializeToStream<T>(T o)
    {
        return LitHelper.ToStream(o);
    }

    /// <inheritdoc />
    public T Deserialize<T>(string json)
    {
        return LitHelper.FromJson<T>(json);
    }

    /// <inheritdoc />
    public object Deserialize(string json, Type type)
    {
        return LitHelper.FromJson(type, json);
    }

    /// <inheritdoc />
    public T DeserializeFromStream<T>(Stream stream)
    {
        return LitHelper.FromStream<T>(stream);
    }

    /// <inheritdoc />
    public object DeserializeFromStream(Stream stream, Type type)
    {
        return LitHelper.FromStream(type, stream);
    }

    /// <inheritdoc />
    public Task<string> SerializeAsync<T>(T o)
    {
        return LitHelper.ToJsonAsync(o);
    }

    /// <inheritdoc />
    public Task<Stream> SerializeToStreamAsync<T>(T o)
    {
        return LitHelper.ToStreamAsync(o);
    }

    /// <inheritdoc />
    public Task<T> DeserializeAsync<T>(string data)
    {
        return LitHelper.FromJsonAsync<T>(data);
    }

    /// <inheritdoc />
    public Task<object> DeserializeAsync(string data, Type type)
    {
        return LitHelper.FromJsonAsync(type, data);
    }

    /// <inheritdoc />
    public Task<T> DeserializeFromStreamAsync<T>(Stream stream)
    {
        return LitHelper.FromStreamAsync<T>(stream);
    }

    /// <inheritdoc />
    public Task<object> DeserializeFromStreamAsync(Stream stream, Type type)
    {
        return LitHelper.FromStreamAsync(type, stream);
    }
}