using Newtonsoft.Json;

namespace Cosmos.EnumUtils.DynamicEnumServices;

public class DynamicFlagEnumNameConverter<TEnum, TValue> : JsonConverter<TEnum>
    where TEnum : DynamicFlagEnum<TEnum, TValue>, IDynamicEnum
    where TValue : struct, IEquatable<TValue>, IComparable<TValue>
{
    public override bool CanRead => true;

    public override bool CanWrite => true;

    public override TEnum ReadJson(JsonReader reader, Type objectType, TEnum existingValue, bool hasExistingValue, JsonSerializer serializer)
    {
        return reader.TokenType switch
        {
            JsonToken.String => __getViaName((string) reader.Value),
            _ => throw new JsonSerializationException($"Unexpected token {reader.TokenType} when parsing a dynamic enum.")
        };

        TEnum __getViaName(string name)
        {
            try
            {
                return DynamicFlagEnum<TEnum, TValue>.FromName(name, false);
            }
            catch (Exception ex)
            {
                throw new JsonSerializationException($"Error converting value '{name}' to a dynamic enum.", ex);
            }
        }
    }

    public override void WriteJson(JsonWriter writer, TEnum value, JsonSerializer serializer)
    {
        if (value is null)
            writer.WriteNull();
        else
            writer.WriteValue(value.Name);
    }
}