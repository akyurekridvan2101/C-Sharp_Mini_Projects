namespace XoxGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Grid = new PictureBox();
            A1 = new Button();
            C2 = new Button();
            C1 = new Button();
            B3 = new Button();
            B2 = new Button();
            B1 = new Button();
            A3 = new Button();
            A2 = new Button();
            Player1 = new Label();
            Player2 = new Label();
            C3 = new Button();
            RestartGame = new Button();
            ((System.ComponentModel.ISupportInitialize)Grid).BeginInit();
            SuspendLayout();
            // 
            // Grid
            // 
            Grid.Image = (Image)resources.GetObject("Grid.Image");
            Grid.Location = new Point(1, 58);
            Grid.Name = "Grid";
            Grid.Size = new Size(462, 462);
            Grid.SizeMode = PictureBoxSizeMode.AutoSize;
            Grid.TabIndex = 0;
            Grid.TabStop = false;
            // 
            // A1
            // 
            A1.Font = new Font("Segoe UI", 60F);
            A1.Location = new Point(1, 59);
            A1.Name = "A1";
            A1.Size = new Size(144, 141);
            A1.TabIndex = 23;
            A1.UseVisualStyleBackColor = true;
            A1.Click += A1_Click;
            // 
            // C2
            // 
            C2.Font = new Font("Segoe UI", 60F);
            C2.Location = new Point(160, 380);
            C2.Name = "C2";
            C2.Size = new Size(144, 141);
            C2.TabIndex = 25;
            C2.UseVisualStyleBackColor = true;
            C2.Click += C2_Click;
            // 
            // C1
            // 
            C1.Font = new Font("Segoe UI", 60F);
            C1.Location = new Point(1, 380);
            C1.Name = "C1";
            C1.Size = new Size(144, 141);
            C1.TabIndex = 26;
            C1.UseVisualStyleBackColor = true;
            C1.Click += C1_Click;
            // 
            // B3
            // 
            B3.Font = new Font("Segoe UI", 60F);
            B3.Location = new Point(319, 217);
            B3.Name = "B3";
            B3.Size = new Size(144, 152);
            B3.TabIndex = 27;
            B3.UseVisualStyleBackColor = true;
            B3.Click += B3_Click;
            // 
            // B2
            // 
            B2.Font = new Font("Segoe UI", 60F);
            B2.Location = new Point(160, 217);
            B2.Name = "B2";
            B2.Size = new Size(144, 152);
            B2.TabIndex = 28;
            B2.UseVisualStyleBackColor = true;
            B2.Click += B2_Click;
            // 
            // B1
            // 
            B1.Font = new Font("Segoe UI", 60F);
            B1.Location = new Point(1, 217);
            B1.Name = "B1";
            B1.Size = new Size(144, 152);
            B1.TabIndex = 29;
            B1.UseVisualStyleBackColor = true;
            B1.Click += B1_Click;
            // 
            // A2
            // 
            A2.Font = new Font("Segoe UI", 60F);
            A2.Location = new Point(160, 59);
            A2.Name = "A2";
            A2.Size = new Size(144, 141);
            A2.TabIndex = 31;
            A2.UseVisualStyleBackColor = true;
            A2.Click += A2_Click;
            // 
            // A3
            // 
            A3.Font = new Font("Segoe UI", 60F);
            A3.Location = new Point(319, 59);
            A3.Name = "A3";
            A3.Size = new Size(144, 141);
            A3.TabIndex = 30;
            A3.UseVisualStyleBackColor = true;
            A3.Click += A3_Click;
            // 
            // C3
            // 
            C3.Font = new Font("Segoe UI", 60F);
            C3.Location = new Point(319, 380);
            C3.Name = "C3";
            C3.Size = new Size(144, 141);
            C3.TabIndex = 35;
            C3.UseVisualStyleBackColor = true;
            C3.Click += C3_Click;
            // 
            // Player1
            // 
            Player1.AutoSize = true;
            Player1.Font = new Font("Segoe UI", 20F);
            Player1.Location = new Point(160, 9);
            Player1.Name = "Player1";
            Player1.Size = new Size(137, 46);
            Player1.TabIndex = 32;
            Player1.Text = "Player 1";
            // 
            // Player2
            // 
            Player2.AutoSize = true;
            Player2.Font = new Font("Segoe UI", 20F);
            Player2.Location = new Point(167, 524);
            Player2.Name = "Player2";
            Player2.Size = new Size(137, 46);
            Player2.TabIndex = 34;
            Player2.Text = "Player 2";
            // 
            // RestartGame
            // 
            RestartGame.BackColor = Color.Silver;
            RestartGame.Font = new Font("Segoe UI", 15F);
            RestartGame.Location = new Point(169, 595);
            RestartGame.Name = "RestartGame";
            RestartGame.Size = new Size(128, 43);
            RestartGame.TabIndex = 36;
            RestartGame.Text = "RESTART";
            RestartGame.UseVisualStyleBackColor = false;
            RestartGame.Click += RestartGame_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(468, 662);
            Controls.Add(RestartGame);
            Controls.Add(C3);
            Controls.Add(Player2);
            Controls.Add(Player1);
            Controls.Add(A2);
            Controls.Add(A3);
            Controls.Add(B1);
            Controls.Add(B2);
            Controls.Add(B3);
            Controls.Add(C1);
            Controls.Add(C2);
            Controls.Add(A1);
            Controls.Add(Grid);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tic-Tac-Tao";
            ((System.ComponentModel.ISupportInitialize)Grid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Grid;
        private Button A1;
        private Button C2;
        private Button C1;
        private Button B3;
        private Button B2;
        private Button B1;
        private Button A3;
        private Button A2;
        private Label Player1;
        private Label Player2;
        private Button C3;
        private Button RestartGame;
    }
}
