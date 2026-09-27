
#nullable enable

namespace Photoroom
{
    /// <summary>
    /// The garment mainGarmentColor and mainGarmentCategory describe. Only present when at least one of those two features is requested and a garment was found. It can be present without either classification, when the garment matched no entry of the supplied taxonomies.
    /// </summary>
    public sealed partial class VisualQaV3ResponseMainGarment
    {
        /// <summary>
        /// Short name of the garment that was classified (e.g. "rust blouse"), naming which item mainGarmentColor and mainGarmentCategory describe.<br/>
        /// Example: rust blouse
        /// </summary>
        /// <example>rust blouse</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Photoroom's own fixed category for that garment, from the same list as clothingItemDetection items and independent of the supplied categoryTaxonomy.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Photoroom.JsonConverters.VisualQaV3ResponseMainGarmentTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Photoroom.VisualQaV3ResponseMainGarmentType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualQaV3ResponseMainGarment" /> class.
        /// </summary>
        /// <param name="description">
        /// Short name of the garment that was classified (e.g. "rust blouse"), naming which item mainGarmentColor and mainGarmentCategory describe.<br/>
        /// Example: rust blouse
        /// </param>
        /// <param name="type">
        /// Photoroom's own fixed category for that garment, from the same list as clothingItemDetection items and independent of the supplied categoryTaxonomy.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VisualQaV3ResponseMainGarment(
            string description,
            global::Photoroom.VisualQaV3ResponseMainGarmentType type)
        {
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualQaV3ResponseMainGarment" /> class.
        /// </summary>
        public VisualQaV3ResponseMainGarment()
        {
        }

    }
}