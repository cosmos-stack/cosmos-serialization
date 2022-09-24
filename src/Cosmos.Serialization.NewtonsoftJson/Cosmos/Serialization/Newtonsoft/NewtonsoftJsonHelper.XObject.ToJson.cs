using System.Xml.Linq;

namespace Cosmos.Serialization.Newtonsoft;

public static partial class NewtonsoftJsonHelper
{
    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="node"></param>
    /// <returns></returns>
    public static string ToJson(XObject node)
    {
        return node is null
            ? string.Empty
            : JsonConvert.SerializeXNode(node);
    }

    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="node"></param>
    /// <param name="formatting"></param>
    /// <returns></returns>
    public static string ToJson(XObject node, Formatting formatting)
    {
        return node is null
            ? string.Empty
            : JsonConvert.SerializeXNode(node, formatting);
    }

    /// <summary>
    /// Serialize
    /// </summary>
    /// <param name="node"></param>
    /// <param name="formatting"></param>
    /// <param name="omitRootObject"></param>
    /// <returns></returns>
    public static string ToJson(XObject node, Formatting formatting, bool omitRootObject)
    {
        return node is null
            ? string.Empty
            : JsonConvert.SerializeXNode(node, formatting, omitRootObject);
    }

    /// <summary>
    /// Serialize async
    /// </summary>
    /// <param name="node"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<string> ToJsonAsync(XObject node, CancellationToken cancellationToken = default)
    {
        return node is null
            ? string.Empty
            : await Task.Run(() => JsonConvert.SerializeXNode(node), cancellationToken);
    }

    /// <summary>
    /// Serialize async
    /// </summary>
    /// <param name="node"></param>
    /// <param name="formatting"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<string> ToJsonAsync(XObject node, Formatting formatting, CancellationToken cancellationToken = default)
    {
        return node is null
            ? string.Empty
            : await Task.Run(() => JsonConvert.SerializeXNode(node, formatting), cancellationToken);
    }

    /// <summary>
    /// Serialize async
    /// </summary>
    /// <param name="node"></param>
    /// <param name="omitRootObject"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="formatting"></param>
    /// <returns></returns>
    public static async Task<string> ToJsonAsync(XObject node, Formatting formatting, bool omitRootObject, CancellationToken cancellationToken = default)
    {
        return node is null
            ? string.Empty
            : await Task.Run(() => JsonConvert.SerializeXNode(node, formatting, omitRootObject), cancellationToken);
    }
}