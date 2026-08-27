
#nullable enable

namespace Photoroom
{
    /// <summary>
    /// Subject location relative to image size (0 to 1). A 0 (xmin/ymin) or 1 (xmax/ymax) means the subject touches that edge and is cropped.
    /// </summary>
    public sealed partial class VisualQaResponseFeaturesCroppedSubjectBoundingBox
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ymin")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Ymin { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ymax")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Ymax { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("xmin")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Xmin { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("xmax")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Xmax { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualQaResponseFeaturesCroppedSubjectBoundingBox" /> class.
        /// </summary>
        /// <param name="ymin"></param>
        /// <param name="ymax"></param>
        /// <param name="xmin"></param>
        /// <param name="xmax"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VisualQaResponseFeaturesCroppedSubjectBoundingBox(
            double ymin,
            double ymax,
            double xmin,
            double xmax)
        {
            this.Ymin = ymin;
            this.Ymax = ymax;
            this.Xmin = xmin;
            this.Xmax = xmax;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualQaResponseFeaturesCroppedSubjectBoundingBox" /> class.
        /// </summary>
        public VisualQaResponseFeaturesCroppedSubjectBoundingBox()
        {
        }

    }
}