namespace AppointmentsSystem
{
    partial class AppointmentsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AppointmentListView = new ListView();
            SuspendLayout();
            // 
            // AppointmentListView
            // 
            AppointmentListView.BackColor = SystemColors.Control;
            AppointmentListView.Location = new Point(1, 0);
            AppointmentListView.Name = "AppointmentListView";
            AppointmentListView.Size = new Size(600, 514);
            AppointmentListView.TabIndex = 20;
            AppointmentListView.UseCompatibleStateImageBehavior = false;
            AppointmentListView.View = View.Details;
            // 
            // AppointmentsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 515);
            Controls.Add(AppointmentListView);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AppointmentsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Appointments";
            Load += AppointmentsForm_Load;
            ResumeLayout(false);
        }

        #endregion

        public ListView AppointmentListView;
    }
}
