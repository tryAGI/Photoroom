
#nullable enable

namespace Photoroom
{
    /// <summary>
    /// The Photoroom API takes an image as input, applies edits (background removal, AI backgrounds, shadows, relighting, text removal, flat lay, ghost mannequin, virtual model, and more), and returns the edited image.<br/>
    /// For tested parameter combinations for common use cases, see our tutorials before building your integration:<br/>
    /// - Second-hand marketplace listings: https://docs.photoroom.com/tutorials/how-to-improve-images-for-second-hand-item-marketplaces<br/>
    /// - E-commerce with brand consistency: https://docs.photoroom.com/tutorials/how-to-create-e-commerce-images-with-consistent-brand-guidelines<br/>
    /// - Food delivery apps: https://docs.photoroom.com/tutorials/how-to-create-food-delivery-images-with-consistent-brand-guidelines<br/>
    /// - Google Shopping compliance: https://docs.photoroom.com/tutorials/how-to-create-compliant-product-images-for-google-shopping<br/>
    /// - Sticker images: https://docs.photoroom.com/tutorials/how-to-create-sticker-images<br/>
    /// To use the API, you need an API key. Create one at https://app.photoroom.com/api-dashboard. The key must be passed in the x-api-key header on every request.<br/>
    /// Full documentation: https://docs.photoroom.com<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class PhotoroomClient : global::Photoroom.IPhotoroomClient, global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string DefaultBaseUrl = "https://image-api.photoroom.com/";

        private bool _disposeHttpClient = true;

        /// <inheritdoc/>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <inheritdoc/>
        public System.Uri? BaseUri => ResolveDisplayedBaseUri();

        /// <inheritdoc/>
        public global::System.Collections.Generic.List<global::Photoroom.EndPointAuthorization> Authorizations { get; }

        /// <inheritdoc/>
        public bool ReadResponseAsString { get; set; }
#if DEBUG
            = true;
#endif

        /// <inheritdoc/>
        public global::Photoroom.AutoSDKClientOptions Options { get; }


