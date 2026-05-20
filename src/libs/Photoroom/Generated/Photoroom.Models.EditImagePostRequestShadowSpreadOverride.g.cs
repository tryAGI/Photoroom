
#nullable enable

namespace Photoroom
{
    /// <summary>
    /// Override for the spread of the shadow.<br/>
    /// Can be provided either as an angle in degrees or as one of the following presets:<br/>
    /// - `short` = 10<br/>
    /// - `medium` = 45<br/>
    /// - `long` = 90<br/>
    /// When using degrees, 0 means a very short shadow and 90 means a very long shadow.<br/>
    /// This option is only supported by the `2026-04-15` AI Shadows model. It requires setting `shadow.mode` to `ai.auto-with-overrides`.
    /// </summary>
    public sealed partial class EditImagePostRequestShadowSpreadOverride
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}