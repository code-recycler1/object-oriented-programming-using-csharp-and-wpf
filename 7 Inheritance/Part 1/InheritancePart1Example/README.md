# Inheritance Part 1 Example

## Overview

This solution demonstrates the concept of inheritance in C# using a WPF application. The project consists of a WPF application and a class library for models.

## Projects

1. **InheritancePart1Example_WPF**: This is the WPF application that provides a user interface to interact with different types of users.
2. **InheritancePart1Example_Models**: This class library contains the model classes that represent different types of users.

## Classes

### InheritancePart1Example_Models

- **User**: This is the base class representing a generic user. It contains properties for `Number`, `FirstName`, and `LastName`, and methods to display user data.
- **Teacher**: This class inherits from `User` and adds a `Salary` property.
- **Student**: This class inherits from `User` and adds a `HasScholarship` property.

### InheritancePart1Example_WPF

- **MainWindow**: This is the main window of the WPF application. It allows users to add different types of users (User, Teacher, Student) and display their information.

## Usage

1. **Run the WPF application**.
2. **Select the type of user** you want to add (User, Teacher, Student) using the radio buttons.
3. **Fill in the required information** in the text fields.
4. **Click the "Add" button** to add the user to the list.
5. **Click the "Show All" button** to display all added users.

## Example

1. **Adding a User**:
   - Select "User" radio button.
   - Enter the number, first name, and last name.
   - Click "Add".

2. **Adding a Teacher**:
   - Select "Teacher" radio button.
   - Enter the number, first name, last name, and salary.
   - Click "Add".

3. **Adding a Student**:
   - Select "Student" radio button.
   - Enter the number, first name, last name, and check the scholarship checkbox if applicable.
   - Click "Add".

4. **Displaying All Users**:
   - Click "Show All" to display all added users in the result label.

## Conclusion

This example demonstrates how to use inheritance in C# to create a flexible and extensible application. The WPF application provides a simple interface to interact with different types of users, showcasing the power of inheritance in object-oriented programming.
