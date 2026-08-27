#nullable enable

namespace Photoroom.JsonConverters
{
    /// <inheritdoc />
    public sealed class VisualQaResponseClothingItemDetectionItemCategoryJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Photoroom.VisualQaResponseClothingItemDetectionItemCategory>
    {
        /// <inheritdoc />
        public override global::Photoroom.VisualQaResponseClothingItemDetectionItemCategory Read(
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
                        return global::Photoroom.VisualQaResponseClothingItemDetectionItemCategoryExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Photoroom.VisualQaResponseClothingItemDetectionItemCategory)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Photoroom.VisualQaResponseClothingItemDetectionItemCategory);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Photoroom.VisualQaResponseClothingItemDetectionItemCategory value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Photoroom.VisualQaResponseClothingItemDetectionItemCategoryExtensions.ToValueString(value));
        }
    }
}
