using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AppointmentsSystem
{
    public partial class Form1 : Form
    {
        AppointmentsForm appointmentsForm; // Form used to display appointments

        // Array to hold button colors
        private Color[,] buttonColors = new Color[8, 8];

        // Last selected button
        private Button lastSelectedButton;

        // Selected time
        string clock;

        // Appointment date
        public string appointmentDate { get; set; }

        // Constructor of Form1
        public Form1()
        {
            InitializeComponent();
        }

        // Actions to be performed when the form is loaded
        private void Form1_Load(object sender, EventArgs e)
        {
            // Add dates to the history selection box
            AppointmentDate.Items.Add(Convert.ToDateTime(DateTime.Now.AddDays(0)));
            AppointmentDate.Items.Add(Convert.ToDateTime(DateTime.Now.AddDays(1)));
            AppointmentDate.Items.Add(Convert.ToDateTime(DateTime.Now.AddDays(2)));
            AppointmentDate.Items.Add(Convert.ToDateTime(DateTime.Now.AddDays(3)));
            AppointmentDate.Items.Add(Convert.ToDateTime(DateTime.Now.AddDays(4)));
            AppointmentDate.Items.Add(Convert.ToDateTime(DateTime.Now.AddDays(5)));
            AppointmentDate.Items.Add(Convert.ToDateTime(DateTime.Now.AddDays(6)));
            AppointmentDate.Items.Add(Convert.ToDateTime(DateTime.Now.AddDays(7)));

            // Check appointments with past dates
            List<Appointment> toBeDeleted = new List<Appointment>();
            foreach (Appointment appointment in Program.AppointmentsOnFile.Appointmentsss)
            {
                if (Convert.ToDateTime(appointment?.Date) >= DateTime.Today)
                {
                    int whichDay = Convert.ToInt32((Convert.ToDateTime(appointment.Date) - DateTime.Today).TotalDays) - 1;
                    switch (appointment.Clock)
                    {
                        case "08.30 - 09.15":
                            buttonColors[whichDay, 0] = Color.Red;
                            break;
                        case "09.30 - 10.15":
                            buttonColors[whichDay, 1] = Color.Red;
                            break;
                        case "10.30 - 11.15":
                            buttonColors[whichDay, 2] = Color.Red;
                            break;
                        case "11.30 - 12.15":
                            buttonColors[whichDay, 3] = Color.Red;
                            break;
                        case "13.30 - 14.15":
                            buttonColors[whichDay, 4] = Color.Red;
                            break;
                        case "14.30 - 15.15":
                            buttonColors[whichDay, 5] = Color.Red;
                            break;
                        case "15.30 - 16.15":
                            buttonColors[whichDay, 6] = Color.Red;
                            break;
                        case "16.30 - 17.15":
                            buttonColors[whichDay, 7] = Color.Red;
                            break;
                    }
                }
                else
                {
                    // Delete appointments with past dates
                    toBeDeleted.Add(appointment);
                }
            }

            // Remove appointments with past dates from JSON
            foreach (Appointment appointment in toBeDeleted)
            {
                Program.AppointmentsOnFile.Appointmentsss.Remove(appointment);
            }

        }

        // Actions to be performed when the "Get Appointment" button is clicked
        private void GetAppointment_Click(object sender, EventArgs e)
        {
            // If the last selected button color is red (already selected), do nothing
            if (lastSelectedButton?.BackColor == Color.Red)
                return;

            // If the last selected button is null (no time selected yet), show a warning and do nothing
            if (lastSelectedButton == null)
            {
                MessageBox.Show("Please select a time...");
                return;
            }

            // Check if all required fields are filled
            if (FirstName.Text == "" || Surname.Text == "" || TC.Text == "" || AppointmentDate.Text == "" || Gender.Text == "")
            {
                MessageBox.Show("Please make sure all fields are filled...");
                return;
            }

            // Set the selected button color to red (indicating it's filled)
            lastSelectedButton.BackColor = Color.Red;

            // Calculate the selected date and time
            int whichDay = Convert.ToInt32((Convert.ToDateTime(AppointmentDate.Text) - DateTime.Today).TotalDays) - 1;
            switch (lastSelectedButton.Text)
            {
                case "08.30 - 09.15":
                    buttonColors[whichDay, 0] = Color.Red;
                    break;
                case "09.30 - 10.15":
                    buttonColors[whichDay, 1] = Color.Red;
                    break;
                case "10.30 - 11.15":
                    buttonColors[whichDay, 2] = Color.Red;
                    break;
                case "11.30 - 12.15":
                    buttonColors[whichDay, 3] = Color.Red;
                    break;
                case "13.30 - 14.15":
                    buttonColors[whichDay, 4] = Color.Red;
                    break;
                case "14.30 - 15.15":
                    buttonColors[whichDay, 5] = Color.Red;
                    break;
                case "15.30 - 16.15":
                    buttonColors[whichDay, 6] = Color.Red;
                    break;
                case "16.30 - 17.15":
                    buttonColors[whichDay, 7] = Color.Red;
                    break;
            }

            // Create a new item for the ListView
            ListViewItem lvi;
            string[] information = { AppointmentDate.Text, this.clock, FirstName.Text, Surname.Text, TC.Text, Gender.Text };
            lvi = new ListViewItem(information);

            // If appointmentsForm is null, create a new appointmentsForm and add the item
            if (appointmentsForm == null)
            {
                appointmentsForm = new AppointmentsForm();
                appointmentsForm.AppointmentListView.Items.Add(lvi);
            }
            else
            {
                // If appointmentsForm is not null, only create a new appointmentsForm (adding items will be done below)
                appointmentsForm = new AppointmentsForm();
            }

            // Create a new appointment and add it to JSON
            Appointment appointment = new Appointment
            {
                Name = FirstName.Text,
                Surname = Surname.Text,
                TC = TC.Text,
                Gender = Gender.Text,
                Date = AppointmentDate.Text,
                Clock = this.clock
            };
            Program.AppointmentsOnFile.Appointmentsss.Add(appointment);
        }

        // Actions to be performed when the "Show Appointments" button is clicked
        private void ShowAppointments_Click(object sender, EventArgs e)
        {
            // Create the form to display appointments
            appointmentsForm = new AppointmentsForm();

            // Clear the ListView
            appointmentsForm.AppointmentListView.Items.Clear();

            // Add appointments from JSON to the ListView
            foreach (Appointment appointment in Program.AppointmentsOnFile.Appointmentsss)
            {
                ListViewItem lvi;
                string[] info = { appointment.Name, appointment.Surname, appointment.TC, appointment.Gender, appointment.Date, appointment.Clock };
                lvi = new ListViewItem(info);
                appointmentsForm.AppointmentListView.Items.Add(lvi);
            }

            // Show the form to display appointments
            appointmentsForm.Show();
        }

        // Actions to be performed when the selection of the history ComboBox changes
        private void AppointmentDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            // If the last selected button color is green (previously selected), change it to white and set lastSelectedButton to null
            if (lastSelectedButton?.BackColor == Color.Green)
            {
                lastSelectedButton.BackColor = Color.White;
                lastSelectedButton = null;
            }

            // Set button colors based on the selected date
            int date = Convert.ToInt32((Convert.ToDateTime(AppointmentDate.Text) - DateTime.Today).TotalDays) - 1;
            AssignColors(date);
        }

        // Assign button colors
        private void AssignColors(int history)
        {
            One.BackColor = this.buttonColors[history, 0];
            Two.BackColor = this.buttonColors[history, 1];
            Three.BackColor = this.buttonColors[history, 2];
            Four.BackColor = this.buttonColors[history, 3];
            Five.BackColor = this.buttonColors[history, 4];
            Six.BackColor = this.buttonColors[history, 5];
            Seven.BackColor = this.buttonColors[history, 6];
            Eight.BackColor = this.buttonColors[history, 7];
        }

        // Calculate the nearest date
        private string NearestDate()
        {
            for (int i = 0; i <= 7; i++)
            {
                for (int j = 0; j <= 7; j++)
                {
                    if (buttonColors[i, j] != Color.Red)
                    {
                        DateTime history = DateTime.Now.AddDays(i);
                        string timeInterval = j == 0 ? "08.30 - 09.15" :
                                             j == 1 ? "09.30 - 10.15" :
                                             j == 2 ? "10.30 - 11.15" :
                                             j == 3 ? "11.30 - 12.15" :
                                             j == 4 ? "13.30 - 14.15" :
                                             j == 5 ? "14.30 - 15.15" :
                                             j == 6 ? "15.30 - 16.15" :
                                                      "16.30 - 17.15";
                        return "The nearest appointment is on " + history.ToShortDateString() + " at " + timeInterval + ".";
                    }
                }
            }
            return null;
        }

        // Actions to be performed when a time button is clicked
        private void OnTimeButtonClick(Button button)
        {
            // If no date is selected, show a warning and do nothing
            if (AppointmentDate.Text == "")
            {
                MessageBox.Show("Please select a date...");
                return;
            }

            // Calculate the nearest date
            string freeDay = NearestDate();

            // If the button color is red (occupied), it means no suitable appointment is available, show a message
            if (button.BackColor == Color.Red)
            {
                if (freeDay == null)
                    MessageBox.Show("No available appointment slot");
                else
                    MessageBox.Show($"This slot is already booked.{freeDay}");
            }
            // If the button color is green (selected), it means it's already selected, show a message
            else if (button.BackColor == Color.Green)
            {
                MessageBox.Show("This slot is already selected.");
            }
            // If the button color is white (available), confirm the selection
            else
            {
                // Set the selected time and change the button color to green
                clock = button.Text;
                button.BackColor = Color.Green;

                // If lastSelectedButton is not null and its color is green (previously selected), change its color to white
                if (this.lastSelectedButton?.BackColor != null && this.lastSelectedButton.BackColor == Color.Green)
                {
                    this.lastSelectedButton.BackColor = Color.White;
                }
                // Set the selected button as lastSelectedButton
                this.lastSelectedButton = button;
            }
        }

        // Actions to be performed when button One is clicked
        private void One_Click(object sender, EventArgs e)
        {
            // Call the OnTimeButtonClick method and pass the button as a parameter
            OnTimeButtonClick(One);
        }

        private void Two_Click(object sender, EventArgs e)
        {
            OnTimeButtonClick(Two);
        }

        private void Three_Click(object sender, EventArgs e)
        {
            OnTimeButtonClick(Three);
        }

        private void Four_Click(object sender, EventArgs e)
        {
            OnTimeButtonClick(Four);
        }

        private void Five_Click(object sender, EventArgs e)
        {
            OnTimeButtonClick(Five);
        }

        private void Six_Click(object sender, EventArgs e)
        {
            OnTimeButtonClick(Six);
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            OnTimeButtonClick(Seven);
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            OnTimeButtonClick(Eight);
        }
    }
}
