
#nullable enable

namespace Photoroom
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EditImageGetEditWithAIAdditionalImages2
    {
        /// <summary>
        /// Bytes of an additional reference image. Only available in the POST request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageFile")]
        public byte[]? ImageFile { get; set; }

        /// <summary>
        /// Bytes of an additional reference image. Only available in the POST request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageFilename")]
        public string? ImageFilename { get; set; }

        /// <summary>
        /// URL of an additional reference image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageUrl")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EditImageGetEditWithAIAdditionalImages2" /> class.
        /// </summary>
        /// <param name="imageFile">
        /// Bytes of an additional reference image. Only available in the POST request.
        /// </param>
        /// <param name="imageFilename">
        /// Bytes of an additional reference image. Only available in the POST request.
        /// </param>
        /// <param name="imageUrl">
        /// URL of an additional reference image.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EditImageGetEditWithAIAdditionalImages2(
            byte[]? imageFile,
            string? imageFilename,
            string? imageUrl)
        {
            this.ImageFile = imageFile;
            this.ImageFilename = imageFilename;
            this.ImageUrl = imageUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditImageGetEditWithAIAdditionalImages2" /> class.
        /// </summary>
        public EditImageGetEditWithAIAdditionalImages2()
        {
        }
    }
}