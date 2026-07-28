
#nullable enable

namespace Photoroom
{
    /// <summary>
    /// Requested features and their results; only requested features are present.
    /// </summary>
    public sealed partial class VisualQaResponseFeatures
    {
        /// <summary>
        /// Likelihood the image is AI-generated. Scores closer to 1 mean a higher likelihood.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aiGenerated")]
        public global::Photoroom.VisualQaResponseFeaturesAiGenerated? AiGenerated { get; set; }

        /// <summary>
        /// Likelihood the image contains hateful or offensive content such as hate symbols. Scores closer to 1 mean a higher likelihood.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hate")]
        public global::Photoroom.VisualQaResponseFeaturesHate? Hate { get; set; }

        /// <summary>
        /// Likelihood the image contains violent content. Scores closer to 1 mean a higher likelihood.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("violence")]
        public global::Photoroom.VisualQaResponseFeaturesViolence? Violence { get; set; }

        /// <summary>
        /// Likelihood the image contains artificial (added) text. Scores closer to 1 mean a higher likelihood.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public global::Photoroom.VisualQaResponseFeaturesText? Text { get; set; }

        /// <summary>
        /// Overall image quality (sharpness, blur, contrast, brightness). Scores closer to 1 mean better quality.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overallImageQuality")]
        public global::Photoroom.VisualQaResponseFeaturesOverallImageQuality? OverallImageQuality { get; set; }

        /// <summary>
        /// Likelihood the image contains humans or human elements such as hands or legs. Scores closer to 1 mean a higher likelihood.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("humanElements")]
        public global::Photoroom.VisualQaResponseFeaturesHumanElements? HumanElements { get; set; }

        /// <summary>
        /// Whether the main subject is a sellable physical product — a consumer good or retail item, food included: score 1 if so, 0 otherwise (e.g. logos, people, landscapes, abstract art).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isEcommerceProduct")]
        public global::Photoroom.VisualQaResponseFeaturesIsEcommerceProduct? IsEcommerceProduct { get; set; }

        /// <summary>
        /// Whether the main subject is an edible or drinkable item (packaged food, fresh produce, beverages, dishes, snacks): score 1 if so, 0 otherwise. A refinement of isEcommerceProduct — request both when you need food-specific routing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isFoodOrBeverage")]
        public global::Photoroom.VisualQaResponseFeaturesIsFoodOrBeverage? IsFoodOrBeverage { get; set; }

        /// <summary>
        /// Crop-quality assessment and detected subject bounding box.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cropped")]
        public global::Photoroom.VisualQaResponseFeaturesCropped? Cropped { get; set; }

        /// <summary>
        /// Whether a shadow is cast over the product: score 1 if present, 0 otherwise.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shadowCastOverProduct")]
        public global::Photoroom.VisualQaResponseFeaturesShadowCastOverProduct? ShadowCastOverProduct { get; set; }

        /// <summary>
        /// Similarity between the image and the reference image (e.g. ghost-mannequin, virtual try-on): scores closer to 1 mean a better match. Requires a reference image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fashionFidelity")]
        public global::Photoroom.VisualQaResponseFeaturesFashionFidelity? FashionFidelity { get; set; }

        /// <summary>
        /// Whether an edited image stays faithful to the reference image: 0 = faithful, 1 = a fidelity issue detected. Requires a reference image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("foodFidelity")]
        public global::Photoroom.VisualQaResponseFeaturesFoodFidelity? FoodFidelity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualQaResponseFeatures" /> class.
        /// </summary>
        /// <param name="aiGenerated">
        /// Likelihood the image is AI-generated. Scores closer to 1 mean a higher likelihood.
        /// </param>
        /// <param name="hate">
        /// Likelihood the image contains hateful or offensive content such as hate symbols. Scores closer to 1 mean a higher likelihood.
        /// </param>
        /// <param name="violence">
        /// Likelihood the image contains violent content. Scores closer to 1 mean a higher likelihood.
        /// </param>
        /// <param name="text">
        /// Likelihood the image contains artificial (added) text. Scores closer to 1 mean a higher likelihood.
        /// </param>
        /// <param name="overallImageQuality">
        /// Overall image quality (sharpness, blur, contrast, brightness). Scores closer to 1 mean better quality.
        /// </param>
        /// <param name="humanElements">
        /// Likelihood the image contains humans or human elements such as hands or legs. Scores closer to 1 mean a higher likelihood.
        /// </param>
        /// <param name="isEcommerceProduct">
        /// Whether the main subject is a sellable physical product — a consumer good or retail item, food included: score 1 if so, 0 otherwise (e.g. logos, people, landscapes, abstract art).
        /// </param>
        /// <param name="isFoodOrBeverage">
        /// Whether the main subject is an edible or drinkable item (packaged food, fresh produce, beverages, dishes, snacks): score 1 if so, 0 otherwise. A refinement of isEcommerceProduct — request both when you need food-specific routing.
        /// </param>
        /// <param name="cropped">
        /// Crop-quality assessment and detected subject bounding box.
        /// </param>
        /// <param name="shadowCastOverProduct">
        /// Whether a shadow is cast over the product: score 1 if present, 0 otherwise.
        /// </param>
        /// <param name="fashionFidelity">
        /// Similarity between the image and the reference image (e.g. ghost-mannequin, virtual try-on): scores closer to 1 mean a better match. Requires a reference image.
        /// </param>
        /// <param name="foodFidelity">
        /// Whether an edited image stays faithful to the reference image: 0 = faithful, 1 = a fidelity issue detected. Requires a reference image.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VisualQaResponseFeatures(
            global::Photoroom.VisualQaResponseFeaturesAiGenerated? aiGenerated,
            global::Photoroom.VisualQaResponseFeaturesHate? hate,
            global::Photoroom.VisualQaResponseFeaturesViolence? violence,
            global::Photoroom.VisualQaResponseFeaturesText? text,
            global::Photoroom.VisualQaResponseFeaturesOverallImageQuality? overallImageQuality,
            global::Photoroom.VisualQaResponseFeaturesHumanElements? humanElements,
            global::Photoroom.VisualQaResponseFeaturesIsEcommerceProduct? isEcommerceProduct,
            global::Photoroom.VisualQaResponseFeaturesIsFoodOrBeverage? isFoodOrBeverage,
            global::Photoroom.VisualQaResponseFeaturesCropped? cropped,
            global::Photoroom.VisualQaResponseFeaturesShadowCastOverProduct? shadowCastOverProduct,
            global::Photoroom.VisualQaResponseFeaturesFashionFidelity? fashionFidelity,
            global::Photoroom.VisualQaResponseFeaturesFoodFidelity? foodFidelity)
        {
            this.AiGenerated = aiGenerated;
            this.Hate = hate;
            this.Violence = violence;
            this.Text = text;
            this.OverallImageQuality = overallImageQuality;
            this.HumanElements = humanElements;
            this.IsEcommerceProduct = isEcommerceProduct;
            this.IsFoodOrBeverage = isFoodOrBeverage;
            this.Cropped = cropped;
            this.ShadowCastOverProduct = shadowCastOverProduct;
            this.FashionFidelity = fashionFidelity;
            this.FoodFidelity = foodFidelity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualQaResponseFeatures" /> class.
        /// </summary>
        public VisualQaResponseFeatures()
        {
        }

    }
}