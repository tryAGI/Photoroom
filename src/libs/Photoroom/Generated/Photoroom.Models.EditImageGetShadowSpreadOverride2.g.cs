
#nullable enable

namespace Photoroom
{
    /// <summary>
    /// 
    /// </summary>
    public enum EditImageGetShadowSpreadOverride2
    {
        /// <summary>
        /// 
        /// </summary>
        Long,
        /// <summary>
        /// 
        /// </summary>
        Medium,
        /// <summary>
        /// 
        /// </summary>
        Short,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EditImageGetShadowSpreadOverride2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditImageGetShadowSpreadOverride2 value)
        {
            return value switch
            {
                EditImageGetShadowSpreadOverride2.Long => "long",
                EditImageGetShadowSpreadOverride2.Medium => "medium",
                EditImageGetShadowSpreadOverride2.Short => "short",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditImageGetShadowSpreadOverride2? ToEnum(string value)
        {
            return value switch
            {
                "long" => EditImageGetShadowSpreadOverride2.Long,
                "medium" => EditImageGetShadowSpreadOverride2.Medium,
                "short" => EditImageGetShadowSpreadOverride2.Short,
                _ => null,
            };
        }
    }
}