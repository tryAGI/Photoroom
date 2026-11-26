
#nullable enable

namespace Photoroom
{
    /// <summary>
    /// Default Value: auto
    /// </summary>
    public enum EditImageGetContentCredentialsMode
    {
        /// <summary>
        /// the output is also signed when no AI operation ran, for example a background   removal or a layout-only edit.
        /// </summary>
        Always,
        /// <summary>
        /// the output is signed when an AI operation generated part or all of it.
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EditImageGetContentCredentialsModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditImageGetContentCredentialsMode value)
        {
            return value switch
            {
                EditImageGetContentCredentialsMode.Always => "always",
                EditImageGetContentCredentialsMode.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditImageGetContentCredentialsMode? ToEnum(string value)
        {
            return value switch
            {
                "always" => EditImageGetContentCredentialsMode.Always,
                "auto" => EditImageGetContentCredentialsMode.Auto,
                _ => null,
            };
        }
    }
}