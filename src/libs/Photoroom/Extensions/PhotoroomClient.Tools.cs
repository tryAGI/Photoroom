using Microsoft.Extensions.AI;

namespace Photoroom;

/// <summary>
/// Extensions for using PhotoroomClient as MEAI AIFunction tools with any IChatClient.
/// </summary>
public static class PhotoroomToolExtensions
{
    /// <summary>
    /// Creates an <see cref="AIFunction"/> that removes the background from an image URL,
    /// suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Photoroom client.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsRemoveBackgroundTool(
        this PhotoroomClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string imageUrl, CancellationToken cancellationToken) =>
            {
                // Use the GET /v2/edit endpoint with background removal only
                var result = await client.EditImageGetAsync(
                    imageUrl: imageUrl,
                    removeBackground: true,
                    exportFormat: EditImageGetExportFormat.Png,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return $"Background removed. Result: {result.Length} bytes PNG image returned.";
            },
            name: "PhotoroomRemoveBackground",
            description: "Removes the background from an image given its URL. Returns the processed image as PNG bytes.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that edits an image with AI capabilities
    /// (background generation, shadow, relighting, text removal, etc.),
    /// suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Photoroom client.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsEditImageTool(
        this PhotoroomClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (
                string imageUrl,
                string? backgroundPrompt,
                string? backgroundColor,
                bool? addShadow,
                bool? enableRelighting,
                bool? removeText,
                string? outputSize,
                CancellationToken cancellationToken) =>
            {
                var result = await client.EditImageGetAsync(
                    imageUrl: imageUrl,
                    removeBackground: true,
                    backgroundPrompt: backgroundPrompt,
                    backgroundColor: backgroundColor,
                    shadowMode: addShadow == true
                        ? EditImageGetShadowMode.AiSoft
                        : null,
                    lightingMode: enableRelighting == true
                        ? EditImageGetLightingMode.AiAuto
                        : null,
                    textRemovalMode: removeText == true
                        ? EditImageGetTextRemovalMode.AiAll
                        : null,
                    outputSize: outputSize,
                    exportFormat: EditImageGetExportFormat.Png,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return $"Image edited successfully. Result: {result.Length} bytes PNG image returned.";
            },
            name: "PhotoroomEditImage",
            description: "Edits an image using Photoroom AI. Can remove/replace backgrounds (with a prompt or solid color), add shadows, apply relighting, and remove text from images.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that generates an image from a text prompt,
    /// suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Photoroom client.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsGenerateImageTool(
        this PhotoroomClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (
                string prompt,
                EditImageGetImageFromPromptSize? size,
                CancellationToken cancellationToken) =>
            {
                var result = await client.EditImageGetAsync(
                    imageFromPromptPrompt: prompt,
                    imageFromPromptSize: size,
                    exportFormat: EditImageGetExportFormat.Png,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return $"Image generated successfully. Result: {result.Length} bytes PNG image returned.";
            },
            name: "PhotoroomGenerateImage",
            description: "Generates an image from a text prompt using Photoroom AI. Optionally specify the output size (e.g., LANDSCAPE_16_9, PORTRAIT_4_3, SQUARE_HD).");
    }
}
