
#nullable enable

namespace Photoroom
{
    /// <summary>
    /// The colorTaxonomy entry matched to the main garment. Only present when the mainGarmentColor feature is requested and a garment was matched.<br/>
    /// Example: {"code":"COLOR-042","name":"Brick","hex":"#AF4942"}
    /// </summary>
    public sealed partial class VisualQaV3ResponseMainGarmentColor
    {
        /// <summary>
        /// Code of the matched colorTaxonomy entry, returned verbatim.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// Name of the matched entry, present only if the supplied entry carried one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Hex colour of the matched entry.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hex")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Hex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualQaV3ResponseMainGarmentColor" /> class.
        /// </summary>
        /// <param name="code">
        /// Code of the matched colorTaxonomy entry, returned verbatim.
        /// </param>
        /// <param name="hex">
        /// Hex colour of the matched entry.
        /// </param>
        /// <param name="name">
        /// Name of the matched entry, present only if the supplied entry carried one.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VisualQaV3ResponseMainGarmentColor(
            string code,
            string hex,
            string? name)
        {
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Name = name;
            this.Hex = hex ?? throw new global::System.ArgumentNullException(nameof(hex));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualQaV3ResponseMainGarmentColor" /> class.
        /// </summary>
        public VisualQaV3ResponseMainGarmentColor()
        {
        }

    }
}