using Cosmos.Serialization.SwifterMsgPack;
using Cosmos.Serialization.Variousness;

namespace Cosmos.Serialization;

/// <summary>
/// MsgPack-cli object serializer
/// </summary>
public class SwifterMsgPackObjectSerializer : IMessagePackSerializer
{
    /// <inheritdoc />
    public byte[] Serialize<T>(T o)
    {
        return SwifterMsgPackHelper.ToBytes(o);
    }

    /// <inheritdoc />
    public Stream SerializeToStream<T>(T o)
    {
        return SwifterMsgPackHelper.ToStream(o);
    }

    /// <inheritdoc />
    public T Deserialize<T>(byte[] data)
    {
        return SwifterMsgPackHelper.FromBytes<T>(data);
    }

    /// <inheritdoc />
    public object Deserialize(byte[] data, Type type)
    {
        return SwifterMsgPackHelper.FromBytes(type, data);
    }

    /// <inheritdoc />
    public T DeserializeFromStream<T>(Stream stream)
    {
        return SwifterMsgPackHelper.FromStream<T>(stream);
    }

    /// <inheritdoc />
    public object DeserializeFromStream(Stream stream, Type type)
    {
        return SwifterMsgPackHelper.FromStream(type, stream);
    }

    /// <inheritdoc />
    public Task<byte[]> SerializeAsync<T>(T o)
    {
        return SwifterMsgPackHelper.ToBytesAsync(o);
    }

    /// <inheritdoc />
    public Task<Stream> SerializeToStreamAsync<T>(T o)
    {
        return SwifterMsgPackHelper.ToStreamAsync(o);
    }

    /// <inheritdoc />
    public Task<T> DeserializeAsync<T>(byte[] data)
    {
        return SwifterMsgPackHelper.FromBytesAsync<T>(data);
    }

    /// <inheritdoc />
    public Task<object> DeserializeAsync(byte[] data, Type type)
    {
        return SwifterMsgPackHelper.FromBytesAsync(type, data);
    }

    /// <inheritdoc />
    public Task<T> DeserializeFromStreamAsync<T>(Stream stream)
    {
        return SwifterMsgPackHelper.FromStreamAsync<T>(stream);
    }

    /// <inheritdoc />
    public Task<object> DeserializeFromStreamAsync(Stream stream, Type type)
    {
        return SwifterMsgPackHelper.FromStreamAsync(type, stream);
    }
}