#nullable enable

namespace Photoroom;

public partial class PhotoroomClient
{
#pragma warning disable CA1822 // Mark members as static
    partial void PrepareRequest(
        global::System.Net.Http.HttpClient client,
        global::System.Net.Http.HttpRequestMessage request)
    {
        // Photoroom uses x-api-key header instead of Authorization: Bearer
        if (request.Headers.Authorization is { Scheme: "Bearer", Parameter: { } apiKey })
        {
            request.Headers.Authorization = null;
            request.Headers.TryAddWithoutValidation("x-api-key", apiKey);
        }
    }
#pragma warning restore CA1822 // Mark members as static
}
