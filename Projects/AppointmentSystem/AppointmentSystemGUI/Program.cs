using System;
using System.Collections.Generic;
using System.IO;

namespace AppointmentsSystem
{
    internal static class Program
    {
        public static Appointments AppointmentsOnFile;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Text file name and path
            string txtFilePath = "data.txt";

            ReadOrCreateTxtFile(txtFilePath);

            // Read or create data from text file
            AppointmentsOnFile = ReadOrCreateTxtFile(txtFilePath);

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            WriteToTxtFile(AppointmentsOnFile, txtFilePath);
        }

        // Function to read or create data from text file
        static Appointments ReadOrCreateTxtFile(string txtFilePath)
        {
            if (File.Exists(txtFilePath))
            {
                // Read data from text file
                List<Appointment> appointments = new List<Appointment>();
                string[] lines = File.ReadAllLines(txtFilePath);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    appointments.Add(new Appointment
                    {
                        Date = parts[0],
                        Clock = parts[1],
                        Name = parts[2],
                        Surname = parts[3],
                        TC = parts[4],
                        Gender = parts[5]
                    });
                }
                return new Appointments { Appointmentsss = appointments };
            }
            else
            {
                // Create a new appointments list if the text file doesn't exist
                return new Appointments { Appointmentsss = new List<Appointment>() };
            }
        }

        // Function to write appointments to the text file
        static void WriteToTxtFile(Appointments randevular, string txtFilePath)
        {
            // Convert appointments to text format and write to file
            List<string> lines = new List<string>();
            foreach (var appointment in randevular.Appointmentsss)
            {
                lines.Add($"{appointment.Date},{appointment.Clock},{appointment.Name},{appointment.Surname},{appointment.TC},{appointment.Gender}");
            }
            File.WriteAllLines(txtFilePath, lines);
        }
    }

    class Appointment
    {
        public string Date { get; set; }
        public string Clock { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string TC { get; set; }
        public string Gender { get; set; }
    }

    class Appointments
    {
        public List<Appointment> Appointmentsss { get; set; }
    }
}
