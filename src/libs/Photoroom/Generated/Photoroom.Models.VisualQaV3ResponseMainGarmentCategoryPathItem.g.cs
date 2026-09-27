
#nullable enable

namespace Photoroom
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VisualQaV3ResponseMainGarmentCategoryPathItem
    {
        /// <summary>
        /// Code of this ancestor, as supplied in categoryTaxonomy.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// Name of this ancestor, as supplied in categoryTaxonomy.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualQaV3ResponseMainGarmentCategoryPathItem" /> class.
        /// </summary>
        /// <param name="code">
        /// Code of this ancestor, as supplied in categoryTaxonomy.
        /// </param>
        /// <param name="name">
        /// Name of this ancestor, as supplied in categoryTaxonomy.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VisualQaV3ResponseMainGarmentCategoryPathItem(
            string code,
            string name)
        {
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualQaV3ResponseMainGarmentCategoryPathItem" /> class.
        /// </summary>
        public VisualQaV3ResponseMainGarmentCategoryPathItem()
        {
        }

    }
}