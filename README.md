# SerializationDemo

![Serialization](https://img.shields.io/badge/.NET-Serialization-blue)
![C#](https://img.shields.io/badge/Language-C%23-green)

---

## Overview

SerializationDemo is a small .NET example that demonstrates how to serialize and deserialize objects using common formats.

This project shows three serialization approaches:

- **Binary**
- **XML**
- **JSON**

---

## What’s included

- `Person.cs` — sample model for serialization
- `Program.cs` — demo driver that shows how to convert objects to and from serialized data
- `person.json` — example JSON output
- `person.xml` — example XML output

---

## Why this matters

Serialization is the process of converting an object into a format that can be stored or transmitted, then reconstructing it later.

This demo helps you understand:

- when to use JSON vs XML vs binary
- how .NET handles serialization formats
- how to read and write serialized data using C#

---

## Quick Start

```bash
dotnet run
```

Then inspect the generated files or the console output.

---

## Example

```csharp
var person = new Person
{
    Id = 1,
    Name = "Alice",
    Email = "alice@example.com"
};

// JSON serialization
var json = JsonSerializer.Serialize(person, new JsonSerializerOptions { WriteIndented = true });
```

---

## Notes

- The JSON file in this repository shows how the serialized data is structured.
- The XML file shows the same data in a different format.
- Binary serialization is useful for compact storage and fast round-trips.

---

## License

This demo is provided for learning and exploration.

