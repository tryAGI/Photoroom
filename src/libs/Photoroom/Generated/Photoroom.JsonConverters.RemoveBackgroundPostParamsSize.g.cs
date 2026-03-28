#nullable enable

namespace Photoroom.JsonConverters
{
    /// <inheritdoc />
    public sealed class RemoveBackgroundPostParamsSizeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Photoroom.RemoveBackgroundPostParamsSize>
    {
        /// <inheritdoc />
        public override global::Photoroom.RemoveBackgroundPostParamsSize Read(
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
                        return global::Photoroom.RemoveBackgroundPostParamsSizeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Photoroom.RemoveBackgroundPostParamsSize)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Photoroom.RemoveBackgroundPostParamsSize);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Photoroom.RemoveBackgroundPostParamsSize value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Photoroom.RemoveBackgroundPostParamsSizeExtensions.ToValueString(value));
        }
    }
}
