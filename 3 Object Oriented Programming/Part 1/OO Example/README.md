# Object Oriented Programming Part 1 Example

This solution demonstrates basic Object-Oriented Programming (OOP) concepts using a WPF application and a model class in C# targeting .NET Framework 4.8.

## Projects

### OO_Example_WPF
This is a WPF application that serves as the user interface for the example.

### OO_Example_Models
This project contains the model classes used in the example. It includes the following:
- `User.cs`: A class representing a user with properties for `Number`, `FirstName`, `LastName`, and a read-only property `FullName`. It also includes methods to display and clear user data.

## User Class

The `User` class in the `OO_Example_Models` project includes:
- Private fields: `_number`, `_firstName`, `_lastName`
- Public properties: `Number`, `FirstName`, `LastName`
- Read-only property: `FullName`
- Methods: `ShowData()`, `Clear()`
- Constructor: Initializes the user object with default values.
