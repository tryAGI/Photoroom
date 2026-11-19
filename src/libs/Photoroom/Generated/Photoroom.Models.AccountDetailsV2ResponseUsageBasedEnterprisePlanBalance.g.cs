
#nullable enable

namespace Photoroom
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AccountDetailsV2ResponseUsageBasedEnterprisePlanBalance
    {
        /// <summary>
        /// The remaining balance as a decimal string in the contract currency, truncated to cents. Negative when the account is overdrawn.<br/>
        /// Example: 1234.56
        /// </summary>
        /// <example>1234.56</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Amount { get; set; }

        /// <summary>
        /// The same balance as an integer number of hundredths of the contract currency, for arithmetic without rounding errors.<br/>
        /// Example: 123456
        /// </summary>
        /// <example>123456</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("amountHundredths")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AmountHundredths { get; set; }

        /// <summary>
        /// The lowercase ISO 4217 code of the contract currency<br/>
        /// Example: usd
        /// </summary>
        /// <example>usd</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("currency")]
        public string? Currency { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountDetailsV2ResponseUsageBasedEnterprisePlanBalance" /> class.
        /// </summary>
        /// <param name="amount">
        /// The remaining balance as a decimal string in the contract currency, truncated to cents. Negative when the account is overdrawn.<br/>
        /// Example: 1234.56
        /// </param>
        /// <param name="amountHundredths">
        /// The same balance as an integer number of hundredths of the contract currency, for arithmetic without rounding errors.<br/>
        /// Example: 123456
        /// </param>
        /// <param name="currency">
        /// The lowercase ISO 4217 code of the contract currency<br/>
        /// Example: usd
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AccountDetailsV2ResponseUsageBasedEnterprisePlanBalance(
            string amount,
            int amountHundredths,
            string? currency)
        {
            this.Amount = amount ?? throw new global::System.ArgumentNullException(nameof(amount));
            this.AmountHundredths = amountHundredths;
            this.Currency = currency;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountDetailsV2ResponseUsageBasedEnterprisePlanBalance" /> class.
        /// </summary>
        public AccountDetailsV2ResponseUsageBasedEnterprisePlanBalance()
        {
        }

    }
}