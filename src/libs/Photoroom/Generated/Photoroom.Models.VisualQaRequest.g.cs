
#nullable enable

namespace Photoroom
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VisualQaRequest
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
        /// Features to run, as an array or a comma-separated string (e.g. "aiGenerated,text"). If omitted, you still receive the caption and metadata.<br/>
        /// Example: [aiGenerated, text]
        /// </summary>
        /// <example>[aiGenerated, text]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("features")]
        public global::System.Collections.Generic.IList<global::Photoroom.VisualQaRequestFeature>? Features { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualQaRequest" /> class.
        /// </summary>
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
        /// <param name="features">
        /// Features to run, as an array or a comma-separated string (e.g. "aiGenerated,text"). If omitted, you still receive the caption and metadata.<br/>
        /// Example: [aiGenerated, text]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VisualQaRequest(
            byte[]? imageFile,
            string? imageFilename,
            string? imageUrl,
            byte[]? referenceImageFile,
            string? referenceImageFilename,
            string? referenceImageUrl,
            global::System.Collections.Generic.IList<global::Photoroom.VisualQaRequestFeature>? features)
        {
            this.ImageFile = imageFile;
            this.ImageFilename = imageFilename;
            this.ImageUrl = imageUrl;
            this.ReferenceImageFile = referenceImageFile;
            this.ReferenceImageFilename = referenceImageFilename;
            this.ReferenceImageUrl = referenceImageUrl;
            this.Features = features;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualQaRequest" /> class.
        /// </summary>
        public VisualQaRequest()
        {
        }

    }
}