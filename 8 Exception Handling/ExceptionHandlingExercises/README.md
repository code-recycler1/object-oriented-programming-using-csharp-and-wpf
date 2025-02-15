# Exception Handling Exercises

## Setup
- Create a project. The solution name must be:`ExceptionHandlingExercises`, the project name: `ExceptionHandlingExercises_WPF`.
- Update the MainWindow to navigate to the exercises.

### Design

![Setup Image 1](./Screenshots/Setup_1.png)

# Exercise 1 - Bank Account

## Objective
- Work with Class-Library and Classes.
- Work with inheritance.
- Work with Exceptions.

## Class Design
Start from the `Bank Account` exercise in Inheritance Part 3.

![Exercise 1 Image 1](./Screenshots/Exercise_1_Situation_1.png)

### Adjustments:
- Create a `CustomException` class that inherits from `Exception`.
- Throw a `CustomException` in the `Balance` property if the balance is less than the minimum.

## Design

![Exercise 1 Image 2](./Screenshots/Exercise_1_Situation_2.png)

## Procedure
- The following file must be read when the form loads:

```
bank account;BE 00 0000 1111 2222;-1000
bank account;BE 82 1796 3107 6768;1000
checking account;BE35 3630 8305 1137;500
savings account;BE27 2100 0000 2173;2487;2,1
```


A list of accounts is populated. Only valid records are added. The ComboBox is linked to the list. Use a DAL (Data Access Layer). Handle the necessary errors!

![Exercise 1 Image 3](./Screenshots/Exercise_1_Situation_3.png)

- Handle the necessary errors when withdrawing money.

Example of withdrawing from a `Bank Account`:

![Exercise 1 Image 4-1](./Screenshots/Exercise_1_Situation_4-1.png) ![Exercise 1 Image 4-2](./Screenshots/Exercise_1_Situation_4-2.png)

Example of withdrawing from a `Checking Account`:

![Exercise 1 Image 5-1](./Screenshots/Exercise_1_Situation_5-1.png) ![Exercise 1 Image 5-2](./Screenshots/Exercise_1_Situation_5-2.png)

---

# Exercise 2 - Customer

## Objective
- Work with Class-Library and Classes.
- Work with inheritance.

## Class Design
Create the following `Customer` class:

![Exercise 2 Image 1](./Screenshots/Exercise_2_Situation_1.png)

### Additional Information:
- Two customers are the same if their `customer number` is the same.

Create the following `CustomerNotFoundException` class. This class inherits from `Exception`.

### Additional Information:
- The message provided by the exception is: `The customer number 'CustomerNumber' does not exist.`

## Design

![Exercise 2 Image 2](./Screenshots/Exercise_2_Situation_2.png)

## Procedure
- When entering a number and clicking "Search", the program checks if this customer exists in a list. The result is displayed in a label. Any errors are handled!

  - Create a method `ReadFile` that populates a list of `Customer` objects based on a file. Errors are handled and logged using the `LogError` method.

![Exercise 2 Image 3](./Screenshots/Exercise_2_Situation_3.png)

  - Create a method `FindCustomerByNumber`. This method calls the `ReadFile` method and then iterates through the list to check if a customer with the specified number exists. If the customer does not exist, a `CustomerNotFoundException` is thrown. If the customer number is found, the customer object is returned.

Example of customer not found:

![Exercise 2 Image 4](./Screenshots/Exercise_2_Situation_4.png)

Example of customer found:

![Exercise 2 Image 5](./Screenshots/Exercise_2_Situation_5.png)