
#nullable enable

namespace Photoroom
{
    /// <summary>
    /// The clothing category this item was classified into, from a fixed, versioned list (e.g. pumps or sneakers are classified as "shoes").
    /// </summary>
    public enum VisualQaV3ResponseClothingItemDetectionItemCategory
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
    public static class VisualQaV3ResponseClothingItemDetectionItemCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VisualQaV3ResponseClothingItemDetectionItemCategory value)
        {
            return value switch
            {
                VisualQaV3ResponseClothingItemDetectionItemCategory.Accessory => "accessory",
                VisualQaV3ResponseClothingItemDetectionItemCategory.Blouse => "blouse",
                VisualQaV3ResponseClothingItemDetectionItemCategory.Coat => "coat",
                VisualQaV3ResponseClothingItemDetectionItemCategory.Dress => "dress",
                VisualQaV3ResponseClothingItemDetectionItemCategory.Jacket => "jacket",
                VisualQaV3ResponseClothingItemDetectionItemCategory.Other => "other",
                VisualQaV3ResponseClothingItemDetectionItemCategory.Shirt => "shirt",
                VisualQaV3ResponseClothingItemDetectionItemCategory.Shoes => "shoes",
                VisualQaV3ResponseClothingItemDetectionItemCategory.Shorts => "shorts",
                VisualQaV3ResponseClothingItemDetectionItemCategory.Skirt => "skirt",
                VisualQaV3ResponseClothingItemDetectionItemCategory.Sweater => "sweater",
                VisualQaV3ResponseClothingItemDetectionItemCategory.TShirt => "t-shirt",
                VisualQaV3ResponseClothingItemDetectionItemCategory.Top => "top",
                VisualQaV3ResponseClothingItemDetectionItemCategory.Trousers => "trousers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VisualQaV3ResponseClothingItemDetectionItemCategory? ToEnum(string value)
        {
            return value switch
            {
                "accessory" => VisualQaV3ResponseClothingItemDetectionItemCategory.Accessory,
                "blouse" => VisualQaV3ResponseClothingItemDetectionItemCategory.Blouse,
                "coat" => VisualQaV3ResponseClothingItemDetectionItemCategory.Coat,
                "dress" => VisualQaV3ResponseClothingItemDetectionItemCategory.Dress,
                "jacket" => VisualQaV3ResponseClothingItemDetectionItemCategory.Jacket,
                "other" => VisualQaV3ResponseClothingItemDetectionItemCategory.Other,
                "shirt" => VisualQaV3ResponseClothingItemDetectionItemCategory.Shirt,
                "shoes" => VisualQaV3ResponseClothingItemDetectionItemCategory.Shoes,
                "shorts" => VisualQaV3ResponseClothingItemDetectionItemCategory.Shorts,
                "skirt" => VisualQaV3ResponseClothingItemDetectionItemCategory.Skirt,
                "sweater" => VisualQaV3ResponseClothingItemDetectionItemCategory.Sweater,
                "t-shirt" => VisualQaV3ResponseClothingItemDetectionItemCategory.TShirt,
                "top" => VisualQaV3ResponseClothingItemDetectionItemCategory.Top,
                "trousers" => VisualQaV3ResponseClothingItemDetectionItemCategory.Trousers,
                _ => null,
            };
        }
    }
}