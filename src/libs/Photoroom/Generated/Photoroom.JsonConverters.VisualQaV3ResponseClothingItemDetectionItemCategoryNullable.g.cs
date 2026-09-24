#nullable enable

namespace Photoroom.JsonConverters
{
    /// <inheritdoc />
    public sealed class VisualQaV3ResponseClothingItemDetectionItemCategoryNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Photoroom.VisualQaV3ResponseClothingItemDetectionItemCategory?>
    {
        /// <inheritdoc />
        public override global::Photoroom.VisualQaV3ResponseClothingItemDetectionItemCategory? Read(
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
                        return global::Photoroom.VisualQaV3ResponseClothingItemDetectionItemCategoryExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Photoroom.VisualQaV3ResponseClothingItemDetectionItemCategory)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Photoroom.VisualQaV3ResponseClothingItemDetectionItemCategory?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Photoroom.VisualQaV3ResponseClothingItemDetectionItemCategory? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Photoroom.VisualQaV3ResponseClothingItemDetectionItemCategoryExtensions.ToValueString(value.Value));
            }
        }
    }
}
