#nullable enable

namespace Photoroom
{
    public partial interface IPhotoroomClient
    {
        /// <summary>
        /// Account Details v2<br/>
        /// Get current account details, including remaining image edits and monthly quota
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Photoroom.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Photoroom.AccountDetailsV2Response> AccountDetailsV2Async(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}