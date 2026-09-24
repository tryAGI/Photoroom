
#nullable enable

namespace Photoroom
{
    /// <summary>
    /// Distinct clothing, footwear, and accessory items detected in the image. Only present when clothingItemDetection is requested.
    /// </summary>
    public sealed partial class VisualQaV3ResponseClothingItemDetection
    {
        /// <summary>
        /// Distinct clothing items, footwear, and accessories detected in the image, each with a short name and a category from a fixed list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Photoroom.VisualQaV3ResponseClothingItemDetectionItem> Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualQaV3ResponseClothingItemDetection" /> class.
        /// </summary>
        /// <param name="items">
        /// Distinct clothing items, footwear, and accessories detected in the image, each with a short name and a category from a fixed list.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VisualQaV3ResponseClothingItemDetection(
            global::System.Collections.Generic.IList<global::Photoroom.VisualQaV3ResponseClothingItemDetectionItem> items)
        {
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualQaV3ResponseClothingItemDetection" /> class.
        /// </summary>
        public VisualQaV3ResponseClothingItemDetection()
        {
        }

    }
}