[![](https://img.shields.io/nuget/v/soenneker.autofaker.overrides.requests.entities.named.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.autofaker.overrides.requests.entities.named/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.autofaker.overrides.requests.entities.named/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.autofaker.overrides.requests.entities.named/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.autofaker.overrides.requests.entities.named.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.autofaker.overrides.requests.entities.named/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.autofaker.overrides.requests.entities.named/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.autofaker.overrides.requests.entities.named/actions/workflows/codeql.yml)

# Soenneker.AutoFaker.Overrides.Requests.Entities.Named

An AutoFaker override that supplies a display name for `NamedEntityRequest` models.

## Installation

```bash
dotnet add package Soenneker.AutoFaker.Overrides.Requests.Entities.Named
```

## Usage

```csharp
using Soenneker.AutoFaker.Overrides.Requests.Entities.Named;
using Soenneker.AutoFaker.Overrides.Requests.Entity;
using Soenneker.Requests.Entities.Named;
using Soenneker.Utils.AutoBogus;

var autoFaker = new AutoFaker();
autoFaker.Config.Overrides =
[
    new EntityRequestOverride(),
    new NamedEntityRequestOverride()
];

NamedEntityRequest request = autoFaker.Generate<NamedEntityRequest>();
```

`NamedEntityRequestOverride` applies to the base request and derived types and fills `Name` with a generated commerce product name. Register `EntityRequestOverride` too when the optional inherited `Id` should be a GUID string.
