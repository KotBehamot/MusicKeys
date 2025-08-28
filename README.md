# MusicKeys

A .NET library for representing and handling musical keys (major/minor) with descriptive attributes.

## Features
- `MusicKey` enum with key descriptions (short and long name, major/minor mode)
- `MusicKeyDescriptionAttribute` for describing each key
- Extension methods:
  - `GetShortName()` — returns the short name of the key
  - `GetLongName()` — returns the full name of the key
  - `IsMajor()` — indicates if the key is major

## Usage Example
```csharp
using MusicKeys;
using MusicKeys.Enums;
using MusicKeys.Extensions;

var key = MusicKey.CSharpMajor;
Console.WriteLine(key.GetShortName()); // C#
Console.WriteLine(key.GetLongName());  // C# major
Console.WriteLine(key.IsMajor());      // True
```

## Requirements
- .NET Standard 2.0

## License
Apache 2.0
