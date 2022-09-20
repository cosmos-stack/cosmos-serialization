using Cosmos.Serialization.Bssom;

namespace Cosmos.Serialization;

/// <summary>
/// Bssom object serializer
/// </summary>
[Obsolete("将在 Cosmos-Stack 0.4.7.5 中进行重构")]
public class BssomObjectSerializer : IObjectSerializer<byte[]>
{
    private readonly BssomSerializerOptions _options;

    public BssomObjectSerializer()
    {
        _options = BssomHelper.GetDefaultOptions();
    }

    public BssomObjectSerializer(BssomSerializerOptions options)
    {
        _options = options ?? BssomHelper.GetDefaultOptions();
    }

    /// <inheritdoc />
    public byte[] Serialize<T>(T o)
    {
        return BssomHelper.ToBytes(o, _options);
    }

    /// <inheritdoc />
    public Stream SerializeToStream<T>(T o)
    {
        return BssomHelper.ToStream(o, _options);
    }

    /// <inheritdoc />
    public T Deserialize<T>(byte[] data)
    {
        return BssomHelper.FromBytes<T>(data, _options);
    }

    /// <inheritdoc />
    public object Deserialize(byte[] data, Type type)
    {
        return BssomHelper.FromBytes(type, data, _options);
    }

    /// <inheritdoc />
    public T DeserializeFromStream<T>(Stream stream)
    {
        return BssomHelper.FromStream<T>(stream, _options);
    }

    /// <inheritdoc />
    public object DeserializeFromStream(Stream stream, Type type)
    {
        return BssomHelper.FromStream(type, stream, _options);
    }

    /// <inheritdoc />
    public Task<byte[]> SerializeAsync<T>(T o)
    {
        return BssomHelper.ToBytesAsync(o, _options);
    }

    /// <inheritdoc />
    public Task<Stream> SerializeToStreamAsync<T>(T o)
    {
        return BssomHelper.ToStreamAsync(o, _options);
    }

    /// <inheritdoc />
    public Task<T> DeserializeAsync<T>(byte[] data)
    {
        return BssomHelper.FromBytesAsync<T>(data, _options);
    }

    /// <inheritdoc />
    public Task<object> DeserializeAsync(byte[] data, Type type)
    {
        return BssomHelper.FromBytesAsync(type, data, _options);
    }

    /// <inheritdoc />
    public Task<T> DeserializeFromStreamAsync<T>(Stream stream)
    {
        return BssomHelper.FromStreamAsync<T>(stream, _options);
    }

    /// <inheritdoc />
    public Task<object> DeserializeFromStreamAsync(Stream stream, Type type)
    {
        return BssomHelper.FromStreamAsync(type, stream, _options);
    }
}