
#nullable enable

namespace Photoroom
{
    /// <summary>
    /// 
    /// </summary>
    public enum EditImageGetShadowSubjectPoseOverride2
    {
        /// <summary>
        /// 
        /// </summary>
        Flatlay,
        /// <summary>
        /// 
        /// </summary>
        Upright,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EditImageGetShadowSubjectPoseOverride2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditImageGetShadowSubjectPoseOverride2 value)
        {
            return value switch
            {
                EditImageGetShadowSubjectPoseOverride2.Flatlay => "flatlay",
                EditImageGetShadowSubjectPoseOverride2.Upright => "upright",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditImageGetShadowSubjectPoseOverride2? ToEnum(string value)
        {
            return value switch
            {
                "flatlay" => EditImageGetShadowSubjectPoseOverride2.Flatlay,
                "upright" => EditImageGetShadowSubjectPoseOverride2.Upright,
                _ => null,
            };
        }
    }
}