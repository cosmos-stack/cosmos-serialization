using System.Xml;

namespace Cosmos.Serialization.Newtonsoft;

public static partial class NewtonsoftJsonHelper
{
    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="json"></param>
    /// <returns></returns>
    public static XmlNode ToJsXmlNode(string json)
    {
        return json is null
            ? default
            : JsonConvert.DeserializeXmlNode(json);
    }

    /// <summary>
    /// Deserialize async
    /// </summary>
    /// <param name="json"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<XmlNode> ToJsXmlNodeAsync(string json, CancellationToken cancellationToken = default)
    {
        return json is null
            ? default
            : await Task.Run(() => JsonConvert.DeserializeXmlNode(json), cancellationToken);
    }
}