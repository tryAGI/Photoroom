#nullable enable

namespace Photoroom
{
    public partial interface IPhotoroomClient
    {
        /// <summary>
        /// Account Details v1<br/>
        /// Get current account details, including remaining credits balance and monthly quota
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Photoroom.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Photoroom.AccountDetailsV1Response> AccountDetailsV1Async(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}