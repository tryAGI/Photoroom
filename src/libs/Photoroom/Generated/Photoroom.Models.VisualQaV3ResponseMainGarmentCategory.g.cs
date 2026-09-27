
#nullable enable

namespace Photoroom
{
    /// <summary>
    /// The categoryTaxonomy node matched to the main garment, with its full ancestry. Only present when the mainGarmentCategory feature is requested and a garment was matched.
    /// </summary>
    public sealed partial class VisualQaV3ResponseMainGarmentCategory
    {
        /// <summary>
        /// Code of the matched categoryTaxonomy node, returned verbatim.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// Name of the matched node.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Root-first ancestry of the matched node, ending with the node itself. Accuracy is highest at the shallower levels, so read the depth your catalogue actually distinguishes rather than always taking the leaf.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Photoroom.VisualQaV3ResponseMainGarmentCategoryPathItem> Path { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualQaV3ResponseMainGarmentCategory" /> class.
        /// </summary>
        /// <param name="code">
        /// Code of the matched categoryTaxonomy node, returned verbatim.
        /// </param>
        /// <param name="name">
        /// Name of the matched node.
        /// </param>
        /// <param name="path">
        /// Root-first ancestry of the matched node, ending with the node itself. Accuracy is highest at the shallower levels, so read the depth your catalogue actually distinguishes rather than always taking the leaf.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VisualQaV3ResponseMainGarmentCategory(
            string code,
            string name,
            global::System.Collections.Generic.IList<global::Photoroom.VisualQaV3ResponseMainGarmentCategoryPathItem> path)
        {
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualQaV3ResponseMainGarmentCategory" /> class.
        /// </summary>
        public VisualQaV3ResponseMainGarmentCategory()
        {
        }

    }
}