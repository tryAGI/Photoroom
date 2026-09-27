
#nullable enable

namespace Photoroom
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VisualQaV3Request
    {
        /// <summary>
        /// Image to analyze, as a binary file. Provide exactly one of imageFile or imageUrl.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageFile")]
        public byte[]? ImageFile { get; set; }

        /// <summary>
        /// Image to analyze, as a binary file. Provide exactly one of imageFile or imageUrl.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageFilename")]
        public string? ImageFilename { get; set; }

        /// <summary>
        /// URL of the image to analyze. Provide exactly one of imageFile or imageUrl.<br/>
        /// Example: https://example.com/image.jpg
        /// </summary>
        /// <example>https://example.com/image.jpg</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageUrl")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// Reference image (binary) to compare against, required when features includes fashionFidelity or foodFidelity. Provide exactly one of referenceImageFile or referenceImageUrl.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceImageFile")]
        public byte[]? ReferenceImageFile { get; set; }

        /// <summary>
        /// Reference image (binary) to compare against, required when features includes fashionFidelity or foodFidelity. Provide exactly one of referenceImageFile or referenceImageUrl.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceImageFilename")]
        public string? ReferenceImageFilename { get; set; }

        /// <summary>
        /// URL of the reference image to compare against, required when features includes fashionFidelity or foodFidelity. Provide exactly one of referenceImageFile or referenceImageUrl.<br/>
        /// Example: https://example.com/reference.jpg
        /// </summary>
        /// <example>https://example.com/reference.jpg</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceImageUrl")]
        public string? ReferenceImageUrl { get; set; }

        /// <summary>
        /// Features to run, as an array or a comma-separated string (e.g. "caption,aiGenerated"). Only the requested features are computed and returned; at least one is required.<br/>
        /// Example: [caption, aiGenerated]
        /// </summary>
        /// <example>[caption, aiGenerated]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("features")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Photoroom.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Photoroom.VisualQaV3RequestFeaturesVariant2Item>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Photoroom.AnyOf<string, global::System.Collections.Generic.IList<global::Photoroom.VisualQaV3RequestFeaturesVariant2Item>> Features { get; set; }

        /// <summary>
        /// JSON array of the colour taxonomy to classify the main garment against: 1 to 1000 entries of { code, name?, hex }, where hex is a 6-digit colour with or without the leading "#". Required when features includes mainGarmentColor, and rejected without it. Codes must be unique and are returned verbatim.<br/>
        /// Example: [{"code":"COLOR-027","name":"Navy","hex":"#002062"}]
        /// </summary>
        /// <example>[{"code":"COLOR-027","name":"Navy","hex":"#002062"}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("colorTaxonomy")]
        public string? ColorTaxonomy { get; set; }

        /// <summary>
        /// JSON array of the category taxonomy to classify the main garment against, flattened and linked by parentCode: 1 to 2000 nodes of { code, name, parentCode? }. A node with no parentCode is a root. Required when features includes mainGarmentCategory, and rejected without it. Codes must be unique and are returned verbatim.<br/>
        /// Example: [{"code":"TOPS","name":"Tops"},{"code":"TEE","name":"T-Shirts","parentCode":"TOPS"}]
        /// </summary>
        /// <example>[{"code":"TOPS","name":"Tops"},{"code":"TEE","name":"T-Shirts","parentCode":"TOPS"}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("categoryTaxonomy")]
        public string? CategoryTaxonomy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualQaV3Request" /> class.
        /// </summary>
        /// <param name="features">
        /// Features to run, as an array or a comma-separated string (e.g. "caption,aiGenerated"). Only the requested features are computed and returned; at least one is required.<br/>
        /// Example: [caption, aiGenerated]
        /// </param>
        /// <param name="imageFile">
        /// Image to analyze, as a binary file. Provide exactly one of imageFile or imageUrl.
        /// </param>
        /// <param name="imageFilename">
        /// Image to analyze, as a binary file. Provide exactly one of imageFile or imageUrl.
        /// </param>
        /// <param name="imageUrl">
        /// URL of the image to analyze. Provide exactly one of imageFile or imageUrl.<br/>
        /// Example: https://example.com/image.jpg
        /// </param>
        /// <param name="referenceImageFile">
        /// Reference image (binary) to compare against, required when features includes fashionFidelity or foodFidelity. Provide exactly one of referenceImageFile or referenceImageUrl.
        /// </param>
        /// <param name="referenceImageFilename">
        /// Reference image (binary) to compare against, required when features includes fashionFidelity or foodFidelity. Provide exactly one of referenceImageFile or referenceImageUrl.
        /// </param>
        /// <param name="referenceImageUrl">
        /// URL of the reference image to compare against, required when features includes fashionFidelity or foodFidelity. Provide exactly one of referenceImageFile or referenceImageUrl.<br/>
        /// Example: https://example.com/reference.jpg
        /// </param>
        /// <param name="colorTaxonomy">
        /// JSON array of the colour taxonomy to classify the main garment against: 1 to 1000 entries of { code, name?, hex }, where hex is a 6-digit colour with or without the leading "#". Required when features includes mainGarmentColor, and rejected without it. Codes must be unique and are returned verbatim.<br/>
        /// Example: [{"code":"COLOR-027","name":"Navy","hex":"#002062"}]
        /// </param>
        /// <param name="categoryTaxonomy">
        /// JSON array of the category taxonomy to classify the main garment against, flattened and linked by parentCode: 1 to 2000 nodes of { code, name, parentCode? }. A node with no parentCode is a root. Required when features includes mainGarmentCategory, and rejected without it. Codes must be unique and are returned verbatim.<br/>
        /// Example: [{"code":"TOPS","name":"Tops"},{"code":"TEE","name":"T-Shirts","parentCode":"TOPS"}]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VisualQaV3Request(
            global::Photoroom.AnyOf<string, global::System.Collections.Generic.IList<global::Photoroom.VisualQaV3RequestFeaturesVariant2Item>> features,
            byte[]? imageFile,
            string? imageFilename,
            string? imageUrl,
            byte[]? referenceImageFile,
            string? referenceImageFilename,
            string? referenceImageUrl,
            string? colorTaxonomy,
            string? categoryTaxonomy)
        {
            this.ImageFile = imageFile;
            this.ImageFilename = imageFilename;
            this.ImageUrl = imageUrl;
            this.ReferenceImageFile = referenceImageFile;
            this.ReferenceImageFilename = referenceImageFilename;
            this.ReferenceImageUrl = referenceImageUrl;
            this.Features = features;
            this.ColorTaxonomy = colorTaxonomy;
            this.CategoryTaxonomy = categoryTaxonomy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualQaV3Request" /> class.
        /// </summary>
        public VisualQaV3Request()
        {
        }

    }
}