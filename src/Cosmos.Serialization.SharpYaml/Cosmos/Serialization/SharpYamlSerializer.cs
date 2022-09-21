using Cosmos.Serialization.SharpYaml;
using Cosmos.Serialization.Variousness;

namespace Cosmos.Serialization;

/// <summary>
/// SharpYaml Serializer
/// </summary>
public class SharpYamlSerializer : IYamlSerializer
{
    private readonly Serializer _serializer;

    public SharpYamlSerializer()
    {
        _serializer = SharpYamlHelper.GetDefaultSerializer();
    }

    public SharpYamlSerializer(SerializerSettings settings)
    {
        _serializer = settings is null
            ? SharpYamlHelper.GetDefaultSerializer()
            : new(settings);
    }

    public SharpYamlSerializer(Serializer serializer)
    {
        _serializer = serializer ?? SharpYamlHelper.GetDefaultSerializer();
    }

    /// <inheritdoc />
    public string Serialize<T>(T o)
    {
        return SharpYamlHelper.ToYaml(o, _serializer);
    }

    /// <inheritdoc />
    public Stream SerializeToStream<T>(T o)
    {
        return SharpYamlHelper.ToStream(o, _serializer);
    }

    /// <inheritdoc />
    public T Deserialize<T>(string data)
    {
        return SharpYamlHelper.FromYaml<T>(data, _serializer);
    }

    /// <inheritdoc />
    public object Deserialize(string data, Type type)
    {
        return SharpYamlHelper.FromYaml(type, data, _serializer);
    }

    /// <inheritdoc />
    public T DeserializeFromStream<T>(Stream stream)
    {
        return SharpYamlHelper.FromStream<T>(stream, _serializer);
    }

    /// <inheritdoc />
    public object DeserializeFromStream(Stream stream, Type type)
    {
        return SharpYamlHelper.FromStream(type, stream, _serializer);
    }

    /// <inheritdoc />
    public Task<string> SerializeAsync<T>(T o)
    {
        return Task.FromResult(SharpYamlHelper.ToYaml(o, _serializer));
    }

    /// <inheritdoc />
    public Task<Stream> SerializeToStreamAsync<T>(T o)
    {
        return Task.FromResult(SharpYamlHelper.ToStream(o, _serializer));
    }

    /// <inheritdoc />
    public Task<T> DeserializeAsync<T>(string data)
    {
        return Task.FromResult(SharpYamlHelper.FromYaml<T>(data, _serializer));
    }

    /// <inheritdoc />
    public Task<object> DeserializeAsync(string data, Type type)
    {
        return Task.FromResult(SharpYamlHelper.FromYaml(type, data, _serializer));
    }

    /// <inheritdoc />
    public Task<T> DeserializeFromStreamAsync<T>(Stream stream)
    {
        return Task.FromResult(SharpYamlHelper.FromStream<T>(stream, _serializer));
    }

    /// <inheritdoc />
    public Task<object> DeserializeFromStreamAsync(Stream stream, Type type)
    {
        return Task.FromResult(SharpYamlHelper.FromStream(type, stream, _serializer));
    }
}