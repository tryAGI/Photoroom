#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: https://image-api.photoroom.com/openapi

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error -L -o openapi.yaml https://image-api.photoroom.com/openapi

# Fix virtualModel.additionalProductImages in GET /v2/edit and /v1/render:
#   simplify to string array (GET can only use imageUrl, not binary imageFile)
jq '
  .paths["/v2/edit"].get.parameters |= map(
      if .name == "virtualModel.additionalProductImages" then
        .schema = {
          "type": "array",
          "items": { "type": "string" },
          "minItems": 1,
          "maxItems": 4,
          "description": "URLs of additional product images showing different angles or details."
        }
      else . end
    )
  | .paths["/v1/render"].get.parameters |= (if . then map(
      if .name == "virtualModel.additionalProductImages" then
        .schema = {
          "type": "array",
          "items": { "type": "string" },
          "minItems": 1,
          "maxItems": 4,
          "description": "URLs of additional product images showing different angles or details."
        }
      else . end
    ) else . end)
' openapi.yaml > openapi.fixed.yaml
mv openapi.fixed.yaml openapi.yaml

# Auth: --security-scheme overrides the spec's apiKey auth with standard HTTP bearer.
# --base-url injects server URL (missing from spec).
autosdk generate openapi.yaml \
  --namespace Photoroom \
  --clientClassName PhotoroomClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer \
  --base-url https://image-api.photoroom.com
