
#nullable enable

namespace Photoroom
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PaymentErrorError
    {
        /// <summary>
        /// The message describing the error. It depends on how the team is billed:<br/>
        /// - API credits: `API credits exhausted. Visit https://app.photoroom.com/api-dashboard to purchase more API credits`<br/>
        /// - Usage-based: `Your wallet balance is too low for this request. Contact our sales team at https://www.photoroom.com/contact-sales to add funds.`<br/>
        /// Example: API credits exhausted. Visit https://app.photoroom.com/api-dashboard to purchase more API credits
        /// </summary>
        /// <example>API credits exhausted. Visit https://app.photoroom.com/api-dashboard to purchase more API credits</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentErrorError" /> class.
        /// </summary>
        /// <param name="message">
        /// The message describing the error. It depends on how the team is billed:<br/>
        /// - API credits: `API credits exhausted. Visit https://app.photoroom.com/api-dashboard to purchase more API credits`<br/>
        /// - Usage-based: `Your wallet balance is too low for this request. Contact our sales team at https://www.photoroom.com/contact-sales to add funds.`<br/>
        /// Example: API credits exhausted. Visit https://app.photoroom.com/api-dashboard to purchase more API credits
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PaymentErrorError(
            string message)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentErrorError" /> class.
        /// </summary>
        public PaymentErrorError()
        {
        }

    }
}