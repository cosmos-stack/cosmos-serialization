using Cosmos.Serialization.Variousness;
using Cosmos.Serialization.YamlDotNet;

namespace Cosmos.Serialization;

/// <summary>
/// Yaml Serializer
/// </summary>
public class YamlSerializer : IYamlSerializer
{
    private readonly S _serializer;
    private readonly D _deserializer;

    public YamlSerializer()
    {
        _serializer = YamlDotNetHelper.GetDefaultSerializer();
        _deserializer = YamlDotNetHelper.GetDefaultDeserializer();
    }

    public YamlSerializer(S serializer, D deserializer)
    {
        _serializer = serializer ?? YamlDotNetHelper.GetDefaultSerializer();
        _deserializer = deserializer ?? YamlDotNetHelper.GetDefaultDeserializer();
    }

    /// <inheritdoc />
    public string Serialize<T>(T o)
    {
        return YamlDotNetHelper.ToYaml(o, _serializer);
    }

    /// <inheritdoc />
    public Stream SerializeToStream<T>(T o)
    {
        return YamlDotNetHelper.ToStream(o, _serializer);
    }

    /// <inheritdoc />
    public T Deserialize<T>(string data)
    {
        return YamlDotNetHelper.FromYaml<T>(data, _deserializer);
    }

    /// <inheritdoc />
    public object Deserialize(string data, Type type)
    {
        return YamlDotNetHelper.FromYaml(type, data, _deserializer);
    }

    /// <inheritdoc />
    public T DeserializeFromStream<T>(Stream stream)
    {
        return YamlDotNetHelper.FromStream<T>(stream, _deserializer);
    }

    /// <inheritdoc />
    public object DeserializeFromStream(Stream stream, Type type)
    {
        return YamlDotNetHelper.FromStream(type, stream, _deserializer);
    }

    /// <inheritdoc />
    public Task<string> SerializeAsync<T>(T o)
    {
        return Task.FromResult(YamlDotNetHelper.ToYaml(o, _serializer));
    }

    /// <inheritdoc />
    public Task<Stream> SerializeToStreamAsync<T>(T o)
    {
        return Task.FromResult(YamlDotNetHelper.ToStream(o, _serializer));
    }

    /// <inheritdoc />
    public Task<T> DeserializeAsync<T>(string data)
    {
        return Task.FromResult(YamlDotNetHelper.FromYaml<T>(data, _deserializer));
    }

    /// <inheritdoc />
    public Task<object> DeserializeAsync(string data, Type type)
    {
        return Task.FromResult(YamlDotNetHelper.FromYaml(type, data, _deserializer));
    }

    /// <inheritdoc />
    public Task<T> DeserializeFromStreamAsync<T>(Stream stream)
    {
        return Task.FromResult(YamlDotNetHelper.FromStream<T>(stream, _deserializer));
    }

    /// <inheritdoc />
    public Task<object> DeserializeFromStreamAsync(Stream stream, Type type)
    {
        return Task.FromResult(YamlDotNetHelper.FromStream(type, stream, _deserializer));
    }
}