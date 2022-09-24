using System.Text;
using Cosmos.Text;
using SpanJson;

namespace Cosmos.Serialization.SpanJson;

public static partial class SpanJsonHelper
{
    public static string ToMinifyJson(string json)
    {
        return JsonSerializer.Minifier.Minify(json);
    }

    public static string ToMinifyJson(in ReadOnlySpan<char> jsonChar)
    {
        return JsonSerializer.Minifier.Minify(jsonChar);
    }

    public static string ToMinifyJson(in ReadOnlySpan<byte> jsonBytes, Encoding encoding = null)
    {
        return JsonSerializer.Minifier.Minify(jsonBytes).GetString(encoding.GetEncoding());
    }

    public static byte[] ToMinifyBytes(in ReadOnlySpan<byte> jsonBytes)
    {
        return JsonSerializer.Minifier.Minify(jsonBytes);
    }

    public static string ToPrettyPrintJson(string json)
    {
        return JsonSerializer.PrettyPrinter.Print(json);
    }

    public static string ToPrettyPrintJson(in ReadOnlySpan<char> jsonChar)
    {
        return JsonSerializer.PrettyPrinter.Print(jsonChar);
    }

    public static string ToPrettyPrintJson(in ReadOnlySpan<byte> jsonBytes, Encoding encoding = null)
    {
        return JsonSerializer.PrettyPrinter.Print(jsonBytes).GetString(encoding.GetEncoding());
    }

    public static byte[] ToPrettyPrintBytes(in ReadOnlySpan<byte> jsonBytes)
    {
        return JsonSerializer.PrettyPrinter.Print(jsonBytes);
    }
}