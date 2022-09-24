using System.Text.Json;
using Cosmos.Serialization.SystemTextJson;

namespace Cosmos.Serialization;

/// <summary>
/// Microsoft System.Text.Json object serializer
/// </summary>
public class MicrosoftJsonObjectSerializer : IJsonSerializer
{
    private readonly JsonSerializerOptions _options;

    public MicrosoftJsonObjectSerializer()
    {
        _options = SystemTextJsonHelper.GetDefaultOptions();
    }

    public MicrosoftJsonObjectSerializer(JsonSerializerOptions options)
    {
        _options = options ?? SystemTextJsonHelper.GetDefaultOptions();
    }

    public MicrosoftJsonObjectSerializer(Func<JsonSerializerOptions> optionsFactory)
    {
        _options = optionsFactory is null ? SystemTextJsonHelper.GetDefaultOptions() : optionsFactory();
    }

    /// <inheritdoc />
    public string Serialize<T>(T o)
    {
        return SystemTextJsonHelper.ToJson(o, _options);
    }

    /// <inheritdoc />
    public Stream SerializeToStream<T>(T o)
    {
        return SystemTextJsonHelper.ToStream(o, _options);
    }

    /// <inheritdoc />
    public T Deserialize<T>(string json)
    {
        return SystemTextJsonHelper.FromJson<T>(json, _options);
    }

    /// <inheritdoc />
    public object Deserialize(string json, Type type)
    {
        return SystemTextJsonHelper.FromJson(type, json, _options);
    }

    /// <inheritdoc />
    public T DeserializeFromStream<T>(Stream stream)
    {
        return SystemTextJsonHelper.FromStream<T>(stream, _options);
    }

    /// <inheritdoc />
    public object DeserializeFromStream(Stream stream, Type type)
    {
        return SystemTextJsonHelper.FromStream(type, stream, _options);
    }

    /// <inheritdoc />
    public Task<string> SerializeAsync<T>(T o)
    {
        return SystemTextJsonHelper.ToJsonAsync(o, _options);
    }

    /// <inheritdoc />
    public Task<Stream> SerializeToStreamAsync<T>(T o)
    {
        return SystemTextJsonHelper.ToStreamAsync(o, _options);
    }

    /// <inheritdoc />
    public Task<T> DeserializeAsync<T>(string data)
    {
        return SystemTextJsonHelper.FromJsonAsync<T>(data, _options);
    }

    /// <inheritdoc />
    public Task<object> DeserializeAsync(string data, Type type)
    {
        return SystemTextJsonHelper.FromJsonAsync(type, data, _options);
    }

    /// <inheritdoc />
    public Task<T> DeserializeFromStreamAsync<T>(Stream stream)
    {
        return SystemTextJsonHelper.FromStreamAsync<T>(stream, _options);
    }

    /// <inheritdoc />
    public Task<object> DeserializeFromStreamAsync(Stream stream, Type type)
    {
        return SystemTextJsonHelper.FromStreamAsync(type, stream, _options);
    }
}