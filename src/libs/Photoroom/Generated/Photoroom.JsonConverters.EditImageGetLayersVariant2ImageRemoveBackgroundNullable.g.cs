#nullable enable

namespace Photoroom.JsonConverters
{
    /// <inheritdoc />
    public sealed class EditImageGetLayersVariant2ImageRemoveBackgroundNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Photoroom.EditImageGetLayersVariant2ImageRemoveBackground?>
    {
        /// <inheritdoc />
        public override global::Photoroom.EditImageGetLayersVariant2ImageRemoveBackground? Read(
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
                        return global::Photoroom.EditImageGetLayersVariant2ImageRemoveBackgroundExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Photoroom.EditImageGetLayersVariant2ImageRemoveBackground)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Photoroom.EditImageGetLayersVariant2ImageRemoveBackground?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Photoroom.EditImageGetLayersVariant2ImageRemoveBackground? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Photoroom.EditImageGetLayersVariant2ImageRemoveBackgroundExtensions.ToValueString(value.Value));
            }
        }
    }
}
