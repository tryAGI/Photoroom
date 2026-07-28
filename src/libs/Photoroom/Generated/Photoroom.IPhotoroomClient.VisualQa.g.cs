#nullable enable

namespace Photoroom
{
    public partial interface IPhotoroomClient
    {
        /// <summary>
        /// Visual QA<br/>
        /// Analyze an image and return a caption, image metadata, and scores for the requested features (see the `features` enum).<br/>
        /// Requires an Enterprise plan: requests authenticated with a non-Enterprise API key receive a 403 with a link to contact our sales team.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Photoroom.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Photoroom.VisualQaResponse> VisualQaAsync(

            global::Photoroom.VisualQaRequest request,
            global::Photoroom.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Visual QA<br/>
        /// Analyze an image and return a caption, image metadata, and scores for the requested features (see the `features` enum).<br/>
        /// Requires an Enterprise plan: requests authenticated with a non-Enterprise API key receive a 403 with a link to contact our sales team.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Photoroom.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Photoroom.AutoSDKHttpResponse<global::Photoroom.VisualQaResponse>> VisualQaAsResponseAsync(

            global::Photoroom.VisualQaRequest request,
            global::Photoroom.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Visual QA<br/>
        /// Analyze an image and return a caption, image metadata, and scores for the requested features (see the `features` enum).<br/>
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
        /// Features to run, as an array or a comma-separated string (e.g. "aiGenerated,text"). If omitted, you still receive the caption and metadata.<br/>
        /// Example: [aiGenerated, text]
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Photoroom.VisualQaResponse> VisualQaAsync(
            byte[]? imageFile = default,
            string? imageFilename = default,
            string? imageUrl = default,
            byte[]? referenceImageFile = default,
            string? referenceImageFilename = default,
            string? referenceImageUrl = default,
            global::System.Collections.Generic.IList<global::Photoroom.VisualQaRequestFeature>? features = default,
            global::Photoroom.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}