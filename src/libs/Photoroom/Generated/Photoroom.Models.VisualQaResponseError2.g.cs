
#nullable enable

namespace Photoroom
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VisualQaResponseError2
    {
        /// <summary>
        /// The message describing the error<br/>
        /// Example: This endpoint is only available to customers on an Enterprise plan. Contact our sales team to get access: https://www.photoroom.com/contact-sales
        /// </summary>
        /// <example>This endpoint is only available to customers on an Enterprise plan. Contact our sales team to get access: https://www.photoroom.com/contact-sales</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualQaResponseError2" /> class.
        /// </summary>
        /// <param name="message">
        /// The message describing the error<br/>
        /// Example: This endpoint is only available to customers on an Enterprise plan. Contact our sales team to get access: https://www.photoroom.com/contact-sales
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VisualQaResponseError2(
            string message)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualQaResponseError2" /> class.
        /// </summary>
        public VisualQaResponseError2()
        {
        }

    }
}