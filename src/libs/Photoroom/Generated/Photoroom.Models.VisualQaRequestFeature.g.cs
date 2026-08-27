
#nullable enable

namespace Photoroom
{
    /// <summary>
    ///
    /// </summary>
    public enum VisualQaRequestFeature
    {
        /// <summary>
        ///
        /// </summary>
        AiGenerated,
        /// <summary>
        ///
        /// </summary>
        Cropped,
        /// <summary>
        ///
        /// </summary>
        FashionFidelity,
        /// <summary>
        ///
        /// </summary>
        FoodFidelity,
        /// <summary>
        ///
        /// </summary>
        Hate,
        /// <summary>
        ///
        /// </summary>
        HumanElements,
        /// <summary>
        ///
        /// </summary>
        IsEcommerceProduct,
        /// <summary>
        ///
        /// </summary>
        IsFoodOrBeverage,
        /// <summary>
        ///
        /// </summary>
        OverallImageQuality,
        /// <summary>
        ///
        /// </summary>
        ShadowCastOverProduct,
        /// <summary>
        ///
        /// </summary>
        Text,
        /// <summary>
        ///
        /// </summary>
        Violence,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VisualQaRequestFeatureExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VisualQaRequestFeature value)
        {
            return value switch
            {
                VisualQaRequestFeature.AiGenerated => "aiGenerated",
                VisualQaRequestFeature.Cropped => "cropped",
                VisualQaRequestFeature.FashionFidelity => "fashionFidelity",
                VisualQaRequestFeature.FoodFidelity => "foodFidelity",
                VisualQaRequestFeature.Hate => "hate",
                VisualQaRequestFeature.HumanElements => "humanElements",
                VisualQaRequestFeature.IsEcommerceProduct => "isEcommerceProduct",
                VisualQaRequestFeature.IsFoodOrBeverage => "isFoodOrBeverage",
                VisualQaRequestFeature.OverallImageQuality => "overallImageQuality",
                VisualQaRequestFeature.ShadowCastOverProduct => "shadowCastOverProduct",
                VisualQaRequestFeature.Text => "text",
                VisualQaRequestFeature.Violence => "violence",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VisualQaRequestFeature? ToEnum(string value)
        {
            return value switch
            {
                "aiGenerated" => VisualQaRequestFeature.AiGenerated,
                "cropped" => VisualQaRequestFeature.Cropped,
                "fashionFidelity" => VisualQaRequestFeature.FashionFidelity,
                "foodFidelity" => VisualQaRequestFeature.FoodFidelity,
                "hate" => VisualQaRequestFeature.Hate,
                "humanElements" => VisualQaRequestFeature.HumanElements,
                "isEcommerceProduct" => VisualQaRequestFeature.IsEcommerceProduct,
                "isFoodOrBeverage" => VisualQaRequestFeature.IsFoodOrBeverage,
                "overallImageQuality" => VisualQaRequestFeature.OverallImageQuality,
                "shadowCastOverProduct" => VisualQaRequestFeature.ShadowCastOverProduct,
                "text" => VisualQaRequestFeature.Text,
                "violence" => VisualQaRequestFeature.Violence,
                _ => null,
            };
        }
    }
}