using System.Xml.Linq;

namespace Cosmos.Serialization.Newtonsoft;

public static partial class NewtonsoftJsonHelper
{
    /// <summary>
    /// Deserialize
    /// </summary>
    /// <param name="json"></param>
    /// <returns></returns>
    public static XObject ToXNode(string json)
    {
        return json is null
            ? default
            : JsonConvert.DeserializeXNode(json);
    }

    /// <summary>
    /// Deserialize async
    /// </summary>
    /// <param name="json"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<XObject> ToXNodeAsync(string json, CancellationToken cancellationToken = default)
    {
        return json is null
            ? default
            : await Task.Run(() => JsonConvert.DeserializeXNode(json), cancellationToken);
    }
}