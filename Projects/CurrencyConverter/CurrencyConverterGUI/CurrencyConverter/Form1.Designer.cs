namespace CurrencyConverter
{
    partial class Form1
    {
        private void DovizBilgileriniYaz()
        {
            label1.Text = Program.dovizBilgileri[0, 0];
            label2.Text = Program.dovizBilgileri[0, 1];
            label3.Text = Program.dovizBilgileri[0, 2];
            
            label4.Text = Program.dovizBilgileri[1, 0];
            label5.Text = Program.dovizBilgileri[1, 1];
            label6.Text = Program.dovizBilgileri[1, 2];

            label7.Text = Program.dovizBilgileri[2, 0];
            label8.Text = Program.dovizBilgileri[2, 1];
            label9.Text = Program.dovizBilgileri[2, 2];

            label10.Text = Program.dovizBilgileri[3, 0];
            label11.Text = Program.dovizBilgileri[3, 1];
            label12.Text = Program.dovizBilgileri[3, 2];

            label13.Text = Program.dovizBilgileri[4, 0];
            label14.Text = Program.dovizBilgileri[4, 1];
            label15.Text = Program.dovizBilgileri[4, 2];

            label16.Text = Program.dovizBilgileri[5, 0];
            label17.Text = Program.dovizBilgileri[5, 1];
            label18.Text = Program.dovizBilgileri[5, 2];

            label19.Text = Program.dovizBilgileri[6, 0];
            label20.Text = Program.dovizBilgileri[6, 1];
            label21.Text = Program.dovizBilgileri[6, 2];

            label22.Text = Program.dovizBilgileri[7, 0];
            label23.Text = Program.dovizBilgileri[7, 1];
            label24.Text = Program.dovizBilgileri[7, 2];

            label25.Text = Program.dovizBilgileri[8, 0];
            label26.Text = Program.dovizBilgileri[8, 1];
            label27.Text = Program.dovizBilgileri[8, 2];

            label28.Text = Program.dovizBilgileri[9, 0];
            label29.Text = Program.dovizBilgileri[9, 1];
            label30.Text = Program.dovizBilgileri[9, 2];

            label31.Text = Program.dovizBilgileri[10, 0];
            label32.Text = Program.dovizBilgileri[10, 1];
            label33.Text = Program.dovizBilgileri[10, 2];

            label34.Text = Program.dovizBilgileri[11, 0];
            label35.Text = Program.dovizBilgileri[11, 1];
            label36.Text = Program.dovizBilgileri[11, 2];


            Label[] degisimler = { label3, label6, label9, label12, label15, label18,
                label21, label24, label27, label30, label33, label36 };

            PictureBox[] yonler = {
                ABDDolariYon , EuroYon , IngilizSterliniYon ,
                IsvicreFrangiYon , JaponYeniYon , SuudiArabistanRiyaliYon ,
                NorvecKronuYon , DanimarkaKronuYon , AvustralyaDolariYon ,
                KanadaDolariYon , IsvecKronuYon , RubleYon
            };


            this.ReferansResim.Visible = false;// referans resmi gizleniyor çünkü sadece diğer resimlerin yönlerini göstermek için kullanılıyor
            for (int i = 0; i < 12; i++)
            {
                if (degisimler[i].Text[0] == '-')
                {
                    yonler[i].Image = this.ReferansResim.Image;
                }

            }
        }

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
            Adlar = new Label();
            AlisFiyatlari = new Label();
            Degisim = new Label();
            SatisFiyatlari = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            ABD = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox10 = new PictureBox();
            pictureBox11 = new PictureBox();
            pictureBox12 = new PictureBox();
            panel1 = new Panel();
            ABDDolariYon = new PictureBox();
            label49 = new Label();
            panel2 = new Panel();
            EuroYon = new PictureBox();
            label58 = new Label();
            panel3 = new Panel();
            IngilizSterliniYon = new PictureBox();
            label57 = new Label();
            label9 = new Label();
            label10 = new Label();
            label12 = new Label();
            label11 = new Label();
            panel6 = new Panel();
            JaponYeniYon = new PictureBox();
            label55 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label33 = new Label();
            label34 = new Label();
            label35 = new Label();
            label36 = new Label();
            label29 = new Label();
            label30 = new Label();
            label31 = new Label();
            label32 = new Label();
            label25 = new Label();
            label26 = new Label();
            label27 = new Label();
            label28 = new Label();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label16 = new Label();
            panel4 = new Panel();
            IsvicreFrangiYon = new PictureBox();
            label56 = new Label();
            panel5 = new Panel();
            SuudiArabistanRiyaliYon = new PictureBox();
            label54 = new Label();
            panel7 = new Panel();
            NorvecKronuYon = new PictureBox();
            label53 = new Label();
            panel8 = new Panel();
            DanimarkaKronuYon = new PictureBox();
            label52 = new Label();
            panel9 = new Panel();
            AvustralyaDolariYon = new PictureBox();
            label51 = new Label();
            panel10 = new Panel();
            KanadaDolariYon = new PictureBox();
            label50 = new Label();
            panel11 = new Panel();
            IsvecKronuYon = new PictureBox();
            label60 = new Label();
            panel12 = new Panel();
            RubleYon = new PictureBox();
            label59 = new Label();
            panel13 = new Panel();
            Yon = new Label();
            Sagdaki = new ComboBox();
            Soldaki = new ComboBox();
            label38 = new Label();
            label37 = new Label();
            Miktar = new TextBox();
            panel14 = new Panel();
            ReferansResim = new PictureBox();
            Sonuc = new Label();
            DonusturButonu = new Button();
            ((System.ComponentModel.ISupportInitialize)ABD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ABDDolariYon).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EuroYon).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IngilizSterliniYon).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)JaponYeniYon).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IsvicreFrangiYon).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SuudiArabistanRiyaliYon).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NorvecKronuYon).BeginInit();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DanimarkaKronuYon).BeginInit();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AvustralyaDolariYon).BeginInit();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)KanadaDolariYon).BeginInit();
            panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IsvecKronuYon).BeginInit();
            panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RubleYon).BeginInit();
            panel13.SuspendLayout();
            panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ReferansResim).BeginInit();
            SuspendLayout();
            // 
            // Adlar
            // 
            Adlar.AutoSize = true;
            Adlar.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Adlar.ForeColor = SystemColors.ButtonHighlight;
            Adlar.Location = new Point(0, 0);
            Adlar.Name = "Adlar";
            Adlar.Size = new Size(133, 31);
            Adlar.TabIndex = 0;
            Adlar.Text = "Döviz Cinsi";
            // 
            // AlisFiyatlari
            // 
            AlisFiyatlari.AutoSize = true;
            AlisFiyatlari.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 162);
            AlisFiyatlari.ForeColor = SystemColors.ButtonHighlight;
            AlisFiyatlari.Location = new Point(488, 0);
            AlisFiyatlari.Name = "AlisFiyatlari";
            AlisFiyatlari.Size = new Size(54, 31);
            AlisFiyatlari.TabIndex = 1;
            AlisFiyatlari.Text = "Alış";
            // 
            // Degisim
            // 
            Degisim.AutoSize = true;
            Degisim.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Degisim.ForeColor = SystemColors.ButtonHighlight;
            Degisim.Location = new Point(817, 0);
            Degisim.Name = "Degisim";
            Degisim.Size = new Size(102, 31);
            Degisim.TabIndex = 2;
            Degisim.Text = "Değişim";
            // 
            // SatisFiyatlari
            // 
            SatisFiyatlari.AutoSize = true;
            SatisFiyatlari.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 162);
            SatisFiyatlari.ForeColor = SystemColors.ButtonHighlight;
            SatisFiyatlari.Location = new Point(666, 0);
            SatisFiyatlari.Name = "SatisFiyatlari";
            SatisFiyatlari.Size = new Size(65, 31);
            SatisFiyatlari.TabIndex = 3;
            SatisFiyatlari.Text = "Satış";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(488, 0);
            label1.Name = "label1";
            label1.Size = new Size(63, 28);
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(665, 6);
            label2.Name = "label2";
            label2.Size = new Size(66, 28);
            label2.TabIndex = 5;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(827, 0);
            label3.Name = "label3";
            label3.Size = new Size(66, 28);
            label3.TabIndex = 6;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(488, 0);
            label4.Name = "label4";
            label4.Size = new Size(67, 28);
            label4.TabIndex = 7;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(666, 0);
            label5.Name = "label5";
            label5.Size = new Size(66, 28);
            label5.TabIndex = 11;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.Location = new Point(827, 0);
            label6.Name = "label6";
            label6.Size = new Size(66, 28);
            label6.TabIndex = 10;
            label6.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label7.Location = new Point(489, 0);
            label7.Name = "label7";
            label7.Size = new Size(66, 28);
            label7.TabIndex = 9;
            label7.Text = "label7";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label8.Location = new Point(665, 0);
            label8.Name = "label8";
            label8.Size = new Size(66, 28);
            label8.TabIndex = 8;
            label8.Text = "label8";
            // 
            // ABD
            // 
            ABD.Image = (Image)resources.GetObject("ABD.Image");
            ABD.Location = new Point(0, 0);
            ABD.Name = "ABD";
            ABD.Size = new Size(66, 34);
            ABD.SizeMode = PictureBoxSizeMode.StretchImage;
            ABD.TabIndex = 52;
            ABD.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(66, 34);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 53;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(66, 34);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 54;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(0, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(66, 34);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 55;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(0, 0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(66, 34);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 56;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(0, 0);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(66, 34);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 57;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(0, 0);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(66, 34);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 58;
            pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(0, 0);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(66, 34);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 59;
            pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(0, 0);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(66, 34);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 60;
            pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.Location = new Point(0, 0);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(66, 34);
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox10.TabIndex = 61;
            pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            pictureBox11.Image = (Image)resources.GetObject("pictureBox11.Image");
            pictureBox11.Location = new Point(0, 0);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(66, 34);
            pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox11.TabIndex = 62;
            pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            pictureBox12.Image = (Image)resources.GetObject("pictureBox12.Image");
            pictureBox12.Location = new Point(0, 0);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(66, 34);
            pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox12.TabIndex = 63;
            pictureBox12.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(ABDDolariYon);
            panel1.Controls.Add(ABD);
            panel1.Controls.Add(label49);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(12, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(922, 34);
            panel1.TabIndex = 64;
            // 
            // ABDDolariYon
            // 
            ABDDolariYon.Image = (Image)resources.GetObject("ABDDolariYon.Image");
            ABDDolariYon.Location = new Point(356, 0);
            ABDDolariYon.Name = "ABDDolariYon";
            ABDDolariYon.Size = new Size(56, 34);
            ABDDolariYon.TabIndex = 126;
            ABDDolariYon.TabStop = false;
            // 
            // label49
            // 
            label49.AutoSize = true;
            label49.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label49.Location = new Point(72, 0);
            label49.Name = "label49";
            label49.Size = new Size(110, 28);
            label49.TabIndex = 119;
            label49.Text = "ABD Doları";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientInactiveCaption;
            panel2.Controls.Add(EuroYon);
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(label58);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(12, 104);
            panel2.Name = "panel2";
            panel2.Size = new Size(922, 34);
            panel2.TabIndex = 65;
            // 
            // EuroYon
            // 
            EuroYon.Image = (Image)resources.GetObject("EuroYon.Image");
            EuroYon.Location = new Point(356, 0);
            EuroYon.Name = "EuroYon";
            EuroYon.Size = new Size(56, 34);
            EuroYon.TabIndex = 129;
            EuroYon.TabStop = false;
            // 
            // label58
            // 
            label58.AutoSize = true;
            label58.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label58.Location = new Point(72, 0);
            label58.Name = "label58";
            label58.Size = new Size(53, 28);
            label58.TabIndex = 128;
            label58.Text = "Euro";
            // 
            // panel3
            // 
            panel3.Controls.Add(IngilizSterliniYon);
            panel3.Controls.Add(pictureBox7);
            panel3.Controls.Add(label57);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label9);
            panel3.Location = new Point(12, 144);
            panel3.Name = "panel3";
            panel3.Size = new Size(922, 34);
            panel3.TabIndex = 66;
            // 
            // IngilizSterliniYon
            // 
            IngilizSterliniYon.Image = (Image)resources.GetObject("IngilizSterliniYon.Image");
            IngilizSterliniYon.Location = new Point(356, 0);
            IngilizSterliniYon.Name = "IngilizSterliniYon";
            IngilizSterliniYon.Size = new Size(56, 34);
            IngilizSterliniYon.TabIndex = 128;
            IngilizSterliniYon.TabStop = false;
            // 
            // label57
            // 
            label57.AutoSize = true;
            label57.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label57.Location = new Point(72, 0);
            label57.Name = "label57";
            label57.Size = new Size(134, 28);
            label57.TabIndex = 127;
            label57.Text = "İngiliz Sterlini";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label9.Location = new Point(827, 0);
            label9.Name = "label9";
            label9.Size = new Size(66, 28);
            label9.TabIndex = 73;
            label9.Text = "label9";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label10.Location = new Point(489, 0);
            label10.Name = "label10";
            label10.Size = new Size(74, 28);
            label10.TabIndex = 72;
            label10.Text = "label10";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label12.Location = new Point(827, 0);
            label12.Name = "label12";
            label12.Size = new Size(74, 28);
            label12.TabIndex = 70;
            label12.Text = "label12";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label11.Location = new Point(666, 0);
            label11.Name = "label11";
            label11.Size = new Size(71, 28);
            label11.TabIndex = 71;
            label11.Text = "label11";
            // 
            // panel6
            // 
            panel6.Controls.Add(JaponYeniYon);
            panel6.Controls.Add(pictureBox12);
            panel6.Controls.Add(label55);
            panel6.Controls.Add(label13);
            panel6.Controls.Add(label14);
            panel6.Controls.Add(label15);
            panel6.Location = new Point(12, 226);
            panel6.Name = "panel6";
            panel6.Size = new Size(922, 34);
            panel6.TabIndex = 69;
            // 
            // JaponYeniYon
            // 
            JaponYeniYon.Image = (Image)resources.GetObject("JaponYeniYon.Image");
            JaponYeniYon.Location = new Point(356, 0);
            JaponYeniYon.Name = "JaponYeniYon";
            JaponYeniYon.Size = new Size(56, 34);
            JaponYeniYon.TabIndex = 127;
            JaponYeniYon.TabStop = false;
            // 
            // label55
            // 
            label55.AutoSize = true;
            label55.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label55.Location = new Point(72, 0);
            label55.Name = "label55";
            label55.Size = new Size(110, 28);
            label55.TabIndex = 125;
            label55.Text = "Japon Yeni";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label13.Location = new Point(489, 0);
            label13.Name = "label13";
            label13.Size = new Size(74, 28);
            label13.TabIndex = 77;
            label13.Text = "label13";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label14.Location = new Point(666, 0);
            label14.Name = "label14";
            label14.Size = new Size(75, 28);
            label14.TabIndex = 76;
            label14.Text = "label14";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label15.Location = new Point(827, 0);
            label15.Name = "label15";
            label15.Size = new Size(74, 28);
            label15.TabIndex = 75;
            label15.Text = "label15";
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label33.Location = new Point(827, 0);
            label33.Name = "label33";
            label33.Size = new Size(77, 28);
            label33.TabIndex = 97;
            label33.Text = "label33";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label34.Location = new Point(485, 0);
            label34.Name = "label34";
            label34.Size = new Size(78, 28);
            label34.TabIndex = 96;
            label34.Text = "label34";
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label35.Location = new Point(667, -3);
            label35.Name = "label35";
            label35.Size = new Size(77, 28);
            label35.TabIndex = 95;
            label35.Text = "label35";
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label36.Location = new Point(828, 0);
            label36.Name = "label36";
            label36.Size = new Size(77, 28);
            label36.TabIndex = 94;
            label36.Text = "label36";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label29.Location = new Point(667, 0);
            label29.Name = "label29";
            label29.Size = new Size(77, 28);
            label29.TabIndex = 93;
            label29.Text = "label29";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label30.Location = new Point(824, 0);
            label30.Name = "label30";
            label30.Size = new Size(77, 28);
            label30.TabIndex = 92;
            label30.Text = "label30";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label31.Location = new Point(489, 0);
            label31.Name = "label31";
            label31.Size = new Size(74, 28);
            label31.TabIndex = 91;
            label31.Text = "label31";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label32.Location = new Point(667, 0);
            label32.Name = "label32";
            label32.Size = new Size(77, 28);
            label32.TabIndex = 90;
            label32.Text = "label32";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label25.Location = new Point(489, 0);
            label25.Name = "label25";
            label25.Size = new Size(77, 28);
            label25.TabIndex = 89;
            label25.Text = "label25";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label26.Location = new Point(667, 0);
            label26.Name = "label26";
            label26.Size = new Size(77, 28);
            label26.TabIndex = 88;
            label26.Text = "label26";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label27.Location = new Point(824, 0);
            label27.Name = "label27";
            label27.Size = new Size(77, 28);
            label27.TabIndex = 87;
            label27.Text = "label27";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label28.Location = new Point(489, 0);
            label28.Name = "label28";
            label28.Size = new Size(77, 28);
            label28.TabIndex = 86;
            label28.Text = "label28";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label21.Location = new Point(827, 0);
            label21.Name = "label21";
            label21.Size = new Size(74, 28);
            label21.TabIndex = 85;
            label21.Text = "label21";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label22.Location = new Point(489, 0);
            label22.Name = "label22";
            label22.Size = new Size(77, 28);
            label22.TabIndex = 84;
            label22.Text = "label22";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label23.Location = new Point(666, 0);
            label23.Name = "label23";
            label23.Size = new Size(77, 28);
            label23.TabIndex = 83;
            label23.Text = "label23";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label24.Location = new Point(827, 0);
            label24.Name = "label24";
            label24.Size = new Size(78, 28);
            label24.TabIndex = 82;
            label24.Text = "label24";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label17.Location = new Point(667, 0);
            label17.Name = "label17";
            label17.Size = new Size(74, 28);
            label17.TabIndex = 81;
            label17.Text = "label17";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label18.Location = new Point(827, 0);
            label18.Name = "label18";
            label18.Size = new Size(74, 28);
            label18.TabIndex = 80;
            label18.Text = "label18";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label19.Location = new Point(489, 0);
            label19.Name = "label19";
            label19.Size = new Size(74, 28);
            label19.TabIndex = 79;
            label19.Text = "label19";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label20.Location = new Point(667, 0);
            label20.Name = "label20";
            label20.Size = new Size(77, 28);
            label20.TabIndex = 78;
            label20.Text = "label20";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label16.Location = new Point(489, 0);
            label16.Name = "label16";
            label16.Size = new Size(74, 28);
            label16.TabIndex = 74;
            label16.Text = "label16";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.GradientInactiveCaption;
            panel4.Controls.Add(IsvicreFrangiYon);
            panel4.Controls.Add(pictureBox10);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(label56);
            panel4.Location = new Point(12, 184);
            panel4.Name = "panel4";
            panel4.Size = new Size(922, 34);
            panel4.TabIndex = 110;
            // 
            // IsvicreFrangiYon
            // 
            IsvicreFrangiYon.Image = (Image)resources.GetObject("IsvicreFrangiYon.Image");
            IsvicreFrangiYon.Location = new Point(356, 0);
            IsvicreFrangiYon.Name = "IsvicreFrangiYon";
            IsvicreFrangiYon.Size = new Size(56, 34);
            IsvicreFrangiYon.TabIndex = 127;
            IsvicreFrangiYon.TabStop = false;
            // 
            // label56
            // 
            label56.AutoSize = true;
            label56.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label56.Location = new Point(72, 0);
            label56.Name = "label56";
            label56.Size = new Size(131, 28);
            label56.TabIndex = 126;
            label56.Text = "İsviçre Frangı";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.GradientInactiveCaption;
            panel5.Controls.Add(SuudiArabistanRiyaliYon);
            panel5.Controls.Add(pictureBox8);
            panel5.Controls.Add(label54);
            panel5.Controls.Add(label17);
            panel5.Controls.Add(label18);
            panel5.Controls.Add(label16);
            panel5.Location = new Point(12, 266);
            panel5.Name = "panel5";
            panel5.Size = new Size(922, 34);
            panel5.TabIndex = 111;
            // 
            // SuudiArabistanRiyaliYon
            // 
            SuudiArabistanRiyaliYon.Image = (Image)resources.GetObject("SuudiArabistanRiyaliYon.Image");
            SuudiArabistanRiyaliYon.Location = new Point(356, 0);
            SuudiArabistanRiyaliYon.Name = "SuudiArabistanRiyaliYon";
            SuudiArabistanRiyaliYon.Size = new Size(56, 34);
            SuudiArabistanRiyaliYon.TabIndex = 127;
            SuudiArabistanRiyaliYon.TabStop = false;
            // 
            // label54
            // 
            label54.AutoSize = true;
            label54.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label54.Location = new Point(72, 0);
            label54.Name = "label54";
            label54.Size = new Size(208, 28);
            label54.TabIndex = 124;
            label54.Text = "Suudi Arabistan Riyali";
            // 
            // panel7
            // 
            panel7.Controls.Add(NorvecKronuYon);
            panel7.Controls.Add(pictureBox9);
            panel7.Controls.Add(label53);
            panel7.Controls.Add(label19);
            panel7.Controls.Add(label20);
            panel7.Controls.Add(label21);
            panel7.Location = new Point(12, 306);
            panel7.Name = "panel7";
            panel7.Size = new Size(922, 34);
            panel7.TabIndex = 112;
            // 
            // NorvecKronuYon
            // 
            NorvecKronuYon.Image = (Image)resources.GetObject("NorvecKronuYon.Image");
            NorvecKronuYon.Location = new Point(356, 0);
            NorvecKronuYon.Name = "NorvecKronuYon";
            NorvecKronuYon.Size = new Size(56, 34);
            NorvecKronuYon.TabIndex = 127;
            NorvecKronuYon.TabStop = false;
            // 
            // label53
            // 
            label53.AutoSize = true;
            label53.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label53.Location = new Point(72, 0);
            label53.Name = "label53";
            label53.Size = new Size(138, 28);
            label53.TabIndex = 123;
            label53.Text = "Norveç Kronu";
            // 
            // panel8
            // 
            panel8.BackColor = SystemColors.GradientInactiveCaption;
            panel8.Controls.Add(DanimarkaKronuYon);
            panel8.Controls.Add(pictureBox3);
            panel8.Controls.Add(label52);
            panel8.Controls.Add(label22);
            panel8.Controls.Add(label23);
            panel8.Controls.Add(label24);
            panel8.Location = new Point(12, 346);
            panel8.Name = "panel8";
            panel8.Size = new Size(922, 34);
            panel8.TabIndex = 113;
            // 
            // DanimarkaKronuYon
            // 
            DanimarkaKronuYon.Image = (Image)resources.GetObject("DanimarkaKronuYon.Image");
            DanimarkaKronuYon.Location = new Point(356, 0);
            DanimarkaKronuYon.Name = "DanimarkaKronuYon";
            DanimarkaKronuYon.Size = new Size(56, 34);
            DanimarkaKronuYon.TabIndex = 127;
            DanimarkaKronuYon.TabStop = false;
            // 
            // label52
            // 
            label52.AutoSize = true;
            label52.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label52.Location = new Point(72, 0);
            label52.Name = "label52";
            label52.Size = new Size(170, 28);
            label52.TabIndex = 122;
            label52.Text = "Danimarka Kronu";
            // 
            // panel9
            // 
            panel9.Controls.Add(AvustralyaDolariYon);
            panel9.Controls.Add(pictureBox2);
            panel9.Controls.Add(label51);
            panel9.Controls.Add(label25);
            panel9.Controls.Add(label26);
            panel9.Controls.Add(label27);
            panel9.Location = new Point(12, 386);
            panel9.Name = "panel9";
            panel9.Size = new Size(922, 34);
            panel9.TabIndex = 114;
            // 
            // AvustralyaDolariYon
            // 
            AvustralyaDolariYon.Image = (Image)resources.GetObject("AvustralyaDolariYon.Image");
            AvustralyaDolariYon.Location = new Point(356, 0);
            AvustralyaDolariYon.Name = "AvustralyaDolariYon";
            AvustralyaDolariYon.Size = new Size(56, 34);
            AvustralyaDolariYon.TabIndex = 127;
            AvustralyaDolariYon.TabStop = false;
            // 
            // label51
            // 
            label51.AutoSize = true;
            label51.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label51.Location = new Point(72, 0);
            label51.Name = "label51";
            label51.Size = new Size(164, 28);
            label51.TabIndex = 121;
            label51.Text = "Avustralya Doları";
            // 
            // panel10
            // 
            panel10.BackColor = SystemColors.GradientInactiveCaption;
            panel10.Controls.Add(KanadaDolariYon);
            panel10.Controls.Add(pictureBox11);
            panel10.Controls.Add(label50);
            panel10.Controls.Add(label28);
            panel10.Controls.Add(label29);
            panel10.Controls.Add(label30);
            panel10.Location = new Point(12, 426);
            panel10.Name = "panel10";
            panel10.Size = new Size(922, 34);
            panel10.TabIndex = 115;
            // 
            // KanadaDolariYon
            // 
            KanadaDolariYon.Image = (Image)resources.GetObject("KanadaDolariYon.Image");
            KanadaDolariYon.Location = new Point(356, 0);
            KanadaDolariYon.Name = "KanadaDolariYon";
            KanadaDolariYon.Size = new Size(56, 34);
            KanadaDolariYon.TabIndex = 127;
            KanadaDolariYon.TabStop = false;
            // 
            // label50
            // 
            label50.AutoSize = true;
            label50.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label50.Location = new Point(72, 0);
            label50.Name = "label50";
            label50.Size = new Size(137, 28);
            label50.TabIndex = 120;
            label50.Text = "Kanada Doları";
            // 
            // panel11
            // 
            panel11.Controls.Add(IsvecKronuYon);
            panel11.Controls.Add(label60);
            panel11.Controls.Add(pictureBox4);
            panel11.Controls.Add(label31);
            panel11.Controls.Add(label32);
            panel11.Controls.Add(label33);
            panel11.Location = new Point(12, 466);
            panel11.Name = "panel11";
            panel11.Size = new Size(922, 34);
            panel11.TabIndex = 116;
            // 
            // IsvecKronuYon
            // 
            IsvecKronuYon.Image = (Image)resources.GetObject("IsvecKronuYon.Image");
            IsvecKronuYon.Location = new Point(356, 0);
            IsvecKronuYon.Name = "IsvecKronuYon";
            IsvecKronuYon.Size = new Size(56, 34);
            IsvecKronuYon.TabIndex = 131;
            IsvecKronuYon.TabStop = false;
            // 
            // label60
            // 
            label60.AutoSize = true;
            label60.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label60.Location = new Point(72, 0);
            label60.Name = "label60";
            label60.Size = new Size(118, 28);
            label60.TabIndex = 130;
            label60.Text = "İsveç Kronu";
            // 
            // panel12
            // 
            panel12.BackColor = SystemColors.GradientInactiveCaption;
            panel12.Controls.Add(RubleYon);
            panel12.Controls.Add(label59);
            panel12.Controls.Add(ReferansResim);
            panel12.Controls.Add(pictureBox6);
            panel12.Controls.Add(label34);
            panel12.Controls.Add(label35);
            panel12.Controls.Add(label36);
            panel12.Location = new Point(12, 506);
            panel12.Name = "panel12";
            panel12.Size = new Size(922, 34);
            panel12.TabIndex = 117;
            // 
            // RubleYon
            // 
            RubleYon.Image = (Image)resources.GetObject("RubleYon.Image");
            RubleYon.Location = new Point(356, 0);
            RubleYon.Name = "RubleYon";
            RubleYon.Size = new Size(56, 34);
            RubleYon.TabIndex = 130;
            RubleYon.TabStop = false;
            // 
            // label59
            // 
            label59.AutoSize = true;
            label59.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label59.Location = new Point(72, 0);
            label59.Name = "label59";
            label59.Size = new Size(64, 28);
            label59.TabIndex = 129;
            label59.Text = "Ruble";
            // 
            // panel13
            // 
            panel13.BackColor = SystemColors.ActiveCaption;
            panel13.Controls.Add(Yon);
            panel13.Controls.Add(Adlar);
            panel13.Controls.Add(AlisFiyatlari);
            panel13.Controls.Add(SatisFiyatlari);
            panel13.Controls.Add(Degisim);
            panel13.Location = new Point(12, 22);
            panel13.Name = "panel13";
            panel13.Size = new Size(922, 36);
            panel13.TabIndex = 118;
            // 
            // Yon
            // 
            Yon.AutoSize = true;
            Yon.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Yon.ForeColor = SystemColors.ButtonHighlight;
            Yon.Location = new Point(356, 0);
            Yon.Name = "Yon";
            Yon.Size = new Size(54, 31);
            Yon.TabIndex = 4;
            Yon.Text = "Yön";
            // 
            // Sagdaki
            // 
            Sagdaki.DropDownStyle = ComboBoxStyle.DropDownList;
            Sagdaki.FormattingEnabled = true;
            Sagdaki.Items.AddRange(new object[] { "Türk Lirası", "ABD Doları", "Euro", "İngiliz Sterlini", "İsviçre Frangı", "Japon Yeni", "Suudi Arabistan Riyali", "Norveç Kronu", "Danimarka Kronu", "Avustralya Doları", "Kanada Doları", "İsveç Kronu", "Ruble" });
            Sagdaki.Location = new Point(627, 47);
            Sagdaki.Name = "Sagdaki";
            Sagdaki.Size = new Size(144, 28);
            Sagdaki.TabIndex = 119;
            // 
            // Soldaki
            // 
            Soldaki.DropDownStyle = ComboBoxStyle.DropDownList;
            Soldaki.FormattingEnabled = true;
            Soldaki.Items.AddRange(new object[] { "Türk Lirası", "ABD Doları", "Euro", "İngiliz Sterlini", "İsviçre Frangı", "Japon Yeni", "Suudi Arabistan Riyali", "Norveç Kronu", "Danimarka Kronu", "Avustralya Doları", "Kanada Doları", "İsveç Kronu", "Ruble" });
            Soldaki.Location = new Point(169, 47);
            Soldaki.Name = "Soldaki";
            Soldaki.Size = new Size(151, 28);
            Soldaki.TabIndex = 120;
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label38.Location = new Point(627, 13);
            label38.Name = "label38";
            label38.Size = new Size(97, 31);
            label38.TabIndex = 121;
            label38.Text = "Karşılığı";
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label37.Location = new Point(169, 13);
            label37.Name = "label37";
            label37.Size = new Size(82, 31);
            label37.TabIndex = 122;
            label37.Text = "Miktar";
            // 
            // Miktar
            // 
            Miktar.Location = new Point(169, 81);
            Miktar.Name = "Miktar";
            Miktar.Size = new Size(151, 27);
            Miktar.TabIndex = 123;
            // 
            // panel14
            // 
            panel14.Controls.Add(Sonuc);
            panel14.Controls.Add(DonusturButonu);
            panel14.Controls.Add(Sagdaki);
            panel14.Controls.Add(Miktar);
            panel14.Controls.Add(Soldaki);
            panel14.Controls.Add(label37);
            panel14.Controls.Add(label38);
            panel14.Location = new Point(12, 556);
            panel14.Name = "panel14";
            panel14.Size = new Size(922, 142);
            panel14.TabIndex = 125;
            // 
            // ReferansResim
            // 
            ReferansResim.Image = (Image)resources.GetObject("ReferansResim.Image");
            ReferansResim.Location = new Point(356, 0);
            ReferansResim.Name = "ReferansResim";
            ReferansResim.Size = new Size(56, 34);
            ReferansResim.TabIndex = 131;
            ReferansResim.TabStop = false;
            // 
            // Sonuc
            // 
            Sonuc.AutoSize = true;
            Sonuc.Font = new Font("Segoe UI", 13F);
            Sonuc.Location = new Point(627, 81);
            Sonuc.Name = "Sonuc";
            Sonuc.Size = new Size(25, 30);
            Sonuc.TabIndex = 126;
            Sonuc.Text = "0";
            // 
            // DonusturButonu
            // 
            DonusturButonu.AutoSize = true;
            DonusturButonu.Font = new Font("Segoe UI", 13F);
            DonusturButonu.Image = (Image)resources.GetObject("DonusturButonu.Image");
            DonusturButonu.Location = new Point(452, 47);
            DonusturButonu.Name = "DonusturButonu";
            DonusturButonu.Size = new Size(56, 50);
            DonusturButonu.TabIndex = 125;
            DonusturButonu.UseVisualStyleBackColor = true;
            DonusturButonu.Click += Donustur_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 697);
            Controls.Add(panel14);
            Controls.Add(panel13);
            Controls.Add(panel12);
            Controls.Add(panel11);
            Controls.Add(panel10);
            Controls.Add(panel9);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel6);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Döviz Dönüştürücü";
            ((System.ComponentModel.ISupportInitialize)ABD).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ABDDolariYon).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EuroYon).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)IngilizSterliniYon).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)JaponYeniYon).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)IsvicreFrangiYon).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SuudiArabistanRiyaliYon).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NorvecKronuYon).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DanimarkaKronuYon).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AvustralyaDolariYon).EndInit();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)KanadaDolariYon).EndInit();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)IsvecKronuYon).EndInit();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)RubleYon).EndInit();
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ReferansResim).EndInit();
            ResumeLayout(false);

            DovizBilgileriniYaz();
        }

        #endregion

        private Label Adlar;
        private Label AlisFiyatlari;
        private Label Degisim;
        private Label SatisFiyatlari;

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private PictureBox ABD;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private PictureBox pictureBox11;
        private PictureBox pictureBox12;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel6;
        private Label label33;
        private Label label34;
        private Label label35;
        private Label label36;
        private Label label29;
        private Label label30;
        private Label label31;
        private Label label32;
        private Label label25;
        private Label label26;
        private Label label27;
        private Label label28;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Panel panel4;
        private Panel panel5;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private Panel panel10;
        private Panel panel11;
        private Panel panel12;
        private Panel panel13;
        private Label label49;
        private Label label50;
        private Label label51;
        private Label label52;
        private Label label53;
        private Label label54;
        private Label label55;
        private Label label56;
        private Label label57;
        private Label label58;
        private Label label60;
        private Label label59;
        private ComboBox Sagdaki;
        private ComboBox Soldaki;
        private Label label38;
        private Label label37;
        private TextBox Miktar;
        private Panel panel14;
        private Button DonusturButonu;
        private Label Sonuc;
        private PictureBox ABDDolariYon;
        private PictureBox EuroYon;
        private PictureBox IngilizSterliniYon;
        private PictureBox JaponYeniYon;
        private PictureBox IsvicreFrangiYon;
        private PictureBox SuudiArabistanRiyaliYon;
        private PictureBox NorvecKronuYon;
        private PictureBox DanimarkaKronuYon;
        private PictureBox AvustralyaDolariYon;
        private PictureBox KanadaDolariYon;
        private PictureBox RubleYon;
        private PictureBox IsvecKronuYon;
        private PictureBox ReferansResim;
        private Label Yon;
    }
}
