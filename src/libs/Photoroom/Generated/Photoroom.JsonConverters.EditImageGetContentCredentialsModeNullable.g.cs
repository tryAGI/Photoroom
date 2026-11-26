#nullable enable

namespace Photoroom.JsonConverters
{
    /// <inheritdoc />
    public sealed class EditImageGetContentCredentialsModeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Photoroom.EditImageGetContentCredentialsMode?>
    {
        /// <inheritdoc />
        public override global::Photoroom.EditImageGetContentCredentialsMode? Read(
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
                        return global::Photoroom.EditImageGetContentCredentialsModeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Photoroom.EditImageGetContentCredentialsMode)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Photoroom.EditImageGetContentCredentialsMode?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Photoroom.EditImageGetContentCredentialsMode? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Photoroom.EditImageGetContentCredentialsModeExtensions.ToValueString(value.Value));
            }
        }
    }
}
