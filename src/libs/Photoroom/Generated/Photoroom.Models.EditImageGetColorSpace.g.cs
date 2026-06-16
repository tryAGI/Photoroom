
#nullable enable

namespace Photoroom
{
    /// <summary>
    /// Default Value: sRGB
    /// </summary>
    public enum EditImageGetColorSpace
    {
        /// <summary>
        /// 'auto', EXIF-subset preserveMetadata modes, ...) returns a 400 error naming the conflicting parameter.
        /// </summary>
        Original,
        /// <summary>
        /// 'auto', EXIF-subset preserveMetadata modes, ...) returns a 400 error naming the conflicting parameter.
        /// </summary>
        Srgb,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EditImageGetColorSpaceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditImageGetColorSpace value)
        {
            return value switch
            {
                EditImageGetColorSpace.Original => "original",
                EditImageGetColorSpace.Srgb => "sRGB",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditImageGetColorSpace? ToEnum(string value)
        {
            return value switch
            {
                "original" => EditImageGetColorSpace.Original,
                "sRGB" => EditImageGetColorSpace.Srgb,
                _ => null,
            };
        }
    }
}