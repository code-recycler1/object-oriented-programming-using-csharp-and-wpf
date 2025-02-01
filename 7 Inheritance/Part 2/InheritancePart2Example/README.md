# Inheritance Part 2 Example

## Overview

This solution demonstrates the concept of inheritance in C# using a WPF application. The solution consists of two projects:

1. **InheritancePart2Example_WPF**: A WPF application that provides a user interface to interact with different types of users.
2. **InheritancePart2Example_Models**: A class library that contains the models representing different types of users.

## Projects

### InheritancePart2Example_WPF

This project is a WPF application targeting .NET Framework 4.8. It provides a graphical user interface to add and display different types of users, including general users, students, and teachers.

#### Key Features:
- Add users, students, and teachers.
- Display user information.
- Different controls for different user types (e.g., scholarship for students, salary for teachers).

### InheritancePart2Example_Models

This project is a class library targeting .NET Framework 4.8. It contains the models representing different types of users.

#### Key Classes:
- **User**: The base class representing a general user.
- **Student**: A derived class representing a student, which includes a scholarship status.
- **Teacher**: A derived class representing a teacher, which includes a salary.

## Usage

1. Select the type of user you want to add (User, Student, or Teacher).
2. Fill in the required fields.
3. Click the "Add" button to add the user to the list.
4. The user information will be displayed, and the list of users will be updated.