        internal global::Photoroom.AutoSDKServerConfiguration AutoSDKServerConfiguration { get; set; } = new global::Photoroom.AutoSDKServerConfiguration();
        /// <summary>
        /// 
        /// </summary>
        public global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; } = global::Photoroom.SourceGenerationContext.Default;



        private static readonly global::Photoroom.AutoSDKServer[] s_availableServers = new global::Photoroom.AutoSDKServer[]
        {            new global::Photoroom.AutoSDKServer(
                id: "https-image-api-photoroom-com",
                name: "image-api.photoroom.com",
                url: "https://image-api.photoroom.com/",
                description: ""),
            new global::Photoroom.AutoSDKServer(
                id: "https-sdk-photoroom-com",
                name: "Production server (Basic plan)",
                url: "https://sdk.photoroom.com/",
                description: "Production server (Basic plan)"),
        };

        /// <summary>
        /// The server options available for this client.
        /// </summary>
        public global::System.Collections.Generic.IReadOnlyList<global::Photoroom.AutoSDKServer> AvailableServers => s_availableServers;

        /// <summary>
        /// The currently selected server for this client, if any.
        /// </summary>
        public global::Photoroom.AutoSDKServer? SelectedServer
        {
            get => ResolveSelectedServer();
            set => SelectServer(value);
        }

        /// <summary>
        /// Creates a new instance of the PhotoroomClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public PhotoroomClient(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::Photoroom.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true) : this(
                httpClient,
                baseUri,
                authorizations,
                options: null,
                disposeHttpClient: disposeHttpClient)
        {
        }

        /// <summary>
        /// Creates a new instance of the PhotoroomClient with explicit options but no base URL override.
        /// Skips passing <c>baseUri</c> so the default base URL from the OpenAPI spec applies.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="options">Client-wide request defaults such as headers, query parameters, retries, and timeout.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public PhotoroomClient(
            global::System.Net.Http.HttpClient? httpClient,
            global::System.Collections.Generic.List<global::Photoroom.EndPointAuthorization>? authorizations,
            global::Photoroom.AutoSDKClientOptions? options,
            bool disposeHttpClient = true) : this(
                httpClient,
                baseUri: null,
                authorizations,
                options,
                disposeHttpClient: disposeHttpClient)
        {
        }

        /// <summary>
        /// Creates a new instance of the PhotoroomClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="options">Client-wide request defaults such as headers, query parameters, retries, and timeout.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public PhotoroomClient(
            global::System.Net.Http.HttpClient? httpClient,
            global::System.Uri? baseUri,
            global::System.Collections.Generic.List<global::Photoroom.EndPointAuthorization>? authorizations,
            global::Photoroom.AutoSDKClientOptions? options,
            bool disposeHttpClient = true)
        {

            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::Photoroom.EndPointAuthorization>();
            Options = options ?? new global::Photoroom.AutoSDKClientOptions();
            _disposeHttpClient = disposeHttpClient;

            AutoSDKServerConfiguration.ExplicitBaseUri = baseUri ?? httpClient?.BaseAddress;

            Initialized(HttpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            if (_disposeHttpClient)
            {
                HttpClient.Dispose();
            }
        }

        partial void Initialized(
            global::System.Net.Http.HttpClient client);
        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);


        /// <summary>
        /// Selects one of the generated server options by id.
        /// </summary>
        public bool TrySelectServer(string serverId)
        {
            if (string.IsNullOrWhiteSpace(serverId))
            {
                return false;
            }

            foreach (var server in s_availableServers)
            {
                if (string.Equals(server.Id, serverId, global::System.StringComparison.OrdinalIgnoreCase))
                {
                    AutoSDKServerConfiguration.SelectedServer = server;
                    AutoSDKServerConfiguration.ExplicitBaseUri = null;
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Clears the currently selected server.
        /// </summary>
        public void ClearSelectedServer()
        {
            AutoSDKServerConfiguration.SelectedServer = null;
        }

        private global::Photoroom.AutoSDKServer? ResolveSelectedServer()
        {
            var selectedServer = AutoSDKServerConfiguration.SelectedServer;
            if (selectedServer is null)
            {
                return null;
            }

            foreach (var server in s_availableServers)
            {
                if (string.Equals(server.Id, selectedServer.Id, global::System.StringComparison.Ordinal))
                {
                    return server;
                }
            }

            return null;
        }

        private void SelectServer(global::Photoroom.AutoSDKServer? server)
        {
            if (server is null)
            {
                AutoSDKServerConfiguration.SelectedServer = null;
                return;
            }

            foreach (var candidate in s_availableServers)
            {
                if (string.Equals(candidate.Id, server.Id, global::System.StringComparison.Ordinal))
                {
                    AutoSDKServerConfiguration.SelectedServer = candidate;
                    AutoSDKServerConfiguration.ExplicitBaseUri = null;
                    return;
                }
            }

            throw new global::System.ArgumentException("The provided server is not available for this client.", nameof(server));
        }

        private global::System.Uri? ResolveDisplayedBaseUri()
        {
            if (AutoSDKServerConfiguration.ExplicitBaseUri is global::System.Uri explicitBaseUri)
            {
                return explicitBaseUri;
            }

            return ResolveSelectedServer()?.Uri ?? HttpClient.BaseAddress;
        }

        private global::System.Uri? ResolveBaseUri(
            global::Photoroom.AutoSDKServer[] servers,
            string defaultBaseUrl)
        {
            if (AutoSDKServerConfiguration.ExplicitBaseUri is global::System.Uri explicitBaseUri)
            {
                return explicitBaseUri;
            }

            if (AutoSDKServerConfiguration.SelectedServer is global::Photoroom.AutoSDKServer selectedServer)
            {
                foreach (var server in servers)
                {
                    if (string.Equals(server.Id, selectedServer.Id, global::System.StringComparison.Ordinal))
                    {
                        return server.Uri;
                    }
                }
            }

            if (servers.Length > 0)
            {
                return servers[0].Uri;
            }

            return string.IsNullOrWhiteSpace(defaultBaseUrl)
                ? HttpClient.BaseAddress
                : new global::System.Uri(defaultBaseUrl, global::System.UriKind.RelativeOrAbsolute);
        }
    }
}