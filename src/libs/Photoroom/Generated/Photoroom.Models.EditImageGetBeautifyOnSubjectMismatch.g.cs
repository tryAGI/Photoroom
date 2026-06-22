
#nullable enable

namespace Photoroom
{
    /// <summary>
    /// 
    /// </summary>
    public enum EditImageGetBeautifyOnSubjectMismatch
    {
        /// <summary>
        /// for `ai.food`, when the provided image is not detected as food (before any processing happens) — use this to fail fast instead of beautifying a non-food image; for any other mode, because the check is not supported there.
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Ignore,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EditImageGetBeautifyOnSubjectMismatchExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditImageGetBeautifyOnSubjectMismatch value)
        {
            return value switch
            {
                EditImageGetBeautifyOnSubjectMismatch.Error => "error",
                EditImageGetBeautifyOnSubjectMismatch.Ignore => "ignore",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditImageGetBeautifyOnSubjectMismatch? ToEnum(string value)
        {
            return value switch
            {
                "error" => EditImageGetBeautifyOnSubjectMismatch.Error,
                "ignore" => EditImageGetBeautifyOnSubjectMismatch.Ignore,
                _ => null,
            };
        }
    }
}