namespace Cosmos.Serialization.SharpYaml;

public static partial class SharpYamlExtensions
{
    /// <summary>
    /// Serialize the value to yaml text and write it to the <see cref="System.IO.Stream"/>.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <param name="serializer"></param>
    /// <typeparam name="TValue"></typeparam>
    public static void SharpYamlPackTo<TValue>(this TValue value, Stream stream, Serializer serializer = null)
    {
        SharpYamlHelper.Pack(value, stream, serializer);
    }

    /// <summary>
    /// Serialize the value to yaml text and write it to the <see cref="System.IO.Stream"/>.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <param name="type"></param>
    /// <param name="serializer"></param>
    public static void SharpYamlPackTo(this object value, Type type, Stream stream, Serializer serializer = null)
    {
        SharpYamlHelper.Pack(type, value, stream, serializer);
    }

    /// <summary>
    /// Serialize the value to yaml text and write it to the <see cref="System.IO.Stream"/>.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <param name="serializer"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TValue"></typeparam>
    public static Task SharpYamlPackToAsync<TValue>(this TValue value, Stream stream, Serializer serializer = null, CancellationToken cancellationToken = default)
    {
        return SharpYamlHelper.PackAsync(value, stream, serializer, cancellationToken);
    }

    /// <summary>
    /// Serialize the value to yaml text and write it to the <see cref="System.IO.Stream"/>.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="stream"></param>
    /// <param name="type"></param>
    /// <param name="serializer"></param>
    /// <param name="cancellationToken"></param>
    public static Task SharpYamlPackToAsync(this object value, Type type, Stream stream, Serializer serializer = null, CancellationToken cancellationToken = default)
    {
        return SharpYamlHelper.PackAsync(type, value, stream, serializer, cancellationToken);
    }
}