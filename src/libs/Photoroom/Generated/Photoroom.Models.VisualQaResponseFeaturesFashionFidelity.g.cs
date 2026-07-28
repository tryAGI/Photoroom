
#nullable enable

namespace Photoroom
{
    /// <summary>
    /// Similarity between the image and the reference image (e.g. ghost-mannequin, virtual try-on): scores closer to 1 mean a better match. Requires a reference image.
    /// </summary>
    public sealed partial class VisualQaResponseFeaturesFashionFidelity
    {
        /// <summary>
        /// Score for this feature; see the feature description for its meaning and range.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Score { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualQaResponseFeaturesFashionFidelity" /> class.
        /// </summary>
        /// <param name="score">
        /// Score for this feature; see the feature description for its meaning and range.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VisualQaResponseFeaturesFashionFidelity(
            double score)
        {
            this.Score = score;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualQaResponseFeaturesFashionFidelity" /> class.
        /// </summary>
        public VisualQaResponseFeaturesFashionFidelity()
        {
        }

    }
}