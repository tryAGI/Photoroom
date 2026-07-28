
#nullable enable

namespace Photoroom
{
    /// <summary>
    /// Likelihood the image contains humans or human elements such as hands or legs. Scores closer to 1 mean a higher likelihood.
    /// </summary>
    public sealed partial class VisualQaResponseFeaturesHumanElements
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
        /// Initializes a new instance of the <see cref="VisualQaResponseFeaturesHumanElements" /> class.
        /// </summary>
        /// <param name="score">
        /// Score for this feature; see the feature description for its meaning and range.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VisualQaResponseFeaturesHumanElements(
            double score)
        {
            this.Score = score;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualQaResponseFeaturesHumanElements" /> class.
        /// </summary>
        public VisualQaResponseFeaturesHumanElements()
        {
        }

    }
}