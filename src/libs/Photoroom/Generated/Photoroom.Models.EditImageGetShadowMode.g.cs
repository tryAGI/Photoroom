
#nullable enable

namespace Photoroom
{
    /// <summary>
    /// 
    /// </summary>
    public enum EditImageGetShadowMode
    {
        /// <summary>
        /// 
        /// </summary>
        AiAutoWithOverrides,
        /// <summary>
        /// 
        /// </summary>
        AiFloating,
        /// <summary>
        /// 
        /// </summary>
        AiHard,
        /// <summary>
        /// 
        /// </summary>
        AiPresetHard,
        /// <summary>
        /// 
        /// </summary>
        AiPresetSoft,
        /// <summary>
        /// 
        /// </summary>
        AiSoft,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EditImageGetShadowModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditImageGetShadowMode value)
        {
            return value switch
            {
                EditImageGetShadowMode.AiAutoWithOverrides => "ai.auto-with-overrides",
                EditImageGetShadowMode.AiFloating => "ai.floating",
                EditImageGetShadowMode.AiHard => "ai.hard",
                EditImageGetShadowMode.AiPresetHard => "ai.preset-hard",
                EditImageGetShadowMode.AiPresetSoft => "ai.preset-soft",
                EditImageGetShadowMode.AiSoft => "ai.soft",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditImageGetShadowMode? ToEnum(string value)
        {
            return value switch
            {
                "ai.auto-with-overrides" => EditImageGetShadowMode.AiAutoWithOverrides,
                "ai.floating" => EditImageGetShadowMode.AiFloating,
                "ai.hard" => EditImageGetShadowMode.AiHard,
                "ai.preset-hard" => EditImageGetShadowMode.AiPresetHard,
                "ai.preset-soft" => EditImageGetShadowMode.AiPresetSoft,
                "ai.soft" => EditImageGetShadowMode.AiSoft,
                _ => null,
            };
        }
    }
}