# Inheritance Part 3 Exercises

## Setup
- Create a project. The solution name must be:`InheritancePart3Exercises`, the project name: `InheritancePart3Exercises_WPF`.
- Update the MainWindow to navigate to the exercises.

### Design

![Setup Image 1](./Screenshots/Setup_1.png)

---

# Exercise 1 - Bank Account

## Objective
- Work with Class-Library and Classes.
- Work with inheritance.

## Class Design

Start from the exercise `Bank Account` from Inheritance Part 2.

![Exercise 1 Image 1](./Screenshots/Exercise_1_Situation_1.png)

### Adjustments:
- Rename the `ShowData` method in the `BankAccount` and `SavingsAccount` classes to `ToString()`.
- Add a `ToString()` method to the `CheckingAccount` class. The return value is a textual representation of the object:
IBAN: `IBAN` with balance: `Balance` (Minimum: `Minimum`)
- Add the `Equals` method to the `BankAccount` class: Two accounts are the same if their IBAN numbers are the same, regardless of whether they are `BankAccount`, `SavingsAccount`, or `CheckingAccount`.

## Design

![Exercise 1 Image 2](./Screenshots/Exercise_1_Situation_2.png)

## Procedure
- Ensure that the `DisplayMemberPath` of the ComboBox is no longer set. This way, the `ToString()` method is implicitly used.

- When the form loads, the file `bankAccounts.txt` is read. This populates a list of accounts. The ComboBox is linked to the list. Use a DAL (Data Access Layer). (Refer to Inheritance 2 exercise.)

![Exercise 1 Image 3](./Screenshots/Exercise_1_Situation_3.png)

- Verify that the `ToString()` method is successfully used.

- When the "Add Account" button is clicked, an account of the desired type is created with the entered IBAN number. The created account can only be added to the list if it does not already exist in the list. If the IBAN number is already added or not filled in, an error message is displayed.

Example of a new account number:

![Exercise 1 Image 4](./Screenshots/Exercise_1_Situation_4.png)

Example of an existing account number: The account object with the IBAN number cannot be added because a savings account with this IBAN number already exists.

![Exercise 1 Image 5-1](./Screenshots/Exercise_1_Situation_5-1.png) ![Exercise 1 Image 5-2](./Screenshots/Exercise_1_Situation_5-2.png)

Example of an empty IBAN number:

![Exercise 1 Image 6-1](./Screenshots/Exercise_1_Situation_6-1.png) ![Exercise 1 Image 6-2](./Screenshots/Exercise_1_Situation_6-2.png)

---

# Exercise 2 - Animals

## Objective
- Work with Class-Library and Classes.
- Work with inheritance.

## Class Design

Start from the exercise `Animals` from Inheritance Part 2.

![Exercise 2 Image 1](./Screenshots/Exercise_2_Situation_1.png)

### Adjustments:
- Add a `ToString()` method. This method calls the `Data` property.
- Add the `Equals` method to the `Animal` class: Two objects are the same if their name and type are the same!

## Design

![Exercise 2 Image 2](./Screenshots/Exercise_2_Situation_2.png)

## Procedure
- Test the `ToString()` method by commenting out the `DisplayMemberPath`!
- Test the `Equals` method by adding two identical objects to the list.
- A parrot, cat, or human with the same name is allowed.

- ![Exercise 2 Image 3](./Screenshots/Exercise_2_Situation_3.png)

---

# Exercise 3 - Cylinder

## Objective
- Work with Class-Library and Classes.
- Work with inheritance.

## Class Design

![Exercise 3 Image 1](./Screenshots/Exercise_3_Situation_1.png)

### Adjustments:
- Rename the `ShowData` method in the `Point`, `Circle`, and `Cylinder` classes to `ToString()`.
- Add the `Equals` method to the `Point` class: Two points are the same if their `x` and `y` values are the same and their types are the same.
- Add the `Equals` method to the `Circle` class: Two circles are the same if their `x`, `y`, and `r` values are the same and their types are the same (calls the `Equals` method of the `Point` class).
- Add the `Equals` method to the `Cylinder` class: Two cylinders are the same if their `x`, `y`, `r`, and `h` values are the same and their types are the same (calls the `Equals` method of the `Circle` class).

## Design

![Exercise 3 Image 2](./Screenshots/Exercise_3_Situation_2.png)

## Procedure
- Test the `ToString()` method by not setting the `DisplayMember` of the ListBox. You should still see the correct description.

![Exercise 3 Image 3](./Screenshots/Exercise_3_Situation_3.png)

- Test the `Equals` method by adding two identical points, circles, or cylinders to the list of cylinders. The object can only be added if the list does not already contain it!

![Exercise 3 Image 4-1](./Screenshots/Exercise_3_Situation_4.png)

- Also test whether you can add a `Point` and a `Circle` with the same `x` and `y` values. This should work!