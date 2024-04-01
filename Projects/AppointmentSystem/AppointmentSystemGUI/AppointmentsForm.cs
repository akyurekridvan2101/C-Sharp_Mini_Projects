using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AppointmentsSystem
{
    public partial class AppointmentsForm : Form
    {
        // Constructor of the AppointmentsForm
        public AppointmentsForm()
        {
            InitializeComponent();
        }

        // Actions to be taken when the AppointmentsForm is loaded
        private void AppointmentsForm_Load(object sender, EventArgs e)
        {
            // Create ListView columns
            AppointmentListView.Columns.Add("       Name", 100);
            AppointmentListView.Columns.Add("      Surname", 100);
            AppointmentListView.Columns.Add("        TC", 100);
            AppointmentListView.Columns.Add("     Gender", 100);
            AppointmentListView.Columns.Add("      Date", 100);
            AppointmentListView.Columns.Add("      Clock", 100);
        }
    }
}
