#nullable enable

namespace Photoroom
{
    public partial interface IPhotoroomClient
    {
        /// <summary>
        /// Account Details v1<br/>
        /// Get current account details, including remaining credits balance and monthly quota
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Photoroom.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Photoroom.AccountDetailsV1Response> AccountDetailsV1Async(
            global::Photoroom.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Account Details v1<br/>
        /// Get current account details, including remaining credits balance and monthly quota
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Photoroom.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Photoroom.AutoSDKHttpResponse<global::Photoroom.AccountDetailsV1Response>> AccountDetailsV1AsResponseAsync(
            global::Photoroom.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}