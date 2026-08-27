
#nullable enable

namespace Photoroom
{
    /// <summary>
    /// The clothing category this item was classified into, from a fixed, versioned list (e.g. pumps or sneakers are classified as "shoes").
    /// </summary>
    public enum VisualQaResponseClothingItemDetectionItemCategory
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
    public static class VisualQaResponseClothingItemDetectionItemCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VisualQaResponseClothingItemDetectionItemCategory value)
        {
            return value switch
            {
                VisualQaResponseClothingItemDetectionItemCategory.Accessory => "accessory",
                VisualQaResponseClothingItemDetectionItemCategory.Blouse => "blouse",
                VisualQaResponseClothingItemDetectionItemCategory.Coat => "coat",
                VisualQaResponseClothingItemDetectionItemCategory.Dress => "dress",
                VisualQaResponseClothingItemDetectionItemCategory.Jacket => "jacket",
                VisualQaResponseClothingItemDetectionItemCategory.Other => "other",
                VisualQaResponseClothingItemDetectionItemCategory.Shirt => "shirt",
                VisualQaResponseClothingItemDetectionItemCategory.Shoes => "shoes",
                VisualQaResponseClothingItemDetectionItemCategory.Shorts => "shorts",
                VisualQaResponseClothingItemDetectionItemCategory.Skirt => "skirt",
                VisualQaResponseClothingItemDetectionItemCategory.Sweater => "sweater",
                VisualQaResponseClothingItemDetectionItemCategory.TShirt => "t-shirt",
                VisualQaResponseClothingItemDetectionItemCategory.Top => "top",
                VisualQaResponseClothingItemDetectionItemCategory.Trousers => "trousers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VisualQaResponseClothingItemDetectionItemCategory? ToEnum(string value)
        {
            return value switch
            {
                "accessory" => VisualQaResponseClothingItemDetectionItemCategory.Accessory,
                "blouse" => VisualQaResponseClothingItemDetectionItemCategory.Blouse,
                "coat" => VisualQaResponseClothingItemDetectionItemCategory.Coat,
                "dress" => VisualQaResponseClothingItemDetectionItemCategory.Dress,
                "jacket" => VisualQaResponseClothingItemDetectionItemCategory.Jacket,
                "other" => VisualQaResponseClothingItemDetectionItemCategory.Other,
                "shirt" => VisualQaResponseClothingItemDetectionItemCategory.Shirt,
                "shoes" => VisualQaResponseClothingItemDetectionItemCategory.Shoes,
                "shorts" => VisualQaResponseClothingItemDetectionItemCategory.Shorts,
                "skirt" => VisualQaResponseClothingItemDetectionItemCategory.Skirt,
                "sweater" => VisualQaResponseClothingItemDetectionItemCategory.Sweater,
                "t-shirt" => VisualQaResponseClothingItemDetectionItemCategory.TShirt,
                "top" => VisualQaResponseClothingItemDetectionItemCategory.Top,
                "trousers" => VisualQaResponseClothingItemDetectionItemCategory.Trousers,
                _ => null,
            };
        }
    }
}