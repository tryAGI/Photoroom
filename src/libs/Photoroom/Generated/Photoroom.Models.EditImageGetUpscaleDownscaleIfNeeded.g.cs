
#nullable enable

namespace Photoroom
{
    /// <summary>
    /// 
    /// </summary>
    public enum EditImageGetUpscaleDownscaleIfNeeded
    {
        /// <summary>
        /// keep the current behavior and return an error when the image is too large. `always`: downscale oversized images to the largest input size accepted by the selected model before upscaling. `skipUpscaleIfNotNeeded`: only downscale oversized images when the 4x upscaled result can still be at least as large as the original input.
        /// </summary>
        Always,
        /// <summary>
        /// keep the current behavior and return an error when the image is too large. `always`: downscale oversized images to the largest input size accepted by the selected model before upscaling. `skipUpscaleIfNotNeeded`: only downscale oversized images when the 4x upscaled result can still be at least as large as the original input.
        /// </summary>
        Never,
        /// <summary>
        /// keep the current behavior and return an error when the image is too large. `always`: downscale oversized images to the largest input size accepted by the selected model before upscaling. `skipUpscaleIfNotNeeded`: only downscale oversized images when the 4x upscaled result can still be at least as large as the original input.
        /// </summary>
        SkipUpscaleIfNotNeeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EditImageGetUpscaleDownscaleIfNeededExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditImageGetUpscaleDownscaleIfNeeded value)
        {
            return value switch
            {
                EditImageGetUpscaleDownscaleIfNeeded.Always => "always",
                EditImageGetUpscaleDownscaleIfNeeded.Never => "never",
                EditImageGetUpscaleDownscaleIfNeeded.SkipUpscaleIfNotNeeded => "skipUpscaleIfNotNeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditImageGetUpscaleDownscaleIfNeeded? ToEnum(string value)
        {
            return value switch
            {
                "always" => EditImageGetUpscaleDownscaleIfNeeded.Always,
                "never" => EditImageGetUpscaleDownscaleIfNeeded.Never,
                "skipUpscaleIfNotNeeded" => EditImageGetUpscaleDownscaleIfNeeded.SkipUpscaleIfNotNeeded,
                _ => null,
            };
        }
    }
}