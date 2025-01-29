# Collections Exercises

## Setup
- Create a project. The solution name must be:`CollectionsExercises`, the project name: `CollectionsExercises_WPF`.
- Update the MainWindow to navigate to the exercises.

### Design

![Setup Image 1](./Screenshots/Setup_1.png)

---

## Exercise 1 - Animals

### Objective
- Working with Lists
- Working with Listboxes

### Design

![Exercise 1 Image 1](./Screenshots/Exercise_1_Situation_1.png)

### Procedure

- When the "Read and Print" button is pressed, the file `animals.txt` is read into a list. This list is then linked to the listbox.

![Exercise 1 Image 2](./Screenshots/Exercise_1_Situation_2.png)

- When the "Add" button is pressed, the new animal is added to the list. Display an appropriate message if the text field is empty. Duplicate animals are not allowed!

![Exercise 1 Image 3](./Screenshots/Exercise_1_Situation_3.png)

![Exercise 1 Image 4](./Screenshots/Exercise_1_Situation_4.png)  

![Exercise 1 Image 5-1](./Screenshots/Exercise_1_Situation_5-1.png) ![Exercise 1 Image 5-2](./Screenshots/Exercise_1_Situation_5-2.png)

- When the "Clear" button is pressed, the list is emptied. The listbox is updated accordingly!

![Exercise 1 Image 6](./Screenshots/Exercise_1_Situation_6.png)

- When the "Delete" button is pressed, the selected item is removed from the list. The listbox is updated accordingly!

![Exercise 1 Image 7-1](./Screenshots/Exercise_1_Situation_7-1.png) ![Exercise 1 Image 7-2](./Screenshots/Exercise_1_Situation_7-2.png)

- When the "Sort" button is pressed, the list is sorted. The listbox is updated accordingly!

---

## Exercise 2 - Most Popular Prime Minister Since 1973

### Objective
- Working with ComboBox
- Working with Global Variables

### Windows Application
A survey is conducted to determine the most popular prime minister since 1973.

![Exercise 2 Image 1](./Screenshots/Exercise_2_Situation_1.png)

### Procedure

- When the form is loaded, the file `ministers.txt` is read into a list. This list is linked to the combobox.

![Exercise 2 Image 2](./Screenshots/Exercise_2_Situation_2.png)

- For each minister, keep track of the number of votes they have received. Create a list of integers with as many elements as there are ministers.

- The number of votes for a minister is incremented by 1 after selecting a minister from the dropdown and pressing the "Vote" button. Display an error message if no minister is selected.

![Exercise 2 Image 3](./Screenshots/Exercise_2_Situation_3.png)

- The results with the number of votes are displayed after pressing the "Results" button.

![Exercise 2 Image 4](./Screenshots/Exercise_2_Situation_4.png)

---

## Exercise 3 - Students with Results

### Objective
- Working with Lists
- Working with Listboxes

### Design

![Exercise 3 Image 1](./Screenshots/Exercise_3_Situation_1.png)

### Procedure

- When the "Read Students and Print" button is pressed, the file `students.txt` is read into a list. This list is displayed in the listbox.

![Exercise 3 Image 2](./Screenshots/Exercise_3_Situation_2.png)

- When the "Read Grades and Print" button is pressed, the file `grades.txt` is read into a list. This list is also displayed in the listbox.

![Exercise 3 Image 3](./Screenshots/Exercise_3_Situation_3.png)

- When the "Determine Results and Print" button is pressed, a combination of the student, their grade, and the achieved result is created. The number of passing and failing students is also tracked. This list is displayed in the listbox.

![Exercise 3 Image 4](./Screenshots/Exercise_3_Situation_4.png)

- When the "Clear" button is pressed, all lists are emptied.

- When the "Close" button is pressed, the application is closed.