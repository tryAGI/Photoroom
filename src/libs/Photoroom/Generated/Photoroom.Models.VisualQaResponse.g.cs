
#nullable enable

namespace Photoroom
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VisualQaResponse
    {
        /// <summary>
        /// A generated caption describing the image. Omitted if no caption could be produced.<br/>
        /// Example: Three gold rings with blue stones on a marble surface.
        /// </summary>
        /// <example>Three gold rings with blue stones on a marble surface.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("caption")]
        public string? Caption { get; set; }

        /// <summary>
        /// Distinct clothing, footwear, and accessory items detected in the image. Only present when clothingItemDetection is requested.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clothingItemDetection")]
        public global::Photoroom.VisualQaResponseClothingItemDetection? ClothingItemDetection { get; set; }

        /// <summary>
        /// Basic image metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Photoroom.VisualQaResponseMetadata Metadata { get; set; }

        /// <summary>
        /// Requested features and their results; only requested features are present.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("features")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Photoroom.VisualQaResponseFeatures Features { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualQaResponse" /> class.
        /// </summary>
        /// <param name="metadata">
        /// Basic image metadata.
        /// </param>
        /// <param name="features">
        /// Requested features and their results; only requested features are present.
        /// </param>
        /// <param name="caption">
        /// A generated caption describing the image. Omitted if no caption could be produced.<br/>
        /// Example: Three gold rings with blue stones on a marble surface.
        /// </param>
        /// <param name="clothingItemDetection">
        /// Distinct clothing, footwear, and accessory items detected in the image. Only present when clothingItemDetection is requested.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VisualQaResponse(
            global::Photoroom.VisualQaResponseMetadata metadata,
            global::Photoroom.VisualQaResponseFeatures features,
            string? caption,
            global::Photoroom.VisualQaResponseClothingItemDetection? clothingItemDetection)
        {
            this.Caption = caption;
            this.ClothingItemDetection = clothingItemDetection;
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.Features = features ?? throw new global::System.ArgumentNullException(nameof(features));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualQaResponse" /> class.
        /// </summary>
        public VisualQaResponse()
        {
        }

    }
}