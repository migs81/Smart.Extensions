# 📚 Smart.Extensions

A collection of useful C# extension methods.

## 📝 Description

This library extends common .NET types with practical and efficient extension methods for everyday development tasks.
It supports `.NET Standard 2.0`, `.NET 8.0`, and `.NET 10.0`.

## ✨ Features

- Fluent and expressive APIs for more readable C# code.
- Reusable extension methods to reduce boilerplate code.
- Strongly-typed helpers for improved reliability.
- Organized and scalable structure by domain (strings, collections, dates, etc.).
- Multi-targeted** for `.NET Standard 2.0`, `.NET 8.0`, and `.NET 10.0`.

## 🛠️ Prerequisites

- .NET SDK (8.0 or 10.0) or a compatible IDE (Visual Studio, Rider, etc.).

## 📦 Installation

```bash
git clone https://github.com/migs81/Smart.Extensions.git
cd Smart.Extensions
dotnet build
```

## 🚀 Usage

```csharp
using Smart.Extensions;

var text = "Hello World".ToCamelCase();
```

## 🧩 Examples of available extensions

### Char Extensions
- `ToUpper`
- `ToLower`
- `IsLetter`
- `IsDigit`

### Collection Extensions
- `IsNullOrEmpty`
- `IsNull`
- `AddRange`
- `ToObservableCollection`

### DateTime Extensions
- `IsWeekend`
- `IsWeekday`
- `IsBetween`

### Enum Extensions
- `Description`

### Integer Extensions
- `IsZero`
- `IsNegative`
- `IsPositive`
- `IsGreaterThan`
- `IsLessThan`
- `Add`
- `Subtract`
- `DivideBy`
- `MultiplyWith`

### Object Extensions
- `GetValueOrDefault`
- `GetOrSetValue`
- `ReplaceIf`
- `If`
- `GetPropertyValues`

### StringBuilder Extensions
- `AppendIf`
- `AppendLineIf`
- `AppendIfNotNullOrEmpty`
- `AppendLineIfNotNullOrEmpty`
- `AppendLines`

### String Extensions
- `IsGuid`
- `IsMailAddress`
- `IsDate`
- `IsUri`
- `Truncate`
- `ToByteArray`
- `IsNumeric`
- `ToPascalCase`
- `ToCamelCase`
- `ToCamelCase`
- `IsAlphaNumeric`

## 📂 Project Structure

```
Smart.Extensions/
├── src/
│   ├── Smart.Extensions/              # Core library
├── tests/                       
│   └── Smart.Extensions.Tests         # Unit tests
└── README.md                          # This file
```

## 📄 License

This project is licensed under the [MIT License](LICENSE).

