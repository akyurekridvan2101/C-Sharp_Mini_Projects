https://github.com/akyurekridvan2101/CSharpMiniProjects/assets/98421577/1b1dcd99-63a6-4be5-97f7-aed1e2140a13

# **Phone Book Application**

This is a simple console-based phone book application implemented in C#. Users can add, update, delete, and display contacts in the phone book.

## **Usage**

### **1. Getting Started**

- **JSON File:** The application uses a JSON file named **`data.json`** to store data. This file allows the application to read and write existing phone book data every time it starts.

### **2. Menu**

The application presents the user with a menu containing the following options:

- **1. Add Person:** Use this option to add a new person.
- **2. Update Person:** Use this option to update an existing person.
- **3. Delete Person:** Use this option to delete an existing person.
- **4. Show Phone Book:** List all persons in the phone book.
- **5. Exit:** Exit the application and save current phone book data to the JSON file.

### **3. Operations**

### 3.1. Adding a Person

- **Name, Surname, and Phone Number:** When adding a new person, the user is prompted to enter the name, surname, and phone number.
- **Phone Book Update:** The new person is added to the phone book, and a message "New person added to the phone book." is displayed.

### 3.2. Updating a Person

- **Selecting Person to Update:** The user is asked to enter the name of the person to update.
- **Entering New Information:** The user is prompted to enter the new surname and phone number.
- **Phone Book Update:** The person is updated, and a message "Person updated." is displayed.

### 3.3. Deleting a Person

- **Selecting Person to Delete:** The user is asked to enter the name of the person to delete.
- **Phone Book Update:** The person is removed from the phone book, and a message "Person deleted." is displayed.

### 3.4. Showing the Phone Book

- **Listed in Alphabetical Order:** All persons in the phone book are displayed in alphabetical order.

### **4. Exiting**

When exiting the application, the current phone book data is saved to the **`data.json`** file.

## **Code Structure**

The application is written in C# programming language and includes the following main classes:

- **Program:** Contains the user interface and basic functionality.
- **Person:** Represents a person.
- **PhoneBook:** Manages persons in a list.