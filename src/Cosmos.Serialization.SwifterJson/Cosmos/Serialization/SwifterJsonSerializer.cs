using Cosmos.Serialization.SwifterJson;

namespace Cosmos.Serialization;

/// <summary>
/// SwiftJson Serializer
/// </summary>
public class SwifterJsonSerializer : IJsonSerializer
{
    private readonly JsonFormatterOptions _options1;
    private readonly JsonFormatterOptions _options2;

    public SwifterJsonSerializer()
    {
        _options1 = SwifterJsonHelper.GetDefaultJsonSerializeOption();
        _options2 = SwifterJsonHelper.GetDefaultJsonDeserializeOption();
    }

    public SwifterJsonSerializer(JsonFormatterOptions? options1, JsonFormatterOptions? options2)
    {
        _options1 = options1 ?? SwifterJsonHelper.GetDefaultJsonSerializeOption();
        _options2 = options2 ?? SwifterJsonHelper.GetDefaultJsonDeserializeOption();
    }

    public SwifterJsonSerializer(Func<JsonFormatterOptions> optionsFactory1, Func<JsonFormatterOptions> optionsFactory2)
    {
        _options1 = optionsFactory1?.Invoke() ?? SwifterJsonHelper.GetDefaultJsonSerializeOption();
        _options2 = optionsFactory2?.Invoke() ?? SwifterJsonHelper.GetDefaultJsonDeserializeOption();
    }

    /// <inheritdoc />
    public string Serialize<T>(T o)
    {
        return SwifterJsonHelper.ToJson(o, _options1);
    }

    /// <inheritdoc />
    public Stream SerializeToStream<T>(T o)
    {
        return SwifterJsonHelper.ToStream(o, _options1);
    }

    /// <inheritdoc />
    public T Deserialize<T>(string json)
    {
        return SwifterJsonHelper.FromJson<T>(json, _options2);
    }

    /// <inheritdoc />
    public object Deserialize(string json, Type type)
    {
        return SwifterJsonHelper.FromJson(type, json);
    }

    /// <inheritdoc />
    public T DeserializeFromStream<T>(Stream stream)
    {
        return SwifterJsonHelper.FromStream<T>(stream, _options2);
    }

    /// <inheritdoc />
    public object DeserializeFromStream(Stream stream, Type type)
    {
        return SwifterJsonHelper.FromStream(type, stream, _options2);
    }

    /// <inheritdoc />
    public Task<string> SerializeAsync<T>(T o)
    {
        return SwifterJsonHelper.ToJsonAsync(o, _options1);
    }

    /// <inheritdoc />
    public Task<Stream> SerializeToStreamAsync<T>(T o)
    {
        return SwifterJsonHelper.ToStreamAsync(o, _options1);
    }

    /// <inheritdoc />
    public Task<T> DeserializeAsync<T>(string data)
    {
        return SwifterJsonHelper.FromJsonAsync<T>(data, _options2);
    }

    /// <inheritdoc />
    public Task<object> DeserializeAsync(string data, Type type)
    {
        return SwifterJsonHelper.FromJsonAsync(type, data, _options2);
    }

    /// <inheritdoc />
    public Task<T> DeserializeFromStreamAsync<T>(Stream stream)
    {
        return SwifterJsonHelper.FromStreamAsync<T>(stream, _options2);
    }

    /// <inheritdoc />
    public Task<object> DeserializeFromStreamAsync(Stream stream, Type type)
    {
        return SwifterJsonHelper.FromStreamAsync(type, stream, _options2);
    }
}