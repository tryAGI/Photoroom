#!/usr/bin/env bash
set -euo pipefail

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

fetch_spec() {
  curl "$@" \
    --fail --silent --show-error --location \
    --retry 5 --retry-delay 10 --retry-all-errors \
    --connect-timeout 30 --max-time 300
}

# OpenAPI spec: https://image-api.photoroom.com/openapi
install_autosdk_cli
rm -rf Generated
fetch_spec --fail --silent --show-error -L -o openapi.yaml https://image-api.photoroom.com/openapi

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

# Auth: x-api-key header. --base-url injects server URL (missing from spec).
autosdk generate openapi.yaml \
  --namespace Photoroom \
  --clientClassName PhotoroomClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme ApiKey:Header:x-api-key \
  --base-url https://image-api.photoroom.com
