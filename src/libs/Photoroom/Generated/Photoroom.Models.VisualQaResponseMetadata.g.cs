
#nullable enable

namespace Photoroom
{
    /// <summary>
    /// Basic image metadata.
    /// </summary>
    public sealed partial class VisualQaResponseMetadata
    {
        /// <summary>
        /// Image width in pixels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        public double? Width { get; set; }

        /// <summary>
        /// Image height in pixels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        public double? Height { get; set; }

        /// <summary>
        /// Image format, e.g. "jpeg" or "png".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        public string? Format { get; set; }

        /// <summary>
        /// Approximate image size in megabytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sizeMB")]
        public double? SizeMB { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualQaResponseMetadata" /> class.
        /// </summary>
        /// <param name="width">
        /// Image width in pixels.
        /// </param>
        /// <param name="height">
        /// Image height in pixels.
        /// </param>
        /// <param name="format">
        /// Image format, e.g. "jpeg" or "png".
        /// </param>
        /// <param name="sizeMB">
        /// Approximate image size in megabytes.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VisualQaResponseMetadata(
            double? width,
            double? height,
            string? format,
            double? sizeMB)
        {
            this.Width = width;
            this.Height = height;
            this.Format = format;
            this.SizeMB = sizeMB;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualQaResponseMetadata" /> class.
        /// </summary>
        public VisualQaResponseMetadata()
        {
        }

    }
}