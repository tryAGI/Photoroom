
#nullable enable

namespace Photoroom
{
    /// <summary>
    /// Use a preset model by name.
    /// </summary>
    public sealed partial class EditImageGetVirtualModelModelVariant1Preset
    {
        /// <summary>
        /// Name of the preset model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Photoroom.JsonConverters.EditImageGetVirtualModelModelVariant1PresetNameJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Photoroom.EditImageGetVirtualModelModelVariant1PresetName Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EditImageGetVirtualModelModelVariant1Preset" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the preset model.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EditImageGetVirtualModelModelVariant1Preset(
            global::Photoroom.EditImageGetVirtualModelModelVariant1PresetName name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditImageGetVirtualModelModelVariant1Preset" /> class.
        /// </summary>
        public EditImageGetVirtualModelModelVariant1Preset()
        {
        }
    }
}