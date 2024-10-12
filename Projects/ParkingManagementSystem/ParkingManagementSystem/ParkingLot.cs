namespace ParkingManagementSystem
{
    internal class ParkingLot
    {
        int[] parkingOccupancy;
        int numberOfCarsInParkingLot = 0;
        Vehicle lastEnteredVehicle;
        Vehicle head;

        List<Vehicle> vehicleHistory;

        public ParkingLot()
        {
            this.parkingOccupancy = new int[40]; // There are 40 spots available.
            this.vehicleHistory = new List<Vehicle>(); // Each time a vehicle exits, it's added to this list.
        }

        public void VehicleEntry()
        {
            if (numberOfCarsInParkingLot == 40)
            {
                Console.WriteLine("Unfortunately, there are no available spots in the parking lot...");
                return;
            }
            else
            {
                Vehicle newVehicle = null;

                for (int i = 0; i < parkingOccupancy.Length; i++)
                    if (parkingOccupancy[i] == 0) // When an empty spot is found, begin vehicle entry.
                    {
                        Console.Write("License Plate: ");
                        string licensePlate = Console.ReadLine();
                        Console.Write("Brand: ");
                        string brand = Console.ReadLine();
                        Console.Write("Model: ");
                        string model = Console.ReadLine();

                        newVehicle = new Vehicle(licensePlate, brand, model, i + 1);
                        parkingOccupancy[i] = 1; // This spot becomes occupied.

                        if (lastEnteredVehicle != null)
                            lastEnteredVehicle.Next = newVehicle;
                        else
                            head = newVehicle;

                        lastEnteredVehicle = newVehicle;
                        numberOfCarsInParkingLot++;
                        Console.WriteLine("Vehicle entered. Parking number: " + (i + 1));
                        break;
                    }
            }
        }

        public void VehicleExit()
        {
            Console.Write("Enter the license plate of the exiting vehicle: ");
            string licensePlate = Console.ReadLine();

            Vehicle previousVehicle = null;
            Vehicle currentVehicle = head;

            while (currentVehicle != null)
            {
                if (currentVehicle.licensePlate == licensePlate)
                {
                    // Vehicle found
                    double debt = CalculateParkingFee(currentVehicle.entryTime);

                    if (debt == (double)0)
                    {
                        Console.BackgroundColor = ConsoleColor.Green; // NO DEBT
                        Console.WriteLine("You have no debt");
                        Console.ResetColor();

                        parkingOccupancy[currentVehicle.parkingSpotNumber - 1] = 0; // Free up the parking space.
                        currentVehicle.exitTime = DateTime.Now;
                        vehicleHistory.Add(currentVehicle); // Add the exiting vehicle to history.
                        numberOfCarsInParkingLot--;
                    }
                    else
                    {
                        Console.WriteLine($"Your debt: ");

                        Console.BackgroundColor = ConsoleColor.Red; // DEBT EXISTS
                        Console.Write($"{debt} TL\n");
                        Console.ResetColor();

                        while (true)
                        {
                            Console.Write("If you have collected the fee from the vehicle owner, type \"confirm\" to complete the exit process, or type \"cancel\" to abort: ");
                            string confirmation = Console.ReadLine();

                            if (confirmation.ToLower() == "confirm")
                            {
                                parkingOccupancy[currentVehicle.parkingSpotNumber - 1] = 0; // Free up the parking space.
                                currentVehicle.exitTime = DateTime.Now;
                                vehicleHistory.Add(currentVehicle); // Add the exiting vehicle to history.
                                numberOfCarsInParkingLot--;
                                break;
                            }
                            else if (confirmation.ToLower() == "cancel")
                            {
                                Console.WriteLine("Operation cancelled...");
                                return;
                            }
                            else
                                Console.WriteLine("Invalid input, please try again...");
                        }
                    }

                    Console.WriteLine(currentVehicle.licensePlate + " has exited...");

                    if (previousVehicle == null)
                        head = currentVehicle.Next; // If the vehicle to be removed is the first vehicle (Head), change Head.
                    else
                        previousVehicle.Next = currentVehicle.Next; // If it's in the middle or at the end, merge the list.

                    return;
                }
                previousVehicle = currentVehicle;
                currentVehicle = currentVehicle.Next;
            }

            if (currentVehicle == null)
                Console.WriteLine("Vehicle not found.");
        }

        public double CalculateParkingFee(DateTime entryTime)
        {
            DateTime exitTime = DateTime.Now;

            // Fee rules
            int freeHours = 2;                // First 2 hours are free
            double hourlyRate = 30.0;         // 30 TL for each additional hour
            double maximumDailyRate = 200.0;  // Maximum fee for 24 hours

            // Calculate parking duration
            TimeSpan parkingDuration = exitTime - entryTime;
            double totalHours = parkingDuration.TotalHours;

            // Calculate number of full days
            int dayCount = (int)parkingDuration.TotalDays;
            double totalFee = 0;

            // Calculate fee for full days
            for (int i = 0; i < dayCount; i++)
            {
                totalFee += maximumDailyRate; // Apply maximum fee for each full day
            }

            // Calculate remaining hours
            double remainingHours = totalHours - (dayCount * 24);

            // Calculate fee for the last day (if applicable)
            if (remainingHours > freeHours)
            {
                double lastDayFee = (remainingHours - freeHours) * hourlyRate;

                // If the last day's fee exceeds the maximum, apply the maximum fee
                if (lastDayFee > maximumDailyRate)
                {
                    lastDayFee = maximumDailyRate;
                }

                totalFee += lastDayFee;
            }

            return totalFee;
        }

        public void ParkingLotStatus()
        {
            Console.WriteLine("\n--- Parking Lot Status ---");
            int emptySpotCount = 0;
            int occupiedSpotCount = 0;

            for (int i = 0; i < parkingOccupancy.Length; i++)
            {
                if (parkingOccupancy[i] == 0)
                {
                    Console.BackgroundColor = ConsoleColor.Green; // Green for empty spots
                    Console.Write($"{(i + 1 < 10 ? $"0{i + 1}" : $"{i + 1}")}");
                    emptySpotCount++;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red; // Red for occupied spots
                    Console.Write($"{(i + 1 < 10 ? $"0{i + 1}" : $"{i + 1}")}");
                    occupiedSpotCount++;
                }
                Console.ResetColor(); // Reset colors to prevent affecting other outputs
                Console.Write(" ");

                if ((i + 1) % 10 == 0) // Move to a new line after every 10 spots
                    Console.Write("\n\n");
            }

            Console.WriteLine("\nTotal occupied spots: {0}", occupiedSpotCount);
            Console.WriteLine("Total empty spots: {0}\n", emptySpotCount);
        }

        public void FindVehicleByLicensePlate()
        {
            Console.Write("Enter license plate: ");
            string licensePlate = Console.ReadLine();
            Vehicle currentVehicle = head;

            while (currentVehicle != null)
            {
                if (currentVehicle.licensePlate == licensePlate)
                {
                    Console.WriteLine("Vehicle found! Parking number: " + currentVehicle.parkingSpotNumber);
                    return;
                }
                currentVehicle = currentVehicle.Next;
            }

            Console.WriteLine("Vehicle not found.");
        }

    }
}