using Cosmos.Serialization.Nett;
using Cosmos.Serialization.Variousness;

namespace Cosmos.Serialization;

/// <summary>
/// Nett TOML Serializer
/// </summary>
public class NettSerializer : ITomlSerializer
{
    private readonly TomlSettings _settings;

    public NettSerializer()
    {
        _settings = TomlHelper.GetDefaultSettings();
    }

    public NettSerializer(TomlSettings settings)
    {
        _settings = settings ?? TomlHelper.GetDefaultSettings();
    }

    /// <inheritdoc />
    public string Serialize<T>(T o)
    {
        return TomlHelper.ToToml(o, _settings);
    }

    /// <inheritdoc />
    public Stream SerializeToStream<T>(T o)
    {
        return TomlHelper.ToStream(o, _settings);
    }

    /// <inheritdoc />
    public T Deserialize<T>(string data)
    {
        return TomlHelper.FromToml<T>(data, _settings);
    }

    /// <inheritdoc />
    public object Deserialize(string data, Type type)
    {
        return TomlHelper.FromToml(type, data, _settings);
    }

    /// <inheritdoc />
    public T DeserializeFromStream<T>(Stream stream)
    {
        return TomlHelper.FromStream<T>(stream, _settings);
    }

    /// <inheritdoc />
    public object DeserializeFromStream(Stream stream, Type type)
    {
        return TomlHelper.FromStream(type, stream, _settings);
    }

    /// <inheritdoc />
    public Task<string> SerializeAsync<T>(T o)
    {
        return TomlHelper.ToTomlAsync(o, _settings);
    }

    /// <inheritdoc />
    public Task<Stream> SerializeToStreamAsync<T>(T o)
    {
        return TomlHelper.ToStreamAsync(o, _settings);
    }

    /// <inheritdoc />
    public Task<T> DeserializeAsync<T>(string data)
    {
        return TomlHelper.FromTomlAsync<T>(data, _settings);
    }

    /// <inheritdoc />
    public Task<object> DeserializeAsync(string data, Type type)
    {
        return TomlHelper.FromTomlAsync(type, data, _settings);
    }

    /// <inheritdoc />
    public Task<T> DeserializeFromStreamAsync<T>(Stream stream)
    {
        return TomlHelper.FromStreamAsync<T>(stream, _settings);
    }

    /// <inheritdoc />
    public Task<object> DeserializeFromStreamAsync(Stream stream, Type type)
    {
        return TomlHelper.FromStreamAsync(type, stream, _settings);
    }
}