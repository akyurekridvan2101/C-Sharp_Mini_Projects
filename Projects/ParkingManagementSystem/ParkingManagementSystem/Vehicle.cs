using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagementSystem
{
    internal class Vehicle
    {
        public string licensePlate, brand, model;
        public DateTime entryTime, exitTime;
        public int parkingSpotNumber;

        public Vehicle Next; // Holds reference to the next vehicle.

        public Vehicle(string licensePlate, string brand, string model, int parkingSpotNumber)
        {
            this.licensePlate = licensePlate;
            this.brand = brand;
            this.model = model;
            this.parkingSpotNumber = parkingSpotNumber;

            entryTime = DateTime.Now; // Registers the vehicle entry time as the current time.
        }
    }
}
