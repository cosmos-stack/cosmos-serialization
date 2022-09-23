using Cosmos.Serialization.Jil;

namespace Cosmos.Serialization;

/// <summary>
/// Jil serializer
/// </summary>
public class JilObjectSerializer : IJsonSerializer
{
    private readonly Options _options;

    public JilObjectSerializer()
    {
        _options = JilHelper.GetDefaultOptions();
    }

    public JilObjectSerializer(Options options)
    {
        _options = options ?? JilHelper.GetDefaultOptions();
    }

    public JilObjectSerializer(Func<Options> optionsFactory)
    {
        _options = optionsFactory is null ? JilHelper.GetDefaultOptions() : optionsFactory();
    }

    /// <inheritdoc />
    public string Serialize<T>(T o)
    {
        return JilHelper.ToJson(o, _options);
    }

    /// <inheritdoc />
    public Stream SerializeToStream<T>(T o)
    {
        return JilHelper.ToStream(o, _options);
    }

    /// <inheritdoc />
    public T Deserialize<T>(string json)
    {
        return JilHelper.FromJson<T>(json, _options);
    }

    /// <inheritdoc />
    public object Deserialize(string json, Type type)
    {
        return JilHelper.FromJson(type, json, _options);
    }

    /// <inheritdoc />
    public T DeserializeFromStream<T>(Stream stream)
    {
        return JilHelper.FromStream<T>(stream, _options);
    }

    /// <inheritdoc />
    public object DeserializeFromStream(Stream stream, Type type)
    {
        return JilHelper.FromStream(type, stream, _options);
    }

    /// <inheritdoc />
    public Task<string> SerializeAsync<T>(T o)
    {
        return JilHelper.ToJsonAsync(o, _options);
    }

    /// <inheritdoc />
    public Task<Stream> SerializeToStreamAsync<T>(T o)
    {
        return JilHelper.ToStreamAsync(o, _options);
    }

    /// <inheritdoc />
    public Task<T> DeserializeAsync<T>(string data)
    {
        return JilHelper.FromJsonAsync<T>(data, _options);
    }

    /// <inheritdoc />
    public Task<object> DeserializeAsync(string data, Type type)
    {
        return JilHelper.FromJsonAsync(type, data, _options);
    }

    /// <inheritdoc />
    public Task<T> DeserializeFromStreamAsync<T>(Stream stream)
    {
        return JilHelper.FromStreamAsync<T>(stream, _options);
    }

    /// <inheritdoc />
    public Task<object> DeserializeFromStreamAsync(Stream stream, Type type)
    {
        return JilHelper.FromStreamAsync(type, stream, _options);
    }
}