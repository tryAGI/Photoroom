#nullable enable

namespace Photoroom
{
    public partial interface IPhotoroomClient
    {
        /// <summary>
        /// Visual QA v3<br/>
        /// Analyze an image and return the results of the requested features (see the `features` enum).<br/>
        /// The `mainGarmentColor` and `mainGarmentCategory` features classify the main garment against a taxonomy you supply per request, in `colorTaxonomy` and `categoryTaxonomy` respectively. Each feature and its taxonomy must be sent together — one without the other is a 400. Both classifications ride on the same model call as `clothingItemDetection`, so asking for any combination of the three costs a single call.<br/>
        /// Requires an Enterprise plan: requests authenticated with a non-Enterprise API key receive a 403 with a link to contact our sales team.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Photoroom.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Photoroom.VisualQaV3Response> VisualQaV3Async(

            global::Photoroom.VisualQaV3Request request,
            global::Photoroom.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Visual QA v3<br/>
        /// Analyze an image and return the results of the requested features (see the `features` enum).<br/>
        /// The `mainGarmentColor` and `mainGarmentCategory` features classify the main garment against a taxonomy you supply per request, in `colorTaxonomy` and `categoryTaxonomy` respectively. Each feature and its taxonomy must be sent together — one without the other is a 400. Both classifications ride on the same model call as `clothingItemDetection`, so asking for any combination of the three costs a single call.<br/>
        /// Requires an Enterprise plan: requests authenticated with a non-Enterprise API key receive a 403 with a link to contact our sales team.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Photoroom.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Photoroom.AutoSDKHttpResponse<global::Photoroom.VisualQaV3Response>> VisualQaV3AsResponseAsync(

            global::Photoroom.VisualQaV3Request request,
            global::Photoroom.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Visual QA v3<br/>
        /// Analyze an image and return the results of the requested features (see the `features` enum).<br/>
        /// The `mainGarmentColor` and `mainGarmentCategory` features classify the main garment against a taxonomy you supply per request, in `colorTaxonomy` and `categoryTaxonomy` respectively. Each feature and its taxonomy must be sent together — one without the other is a 400. Both classifications ride on the same model call as `clothingItemDetection`, so asking for any combination of the three costs a single call.<br/>
        /// Requires an Enterprise plan: requests authenticated with a non-Enterprise API key receive a 403 with a link to contact our sales team.
        /// </summary>
        /// <param name="imageFile">
        /// Image to analyze, as a binary file. Provide exactly one of imageFile or imageUrl.
        /// </param>
        /// <param name="imageFilename">
        /// Image to analyze, as a binary file. Provide exactly one of imageFile or imageUrl.
        /// </param>
        /// <param name="imageUrl">
        /// URL of the image to analyze. Provide exactly one of imageFile or imageUrl.<br/>
        /// Example: https://example.com/image.jpg
        /// </param>
        /// <param name="referenceImageFile">
        /// Reference image (binary) to compare against, required when features includes fashionFidelity or foodFidelity. Provide exactly one of referenceImageFile or referenceImageUrl.
        /// </param>
        /// <param name="referenceImageFilename">
        /// Reference image (binary) to compare against, required when features includes fashionFidelity or foodFidelity. Provide exactly one of referenceImageFile or referenceImageUrl.
        /// </param>
        /// <param name="referenceImageUrl">
        /// URL of the reference image to compare against, required when features includes fashionFidelity or foodFidelity. Provide exactly one of referenceImageFile or referenceImageUrl.<br/>
        /// Example: https://example.com/reference.jpg
        /// </param>
        /// <param name="features">
        /// Features to run, as an array or a comma-separated string (e.g. "caption,aiGenerated"). Only the requested features are computed and returned; at least one is required.<br/>
        /// Example: [caption, aiGenerated]
        /// </param>
        /// <param name="colorTaxonomy">
        /// JSON array of the colour taxonomy to classify the main garment against: 1 to 1000 entries of { code, name?, hex }, where hex is a 6-digit colour with or without the leading "#". Required when features includes mainGarmentColor, and rejected without it. Codes must be unique and are returned verbatim.<br/>
        /// Example: [{"code":"COLOR-027","name":"Navy","hex":"#002062"}]
        /// </param>
        /// <param name="categoryTaxonomy">
        /// JSON array of the category taxonomy to classify the main garment against, flattened and linked by parentCode: 1 to 2000 nodes of { code, name, parentCode? }. A node with no parentCode is a root. Required when features includes mainGarmentCategory, and rejected without it. Codes must be unique and are returned verbatim.<br/>
        /// Example: [{"code":"TOPS","name":"Tops"},{"code":"TEE","name":"T-Shirts","parentCode":"TOPS"}]
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Photoroom.VisualQaV3Response> VisualQaV3Async(
            global::Photoroom.AnyOf<string, global::System.Collections.Generic.IList<global::Photoroom.VisualQaV3RequestFeaturesVariant2Item>> features,
            byte[]? imageFile = default,
            string? imageFilename = default,
            string? imageUrl = default,
            byte[]? referenceImageFile = default,
            string? referenceImageFilename = default,
            string? referenceImageUrl = default,
            string? colorTaxonomy = default,
            string? categoryTaxonomy = default,
            global::Photoroom.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}