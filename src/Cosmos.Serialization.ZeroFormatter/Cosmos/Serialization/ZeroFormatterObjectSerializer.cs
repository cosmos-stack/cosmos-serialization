using Cosmos.Serialization.Variousness;
using Cosmos.Serialization.ZeroFormatter;

namespace Cosmos.Serialization;

/// <summary>
/// ZeroFormatter serializer
/// </summary>
public class ZeroFormatterObjectSerializer : IZeroFormatterSerializer
{
    /// <inheritdoc />
    public byte[] Serialize<T>(T o) => ZeroFormatterHelper.ToBytes(o);

    /// <inheritdoc />
    public Stream SerializeToStream<T>(T o) => ZeroFormatterHelper.ToStream(o);

    /// <inheritdoc />
    public T Deserialize<T>(byte[] data) => ZeroFormatterHelper.FromBytes<T>(data);

    /// <inheritdoc />
    public object Deserialize(byte[] data, Type type) => ZeroFormatterHelper.FromBytes(type, data);

    /// <inheritdoc />
    public T DeserializeFromStream<T>(Stream stream) => ZeroFormatterHelper.FromStream<T>(stream);

    /// <inheritdoc />
    public object DeserializeFromStream(Stream stream, Type type) => ZeroFormatterHelper.FromStream(type, stream);

    /// <inheritdoc />
    public Task<byte[]> SerializeAsync<T>(T o) => ZeroFormatterHelper.ToBytesAsync(o);

    /// <inheritdoc />
    public Task<Stream> SerializeToStreamAsync<T>(T o) => ZeroFormatterHelper.ToStreamAsync(o);

    /// <inheritdoc />
    public Task<T> DeserializeAsync<T>(byte[] data) => ZeroFormatterHelper.FromBytesAsync<T>(data);

    /// <inheritdoc />
    public Task<object> DeserializeAsync(byte[] data, Type type) => ZeroFormatterHelper.FromBytesAsync(type, data);

    /// <inheritdoc />
    public Task<T> DeserializeFromStreamAsync<T>(Stream stream) => ZeroFormatterHelper.FromStreamAsync<T>(stream);

    /// <inheritdoc />
    public Task<object> DeserializeFromStreamAsync(Stream stream, Type type) => ZeroFormatterHelper.FromStreamAsync(type, stream);
}