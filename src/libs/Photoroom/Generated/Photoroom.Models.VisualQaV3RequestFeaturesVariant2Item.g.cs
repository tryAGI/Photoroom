
#nullable enable

namespace Photoroom
{
    /// <summary>
    ///
    /// </summary>
    public enum VisualQaV3RequestFeaturesVariant2Item
    {
        /// <summary>
        ///
        /// </summary>
        AiGenerated,
        /// <summary>
        ///
        /// </summary>
        Caption,
        /// <summary>
        ///
        /// </summary>
        ClothingItemDetection,
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
        MainGarmentCategory,
        /// <summary>
        ///
        /// </summary>
        MainGarmentColor,
        /// <summary>
        ///
        /// </summary>
        Metadata,
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
    public static class VisualQaV3RequestFeaturesVariant2ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VisualQaV3RequestFeaturesVariant2Item value)
        {
            return value switch
            {
                VisualQaV3RequestFeaturesVariant2Item.AiGenerated => "aiGenerated",
                VisualQaV3RequestFeaturesVariant2Item.Caption => "caption",
                VisualQaV3RequestFeaturesVariant2Item.ClothingItemDetection => "clothingItemDetection",
                VisualQaV3RequestFeaturesVariant2Item.Cropped => "cropped",
                VisualQaV3RequestFeaturesVariant2Item.FashionFidelity => "fashionFidelity",
                VisualQaV3RequestFeaturesVariant2Item.FoodFidelity => "foodFidelity",
                VisualQaV3RequestFeaturesVariant2Item.Hate => "hate",
                VisualQaV3RequestFeaturesVariant2Item.HumanElements => "humanElements",
                VisualQaV3RequestFeaturesVariant2Item.IsEcommerceProduct => "isEcommerceProduct",
                VisualQaV3RequestFeaturesVariant2Item.IsFoodOrBeverage => "isFoodOrBeverage",
                VisualQaV3RequestFeaturesVariant2Item.MainGarmentCategory => "mainGarmentCategory",
                VisualQaV3RequestFeaturesVariant2Item.MainGarmentColor => "mainGarmentColor",
                VisualQaV3RequestFeaturesVariant2Item.Metadata => "metadata",
                VisualQaV3RequestFeaturesVariant2Item.OverallImageQuality => "overallImageQuality",
                VisualQaV3RequestFeaturesVariant2Item.ShadowCastOverProduct => "shadowCastOverProduct",
                VisualQaV3RequestFeaturesVariant2Item.Text => "text",
                VisualQaV3RequestFeaturesVariant2Item.Violence => "violence",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VisualQaV3RequestFeaturesVariant2Item? ToEnum(string value)
        {
            return value switch
            {
                "aiGenerated" => VisualQaV3RequestFeaturesVariant2Item.AiGenerated,
                "caption" => VisualQaV3RequestFeaturesVariant2Item.Caption,
                "clothingItemDetection" => VisualQaV3RequestFeaturesVariant2Item.ClothingItemDetection,
                "cropped" => VisualQaV3RequestFeaturesVariant2Item.Cropped,
                "fashionFidelity" => VisualQaV3RequestFeaturesVariant2Item.FashionFidelity,
                "foodFidelity" => VisualQaV3RequestFeaturesVariant2Item.FoodFidelity,
                "hate" => VisualQaV3RequestFeaturesVariant2Item.Hate,
                "humanElements" => VisualQaV3RequestFeaturesVariant2Item.HumanElements,
                "isEcommerceProduct" => VisualQaV3RequestFeaturesVariant2Item.IsEcommerceProduct,
                "isFoodOrBeverage" => VisualQaV3RequestFeaturesVariant2Item.IsFoodOrBeverage,
                "mainGarmentCategory" => VisualQaV3RequestFeaturesVariant2Item.MainGarmentCategory,
                "mainGarmentColor" => VisualQaV3RequestFeaturesVariant2Item.MainGarmentColor,
                "metadata" => VisualQaV3RequestFeaturesVariant2Item.Metadata,
                "overallImageQuality" => VisualQaV3RequestFeaturesVariant2Item.OverallImageQuality,
                "shadowCastOverProduct" => VisualQaV3RequestFeaturesVariant2Item.ShadowCastOverProduct,
                "text" => VisualQaV3RequestFeaturesVariant2Item.Text,
                "violence" => VisualQaV3RequestFeaturesVariant2Item.Violence,
                _ => null,
            };
        }
    }
}