# Inheritance Part 3 Example

This solution demonstrates the concept of inheritance in C# using a WPF application. The solution consists of two projects:

1. **InheritancePart3Example_WPF**: This is the WPF application that provides a user interface to interact with different types of users (User, Student, Teacher).
2. **InheritancePart3Example_Models**: This project contains the model classes that represent the different types of users.

## Projects

### InheritancePart3Example_WPF

This project is a WPF application targeting .NET Framework 4.8. It provides a user interface to add and display users. The main features include:

- Adding users of different types (User, Student, Teacher).
- Displaying user details in a ComboBox.
- Dynamically showing/hiding UI elements based on the selected user type.

### InheritancePart3Example_Models

This project contains the model classes that represent the different types of users. The main classes include:

- **User**: The base class for all users.
- **Student**: Inherits from User and adds a scholarship property.
- **Teacher**: Inherits from User and adds a salary property.

## Usage

1. Select the type of user to add (User, Student, Teacher) using the radio buttons.
2. Fill in the user details (Number, First Name, Last Name).
3. If adding a Student, specify the scholarship status.
4. If adding a Teacher, specify the salary.
5. Click the "Add" button to add the user to the list.
6. The added users will be displayed in the ComboBox, and their details will be shown in the label below.
