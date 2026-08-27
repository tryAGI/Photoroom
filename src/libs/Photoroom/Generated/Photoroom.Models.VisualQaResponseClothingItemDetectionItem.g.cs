
#nullable enable

namespace Photoroom
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VisualQaResponseClothingItemDetectionItem
    {
        /// <summary>
        /// Short, descriptive name of the item (e.g. "black leather jacket"). Plain name only — no bounding boxes — intended for direct use as a text-guided-segmentation prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The clothing category this item was classified into, from a fixed, versioned list (e.g. pumps or sneakers are classified as "shoes").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Photoroom.JsonConverters.VisualQaResponseClothingItemDetectionItemCategoryJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Photoroom.VisualQaResponseClothingItemDetectionItemCategory Category { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualQaResponseClothingItemDetectionItem" /> class.
        /// </summary>
        /// <param name="name">
        /// Short, descriptive name of the item (e.g. "black leather jacket"). Plain name only — no bounding boxes — intended for direct use as a text-guided-segmentation prompt.
        /// </param>
        /// <param name="category">
        /// The clothing category this item was classified into, from a fixed, versioned list (e.g. pumps or sneakers are classified as "shoes").
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VisualQaResponseClothingItemDetectionItem(
            string name,
            global::Photoroom.VisualQaResponseClothingItemDetectionItemCategory category)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Category = category;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualQaResponseClothingItemDetectionItem" /> class.
        /// </summary>
        public VisualQaResponseClothingItemDetectionItem()
        {
        }

    }
}