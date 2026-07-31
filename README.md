# SerializationDemo

![Serialization](https://img.shields.io/badge/.NET-Serialization-blue)
![C#](https://img.shields.io/badge/Language-C%23-green)

---

## Overview

SerializationDemo is a small .NET console application that demonstrates how to serialize objects into different formats and restore them back into memory.

This project includes examples for:

- **Binary serialization** using `BinaryWriter`
- **XML serialization** using `XmlSerializer`
- **JSON serialization** using `System.Text.Json`

---

## Project structure
###  ` ### Main Src Files ###`
- `Program.cs` — demo application that creates `Person` instances and writes them to files
- `Person.cs` — simple model containing `UserName` and `UserAge`

### `### Result Files ###`
- `person.json` — example output for a single person in JSON format
- `People.json` — example output for a group of people in JSON format
- `person.xml` — example output for a single person in XML format
- `Person.dat` — example output for a single person in Binary format


---

## Person model

The demo uses a lightweight `Person` class:

- `string? UserName`
- `int UserAge`

This makes it easy to compare how different serializers handle the same data.

---

## What this demo teaches

- how to configure `JsonSerializerOptions` for readable JSON
- how to serialize a single object vs a collection of objects
- the differences between text-based formats (XML/JSON) and binary data
- writing serialized output to disk with `File.WriteAllText` and `FileStream`

---

## Run the demo

From the project folder, run:

```bash
dotnet run
```

Expected behavior:

1. a binary file is created using `Person.dat`
2. a single person is written to `person.xml`
3. a list of people is written to `People.json`
4. console messages confirm completion

---

## Example JSON output

```json
[
  {
    "UserName": "Billy Madison",
    "UserAge": 28
  },
  {
    "UserName": "Jim Carey",
    "UserAge": 35
  }
]
```

---

## Example XML output

```xml
<?xml version="1.0" encoding="utf-8"?>
<Person>
  <UserName>JimmyNeutron</UserName>
  <UserAge>12</UserAge>
</Person>
```

---

## Extend this demo

- add additional properties to `Person` such as `Email`, `Id`, or `DateOfBirth`
- serialize nested objects or lists inside the model
- implement deserialization to read the files back into `Person` instances
- compare `BinaryFormatter` (legacy) with modern serializers such as `System.Text.Json`

---

## Notes

- JSON is often preferred for APIs and configuration files because it is human-readable and widely supported.
- XML is still useful for interoperability with systems that require strict document structure.
- Binary formats are compact and can be faster to read/write, but they are not human-readable.

---

## License

This demo is provided for learning and exploration.

