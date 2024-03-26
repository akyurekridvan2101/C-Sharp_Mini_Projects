using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            // JSON file name and path
            string jsonFilePath = "data.json";

            // Read or create data from JSON file
            PhoneBook phoneBook = ReadOrCreateJsonFile(jsonFilePath);

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Phone Book Menu");
                Console.WriteLine("-----------------------");
                Console.WriteLine("1. Add Person");
                Console.WriteLine("2. Update Person");
                Console.WriteLine("3. Delete Person");
                Console.WriteLine("4. Show Phone Book");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice (1-5): ");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            AddPerson(phoneBook);
                            break;
                        case 2:
                            UpdatePerson(phoneBook);
                            break;
                        case 3:
                            DeletePerson(phoneBook);
                            break;
                        case 4:
                            ShowPhoneBook(phoneBook);
                            break;
                        case 5:
                            // Exit
                            WriteToJsonFile(phoneBook, jsonFilePath);
                            Console.WriteLine("Exiting the program.");
                            return;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }

        // Function to add a person
        static void AddPerson(PhoneBook phoneBook)
        {
            Console.Clear();
            Console.WriteLine("Add Person Menu");
            Console.WriteLine("----------------------");

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Surname: ");
            string surname = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            string phoneNumber = Console.ReadLine();

            // Create a new person object and add it to the phone book
            Person newPerson = new Person
            {
                Name = name,
                Surname = surname,
                PhoneNumber = phoneNumber
            };

            phoneBook.Persons.Add(newPerson);
            Console.WriteLine("New person added to the phone book.");
        }

        // Function to update a person
        static void UpdatePerson(PhoneBook phoneBook)
        {
            Console.Clear();
            Console.WriteLine("Update Person Menu");
            Console.WriteLine("----------------------");

            Console.Write("Enter the Name of the Person to Update: ");
            string name = Console.ReadLine();

            // Find the person to be updated
            Person personToUpdate = phoneBook.Persons.FirstOrDefault(p => p.Name == name);

            if (personToUpdate != null)
            {
                Console.Write("Enter New Surname: ");
                personToUpdate.Surname = Console.ReadLine();

                Console.Write("Enter New Phone Number: ");
                personToUpdate.PhoneNumber = Console.ReadLine();

                Console.WriteLine("Person updated.");
            }
            else
            {
                Console.WriteLine("Person not found.");
            }
        }

        // Function to delete a person
        static void DeletePerson(PhoneBook phoneBook)
        {
            Console.Clear();
            Console.WriteLine("Delete Person Menu");
            Console.WriteLine("----------------------");

            Console.Write("Enter the Name of the Person to Delete: ");
            string name = Console.ReadLine();

            // Find the person to be deleted
            Person personToDelete = phoneBook.Persons.FirstOrDefault(p => p.Name == name);

            if (personToDelete != null)
            {
                // Remove the person from the list
                phoneBook.Persons.Remove(personToDelete);
                Console.WriteLine("Person deleted.");
            }
            else
            {
                Console.WriteLine("Person not found.");
            }
        }

        // Function to show the phone book
        static void ShowPhoneBook(PhoneBook phoneBook)
        {
            Console.Clear();
            Console.WriteLine("Phone Book");
            Console.WriteLine("-----------------");

            // Print each person in the phone book
            foreach (var person in phoneBook.Persons)
            {
                Console.WriteLine($"Name: {person.Name}, Surname: {person.Surname}, Phone Number: {person.PhoneNumber}");
            }
        }

        // Function to read or create data from JSON file
        static PhoneBook ReadOrCreateJsonFile(string jsonFilePath)
        {
            if (File.Exists(jsonFilePath))
            {
                // Read data from JSON file
                string jsonData = File.ReadAllText(jsonFilePath);
                return JsonSerializer.Deserialize<PhoneBook>(jsonData);
            }
            else
            {
                // Create a new phone book if JSON file doesn't exist
                return new PhoneBook { Persons = new List<Person>() };
            }
        }

        // Function to convert phone book to JSON format and write to file
        static void WriteToJsonFile(PhoneBook phoneBook, string jsonFilePath)
        {
            // Convert phone book to JSON format and write to file
            string jsonData = JsonSerializer.Serialize(phoneBook);
            File.WriteAllText(jsonFilePath, jsonData);
        }
    }

    // Person class
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
    }

    // PhoneBook class
    class PhoneBook
    {
        public List<Person> Persons { get; set; }
    }
}
