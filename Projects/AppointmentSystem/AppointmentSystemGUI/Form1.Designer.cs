namespace AppointmentsSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NameLabel = new Label();
            SurnameLabel = new Label();
            FirstName = new TextBox();
            Surname = new TextBox();
            TC = new TextBox();
            TCLabel = new Label();
            GetAppointment = new Button();
            AppointmentDateLabel = new Label();
            AppointmentDate = new ComboBox();
            One = new Button();
            Two = new Button();
            Three = new Button();
            Four = new Button();
            Eight = new Button();
            Seven = new Button();
            Six = new Button();
            Five = new Button();
            ShowAppointments = new Button();
            GenderLabel = new Label();
            Gender = new ComboBox();
            SuspendLayout();
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Segoe UI", 15F);
            NameLabel.Location = new Point(21, 20);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(94, 35);
            NameLabel.TabIndex = 0;
            NameLabel.Text = "Name :";
            // 
            // SurnameLabel
            // 
            SurnameLabel.AutoSize = true;
            SurnameLabel.Font = new Font("Segoe UI", 15F);
            SurnameLabel.Location = new Point(21, 97);
            SurnameLabel.Name = "SurnameLabel";
            SurnameLabel.Size = new Size(125, 35);
            SurnameLabel.TabIndex = 2;
            SurnameLabel.Text = "Surname :";
            // 
            // FirstName
            // 
            FirstName.Location = new Point(259, 29);
            FirstName.Multiline = true;
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(217, 27);
            FirstName.TabIndex = 3;
            // 
            // Surname
            // 
            Surname.Location = new Point(259, 97);
            Surname.Name = "Surname";
            Surname.Size = new Size(217, 27);
            Surname.TabIndex = 4;
            // 
            // TC
            // 
            TC.Location = new Point(259, 170);
            TC.Name = "TC";
            TC.Size = new Size(217, 27);
            TC.TabIndex = 7;
            // 
            // TCLabel
            // 
            TCLabel.AutoSize = true;
            TCLabel.Font = new Font("Segoe UI", 15F);
            TCLabel.Location = new Point(21, 162);
            TCLabel.Name = "TCLabel";
            TCLabel.Size = new Size(54, 35);
            TCLabel.TabIndex = 6;
            TCLabel.Text = "TC :";
            // 
            // GetAppointment
            // 
            GetAppointment.Font = new Font("Segoe UI", 17F);
            GetAppointment.Location = new Point(132, 499);
            GetAppointment.Name = "GetAppointment";
            GetAppointment.Size = new Size(249, 50);
            GetAppointment.TabIndex = 8;
            GetAppointment.Text = "Get Appointment";
            GetAppointment.UseVisualStyleBackColor = true;
            GetAppointment.Click += GetAppointment_Click;
            // 
            // AppointmentDateLabel
            // 
            AppointmentDateLabel.AutoSize = true;
            AppointmentDateLabel.Font = new Font("Segoe UI", 15F);
            AppointmentDateLabel.Location = new Point(21, 217);
            AppointmentDateLabel.Name = "AppointmentDateLabel";
            AppointmentDateLabel.Size = new Size(232, 35);
            AppointmentDateLabel.TabIndex = 10;
            AppointmentDateLabel.Text = "Appointment Date :";
            // 
            // AppointmentDate
            // 
            AppointmentDate.DropDownStyle = ComboBoxStyle.DropDownList;
            AppointmentDate.FormattingEnabled = true;
            AppointmentDate.Location = new Point(259, 224);
            AppointmentDate.Name = "AppointmentDate";
            AppointmentDate.Size = new Size(217, 28);
            AppointmentDate.TabIndex = 9;
            AppointmentDate.SelectedIndexChanged += AppointmentDate_SelectedIndexChanged;
            // 
            // One
            // 
            One.BackColor = Color.White;
            One.Location = new Point(33, 373);
            One.Name = "One";
            One.Size = new Size(112, 38);
            One.TabIndex = 11;
            One.Text = "08.30 - 09.15";
            One.UseVisualStyleBackColor = false;
            One.Click += One_Click;
            // 
            // Two
            // 
            Two.BackColor = Color.White;
            Two.Location = new Point(151, 373);
            Two.Name = "Two";
            Two.Size = new Size(102, 38);
            Two.TabIndex = 12;
            Two.Text = "09.30 - 10.15";
            Two.UseVisualStyleBackColor = false;
            Two.Click += Two_Click;
            // 
            // Three
            // 
            Three.BackColor = Color.White;
            Three.Location = new Point(259, 373);
            Three.Name = "Three";
            Three.Size = new Size(101, 38);
            Three.TabIndex = 13;
            Three.Text = "10.30 - 11.15";
            Three.UseVisualStyleBackColor = false;
            Three.Click += Three_Click;
            // 
            // Four
            // 
            Four.BackColor = Color.White;
            Four.Location = new Point(366, 373);
            Four.Name = "Four";
            Four.Size = new Size(102, 38);
            Four.TabIndex = 14;
            Four.Text = "11.30 - 12.15";
            Four.UseVisualStyleBackColor = false;
            Four.Click += Four_Click;
            // 
            // Eight
            // 
            Eight.BackColor = Color.White;
            Eight.Location = new Point(366, 434);
            Eight.Name = "Eight";
            Eight.Size = new Size(102, 38);
            Eight.TabIndex = 18;
            Eight.Text = "16.30 - 17.15";
            Eight.UseVisualStyleBackColor = false;
            Eight.Click += Eight_Click;
            // 
            // Seven
            // 
            Seven.BackColor = Color.White;
            Seven.Location = new Point(259, 434);
            Seven.Name = "Seven";
            Seven.Size = new Size(101, 38);
            Seven.TabIndex = 17;
            Seven.Text = "15.30 - 16.15";
            Seven.UseVisualStyleBackColor = false;
            Seven.Click += Seven_Click;
            // 
            // Six
            // 
            Six.BackColor = Color.White;
            Six.Location = new Point(151, 434);
            Six.Name = "Six";
            Six.Size = new Size(102, 38);
            Six.TabIndex = 16;
            Six.Text = "14.30 - 15.15";
            Six.UseVisualStyleBackColor = false;
            Six.Click += Six_Click;
            // 
            // Five
            // 
            Five.BackColor = Color.White;
            Five.Location = new Point(33, 434);
            Five.Name = "Five";
            Five.Size = new Size(112, 38);
            Five.TabIndex = 15;
            Five.Text = "13.30 - 14.15";
            Five.UseVisualStyleBackColor = false;
            Five.Click += Five_Click;
            // 
            // ShowAppointments
            // 
            ShowAppointments.Font = new Font("Segoe UI", 17F);
            ShowAppointments.Location = new Point(112, 565);
            ShowAppointments.Name = "ShowAppointments";
            ShowAppointments.Size = new Size(285, 50);
            ShowAppointments.TabIndex = 20;
            ShowAppointments.Text = "Show Appointments";
            ShowAppointments.UseVisualStyleBackColor = true;
            ShowAppointments.Click += ShowAppointments_Click;
            // 
            // GenderLabel
            // 
            GenderLabel.AutoSize = true;
            GenderLabel.Font = new Font("Segoe UI", 15F);
            GenderLabel.Location = new Point(21, 300);
            GenderLabel.Name = "GenderLabel";
            GenderLabel.Size = new Size(108, 35);
            GenderLabel.TabIndex = 22;
            GenderLabel.Text = "Gender :";
            // 
            // Gender
            // 
            Gender.DropDownStyle = ComboBoxStyle.DropDownList;
            Gender.FormattingEnabled = true;
            Gender.Items.AddRange(new object[] { "Male", "Woman" });
            Gender.Location = new Point(259, 300);
            Gender.Name = "Gender";
            Gender.Size = new Size(217, 28);
            Gender.TabIndex = 21;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 641);
            Controls.Add(GenderLabel);
            Controls.Add(Gender);
            Controls.Add(ShowAppointments);
            Controls.Add(Eight);
            Controls.Add(Seven);
            Controls.Add(Six);
            Controls.Add(Five);
            Controls.Add(Four);
            Controls.Add(Three);
            Controls.Add(Two);
            Controls.Add(One);
            Controls.Add(AppointmentDateLabel);
            Controls.Add(AppointmentDate);
            Controls.Add(GetAppointment);
            Controls.Add(TC);
            Controls.Add(TCLabel);
            Controls.Add(Surname);
            Controls.Add(FirstName);
            Controls.Add(SurnameLabel);
            Controls.Add(NameLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Appointment System";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NameLabel;
        private Label SurnameLabel;
        private TextBox FirstName;
        private TextBox Surname;
        private TextBox TC;
        private Label TCLabel;
        private Button GetAppointment;
        private Label AppointmentDateLabel;
        private ComboBox AppointmentDate;
        private Button One;
        private Button Two;
        private Button Three;
        private Button Four;
        private Button Eight;
        private Button Seven;
        private Button Six;
        private Button Five;
        private Button ShowAppointments;
        private Label GenderLabel;
        private ComboBox Gender;
    }
}
