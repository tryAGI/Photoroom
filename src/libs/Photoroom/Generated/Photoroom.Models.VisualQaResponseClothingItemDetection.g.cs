
#nullable enable

namespace Photoroom
{
    /// <summary>
    /// Distinct clothing, footwear, and accessory items detected in the image. Only present when clothingItemDetection is requested.
    /// </summary>
    public sealed partial class VisualQaResponseClothingItemDetection
    {
        /// <summary>
        /// Distinct clothing items, footwear, and accessories detected in the image, each with a short name and a category from a fixed list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Photoroom.VisualQaResponseClothingItemDetectionItem> Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualQaResponseClothingItemDetection" /> class.
        /// </summary>
        /// <param name="items">
        /// Distinct clothing items, footwear, and accessories detected in the image, each with a short name and a category from a fixed list.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VisualQaResponseClothingItemDetection(
            global::System.Collections.Generic.IList<global::Photoroom.VisualQaResponseClothingItemDetectionItem> items)
        {
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualQaResponseClothingItemDetection" /> class.
        /// </summary>
        public VisualQaResponseClothingItemDetection()
        {
        }

    }
}