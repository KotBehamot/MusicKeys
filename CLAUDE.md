# CLAUDE.md — MusicKeys

This file provides context for AI assistants working on the MusicKeys repository.

## Project Overview

**MusicKeys** is a lightweight .NET Standard 2.0 library that exposes a strongly-typed musical key enum (major/minor) with custom attributes and extension methods. It is published as a NuGet package.

- **NuGet package**: `MusicKeys`
- **Current version**: `1.1.0`
- **License**: Apache-2.0
- **Target framework**: .NET Standard 2.0 (compatible with .NET Framework 4.6.1+, .NET Core 2.0+, and .NET 5+)

---

## Repository Structure

```
MusicKeys/
├── .github/workflows/
│   ├── dotnet.yml              # CI: build + pack on push/PR to master/main
│   └── publish-nuget.yml       # CD: publish to NuGet.org on tag/release/manual trigger
├── MusicKeys/
│   ├── KeyDescriptionAttribute.cs   # Custom attribute for key metadata
│   ├── MusicKey.cs                  # Core enum: 30 musical keys (major + minor)
│   ├── MusicKeyExtensions.cs        # Extension methods with reflection caching
│   └── MusicKeys.csproj             # Project file + NuGet metadata
├── CHANGELOG.md
├── global.json                 # .NET SDK version pin (8.0.400)
├── LICENSE.txt
├── MusicKeys.sln
└── README.md
```

---

## Key Source Files

### `MusicKeys/MusicKey.cs`
- Namespace: `MusicKeys.Enums`
- Defines the `MusicKey` enum with 30 values: 17 major keys and 13 minor keys.
- Each value is decorated with `[MusicKeyDescription(...)]`.

### `MusicKeys/KeyDescriptionAttribute.cs`
- Namespace: `MusicKeys.Attributes`
- Sealed attribute class `MusicKeyDescriptionAttribute` (alias: `MusicKeyDescription`).
- Properties: `ShortName` (e.g. `"C#"`), `LongName` (e.g. `"C# major"`), `IsMajor` (`bool`).
- Target: enum fields only (`AttributeTargets.Field`).

### `MusicKeys/MusicKeyExtensions.cs`
- Namespace: `MusicKeys.Extensions`
- Static class with three extension methods on `MusicKey`:
  - `GetShortName()` → `string`
  - `GetLongName()` → `string`
  - `IsMajor()` → `bool`
- Uses a **lazy-loaded static `Dictionary<MusicKey, MusicKeyDescriptionAttribute>`** to cache reflection results — avoids repeated reflection on every call.

---

## Architectural Conventions

1. **Enum + Attribute pattern** — metadata lives on enum fields via custom attributes, not in separate lookup tables.
2. **Extension methods** — public API is surfaced through extension methods for a fluent call style (`key.GetLongName()`).
3. **Reflection caching via `Lazy<T>`** — thread-safe, one-time initialization. Do not remove or bypass this cache.
4. **Namespace separation**:
   - `MusicKeys.Attributes` — attribute definitions
   - `MusicKeys.Enums` — enum types
   - `MusicKeys.Extensions` — extension methods
5. **Language version**: C# 7.3 (`LangVersion` set in `.csproj`). Do not use language features newer than C# 7.3.
6. **Nullability**: nullable reference types are **disabled**. Do not enable them without a project-wide migration.
7. **Implicit usings**: disabled. All `using` directives must be explicit.

---

## Build & Development

### Prerequisites
- .NET SDK **8.0.400** (pinned in `global.json`; `latestFeature` roll-forward is allowed)

### Common Commands

```bash
# Restore dependencies
dotnet restore MusicKeys/MusicKeys.csproj

# Build (Release)
dotnet build MusicKeys/MusicKeys.csproj -c Release

# Pack NuGet package into out/
dotnet pack MusicKeys/MusicKeys.csproj -c Release -o out
```

No npm, Makefile, or other build system is used — only the .NET CLI.

---

## CI/CD

### `dotnet.yml` — Continuous Integration
- **Triggers**: push or PR targeting `master` or `main`.
- **Steps**: checkout → setup .NET 8 → restore → build (Release) → pack.
- Validates that the project builds and packages correctly on every change.

### `publish-nuget.yml` — NuGet Publishing
- **Triggers**: manual dispatch, push of a `v*` tag, or release creation.
- **Steps**: checkout → setup .NET 8 → restore → build (Release) → pack with `ContinuousIntegrationBuild=true` → push to NuGet.org.
- Requires the `NUGET_API_KEY` GitHub secret (stored in repository settings).
- `--skip-duplicate` flag makes the push idempotent.

---

## Versioning & Release Process

1. Update `<Version>` in `MusicKeys/MusicKeys.csproj`.
2. Add a new entry to `CHANGELOG.md`.
3. Commit, tag with `v<version>` (e.g. `v1.2.0`), and push — the publish workflow fires automatically.

---

## No Tests

There is currently no test project. If adding tests:
- Create a new project `MusicKeys.Tests/` using xUnit or NUnit.
- Add it to `MusicKeys.sln`.
- The CI workflow should be updated to run `dotnet test` after `dotnet build`.

---

## Important Notes for AI Assistants

- **Do not** upgrade the C# language version without explicit instruction — the project targets .NET Standard 2.0 and must remain broadly compatible.
- **Do not** enable nullable reference types (`<Nullable>enable</Nullable>`) without a full migration plan.
- **Do not** add runtime dependencies to `.csproj` without checking .NET Standard 2.0 compatibility.
- When adding new musical keys to `MusicKey.cs`, always decorate them with `[MusicKeyDescription(...)]` and update the XML doc comment.
- Extension methods must go in `MusicKeyExtensions.cs` inside `MusicKeys.Extensions` namespace; do not scatter helper logic elsewhere.
- The reflection cache in `MusicKeyExtensions.cs` must cover any new enum values — it is built automatically via reflection so no manual update is needed, but verify the attribute is present on each new value.
