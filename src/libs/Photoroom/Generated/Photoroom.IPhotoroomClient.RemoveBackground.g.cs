#nullable enable

namespace Photoroom
{
    public partial interface IPhotoroomClient
    {
        /// <summary>
        /// Remove Background (Basic plan)<br/>
        /// Remove background from an image
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Photoroom.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Photoroom.RemoveBackgroundResponse> RemoveBackgroundAsync(

            global::Photoroom.RemoveBackgroundPostParams request,
            global::Photoroom.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove Background (Basic plan)<br/>
        /// Remove background from an image
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Photoroom.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Photoroom.AutoSDKHttpResponse<global::Photoroom.RemoveBackgroundResponse>> RemoveBackgroundAsResponseAsync(

            global::Photoroom.RemoveBackgroundPostParams request,
            global::Photoroom.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove Background (Basic plan)<br/>
        /// Remove background from an image
        /// </summary>
        /// <param name="imageFile">
        /// The image file to render
        /// </param>
        /// <param name="imageFilename">
        /// The image file to render
        /// </param>
        /// <param name="format">
        /// The format of the resulting image<br/>
        /// Default Value: png
        /// </param>
        /// <param name="channels">
        /// The channels of the resulting image<br/>
        /// Default Value: rgba
        /// </param>
        /// <param name="bgColor">
        /// The background color of the resulting image. Can be a hex code (`#FF00FF`) or a HTML color (`red`, `green`, etc.)
        /// </param>
        /// <param name="size">
        /// Will resize the output to the specified size. Can be `preview` (0.25 Megapixels), `medium` (1.5 MP), `hd` (4 MP) or `full` (36 MP, can be slower for large images). Useful for mobile apps that need smaller images.<br/>
        /// Default Value: full
        /// </param>
        /// <param name="crop">
        /// If `true`, the image returned is cropped to the cutout border. Transparent pixels are removed from the border<br/>
        /// Default Value: false
        /// </param>
        /// <param name="despill">
        /// If `true`, automatically removes colored reflections that have been left on the main subject by a green background.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Photoroom.RemoveBackgroundResponse> RemoveBackgroundAsync(
            byte[] imageFile,
            string imageFilename,
            global::Photoroom.RemoveBackgroundPostParamsFormat? format = default,
            global::Photoroom.RemoveBackgroundPostParamsChannels? channels = default,
            string? bgColor = default,
            global::Photoroom.RemoveBackgroundPostParamsSize? size = default,
            global::Photoroom.RemoveBackgroundPostParamsCrop? crop = default,
            global::Photoroom.RemoveBackgroundPostParamsDespill? despill = default,
            global::Photoroom.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}