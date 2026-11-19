#nullable enable

namespace Photoroom
{
    public partial interface IPhotoroomClient
    {
        /// <summary>
        /// Account Details v2<br/>
        /// Get current account details, including remaining image edits and monthly quota. Usage-based Enterprise plans get their remaining balance instead.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Photoroom.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Photoroom.AnyOf<global::Photoroom.AccountDetailsV2ResponseVariant1, global::Photoroom.AccountDetailsV2ResponseUsageBasedEnterprisePlan>> AccountDetailsV2Async(
            global::Photoroom.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Account Details v2<br/>
        /// Get current account details, including remaining image edits and monthly quota. Usage-based Enterprise plans get their remaining balance instead.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Photoroom.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Photoroom.AutoSDKHttpResponse<global::Photoroom.AnyOf<global::Photoroom.AccountDetailsV2ResponseVariant1, global::Photoroom.AccountDetailsV2ResponseUsageBasedEnterprisePlan>>> AccountDetailsV2AsResponseAsync(
            global::Photoroom.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}