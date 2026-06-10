# 📚 Migs.Extensions

A collection of useful C# extension methods.

## 📝 Description

This library extends common .NET types with practical and efficient extension methods for everyday development tasks.
It supports `.NET Standard 2.0`, `.NET 6.0`, and `.NET 8.0`.

## ✨ Features

- Fluent and expressive APIs for more readable C# code.
- Reusable extension methods to reduce boilerplate code.
- Strongly-typed helpers for improved reliability.
- Organized and scalable structure by domain (strings, collections, dates, etc.).
- Multi-targeted** for `.NET Standard 2.0`, `.NET 6.0`, and `.NET 8.0`.

## 🛠️ Prerequisites

- .NET SDK (6.0 or 8.0) or a compatible IDE (Visual Studio, Rider, etc.).

## 📦 Installation

1. Clone the repository:
  ```bash
   git clone https://github.com/migs81/Migs.Extensions.git
  ```
2. Navigate to the project directory:
  ```bash
   cd Migs.Extensions
  ```
3. Restore dependencies:
  ```bash
   dotnet restore
  ```
4. Build the project:
  ```bash
   dotnet build
  ```

## 🚀 Usage

```csharp
using Migs.Extensions;

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
Migs.Extensions/
├── src/
│   ├── Migs.Extensions/              # Core library
├── tests/                       
│   └── Migs.Extensions.Tests         # Unit tests
└── README.md                         # This file
```

## 🤝 Contributing

Contributions are welcome! Please open an issue or submit a pull request.

## 📄 License

This project is licensed under the [MIT License](LICENSE).

