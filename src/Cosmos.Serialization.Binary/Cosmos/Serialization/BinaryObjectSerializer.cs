using Cosmos.Serialization.Binary;

namespace Cosmos.Serialization;

/// <summary>
/// Binary object serializer
/// </summary>
[Obsolete("将在 Cosmos-Stack 0.4.7.5 中进行重构")]
public class BinaryObjectSerializer : IObjectSerializer<byte[]>
{
    /// <inheritdoc />
    public byte[] Serialize<T>(T o)
    {
        return BinaryHelper.ToBytes(o);
    }

    /// <inheritdoc />
    public Stream SerializeToStream<T>(T o)
    {
        return BinaryHelper.ToStream(o);
    }

    /// <inheritdoc />
    public T Deserialize<T>(byte[] data)
    {
        return BinaryHelper.FromBytes<T>(data);
    }

    /// <inheritdoc />
    public object Deserialize(byte[] data, Type type)
    {
        return BinaryHelper.FromBytes(data);
    }

    /// <inheritdoc />
    public Task<byte[]> SerializeAsync<T>(T o)
    {
        return Task.FromResult(BinaryHelper.ToBytes(o));
    }

    /// <inheritdoc />
    public Task<T> DeserializeAsync<T>(byte[] data)
    {
        return Task.FromResult(BinaryHelper.FromBytes<T>(data));
    }

    /// <inheritdoc />
    public Task<object> DeserializeAsync(byte[] data, Type type)
    {
        return Task.FromResult(BinaryHelper.FromBytes(data));
    }

    /// <inheritdoc />
    public T DeserializeFromStream<T>(Stream stream)
    {
        return BinaryHelper.FromStream<T>(stream);
    }

    /// <inheritdoc />
    public object DeserializeFromStream(Stream stream, Type type)
    {
        return BinaryHelper.FromStream(stream);
    }

    /// <inheritdoc />
    public async Task<Stream> SerializeToStreamAsync<T>(T o)
    {
        return BinaryHelper.ToStream(o);
    }

    /// <inheritdoc />
    public Task<T> DeserializeFromStreamAsync<T>(Stream stream)
    {
        return Task.FromResult(BinaryHelper.FromStream<T>(stream));
    }

    /// <inheritdoc />
    public Task<object> DeserializeFromStreamAsync(Stream stream, Type type)
    {
        return Task.FromResult(BinaryHelper.FromStream(stream));
    }
}