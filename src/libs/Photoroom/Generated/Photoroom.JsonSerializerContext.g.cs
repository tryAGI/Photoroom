
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Photoroom
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Photoroom.JsonConverters.RemoveBackgroundPostParamsFormatJsonConverter),

            typeof(global::Photoroom.JsonConverters.RemoveBackgroundPostParamsFormatNullableJsonConverter),

            typeof(global::Photoroom.JsonConverters.RemoveBackgroundPostParamsChannelsJsonConverter),

            typeof(global::Photoroom.JsonConverters.RemoveBackgroundPostParamsChannelsNullableJsonConverter),

            typeof(global::Photoroom.JsonConverters.RemoveBackgroundPostParamsSizeJsonConverter),

            typeof(global::Photoroom.JsonConverters.RemoveBackgroundPostParamsSizeNullableJsonConverter),

            typeof(global::Photoroom.JsonConverters.RemoveBackgroundPostParamsCropJsonConverter),

            typeof(global::Photoroom.JsonConverters.RemoveBackgroundPostParamsCropNullableJsonConverter),

            typeof(global::Photoroom.JsonConverters.RemoveBackgroundPostParamsDespillJsonConverter),

            typeof(global::Photoroom.JsonConverters.RemoveBackgroundPostParamsDespillNullableJsonConverter),

            typeof(global::Photoroom.JsonConverters.EditImageGetBackgroundBlurModeJsonConverter),

            typeof(global::Photoroom.JsonConverters.EditImageGetBackgroundBlurModeNullableJsonConverter),

            typeof(global::Photoroom.JsonConverters.EditImageGetBackgroundExpandPromptModeJsonConverter),

            typeof(global::Photoroom.JsonConverters.EditImageGetBackgroundExpandPromptModeNullableJsonConverter),

            typeof(global::Photoroom.JsonConverters.EditImageGetBackgroundScalingJsonConverter),

            typeof(global::Photoroom.JsonConverters.EditImageGetBackgroundScalingNullableJsonConverter),

            typeof(global::Photoroom.JsonConverters.EditImageGetBeautifyModeJsonConverter),

            typeof(global::Photoroom.JsonConverters.EditImageGetBeautifyModeNullableJsonConverter),

            typeof(global::Photoroom.JsonConverters.EditImageGetExportFormatJsonConverter),

            typeof(global::Photoroom.JsonConverters.EditImageGetExportFormatNullableJsonConverter),

            typeof(global::Photoroom.JsonConverters.EditImageGetFlatLaySizeJsonConverter),

            typeof(global::Photoroom.JsonConverters.EditImageGetFlatLaySizeNullableJsonConverter),

            typeof(global::Photoroom.JsonConverters.EditImageGetGhostMannequinSizeJsonConverter),

            typeof(global::Photoroom.JsonConverters.EditImageGetGhostMannequinSizeNullableJsonConverter),

            typeof(global::Photoroom.JsonConverters.EditImageGetHorizontalAlignmentJsonConverter),

            typeof(global::Photoroom.JsonConverters.EditImageGetHorizontalAlignmentNullableJsonConverter),

            typeof(global::Photoroom.JsonConverters.EditImageGetImageFromPromptSizeJsonConverter),

            typeof(global::Photoroom.JsonConverters.EditImageGetImageFromPromptSizeNullableJsonConverter),

            typeof(global::Photoroom.JsonConverters.EditImageGetKeepExistingAlphaChannelJsonConverter),

            typeof(global::Photoroom.JsonConverters.EditImageGetKeepExistingAlphaChannelNullableJsonConverter),

            typeof(global::Photoroom.JsonConverters.EditImageGetLayersVariant2ImageHorizontalAlignmentJsonConverter),

            typeof(global::Photoroom.JsonConverters.EditImageGetLayersVariant2ImageHorizontalAlignmentNullableJsonConverter),

            typeof(global::Photoroom.JsonConverters.EditImageGetLayersVariant2ImageImageFromPromptSizeJsonConverter),

            typeof(global::Photoroom.JsonConverters.EditImageGetLayersVariant2ImageImageFromPromptSizeNullableJsonConverter),

            typeof(global::Photoroom.JsonConverters.EditImageGetLayersVariant2ImageRemoveBackgroundJsonConverter),

            typeof(global::Photoroom.JsonConverters.EditImageGetLayersVariant2ImageRemoveBackgroundNullableJsonConverter),

            typeof(global::Photoroom.JsonConverters.EditImageGetLayersVariant2ImageSegmentationModeJsonConverter),

            typeof(global::Photoroom.JsonConverters.EditImageGetLayersVariant2ImageSegmentationModeNullableJsonConverter),

            typeof(global::Photoroom.JsonConverters.EditImageGetLayersVariant2ImageUseForAIBackgroundJsonConverter),

            typeof(global::Photoroom.JsonConverters.EditImageGetLayersVariant2ImageUseForAIBackgroundNullableJsonConverter),

            typeof(global::Photoroom.JsonConverters.EditImageGetLayersVariant2ImageVerticalAlignmentJsonConverter),

            typeof(global::Photoroom.JsonConverters.EditImageGetLayersVariant2ImageVerticalAlignmentNullableJsonConverter),

            typeof(global::Photoroom.JsonConverters.EditImageGetLightingModeJsonConverter),

            typeof(global::Photoroom.JsonConverters.EditImageGetLightingModeNullableJsonConverter),

            typeof(global::Photoroom.JsonConverters.EditImageGetPreserveMetadataJsonConverter),

            typeof(global::Photoroom.JsonConverters.EditImageGetPreserveMetadataNullableJsonConverter),

            typeof(global::Photoroom.JsonConverters.EditImageGetReferenceBoxJsonConverter),

            typeof(global::Photoroom.JsonConverters.EditImageGetReferenceBoxNullableJsonConverter),

            typeof(global::Photoroom.JsonConverters.EditImageGetScalingJsonConverter),

            typeof(global::Photoroom.JsonConverters.EditImageGetScalingNullableJsonConverter),

            typeof(global::Photoroom.JsonConverters.EditImageGetSegmentationModeJsonConverter),

            typeof(global::Photoroom.JsonConverters.EditImageGetSegmentationModeNullableJsonConverter),

            typeof(global::Photoroom.JsonConverters.EditImageGetShadowModeJsonConverter),

            typeof(global::Photoroom.JsonConverters.EditImageGetShadowModeNullableJsonConverter),

            typeof(global::Photoroom.JsonConverters.EditImageGetTextRemovalModeJsonConverter),

            typeof(global::Photoroom.JsonConverters.EditImageGetTextRemovalModeNullableJsonConverter),

            typeof(global::Photoroom.JsonConverters.EditImageGetUpscaleModeJsonConverter),

            typeof(global::Photoroom.JsonConverters.EditImageGetUpscaleModeNullableJsonConverter),

            typeof(global::Photoroom.JsonConverters.EditImageGetVerticalAlignmentJsonConverter),

            typeof(global::Photoroom.JsonConverters.EditImageGetVerticalAlignmentNullableJsonConverter),

            typeof(global::Photoroom.JsonConverters.EditImageGetVirtualModelModelVariant1PresetNameJsonConverter),

            typeof(global::Photoroom.JsonConverters.EditImageGetVirtualModelModelVariant1PresetNameNullableJsonConverter),

            typeof(global::Photoroom.JsonConverters.EditImageGetVirtualModelPoseJsonConverter),

            typeof(global::Photoroom.JsonConverters.EditImageGetVirtualModelPoseNullableJsonConverter),

            typeof(global::Photoroom.JsonConverters.EditImageGetVirtualModelQualityJsonConverter),

            typeof(global::Photoroom.JsonConverters.EditImageGetVirtualModelQualityNullableJsonConverter),

            typeof(global::Photoroom.JsonConverters.EditImageGetVirtualModelSceneVariant1PresetNameJsonConverter),

            typeof(global::Photoroom.JsonConverters.EditImageGetVirtualModelSceneVariant1PresetNameNullableJsonConverter),

            typeof(global::Photoroom.JsonConverters.EditImageGetVirtualModelSizeJsonConverter),

            typeof(global::Photoroom.JsonConverters.EditImageGetVirtualModelSizeNullableJsonConverter),

            typeof(global::Photoroom.JsonConverters.AnyOfJsonConverter<string, string, global::Photoroom.EditImageGetBackgroundExpandPrompt2>),

            typeof(global::Photoroom.JsonConverters.AnyOfJsonConverter<global::Photoroom.EditImageGetLayersVariant1, global::Photoroom.EditImageGetLayersVariant2>),

            typeof(global::Photoroom.JsonConverters.AnyOfJsonConverter<global::Photoroom.EditImageGetVirtualModelModelVariant1, global::Photoroom.EditImageGetVirtualModelModelVariant2>),

            typeof(global::Photoroom.JsonConverters.AnyOfJsonConverter<global::Photoroom.EditImageGetVirtualModelSceneVariant1, global::Photoroom.EditImageGetVirtualModelSceneVariant2>),

            typeof(global::Photoroom.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.PaymentError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.PaymentErrorError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.UnknownError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.UnknownErrorError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.EditImageBadRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.EditImageBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.RemoveBackgroundPostParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.RemoveBackgroundPostParamsFormat), TypeInfoPropertyName = "RemoveBackgroundPostParamsFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.RemoveBackgroundPostParamsChannels), TypeInfoPropertyName = "RemoveBackgroundPostParamsChannels2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.RemoveBackgroundPostParamsSize), TypeInfoPropertyName = "RemoveBackgroundPostParamsSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.RemoveBackgroundPostParamsCrop), TypeInfoPropertyName = "RemoveBackgroundPostParamsCrop2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.RemoveBackgroundPostParamsDespill), TypeInfoPropertyName = "RemoveBackgroundPostParamsDespill2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.RenderImagePostParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.EditImagePostRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.EditImageGetBackgroundBlurMode), TypeInfoPropertyName = "EditImageGetBackgroundBlurMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.AnyOf<string, string, global::Photoroom.EditImageGetBackgroundExpandPrompt2>), TypeInfoPropertyName = "AnyOfStringStringEditImageGetBackgroundExpandPrompt22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.EditImageGetBackgroundExpandPrompt2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.EditImageGetBackgroundExpandPromptMode), TypeInfoPropertyName = "EditImageGetBackgroundExpandPromptMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.EditImageGetBackgroundScaling), TypeInfoPropertyName = "EditImageGetBackgroundScaling2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.EditImageGetBeautifyMode), TypeInfoPropertyName = "EditImageGetBeautifyMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.EditImageGetExportFormat), TypeInfoPropertyName = "EditImageGetExportFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.EditImageGetFlatLaySize), TypeInfoPropertyName = "EditImageGetFlatLaySize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.EditImageGetGhostMannequinSize), TypeInfoPropertyName = "EditImageGetGhostMannequinSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.EditImageGetHorizontalAlignment), TypeInfoPropertyName = "EditImageGetHorizontalAlignment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.EditImageGetImageFromPromptSize), TypeInfoPropertyName = "EditImageGetImageFromPromptSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.EditImageGetKeepExistingAlphaChannel), TypeInfoPropertyName = "EditImageGetKeepExistingAlphaChannel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.AnyOf<global::Photoroom.EditImageGetLayersVariant1, global::Photoroom.EditImageGetLayersVariant2>), TypeInfoPropertyName = "AnyOfEditImageGetLayersVariant1EditImageGetLayersVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.EditImageGetLayersVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.EditImageGetLayersVariant1Text))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.EditImageGetLayersVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.EditImageGetLayersVariant2Image))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.EditImageGetLayersVariant2ImageHorizontalAlignment), TypeInfoPropertyName = "EditImageGetLayersVariant2ImageHorizontalAlignment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.EditImageGetLayersVariant2ImageImageFromPrompt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.EditImageGetLayersVariant2ImageImageFromPromptSize), TypeInfoPropertyName = "EditImageGetLayersVariant2ImageImageFromPromptSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.EditImageGetLayersVariant2ImageRemoveBackground), TypeInfoPropertyName = "EditImageGetLayersVariant2ImageRemoveBackground2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.EditImageGetLayersVariant2ImageSegmentation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.EditImageGetLayersVariant2ImageSegmentationMode), TypeInfoPropertyName = "EditImageGetLayersVariant2ImageSegmentationMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.EditImageGetLayersVariant2ImageUseForAIBackground), TypeInfoPropertyName = "EditImageGetLayersVariant2ImageUseForAIBackground2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.EditImageGetLayersVariant2ImageVerticalAlignment), TypeInfoPropertyName = "EditImageGetLayersVariant2ImageVerticalAlignment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.EditImageGetLightingMode), TypeInfoPropertyName = "EditImageGetLightingMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.EditImageGetPreserveMetadata), TypeInfoPropertyName = "EditImageGetPreserveMetadata2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.EditImageGetReferenceBox), TypeInfoPropertyName = "EditImageGetReferenceBox2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.EditImageGetScaling), TypeInfoPropertyName = "EditImageGetScaling2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.EditImageGetSegmentationMode), TypeInfoPropertyName = "EditImageGetSegmentationMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.EditImageGetShadowMode), TypeInfoPropertyName = "EditImageGetShadowMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.EditImageGetTextRemovalMode), TypeInfoPropertyName = "EditImageGetTextRemovalMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.EditImageGetUpscaleMode), TypeInfoPropertyName = "EditImageGetUpscaleMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.EditImageGetVerticalAlignment), TypeInfoPropertyName = "EditImageGetVerticalAlignment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.AnyOf<global::Photoroom.EditImageGetVirtualModelModelVariant1, global::Photoroom.EditImageGetVirtualModelModelVariant2>), TypeInfoPropertyName = "AnyOfEditImageGetVirtualModelModelVariant1EditImageGetVirtualModelModelVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.EditImageGetVirtualModelModelVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.EditImageGetVirtualModelModelVariant1Preset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.EditImageGetVirtualModelModelVariant1PresetName), TypeInfoPropertyName = "EditImageGetVirtualModelModelVariant1PresetName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.EditImageGetVirtualModelModelVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.EditImageGetVirtualModelModelVariant2Custom))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.EditImageGetVirtualModelPose), TypeInfoPropertyName = "EditImageGetVirtualModelPose2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.EditImageGetVirtualModelQuality), TypeInfoPropertyName = "EditImageGetVirtualModelQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.AnyOf<global::Photoroom.EditImageGetVirtualModelSceneVariant1, global::Photoroom.EditImageGetVirtualModelSceneVariant2>), TypeInfoPropertyName = "AnyOfEditImageGetVirtualModelSceneVariant1EditImageGetVirtualModelSceneVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.EditImageGetVirtualModelSceneVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.EditImageGetVirtualModelSceneVariant1Preset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.EditImageGetVirtualModelSceneVariant1PresetName), TypeInfoPropertyName = "EditImageGetVirtualModelSceneVariant1PresetName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.EditImageGetVirtualModelSceneVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.EditImageGetVirtualModelSceneVariant2Custom))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.EditImageGetVirtualModelSize), TypeInfoPropertyName = "EditImageGetVirtualModelSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.RemoveBackgroundResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.RemoveBackgroundResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.RemoveBackgroundResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.AccountDetailsV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.AccountDetailsV1ResponseCredits))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.AccountDetailsV1Response2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.AccountDetailsV1ResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.AccountDetailsV2Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.AccountDetailsV2ResponseImages))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.AccountDetailsV2Response2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.AccountDetailsV2ResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.EditImageGetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.EditImageGetResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.EditImageGetResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.EditImageGetResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.EditImageGetResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.EditImageGetResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.EditImagePostResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.EditImagePostResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.EditImagePostResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.EditImagePostResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.EditImagePostResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Photoroom.EditImagePostResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}