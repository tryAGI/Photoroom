
#nullable enable

namespace Photoroom
{
    /// <summary>
    /// Use a preset scene by name.
    /// </summary>
    public sealed partial class EditImageGetVirtualModelSceneVariant1Preset
    {
        /// <summary>
        /// Name of the preset scene.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Photoroom.JsonConverters.EditImageGetVirtualModelSceneVariant1PresetNameJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Photoroom.EditImageGetVirtualModelSceneVariant1PresetName Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EditImageGetVirtualModelSceneVariant1Preset" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the preset scene.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EditImageGetVirtualModelSceneVariant1Preset(
            global::Photoroom.EditImageGetVirtualModelSceneVariant1PresetName name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditImageGetVirtualModelSceneVariant1Preset" /> class.
        /// </summary>
        public EditImageGetVirtualModelSceneVariant1Preset()
        {
        }
    }
}