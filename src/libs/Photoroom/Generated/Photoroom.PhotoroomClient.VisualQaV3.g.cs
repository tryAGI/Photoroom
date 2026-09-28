
#nullable enable

namespace Photoroom
{
    public partial class PhotoroomClient
    {

        private static readonly global::Photoroom.AutoSDKServer[] s_VisualQaV3Servers = new global::Photoroom.AutoSDKServer[]
        {            new global::Photoroom.AutoSDKServer(
                id: "https-image-api-photoroom-com",
                name: "Production server (Plus plan)",
                url: "https://image-api.photoroom.com/",
                description: "Production server (Plus plan)"),
        };


        private static readonly global::Photoroom.EndPointSecurityRequirement s_VisualQaV3SecurityRequirement0 =
            new global::Photoroom.EndPointSecurityRequirement
            {
                Authorizations = new global::Photoroom.EndPointAuthorizationRequirement[]
                {                    new global::Photoroom.EndPointAuthorizationRequirement
                    {
                        Type = "ApiKey",
                        SchemeId = "ApikeyXApiKey",
                        Location = "Header",
                        Name = "x-api-key",
                        FriendlyName = "ApiKeyInHeader",
                    },
                },
            };
        private static readonly global::Photoroom.EndPointSecurityRequirement[] s_VisualQaV3SecurityRequirements =
            new global::Photoroom.EndPointSecurityRequirement[]
            {                s_VisualQaV3SecurityRequirement0,
            };
        partial void PrepareVisualQaV3Arguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Photoroom.VisualQaV3Request request);
        partial void PrepareVisualQaV3Request(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Photoroom.VisualQaV3Request request);
        partial void ProcessVisualQaV3Response(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessVisualQaV3ResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

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
        public async global::System.Threading.Tasks.Task<global::Photoroom.VisualQaV3Response> VisualQaV3Async(

            global::Photoroom.VisualQaV3Request request,
            global::Photoroom.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await VisualQaV3AsResponseAsync(

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
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
        public async global::System.Threading.Tasks.Task<global::Photoroom.AutoSDKHttpResponse<global::Photoroom.VisualQaV3Response>> VisualQaV3AsResponseAsync(

            global::Photoroom.VisualQaV3Request request,
            global::Photoroom.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareVisualQaV3Arguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::Photoroom.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_VisualQaV3SecurityRequirements,
                operationName: "VisualQaV3Async");

            using var __timeoutCancellationTokenSource = global::Photoroom.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::Photoroom.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::Photoroom.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: false);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::Photoroom.PathBuilder(
                                path: "/v3/visual-qa",
                                baseUri: ResolveBaseUri(
                                servers: s_VisualQaV3Servers,
                                defaultBaseUrl: "https://image-api.photoroom.com/"));
                            var __path = __pathBuilder.ToString();
                __path = global::Photoroom.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }

                            var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
                            if (request.ImageFile != default)
                            {

                                var __contentImageFile = new global::System.Net.Http.ByteArrayContent(request.ImageFile ?? global::System.Array.Empty<byte>());
                                __contentImageFile.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue(
                                    request.ImageFilename is null
                                        ? "application/octet-stream"
                                        : (global::System.IO.Path.GetExtension(request.ImageFilename) ?? string.Empty).ToLowerInvariant() switch
                                        {
                                            ".aac" => "audio/aac",
                                            ".flac" => "audio/flac",
                                            ".gif" => "image/gif",
                                            ".jpeg" => "image/jpeg",
                                            ".jpg" => "image/jpeg",
                                            ".json" => "application/json",
                                            ".m4a" => "audio/mp4",
                                            ".mp3" => "audio/mpeg",
                                            ".mp4" => "video/mp4",
                                            ".mpeg" => "audio/mpeg",
                                            ".mpga" => "audio/mpeg",
                                            ".oga" => "audio/ogg",
                                            ".ogg" => "audio/ogg",
                                            ".opus" => "audio/ogg",
                                            ".pdf" => "application/pdf",
                                            ".png" => "image/png",
                                            ".txt" => "text/plain",
                                            ".wav" => "audio/wav",
                                            ".weba" => "audio/webm",
                                            ".webm" => "video/webm",
                                            ".webp" => "image/webp",
                                            _ => "application/octet-stream",
                                        });
                                __httpRequestContent.Add(
                                    content: __contentImageFile,
                                    name: "\"imageFile\"",
                                    fileName: request.ImageFilename != null ? $"\"{request.ImageFilename}\"" : string.Empty);
                                if (__contentImageFile.Headers.ContentDisposition != null)
                                {
                                    __contentImageFile.Headers.ContentDisposition.FileNameStar = null;
                                }

                            }
                            if (request.ImageUrl != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.ImageUrl ?? string.Empty),
                                    name: "\"imageUrl\"");

                            }
                            if (request.ReferenceImageFile != default)
                            {

                                var __contentReferenceImageFile = new global::System.Net.Http.ByteArrayContent(request.ReferenceImageFile ?? global::System.Array.Empty<byte>());
                                __contentReferenceImageFile.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue(
                                    request.ReferenceImageFilename is null
                                        ? "application/octet-stream"
                                        : (global::System.IO.Path.GetExtension(request.ReferenceImageFilename) ?? string.Empty).ToLowerInvariant() switch
                                        {
                                            ".aac" => "audio/aac",
                                            ".flac" => "audio/flac",
                                            ".gif" => "image/gif",
                                            ".jpeg" => "image/jpeg",
                                            ".jpg" => "image/jpeg",
                                            ".json" => "application/json",
                                            ".m4a" => "audio/mp4",
                                            ".mp3" => "audio/mpeg",
                                            ".mp4" => "video/mp4",
                                            ".mpeg" => "audio/mpeg",
                                            ".mpga" => "audio/mpeg",
                                            ".oga" => "audio/ogg",
                                            ".ogg" => "audio/ogg",
                                            ".opus" => "audio/ogg",
                                            ".pdf" => "application/pdf",
                                            ".png" => "image/png",
                                            ".txt" => "text/plain",
                                            ".wav" => "audio/wav",
                                            ".weba" => "audio/webm",
                                            ".webm" => "video/webm",
                                            ".webp" => "image/webp",
                                            _ => "application/octet-stream",
                                        });
                                __httpRequestContent.Add(
                                    content: __contentReferenceImageFile,
                                    name: "\"referenceImageFile\"",
                                    fileName: request.ReferenceImageFilename != null ? $"\"{request.ReferenceImageFilename}\"" : string.Empty);
                                if (__contentReferenceImageFile.Headers.ContentDisposition != null)
                                {
                                    __contentReferenceImageFile.Headers.ContentDisposition.FileNameStar = null;
                                }

                            }
                            if (request.ReferenceImageUrl != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.ReferenceImageUrl ?? string.Empty),
                                    name: "\"referenceImageUrl\"");

                            }            if (request.Features.TryPickValue1(out var __valueFeatures1))
                            {

                                var __contentFeatures1 = new global::System.Net.Http.StringContent(__valueFeatures1 ?? string.Empty);
                                __httpRequestContent.Add(
                                    content: __contentFeatures1,
                                    name: "\"features\"");
                            }
                            else if (request.Features.TryPickValue2(out var __valueFeatures2))
                            {

                                for (var __iFeatures2 = 0; __iFeatures2 < (__valueFeatures2!).Count; __iFeatures2++)
                                {

                                    var __contentFeatures2Item = new global::System.Net.Http.StringContent((__valueFeatures2!)[__iFeatures2].ToValueString());
                                    __httpRequestContent.Add(
                                        content: __contentFeatures2Item,
                                        name: "\"features\"");
                                }
                            }

                            if (request.ColorTaxonomy != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.ColorTaxonomy ?? string.Empty),
                                    name: "\"colorTaxonomy\"");

                            }
                            if (request.CategoryTaxonomy != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.CategoryTaxonomy ?? string.Empty),
                                    name: "\"categoryTaxonomy\"");

                            }

                            __httpRequest.Content = __httpRequestContent;

                global::Photoroom.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareVisualQaV3Request(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::Photoroom.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::Photoroom.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "VisualQaV3",
                                methodName: "VisualQaV3Async",
                                pathTemplate: "\"/v3/visual-qa\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::Photoroom.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Photoroom.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Photoroom.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "VisualQaV3",
                                methodName: "VisualQaV3Async",
                                pathTemplate: "\"/v3/visual-qa\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Photoroom.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Photoroom.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::Photoroom.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::Photoroom.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Photoroom.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "VisualQaV3",
                                methodName: "VisualQaV3Async",
                                pathTemplate: "\"/v3/visual-qa\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Photoroom.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessVisualQaV3Response(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Photoroom.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Photoroom.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "VisualQaV3",
                                methodName: "VisualQaV3Async",
                                pathTemplate: "\"/v3/visual-qa\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Photoroom.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Photoroom.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "VisualQaV3",
                                methodName: "VisualQaV3Async",
                                pathTemplate: "\"/v3/visual-qa\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // Bad Request — returned when neither or both of imageFile / imageUrl are given, when no feature or an unknown feature is requested, when a reference image is missing for or supplied outside fashionFidelity / foodFidelity, when a taxonomy is not valid JSON or breaks its size or entry-shape bounds, or when mainGarmentColor / mainGarmentCategory and its taxonomy are not sent together.
                            if ((int)__response.StatusCode == 400)
                            {
                                string? __content_400 = null;
                                global::System.Exception? __exception_400 = null;
                                global::Photoroom.VisualQaV3Response2? __value_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_400 = global::Photoroom.VisualQaV3Response2.FromJson(__content_400, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_400 = global::Photoroom.VisualQaV3Response2.FromJson(__content_400, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_400 = __ex;
                                }


                                throw global::Photoroom.ApiException<global::Photoroom.VisualQaV3Response2>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_400,
                                    responseBody: __content_400,
                                    responseObject: __value_400,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Forbidden
                            if ((int)__response.StatusCode == 403)
                            {
                                string? __content_403 = null;
                                global::System.Exception? __exception_403 = null;
                                global::Photoroom.VisualQaV3Response3? __value_403 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_403 = global::Photoroom.VisualQaV3Response3.FromJson(__content_403, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_403 = global::Photoroom.VisualQaV3Response3.FromJson(__content_403, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_403 = __ex;
                                }


                                throw global::Photoroom.ApiException<global::Photoroom.VisualQaV3Response3>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_403 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_403,
                                    responseBody: __content_403,
                                    responseObject: __value_403,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Internal Server Error
                            if ((int)__response.StatusCode == 500)
                            {
                                string? __content_500 = null;
                                global::System.Exception? __exception_500 = null;
                                global::Photoroom.VisualQaV3Response4? __value_500 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_500 = global::Photoroom.VisualQaV3Response4.FromJson(__content_500, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_500 = global::Photoroom.VisualQaV3Response4.FromJson(__content_500, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_500 = __ex;
                                }


                                throw global::Photoroom.ApiException<global::Photoroom.VisualQaV3Response4>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_500 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_500,
                                    responseBody: __content_500,
                                    responseObject: __value_500,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessVisualQaV3ResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Photoroom.VisualQaV3Response.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Photoroom.AutoSDKHttpResponse<global::Photoroom.VisualQaV3Response>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Photoroom.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw global::Photoroom.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = await global::Photoroom.VisualQaV3Response.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Photoroom.AutoSDKHttpResponse<global::Photoroom.VisualQaV3Response>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Photoroom.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
                #endif
                                        ).ConfigureAwait(false);
                                    }
                                    catch (global::System.Exception)
                                    {
                                    }

                                    throw global::Photoroom.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
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
        public async global::System.Threading.Tasks.Task<global::Photoroom.VisualQaV3Response> VisualQaV3Async(
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
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Photoroom.VisualQaV3Request
            {
                ImageFile = imageFile,
                ImageFilename = imageFilename,
                ImageUrl = imageUrl,
                ReferenceImageFile = referenceImageFile,
                ReferenceImageFilename = referenceImageFilename,
                ReferenceImageUrl = referenceImageUrl,
                Features = features,
                ColorTaxonomy = colorTaxonomy,
                CategoryTaxonomy = categoryTaxonomy,
            };

            return await VisualQaV3Async(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}