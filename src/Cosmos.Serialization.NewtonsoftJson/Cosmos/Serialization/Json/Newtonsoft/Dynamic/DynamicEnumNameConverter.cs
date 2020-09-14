using System;
using Cosmos.Dynamic;
using Newtonsoft.Json;

namespace Cosmos.Serialization.Json.Newtonsoft.Dynamic
{
    public class DynamicEnumNameConverter<TEnum, TValue> : JsonConverter<TEnum>
        where TEnum : DynamicEnum<TEnum, TValue>
        where TValue : struct, IEquatable<TValue>, IComparable<TValue>
    {
        public override bool CanRead => true;

        public override bool CanWrite => true;

        public override TEnum ReadJson(JsonReader reader, Type objectType, TEnum existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            return reader.TokenType switch
            {
                JsonToken.String => __getViaName((string) reader.Value),
                _ => throw new JsonSerializationException($"Unexpected token {reader.TokenType} when parsing a smart enum.")
            };

            TEnum __getViaName(string name)
            {
                try
                {
                    return DynamicEnum<TEnum, TValue>.FromName(name, false);
                }
                catch (Exception ex)
                {
                    throw new JsonSerializationException($"Error converting value '{name}' to a smart enum.", ex);
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
}