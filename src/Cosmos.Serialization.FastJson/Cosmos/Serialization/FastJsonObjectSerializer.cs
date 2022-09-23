using Cosmos.Serialization.FastJson;

namespace Cosmos.Serialization;

/// <summary>
/// FastJson serializer
/// </summary>
public class FastJsonObjectSerializer : IJsonSerializer
{
    private readonly JSONParameters _parameters;

    public FastJsonObjectSerializer()
    {
        _parameters = FastJsonHelper.GetDefaultParameters();
    }

    public FastJsonObjectSerializer(JSONParameters options)
    {
        _parameters = options ?? FastJsonHelper.GetDefaultParameters();
    }

    public FastJsonObjectSerializer(Func<JSONParameters> optionsFactory)
    {
        _parameters = optionsFactory is null ? FastJsonHelper.GetDefaultParameters() : optionsFactory();
    }

    /// <inheritdoc />
    public string Serialize<T>(T o)
    {
        return FastJsonHelper.ToJson(o, _parameters);
    }

    /// <inheritdoc />
    public Stream SerializeToStream<T>(T o)
    {
        return FastJsonHelper.ToStream(o, _parameters);
    }

    /// <inheritdoc />
    public T Deserialize<T>(string json)
    {
        return FastJsonHelper.FromJson<T>(json, _parameters);
    }

    /// <inheritdoc />
    public object Deserialize(string json, Type type)
    {
        return FastJsonHelper.FromJson(type, json, _parameters);
    }

    /// <inheritdoc />
    public T DeserializeFromStream<T>(Stream stream)
    {
        return FastJsonHelper.FromStream<T>(stream, _parameters);
    }

    /// <inheritdoc />
    public object DeserializeFromStream(Stream stream, Type type)
    {
        return FastJsonHelper.FromStream(type, stream, _parameters);
    }

    /// <inheritdoc />
    public Task<string> SerializeAsync<T>(T o)
    {
        return FastJsonHelper.ToJsonAsync(o, _parameters);
    }

    /// <inheritdoc />
    public Task<Stream> SerializeToStreamAsync<T>(T o)
    {
        return FastJsonHelper.ToStreamAsync(o, _parameters);
    }

    /// <inheritdoc />
    public Task<T> DeserializeAsync<T>(string data)
    {
        return FastJsonHelper.FromJsonAsync<T>(data, _parameters);
    }

    /// <inheritdoc />
    public Task<object> DeserializeAsync(string data, Type type)
    {
        return FastJsonHelper.FromJsonAsync(type, data, _parameters);
    }

    /// <inheritdoc />
    public Task<T> DeserializeFromStreamAsync<T>(Stream stream)
    {
        return FastJsonHelper.FromStreamAsync<T>(stream, _parameters);
    }

    /// <inheritdoc />
    public Task<object> DeserializeFromStreamAsync(Stream stream, Type type)
    {
        return FastJsonHelper.FromStreamAsync(type, stream, _parameters);
    }
}