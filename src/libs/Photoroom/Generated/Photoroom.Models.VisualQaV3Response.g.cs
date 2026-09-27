
#nullable enable

namespace Photoroom
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VisualQaV3Response
    {
        /// <summary>
        /// A generated caption describing the image. Only present when the caption feature is requested.<br/>
        /// Example: Three gold rings with blue stones on a marble surface.
        /// </summary>
        /// <example>Three gold rings with blue stones on a marble surface.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("caption")]
        public string? Caption { get; set; }

        /// <summary>
        /// Distinct clothing, footwear, and accessory items detected in the image. Only present when clothingItemDetection is requested.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clothingItemDetection")]
        public global::Photoroom.VisualQaV3ResponseClothingItemDetection? ClothingItemDetection { get; set; }

        /// <summary>
        /// The garment mainGarmentColor and mainGarmentCategory describe. Only present when at least one of those two features is requested and a garment was found. It can be present without either classification, when the garment matched no entry of the supplied taxonomies.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mainGarment")]
        public global::Photoroom.VisualQaV3ResponseMainGarment? MainGarment { get; set; }

        /// <summary>
        /// The colorTaxonomy entry matched to the main garment. Only present when the mainGarmentColor feature is requested and a garment was matched.<br/>
        /// Example: {"code":"COLOR-042","name":"Brick","hex":"#AF4942"}
        /// </summary>
        /// <example>{"code":"COLOR-042","name":"Brick","hex":"#AF4942"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("mainGarmentColor")]
        public global::Photoroom.VisualQaV3ResponseMainGarmentColor? MainGarmentColor { get; set; }

        /// <summary>
        /// The categoryTaxonomy node matched to the main garment, with its full ancestry. Only present when the mainGarmentCategory feature is requested and a garment was matched.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mainGarmentCategory")]
        public global::Photoroom.VisualQaV3ResponseMainGarmentCategory? MainGarmentCategory { get; set; }

        /// <summary>
        /// Basic image metadata. Only present when the metadata feature is requested.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::Photoroom.VisualQaV3ResponseMetadata? Metadata { get; set; }

        /// <summary>
        /// Likelihood the image is AI-generated. Scores closer to 1 mean a higher likelihood.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aiGenerated")]
        public global::Photoroom.VisualQaV3ResponseAiGenerated? AiGenerated { get; set; }

        /// <summary>
        /// Likelihood the image contains hateful or offensive content such as hate symbols. Scores closer to 1 mean a higher likelihood.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hate")]
        public global::Photoroom.VisualQaV3ResponseHate? Hate { get; set; }

        /// <summary>
        /// Likelihood the image contains violent content. Scores closer to 1 mean a higher likelihood.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("violence")]
        public global::Photoroom.VisualQaV3ResponseViolence? Violence { get; set; }

        /// <summary>
        /// Likelihood the image contains artificial (added) text. Scores closer to 1 mean a higher likelihood.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public global::Photoroom.VisualQaV3ResponseText? Text { get; set; }

        /// <summary>
        /// Overall image quality (sharpness, blur, contrast, brightness). Scores closer to 1 mean better quality.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overallImageQuality")]
        public global::Photoroom.VisualQaV3ResponseOverallImageQuality? OverallImageQuality { get; set; }

        /// <summary>
        /// Likelihood the image contains humans or human elements such as hands or legs. Scores closer to 1 mean a higher likelihood.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("humanElements")]
        public global::Photoroom.VisualQaV3ResponseHumanElements? HumanElements { get; set; }

        /// <summary>
        /// Whether the main subject is a sellable physical product — a consumer good or retail item, food included: score 1 if so, 0 otherwise (e.g. logos, people, landscapes, abstract art).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isEcommerceProduct")]
        public global::Photoroom.VisualQaV3ResponseIsEcommerceProduct? IsEcommerceProduct { get; set; }

        /// <summary>
        /// Whether the main subject is an edible or drinkable item (packaged food, fresh produce, beverages, dishes, snacks): score 1 if so, 0 otherwise. A refinement of isEcommerceProduct — request both when you need food-specific routing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isFoodOrBeverage")]
        public global::Photoroom.VisualQaV3ResponseIsFoodOrBeverage? IsFoodOrBeverage { get; set; }

        /// <summary>
        /// Crop-quality assessment and detected subject bounding box.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cropped")]
        public global::Photoroom.VisualQaV3ResponseCropped? Cropped { get; set; }

        /// <summary>
        /// Whether a shadow is cast over the product: score 1 if present, 0 otherwise.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shadowCastOverProduct")]
        public global::Photoroom.VisualQaV3ResponseShadowCastOverProduct? ShadowCastOverProduct { get; set; }

        /// <summary>
        /// Similarity between the image and the reference image (e.g. ghost-mannequin, virtual try-on): scores closer to 1 mean a better match. Requires a reference image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fashionFidelity")]
        public global::Photoroom.VisualQaV3ResponseFashionFidelity? FashionFidelity { get; set; }

        /// <summary>
        /// Whether an edited image stays faithful to the reference image: 0 = faithful, 1 = a fidelity issue detected. Requires a reference image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("foodFidelity")]
        public global::Photoroom.VisualQaV3ResponseFoodFidelity? FoodFidelity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualQaV3Response" /> class.
        /// </summary>
        /// <param name="caption">
        /// A generated caption describing the image. Only present when the caption feature is requested.<br/>
        /// Example: Three gold rings with blue stones on a marble surface.
        /// </param>
        /// <param name="clothingItemDetection">
        /// Distinct clothing, footwear, and accessory items detected in the image. Only present when clothingItemDetection is requested.
        /// </param>
        /// <param name="mainGarment">
        /// The garment mainGarmentColor and mainGarmentCategory describe. Only present when at least one of those two features is requested and a garment was found. It can be present without either classification, when the garment matched no entry of the supplied taxonomies.
        /// </param>
        /// <param name="mainGarmentColor">
        /// The colorTaxonomy entry matched to the main garment. Only present when the mainGarmentColor feature is requested and a garment was matched.<br/>
        /// Example: {"code":"COLOR-042","name":"Brick","hex":"#AF4942"}
        /// </param>
        /// <param name="mainGarmentCategory">
        /// The categoryTaxonomy node matched to the main garment, with its full ancestry. Only present when the mainGarmentCategory feature is requested and a garment was matched.
        /// </param>
        /// <param name="metadata">
        /// Basic image metadata. Only present when the metadata feature is requested.
        /// </param>
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
        public VisualQaV3Response(
            string? caption,
            global::Photoroom.VisualQaV3ResponseClothingItemDetection? clothingItemDetection,
            global::Photoroom.VisualQaV3ResponseMainGarment? mainGarment,
            global::Photoroom.VisualQaV3ResponseMainGarmentColor? mainGarmentColor,
            global::Photoroom.VisualQaV3ResponseMainGarmentCategory? mainGarmentCategory,
            global::Photoroom.VisualQaV3ResponseMetadata? metadata,
            global::Photoroom.VisualQaV3ResponseAiGenerated? aiGenerated,
            global::Photoroom.VisualQaV3ResponseHate? hate,
            global::Photoroom.VisualQaV3ResponseViolence? violence,
            global::Photoroom.VisualQaV3ResponseText? text,
            global::Photoroom.VisualQaV3ResponseOverallImageQuality? overallImageQuality,
            global::Photoroom.VisualQaV3ResponseHumanElements? humanElements,
            global::Photoroom.VisualQaV3ResponseIsEcommerceProduct? isEcommerceProduct,
            global::Photoroom.VisualQaV3ResponseIsFoodOrBeverage? isFoodOrBeverage,
            global::Photoroom.VisualQaV3ResponseCropped? cropped,
            global::Photoroom.VisualQaV3ResponseShadowCastOverProduct? shadowCastOverProduct,
            global::Photoroom.VisualQaV3ResponseFashionFidelity? fashionFidelity,
            global::Photoroom.VisualQaV3ResponseFoodFidelity? foodFidelity)
        {
            this.Caption = caption;
            this.ClothingItemDetection = clothingItemDetection;
            this.MainGarment = mainGarment;
            this.MainGarmentColor = mainGarmentColor;
            this.MainGarmentCategory = mainGarmentCategory;
            this.Metadata = metadata;
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
        /// Initializes a new instance of the <see cref="VisualQaV3Response" /> class.
        /// </summary>
        public VisualQaV3Response()
        {
        }

    }
}