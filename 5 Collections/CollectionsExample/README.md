# Collections Example

This solution demonstrates the use of collections in a WPF application. It consists of two projects:

1. **CollectionsExample_WPF**: A WPF application that provides a user interface to interact with a list of numbers. Users can load, add, remove, sort, and clear numbers in the list. Additionally, users can read numbers from a file and display them in the UI.

2. **CollectionsExample_DAL**: A Data Access Layer (DAL) project that provides functionality to read numbers from a file.

## Projects

### CollectionsExample_WPF

This project is a WPF application targeting .NET Framework 4.8. It includes the following features:
- Load initial data into a list and display it in the UI.
- Add, remove, sort, and clear numbers in the list.
- Read numbers from a file and add them to the list.
- Display the selected number from the list.

#### Main Files
- `MainWindow.xaml`: Defines the UI layout.
- `MainWindow.xaml.cs`: Contains the logic for interacting with the list of numbers and updating the UI.

### CollectionsExample_DAL

This project is a class library targeting .NET Framework 4.8. It provides functionality to read numbers from a file.

#### Main Files
- `FileReader.cs`: Contains the method to read numbers from a file.

## Usage

- **Load**: Load initial data into the list and display it in the UI.
- **Add**: Add numbers to the list.
- **Remove**: Remove a number from the list.
- **Sort**: Sort the list.
- **Clear**: Clear the list.
- **Read from File**: Read numbers from a file and add them to the list.
- **Reset**: Reset the application to its initial state.
