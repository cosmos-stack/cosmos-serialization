using Cosmos.Serialization.Newtonsoft;

namespace Cosmos.Serialization;

/// <summary>
/// Newtonsoft Json Serializer
/// </summary>
public class NewtonsoftJsonSerializer : IJsonSerializer
{
    private readonly JsonSerializerSettings _settings;

    public NewtonsoftJsonSerializer()
    {
        _settings = NewtonsoftJsonHelper.GetDefaultSettings();
    }

    public NewtonsoftJsonSerializer(JsonSerializerSettings settings)
    {
        _settings = settings ?? NewtonsoftJsonHelper.GetDefaultSettings();
    }

    public NewtonsoftJsonSerializer(Func<JsonSerializerSettings> settingsFactory)
    {
        _settings = settingsFactory is null ? NewtonsoftJsonHelper.GetDefaultSettings() : settingsFactory();
    }

    /// <inheritdoc />
    public string Serialize<T>(T o)
    {
        return NewtonsoftJsonHelper.ToJson(o, _settings);
    }

    /// <inheritdoc />
    public Stream SerializeToStream<T>(T o)
    {
        return NewtonsoftJsonHelper.ToStream(o, _settings);
    }

    /// <inheritdoc />
    public T Deserialize<T>(string json)
    {
        return NewtonsoftJsonHelper.FromJson<T>(json, _settings);
    }

    /// <inheritdoc />
    public object Deserialize(string json, Type type)
    {
        return NewtonsoftJsonHelper.FromJson(type, json, _settings);
    }

    /// <inheritdoc />
    public T DeserializeFromStream<T>(Stream stream)
    {
        return NewtonsoftJsonHelper.FromStream<T>(stream, _settings);
    }

    /// <inheritdoc />
    public object DeserializeFromStream(Stream stream, Type type)
    {
        return NewtonsoftJsonHelper.FromStream(type, stream, _settings);
    }

    /// <inheritdoc />
    public Task<string> SerializeAsync<T>(T o)
    {
        return NewtonsoftJsonHelper.ToJsonAsync(o, _settings);
    }

    /// <inheritdoc />
    public Task<Stream> SerializeToStreamAsync<T>(T o)
    {
        return NewtonsoftJsonHelper.ToStreamAsync(o, _settings);
    }

    /// <inheritdoc />
    public Task<T> DeserializeAsync<T>(string data)
    {
        return NewtonsoftJsonHelper.FromJsonAsync<T>(data, _settings);
    }

    /// <inheritdoc />
    public Task<object> DeserializeAsync(string data, Type type)
    {
        return NewtonsoftJsonHelper.FromJsonAsync(type, data, _settings);
    }

    /// <inheritdoc />
    public Task<T> DeserializeFromStreamAsync<T>(Stream stream)
    {
        return NewtonsoftJsonHelper.FromStreamAsync<T>(stream, _settings);
    }

    /// <inheritdoc />
    public Task<object> DeserializeFromStreamAsync(Stream stream, Type type)
    {
        return NewtonsoftJsonHelper.FromStreamAsync(type, stream, _settings);
    }
}