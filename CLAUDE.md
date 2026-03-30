# CLAUDE.md -- Photoroom SDK

## Overview

Auto-generated C# SDK for [Photoroom](https://www.photoroom.com/) -- AI image editing platform with background removal, AI background generation, relighting, shadow effects, text removal, virtual models, ghost mannequin, flat lay, and image generation.
OpenAPI spec from `https://image-api.photoroom.com/openapi`.

## Build & Test

```bash
dotnet build Photoroom.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

API key auth via `x-api-key` header (native via `--security-scheme`):

```csharp
var client = new PhotoroomClient(apiKey); // PHOTOROOM_API_KEY env var
```

## Key Files

- `src/libs/Photoroom/openapi.yaml` -- OpenAPI spec (downloaded from image-api.photoroom.com)
- `src/libs/Photoroom/generate.sh` -- Downloads spec, fixes auth + servers, runs autosdk
- `src/libs/Photoroom/Generated/` -- **Never edit** -- auto-generated code
- `src/libs/Photoroom/Extensions/PhotoroomClient.Tools.cs` -- MEAI AIFunction tools
- `src/tests/IntegrationTests/Tests.cs` -- Test helper with bearer auth
- `src/tests/IntegrationTests/Examples/` -- Example tests (also generate docs)

## Spec Notes

The `generate.sh` applies fixes via `jq`:

1. **Auth:** Native via `--security-scheme ApiKey:Header:x-api-key`
2. **Servers:** Adds missing `servers` section with `https://image-api.photoroom.com`
3. **Top-level security:** Adds `security` array (spec only has per-operation)
4. **GET additionalProductImages:** Simplifies complex object array to string array (only URLs usable in GET)

## MEAI Integration

AIFunction tools for use with any `IChatClient`:

- `AsRemoveBackgroundTool()` -- Remove background from an image URL
- `AsEditImageTool()` -- Edit image with AI (background, shadow, relighting, text removal)
- `AsGenerateImageTool()` -- Generate image from text prompt

## Endpoints

| Endpoint | Method | Description |
|----------|--------|-------------|
| `/v1/segment` | POST | Remove Background (Basic plan) -- file upload |
| `/v2/edit` | GET | Image Editing v2 (Plus plan) -- URL-based |
| `/v2/edit` | POST | Image Editing v2 (Plus plan) -- file upload |
| `/v1/account` | GET | Account Details v1 |
| `/v2/account` | GET | Account Details v2 |

## Edit Features

The `/v2/edit` endpoint supports:
- **Background removal** -- AI-powered segmentation
- **AI backgrounds** -- Generate backgrounds from text prompts
- **Shadow generation** -- AI soft/hard/floating shadows
- **Relighting** -- AI-powered lighting adjustment
- **Text removal** -- Remove text/watermarks from images
- **Upscaling** -- AI image upscaling (alpha)
- **Virtual model** -- AI virtual try-on for clothing
- **Ghost mannequin** -- Remove mannequin from product photos
- **Flat lay** -- Generate flat lay product shots
- **Image from prompt** -- Generate images from text
- **Edit with AI** -- Natural language image editing
- **Uncrop** -- Expand image boundaries with AI
