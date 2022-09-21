using Cosmos.IO;

namespace Cosmos.Serialization.SharpYaml;

public static partial class SharpYamlHelper
{
    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <param name="serializer"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static Stream ToStream<TValue>(TValue value, Serializer serializer = null)
    {
        var ms = new MemoryStream();
        (serializer ?? Man.DefaultSerializer).Serialize(ms, value, typeof(TValue));
        ms.TrySeek(0, SeekOrigin.Begin);
        return ms;
    }

    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <param name="type"></param>
    /// <param name="serializer"></param>
    /// <returns></returns>
    public static Stream ToStream(Type type, object value, Serializer serializer = null)
    {
        var ms = new MemoryStream();
        (serializer ?? Man.DefaultSerializer).Serialize(ms, value, type);
        ms.TrySeek(0, SeekOrigin.Begin);
        return ms;
    }

    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <param name="serializer"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    /// <returns></returns>
    public static async Task<Stream> ToStreamAsync<TValue>(TValue value, Serializer serializer = null, CancellationToken cancellationToken = default)
    {
        var ms = new MemoryStream();
        await Task.Run(() => (serializer ?? Man.DefaultSerializer).Serialize(ms, value, typeof(TValue)), cancellationToken);
        ms.TrySeek(0, SeekOrigin.Begin);
        return ms;
    }

    /// <summary>
    /// Pack
    /// </summary>
    /// <param name="value"></param>
    /// <param name="type"></param>
    /// <param name="serializer"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<Stream> ToStreamAsync(Type type, object value, Serializer serializer = null, CancellationToken cancellationToken = default)
    {
        var ms = new MemoryStream();
        await Task.Run(() => (serializer ?? Man.DefaultSerializer).Serialize(ms, value, type), cancellationToken);
        ms.TrySeek(0, SeekOrigin.Begin);
        return ms;
    }
}