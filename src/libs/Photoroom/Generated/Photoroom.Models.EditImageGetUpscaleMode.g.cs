
#nullable enable

namespace Photoroom
{
    /// <summary>
    /// 
    /// </summary>
    public enum EditImageGetUpscaleMode
    {
        /// <summary>
        /// maximum 1,000,000 input pixels
        /// </summary>
        AiFast,
        /// <summary>
        /// maximum 512,000 input pixels
        /// </summary>
        AiSlow,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EditImageGetUpscaleModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditImageGetUpscaleMode value)
        {
            return value switch
            {
                EditImageGetUpscaleMode.AiFast => "ai.fast",
                EditImageGetUpscaleMode.AiSlow => "ai.slow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditImageGetUpscaleMode? ToEnum(string value)
        {
            return value switch
            {
                "ai.fast" => EditImageGetUpscaleMode.AiFast,
                "ai.slow" => EditImageGetUpscaleMode.AiSlow,
                _ => null,
            };
        }
    }
}