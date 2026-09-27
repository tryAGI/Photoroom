#nullable enable

namespace Photoroom.JsonConverters
{
    /// <inheritdoc />
    public sealed class VisualQaV3ResponseMainGarmentTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Photoroom.VisualQaV3ResponseMainGarmentType?>
    {
        /// <inheritdoc />
        public override global::Photoroom.VisualQaV3ResponseMainGarmentType? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Photoroom.VisualQaV3ResponseMainGarmentTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Photoroom.VisualQaV3ResponseMainGarmentType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Photoroom.VisualQaV3ResponseMainGarmentType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Photoroom.VisualQaV3ResponseMainGarmentType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Photoroom.VisualQaV3ResponseMainGarmentTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
