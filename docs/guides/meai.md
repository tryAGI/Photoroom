# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The Photoroom SDK provides `AIFunction` tool wrappers compatible with [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai). These tools can be used with any `IChatClient` to give AI models access to Photoroom's AI image editing, background removal, and image generation capabilities.

## Available Tools

### Remove Background

Removes the background from an image given its URL:

```csharp
using Photoroom;
using Microsoft.Extensions.AI;

var photoroomClient = new PhotoroomClient(apiKey);
var tool = photoroomClient.AsRemoveBackgroundTool();

// Use with any IChatClient
var options = new ChatOptions
{
    Tools = [tool],
};
```

### Edit Image

Edits an image with AI capabilities (background generation, shadow, relighting, text removal):

```csharp
var tool = photoroomClient.AsEditImageTool();
```

### Generate Image

Generates an image from a text prompt:

```csharp
var tool = photoroomClient.AsGenerateImageTool();
```

## Usage with IChatClient

```csharp
using Microsoft.Extensions.AI;
using Photoroom;

var photoroomClient = new PhotoroomClient(photoroomApiKey);
IChatClient chatClient = /* any IChatClient implementation */;

var options = new ChatOptions
{
    Tools =
    [
        photoroomClient.AsRemoveBackgroundTool(),
        photoroomClient.AsEditImageTool(),
        photoroomClient.AsGenerateImageTool(),
    ],
};

var response = await chatClient.GetResponseAsync(
    "Remove the background from this image: https://example.com/photo.jpg",
    options);
```
