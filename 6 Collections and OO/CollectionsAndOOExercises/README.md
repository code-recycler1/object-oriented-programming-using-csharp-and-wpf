# Collections and OO Exercises

## Setup
- Create a project. The solution name must be:`CollectionsAndOOExercises`, the project name: `CollectionsAndOOExercises_WPF`.
- Update the MainWindow to navigate to the exercises.

### Design

![Setup Image 1](./Screenshots/Setup_1.png)

---

## Exercise 1 - TV Channel

### Objective
- Work with List and ComboBox.
- Work with Class-Library and Classes.

### Class Design
On a TV remote control, there are numbers corresponding to TV channels:
1. BBC1
2. BBC2
3. ITV
4. Channel 4
5. Channel 5

Create a class that represents a `TelevisionChannel` . A class-library is used.

![Exercise 1 Image 1](./Screenshots/Exercise_1_Situation_1.png)

#### Additional Information:
- Method `ToString()`: The return value is a textual representation of the object:

*Number - Description*

Example: 1 - BBC1


## Design

![Exercise 1 Image 2](./Screenshots/Exercise_1_Situation_2.png)

## Procedure
- When the form loads, a list is populated with `TelevisionChannel` objects. This list is linked to the ComboBox.

![Exercise 1 Image 3](./Screenshots/Exercise_1_Situation_3.png)

- When you select a channel in the ComboBox, the channel number appears in the label.

![Exercise 1 Image 4](./Screenshots/Exercise_1_Situation_4.png)

---

## Exercise 2 - Trainee

### Objective
- Work with Button and Label.
- Work with Class-Library and Classes.
- Validations.

### Class Design
We create the following class `Trainee`.

![Exercise 2 Image 1](./Screenshots/Exercise_2_Situation_1.png)

#### Additional Information:
- Property `Name` : Represents the full name of the trainee.

### Design

![Exercise 2 Image 2](./Screenshots/Exercise_2_Situation_2.png)

### Procedure
- When the form loads, a list is populated with `Trainee` objects. This list is linked to a ListBox.

![Exercise 2 Image 3](./Screenshots/Exercise_2_Situation_3.png)

- When a trainee is selected from the ListBox, the text boxes are populated.

![Exercise 2 Image 4](./Screenshots/Exercise_2_Situation_4.png)

- After selecting, you can modify the data and apply the changes by clicking "Update". After modifying, the text fields are cleared.

![Exercise 2 Image 5-1](./Screenshots/Exercise_2_Situation_5-1.png)  
![Exercise 2 Image 5-2](./Screenshots/Exercise_2_Situation_5-2.png)

- When the "Delete" button is clicked, the selected item is removed from the list.

![Exercise 2 Image 6](./Screenshots/Exercise_2_Situation_6.png)

The trainee is only deleted after confirmation.

![Exercise 2 Image 6-1](./Screenshots/Exercise_2_Situation_6-1.png)  
![Exercise 2 Image 6-2](./Screenshots/Exercise_2_Situation_6-2.png)

- You can also add a trainee to the list. First, a validation is performed on the text fields! Ensure the ListBox stays up-to-date!

![Exercise 2 Image 7](./Screenshots/Exercise_2_Situation_7.png)  
![Exercise 2 Image 8](./Screenshots/Exercise_2_Situation_8.png)  
![Exercise 2 Image 9](./Screenshots/Exercise_2_Situation_9.png)  

---

## Exercise 3 - Shopping Cart

### Objective
- Work with TextBox, Label, and Button.
- Work with Class-Library, Classes, and List.
- Validations.

### Class Design
We create a class `ShoppingCartItem` with the following UML schema.

![Exercise 3 Image 1](./Screenshots/Exercise_3_Situation_1.png)

#### Additional Information:
- Property `TotalPrice` is calculated as: `quantity * price`.
- Method `FormattedTotalPrice`: Returns the total price as a string with 2 decimal places.
- Method `ToString`: Provides a textual representation:

*Quantity * Name: TotalPrice*

Example: ![Exercise 3 Image 2](./Screenshots/Exercise_3_Situation_2.png)

- A class-library is used.

### Design

![Exercise 3 Image 3](./Screenshots/Exercise_3_Situation_3.png)

### Procedure
- When the "Add" button is clicked, a `ShoppingCartItem` is created and added to the list after the necessary checks! Ensure the 3 text boxes are filled and that the price and quantity are numeric.

![Exercise 3 Image 4](./Screenshots/Exercise_3_Situation_4.png)

- When the "Show Shopping Cart" button is clicked, the contents are summarized, and the total amount of the shopping cart is displayed. Use the correct method to display the `ShoppingCartItem`!

![Exercise 3 Image 5](./Screenshots/Exercise_3_Situation_5.png)