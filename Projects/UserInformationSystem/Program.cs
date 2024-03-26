using System;

namespace ConsoleApp_Core
{
    class Program
    {
        // Static variables are defined to store user information since they are class members and are assigned default values by the compiler.
        static string firstName;
        static string lastName;
        static string phoneNumber;
        static string gender;
        static DateTime birthDate;

        static void Main()
        {
            Console.Title = "User Information System";

            // Call the function to get user information.
            GetUserInformation();

            int daysPerWeekForGender = (gender == "male") ? 8 : 5;
            int weeksPerMonth = IsEighteenYearsOld(birthDate) ? 5 : 6;
            int daysUntilAppointment = GetDaysUntilAppointment();

            // Call the Print function to display the information on the screen.
            Print(daysPerWeekForGender, weeksPerMonth, daysUntilAppointment);
            Console.ReadKey();
        }

        // Function to get user information.
        static void GetUserInformation()
        {
            Console.WriteLine("=== User Information Entry ===");

            // Prompt the user to input first name, last name, phone number, gender, and birth date.
            Console.Write("First Name: ");
            firstName = Console.ReadLine();

            Console.Write("Last Name: ");
            lastName = Console.ReadLine();

            Console.Write("Phone Number: ");
            phoneNumber = Console.ReadLine();

            // Loop until a valid gender is entered.
            while (true)
            {
                Console.Write("Gender (male/female): ");
                gender = Console.ReadLine().ToLower();

                if (gender == "male" || gender == "female")
                    break;
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter your gender as male or female...");
                    Console.ResetColor();
                }
            }

            // Check for invalid input while entering the birth date and loop until a valid date is entered.
            while (true)
            {
                try
                {
                    Console.Write("Enter your date of birth (YYYY-MM-DD): ");
                    birthDate = Convert.ToDateTime(Console.ReadLine());

                    // Birth date should be less than or equal to today's date.
                    if (birthDate <= DateTime.Now)
                        break;
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You entered an invalid birth date. The birth date cannot be greater than the current date...");
                        Console.ResetColor();
                    }
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter the birth date correctly (YYYY-MM-DD)...");
                    Console.ResetColor();
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("An unexpected error occurred. Error message => " + ex.Message);
                    Console.ResetColor();
                }
            }
        }

        // Function to calculate the number of days until the appointment.
        static int GetDaysUntilAppointment()
        {
            Console.WriteLine("=== Appointment Information ===");

            // Loop until the user inputs a numeric value for the number of days until the appointment.
            while (true)
            {
                try
                {
                    Console.Write("How many days until your appointment: ");
                    return Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter a numerical value...");
                    Console.ResetColor();
                    continue;
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("An unexpected error occurred. Error message => " + ex.Message);
                    Console.ResetColor();
                    continue;
                }
            }
        }

        // Function to check if the user is 18 years old or older.
        static bool IsEighteenYearsOld(DateTime birthDate)
        {
            DateTime currentDate = DateTime.Now;

            TimeSpan difference = currentDate - birthDate;

            return difference.TotalDays >= (18 * 365 - 30);
        }

        // Function to print the information on the screen.
        static void Print(int daysPerWeekForGender, int weeksPerMonth, int daysUntilAppointment)
        {
            Console.Clear();
            int monthsToAdd = daysUntilAppointment / (daysPerWeekForGender * weeksPerMonth);
            int weeksToAdd = (daysUntilAppointment - (monthsToAdd * daysPerWeekForGender * weeksPerMonth)) / daysPerWeekForGender;
            int daysToAdd = daysUntilAppointment - (monthsToAdd * daysPerWeekForGender * weeksPerMonth) - (weeksToAdd * daysPerWeekForGender);

            // Calculate the appointment date and print it to the screen.
            DateTime appointmentDate = DateTime.Now.AddMonths(monthsToAdd);
            appointmentDate = appointmentDate.AddDays(weeksToAdd * 7);
            appointmentDate = appointmentDate.AddDays(daysToAdd);
            string genderText = (gender == "male") ? "Mr." : "Ms.";

            Console.WriteLine($@"
=== User Information ===
First Name: {firstName}
Last Name: {lastName}
Phone Number: {phoneNumber}
Gender: {gender}
Date of Birth: {birthDate:yyyy-MM-dd}

=== Appointment Information ===
Dear {genderText} {lastName}, you are {DateTime.Now.Year - birthDate.Year} years old, and you have an appointment on {appointmentDate:yyyy-MM-dd}.");
        }
    }
}
