using Cosmos.Serialization.KoobooJson;

namespace Cosmos.Serialization;

/// <summary>
/// Kooboo Serializer
/// </summary>
// ReSharper disable once IdentifierTypo
public class KoobooObjectSerializer : IJsonSerializer
{
    private readonly JsonSerializerOption _options1;
    private readonly JsonDeserializeOption _options2;

    public KoobooObjectSerializer()
    {
        _options1 = KoobooHelper.GetDefaultJsonSerializerOption();
        _options2 = KoobooHelper.GetDefaultJsonDeserializeOption();
    }

    public KoobooObjectSerializer(JsonSerializerOption options1, JsonDeserializeOption options2)
    {
        _options1 = options1 ?? KoobooHelper.GetDefaultJsonSerializerOption();
        _options2 = options2 ?? KoobooHelper.GetDefaultJsonDeserializeOption();
    }

    public KoobooObjectSerializer(Func<JsonSerializerOption> optionsFactory1, Func<JsonDeserializeOption> optionsFactory2)
    {
        _options1 = optionsFactory1 is null ? KoobooHelper.GetDefaultJsonSerializerOption() : optionsFactory1();
        _options2 = optionsFactory2 is null ? KoobooHelper.GetDefaultJsonDeserializeOption() : optionsFactory2();
    }

    /// <inheritdoc />
    public string Serialize<T>(T o)
    {
        return KoobooHelper.ToJson(o, _options1);
    }

    /// <inheritdoc />
    public Stream SerializeToStream<T>(T o)
    {
        return KoobooHelper.ToStream(o, _options1);
    }

    /// <inheritdoc />
    public T Deserialize<T>(string json)
    {
        return KoobooHelper.FromJson<T>(json, _options2);
    }

    /// <inheritdoc />
    public object Deserialize(string json, Type type)
    {
        return KoobooHelper.FromJson(type, json, _options2);
    }

    /// <inheritdoc />
    public T DeserializeFromStream<T>(Stream stream)
    {
        return KoobooHelper.FromStream<T>(stream, _options2);
    }

    /// <inheritdoc />
    public object DeserializeFromStream(Stream stream, Type type)
    {
        return KoobooHelper.FromStream(type, stream, _options2);
    }

    /// <inheritdoc />
    public Task<string> SerializeAsync<T>(T o)
    {
        return KoobooHelper.ToJsonAsync(o, _options1);
    }

    /// <inheritdoc />
    public Task<Stream> SerializeToStreamAsync<T>(T o)
    {
        return KoobooHelper.ToStreamAsync(o, _options1);
    }

    /// <inheritdoc />
    public Task<T> DeserializeAsync<T>(string data)
    {
        return KoobooHelper.FromJsonAsync<T>(data, _options2);
    }

    /// <inheritdoc />
    public Task<object> DeserializeAsync(string data, Type type)
    {
        return KoobooHelper.FromJsonAsync(type, data, _options2);
    }

    /// <inheritdoc />
    public Task<T> DeserializeFromStreamAsync<T>(Stream stream)
    {
        return KoobooHelper.FromStreamAsync<T>(stream, _options2);
    }

    /// <inheritdoc />
    public Task<object> DeserializeFromStreamAsync(Stream stream, Type type)
    {
        return KoobooHelper.FromStreamAsync(type, stream, _options2);
    }
}