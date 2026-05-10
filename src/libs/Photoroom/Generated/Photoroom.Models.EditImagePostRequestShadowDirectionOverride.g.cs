
#nullable enable

namespace Photoroom
{
    /// <summary>
    /// Override for the direction of the shadow.<br/>
    /// Can be provided either as an angle in degrees or as one of the following presets:<br/>
    /// - `behind` = 0<br/>
    /// - `behindLeft` = 45<br/>
    /// - `left` = 90<br/>
    /// - `frontLeft` = 135<br/>
    /// - `front` = 180<br/>
    /// - `frontRight` = 225<br/>
    /// - `right` = 270<br/>
    /// - `behindRight` = 315<br/>
    /// When using degrees, 0 means the shadow is behind the subject, 90 means the shadow is at the left of the subject, 180 means the shadow is in front of the subject, and 270 means the shadow is at the right of the subject.<br/>
    /// This option is only supported by the `2026-04-15` AI Shadows model. It requires setting `shadow.mode` to `ai.auto-with-overrides`.
    /// </summary>
    public sealed partial class EditImagePostRequestShadowDirectionOverride
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}