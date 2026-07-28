
#nullable enable

namespace Photoroom
{
    /// <summary>
    /// Crop-quality assessment and detected subject bounding box.
    /// </summary>
    public sealed partial class VisualQaResponseFeaturesCropped
    {
        /// <summary>
        /// Crop-quality score. Scores closer to 1 mean a higher likelihood the subject is cropped.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Score { get; set; }

        /// <summary>
        /// Subject location relative to image size (0 to 1). A 0 (xmin/ymin) or 1 (xmax/ymax) means the subject touches that edge and is cropped.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subjectBoundingBox")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Photoroom.VisualQaResponseFeaturesCroppedSubjectBoundingBox SubjectBoundingBox { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualQaResponseFeaturesCropped" /> class.
        /// </summary>
        /// <param name="score">
        /// Crop-quality score. Scores closer to 1 mean a higher likelihood the subject is cropped.
        /// </param>
        /// <param name="subjectBoundingBox">
        /// Subject location relative to image size (0 to 1). A 0 (xmin/ymin) or 1 (xmax/ymax) means the subject touches that edge and is cropped.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VisualQaResponseFeaturesCropped(
            double score,
            global::Photoroom.VisualQaResponseFeaturesCroppedSubjectBoundingBox subjectBoundingBox)
        {
            this.Score = score;
            this.SubjectBoundingBox = subjectBoundingBox ?? throw new global::System.ArgumentNullException(nameof(subjectBoundingBox));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualQaResponseFeaturesCropped" /> class.
        /// </summary>
        public VisualQaResponseFeaturesCropped()
        {
        }

    }
}