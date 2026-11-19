
#nullable enable

namespace Photoroom
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AccountDetailsV2ResponseUsageBasedEnterprisePlan
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("balance")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Photoroom.AccountDetailsV2ResponseUsageBasedEnterprisePlanBalance Balance { get; set; }

        /// <summary>
        /// The name of the pricing plan<br/>
        /// Example: enterprise_usage_based
        /// </summary>
        /// <example>enterprise_usage_based</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Plan { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountDetailsV2ResponseUsageBasedEnterprisePlan" /> class.
        /// </summary>
        /// <param name="balance"></param>
        /// <param name="plan">
        /// The name of the pricing plan<br/>
        /// Example: enterprise_usage_based
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AccountDetailsV2ResponseUsageBasedEnterprisePlan(
            global::Photoroom.AccountDetailsV2ResponseUsageBasedEnterprisePlanBalance balance,
            string plan)
        {
            this.Balance = balance ?? throw new global::System.ArgumentNullException(nameof(balance));
            this.Plan = plan ?? throw new global::System.ArgumentNullException(nameof(plan));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountDetailsV2ResponseUsageBasedEnterprisePlan" /> class.
        /// </summary>
        public AccountDetailsV2ResponseUsageBasedEnterprisePlan()
        {
        }

    }
}