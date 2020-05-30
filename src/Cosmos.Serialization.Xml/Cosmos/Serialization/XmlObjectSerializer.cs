using System;
using System.IO;
using System.Threading.Tasks;
using Cosmos.Serialization.Xml;

namespace Cosmos.Serialization
{
    /// <summary>
    /// Xml Serializer
    /// </summary>
    public class XmlObjectSerializer : IXmlSerializer
    {
        /// <inheritdoc />
        public string Serialize<T>(T o)
        {
            return XmlHelper.Serialize(o);
        }

        /// <inheritdoc />
        public Stream SerializeToStream<T>(T o)
        {
            return XmlHelper.Pack(o);
        }

        /// <inheritdoc />
        public T Deserialize<T>(string data)
        {
            return XmlHelper.Deserialize<T>(data);
        }

        /// <inheritdoc />
        public object Deserialize(string data, Type type)
        {
            return XmlHelper.Deserialize(data, type);
        }

        /// <inheritdoc />
        public T DeserializeFromStream<T>(Stream stream)
        {
            return XmlHelper.Unpack<T>(stream);
        }

        /// <inheritdoc />
        public object DeserializeFromStream(Stream stream, Type type)
        {
            return XmlHelper.Unpack(stream, type);
        }

        /// <inheritdoc />
        public Task<string> SerializeAsync<T>(T o)
        {
            return XmlHelper.SerializeAsync(o);
        }

        /// <inheritdoc />
        public Task<Stream> SerializeToStreamAsync<T>(T o)
        {
            return XmlHelper.PackAsync(o);
        }

        /// <inheritdoc />
        public Task<T> DeserializeAsync<T>(string data)
        {
            return XmlHelper.DeserializeAsync<T>(data);
        }

        /// <inheritdoc />
        public Task<object> DeserializeAsync(string data, Type type)
        {
            return XmlHelper.DeserializeAsync(data, type);
        }

        /// <inheritdoc />
        public Task<T> DeserializeFromStreamAsync<T>(Stream stream)
        {
            return XmlHelper.UnpackAsync<T>(stream);
        }

        /// <inheritdoc />
        public Task<object> DeserializeFromStreamAsync(Stream stream, Type type)
        {
            return XmlHelper.UnpackAsync(stream, type);
        }
    }
}