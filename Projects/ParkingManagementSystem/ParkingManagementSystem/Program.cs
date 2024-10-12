using System;

namespace ParkingManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ParkingLot parkingLot = new ParkingLot();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n--- Parking Management System ---");
                Console.WriteLine("1. Vehicle Entry");
                Console.WriteLine("2. Vehicle Exit");
                Console.WriteLine("3. Exit");
                Console.WriteLine("4. Parking Lot Status");
                Console.WriteLine("5. Find Vehicle by License Plate");
                Console.Write("Your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        parkingLot.VehicleEntry();
                        break;
                    case "2":
                        parkingLot.VehicleExit();
                        break;
                    case "3":
                        exit = true;
                        Console.WriteLine("Exiting the program...");
                        break;
                    case "4":
                        parkingLot.ParkingLotStatus();
                        break;
                    case "5":
                        parkingLot.FindVehicleByLicensePlate();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
