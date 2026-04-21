
#nullable enable

namespace Photoroom
{
    /// <summary>
    /// 
    /// </summary>
    public enum EditImageGetShadowDirectionOverride2
    {
        /// <summary>
        /// 
        /// </summary>
        Behind,
        /// <summary>
        /// 
        /// </summary>
        BehindLeft,
        /// <summary>
        /// 
        /// </summary>
        BehindRight,
        /// <summary>
        /// 
        /// </summary>
        Front,
        /// <summary>
        /// 
        /// </summary>
        FrontLeft,
        /// <summary>
        /// 
        /// </summary>
        FrontRight,
        /// <summary>
        /// 
        /// </summary>
        Left,
        /// <summary>
        /// 
        /// </summary>
        Right,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EditImageGetShadowDirectionOverride2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditImageGetShadowDirectionOverride2 value)
        {
            return value switch
            {
                EditImageGetShadowDirectionOverride2.Behind => "behind",
                EditImageGetShadowDirectionOverride2.BehindLeft => "behindLeft",
                EditImageGetShadowDirectionOverride2.BehindRight => "behindRight",
                EditImageGetShadowDirectionOverride2.Front => "front",
                EditImageGetShadowDirectionOverride2.FrontLeft => "frontLeft",
                EditImageGetShadowDirectionOverride2.FrontRight => "frontRight",
                EditImageGetShadowDirectionOverride2.Left => "left",
                EditImageGetShadowDirectionOverride2.Right => "right",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditImageGetShadowDirectionOverride2? ToEnum(string value)
        {
            return value switch
            {
                "behind" => EditImageGetShadowDirectionOverride2.Behind,
                "behindLeft" => EditImageGetShadowDirectionOverride2.BehindLeft,
                "behindRight" => EditImageGetShadowDirectionOverride2.BehindRight,
                "front" => EditImageGetShadowDirectionOverride2.Front,
                "frontLeft" => EditImageGetShadowDirectionOverride2.FrontLeft,
                "frontRight" => EditImageGetShadowDirectionOverride2.FrontRight,
                "left" => EditImageGetShadowDirectionOverride2.Left,
                "right" => EditImageGetShadowDirectionOverride2.Right,
                _ => null,
            };
        }
    }
}