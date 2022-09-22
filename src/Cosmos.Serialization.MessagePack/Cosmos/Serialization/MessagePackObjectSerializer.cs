using Cosmos.Serialization.MessagePack;
using Cosmos.Serialization.Variousness;

namespace Cosmos.Serialization;

/// <summary>
/// Neuecc's MessagePack Serializer
/// </summary>
public class MessagePackObjectSerializer : IMessagePackSerializer
{
    /// <inheritdoc />
    public byte[] Serialize<T>(T o)
    {
        return MessagePackHelper.ToBytes(o);
    }

    /// <inheritdoc />
    public Stream SerializeToStream<T>(T o)
    {
        return MessagePackHelper.ToStream(o);
    }

    /// <inheritdoc />
    public T Deserialize<T>(byte[] data)
    {
        return MessagePackHelper.FromBytes<T>(data);
    }

    /// <inheritdoc />
    public object Deserialize(byte[] data, Type type)
    {
        return MessagePackHelper.FromBytes(type, data);
    }

    /// <inheritdoc />
    public T DeserializeFromStream<T>(Stream stream)
    {
        return MessagePackHelper.FromStream<T>(stream);
    }

    /// <inheritdoc />
    public object DeserializeFromStream(Stream stream, Type type)
    {
        return MessagePackHelper.FromStream(type, stream);
    }

    /// <inheritdoc />
    public Task<byte[]> SerializeAsync<T>(T o)
    {
        return MessagePackHelper.ToBytesAsync(o);
    }

    /// <inheritdoc />
    public Task<Stream> SerializeToStreamAsync<T>(T o)
    {
        return MessagePackHelper.ToStreamAsync(o);
    }

    /// <inheritdoc />
    public Task<T> DeserializeAsync<T>(byte[] data)
    {
        return MessagePackHelper.FromBytesAsync<T>(data);
    }

    /// <inheritdoc />
    public Task<object> DeserializeAsync(byte[] data, Type type)
    {
        return MessagePackHelper.FromBytesAsync(type, data);
    }

    /// <inheritdoc />
    public Task<T> DeserializeFromStreamAsync<T>(Stream stream)
    {
        return MessagePackHelper.FromStreamAsync<T>(stream);
    }

    /// <inheritdoc />
    public Task<object> DeserializeFromStreamAsync(Stream stream, Type type)
    {
        return MessagePackHelper.FromStreamAsync(type, stream);
    }
}