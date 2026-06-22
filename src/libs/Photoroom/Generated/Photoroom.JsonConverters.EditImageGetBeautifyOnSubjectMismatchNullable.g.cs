#nullable enable

namespace Photoroom.JsonConverters
{
    /// <inheritdoc />
    public sealed class EditImageGetBeautifyOnSubjectMismatchNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Photoroom.EditImageGetBeautifyOnSubjectMismatch?>
    {
        /// <inheritdoc />
        public override global::Photoroom.EditImageGetBeautifyOnSubjectMismatch? Read(
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
                        return global::Photoroom.EditImageGetBeautifyOnSubjectMismatchExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Photoroom.EditImageGetBeautifyOnSubjectMismatch)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Photoroom.EditImageGetBeautifyOnSubjectMismatch?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Photoroom.EditImageGetBeautifyOnSubjectMismatch? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Photoroom.EditImageGetBeautifyOnSubjectMismatchExtensions.ToValueString(value.Value));
            }
        }
    }
}
