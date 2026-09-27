
#nullable enable

namespace Photoroom
{
    /// <summary>
    /// Photoroom's own fixed category for that garment, from the same list as clothingItemDetection items and independent of the supplied categoryTaxonomy.
    /// </summary>
    public enum VisualQaV3ResponseMainGarmentType
    {
        /// <summary>
        ///
        /// </summary>
        Accessory,
        /// <summary>
        ///
        /// </summary>
        Blouse,
        /// <summary>
        ///
        /// </summary>
        Coat,
        /// <summary>
        ///
        /// </summary>
        Dress,
        /// <summary>
        ///
        /// </summary>
        Jacket,
        /// <summary>
        ///
        /// </summary>
        Other,
        /// <summary>
        ///
        /// </summary>
        Shirt,
        /// <summary>
        ///
        /// </summary>
        Shoes,
        /// <summary>
        ///
        /// </summary>
        Shorts,
        /// <summary>
        ///
        /// </summary>
        Skirt,
        /// <summary>
        ///
        /// </summary>
        Sweater,
        /// <summary>
        ///
        /// </summary>
        TShirt,
        /// <summary>
        ///
        /// </summary>
        Top,
        /// <summary>
        ///
        /// </summary>
        Trousers,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VisualQaV3ResponseMainGarmentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VisualQaV3ResponseMainGarmentType value)
        {
            return value switch
            {
                VisualQaV3ResponseMainGarmentType.Accessory => "accessory",
                VisualQaV3ResponseMainGarmentType.Blouse => "blouse",
                VisualQaV3ResponseMainGarmentType.Coat => "coat",
                VisualQaV3ResponseMainGarmentType.Dress => "dress",
                VisualQaV3ResponseMainGarmentType.Jacket => "jacket",
                VisualQaV3ResponseMainGarmentType.Other => "other",
                VisualQaV3ResponseMainGarmentType.Shirt => "shirt",
                VisualQaV3ResponseMainGarmentType.Shoes => "shoes",
                VisualQaV3ResponseMainGarmentType.Shorts => "shorts",
                VisualQaV3ResponseMainGarmentType.Skirt => "skirt",
                VisualQaV3ResponseMainGarmentType.Sweater => "sweater",
                VisualQaV3ResponseMainGarmentType.TShirt => "t-shirt",
                VisualQaV3ResponseMainGarmentType.Top => "top",
                VisualQaV3ResponseMainGarmentType.Trousers => "trousers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VisualQaV3ResponseMainGarmentType? ToEnum(string value)
        {
            return value switch
            {
                "accessory" => VisualQaV3ResponseMainGarmentType.Accessory,
                "blouse" => VisualQaV3ResponseMainGarmentType.Blouse,
                "coat" => VisualQaV3ResponseMainGarmentType.Coat,
                "dress" => VisualQaV3ResponseMainGarmentType.Dress,
                "jacket" => VisualQaV3ResponseMainGarmentType.Jacket,
                "other" => VisualQaV3ResponseMainGarmentType.Other,
                "shirt" => VisualQaV3ResponseMainGarmentType.Shirt,
                "shoes" => VisualQaV3ResponseMainGarmentType.Shoes,
                "shorts" => VisualQaV3ResponseMainGarmentType.Shorts,
                "skirt" => VisualQaV3ResponseMainGarmentType.Skirt,
                "sweater" => VisualQaV3ResponseMainGarmentType.Sweater,
                "t-shirt" => VisualQaV3ResponseMainGarmentType.TShirt,
                "top" => VisualQaV3ResponseMainGarmentType.Top,
                "trousers" => VisualQaV3ResponseMainGarmentType.Trousers,
                _ => null,
            };
        }
    }
}