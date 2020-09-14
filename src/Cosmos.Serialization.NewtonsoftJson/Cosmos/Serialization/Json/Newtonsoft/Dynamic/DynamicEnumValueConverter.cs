using System;
using Cosmos.Dynamic;
using Newtonsoft.Json;

namespace Cosmos.Serialization.Json.Newtonsoft.Dynamic
{
    public class DynamicEnumValueConverter<TEnum, TValue> : JsonConverter<TEnum>
        where TEnum : DynamicEnum<TEnum, TValue>
        where TValue : struct, IEquatable<TValue>, IComparable<TValue>
    {
        public override bool CanRead => true;

        public override bool CanWrite => true;

        public override TEnum ReadJson(JsonReader reader, Type objectType, TEnum existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            try
            {
                TValue value;

                if (reader.TokenType == JsonToken.Integer &&
                    typeof(TValue) != typeof(long) &&
                    typeof(TValue) != typeof(bool))
                {
                    value = (TValue) Convert.ChangeType(reader.Value, typeof(TValue));
                }
                else
                {
                    value = (TValue) reader.Value!;
                }

                return DynamicEnum<TEnum, TValue>.SingleFromValue(value);
            }
            catch (Exception ex)
            {
                throw new JsonSerializationException($"Error converting {reader.Value ?? "Null"} to {objectType.Name}.", ex);
            }
        }

        public override void WriteJson(JsonWriter writer, TEnum value, JsonSerializer serializer)
        {
            if (value is null)
                writer.WriteNull();
            else
                writer.WriteValue(value.Value);
        }
    }
}