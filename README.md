# TensicAI.Sdk

.NET SDK for [Tensic](https://tensic.ai), a sovereign AI orchestration platform.

> **Early preview.** This package establishes the package ID and project layout.
> The public API is not stable and no HTTP transport is wired up yet. Expect
> breaking changes before `0.1.0`.

## Installation

```bash
dotnet add package TensicAI.Sdk --prerelease
```

## Usage

```csharp
using TensicAI.Sdk;

var client = new TensicClient("https://manager.tensic.ai", "my-api-key");
```

## Target frameworks

`netstandard2.0` and `net8.0`, so it works from .NET Framework 4.6.1 upwards as
well as modern .NET.

## Other SDKs

| Language | Package | Repository |
|---|---|---|
| PHP | `tensicai/php-sdk` | [tensicai/php-sdk](https://github.com/tensicai/php-sdk) |
| Python | `tensicai` | [tensicai/python-sdk](https://github.com/tensicai/python-sdk) |
| Node | `@tensicai/node-sdk` | [tensicai/node-sdk](https://github.com/tensicai/node-sdk) |
| Rust | `tensicai-rust-sdk` | [tensicai/rust-sdk](https://github.com/tensicai/rust-sdk) |
| .NET | `TensicAI.Sdk` | [tensicai/dotnet-sdk](https://github.com/tensicai/dotnet-sdk) |

## Licence

Apache-2.0
