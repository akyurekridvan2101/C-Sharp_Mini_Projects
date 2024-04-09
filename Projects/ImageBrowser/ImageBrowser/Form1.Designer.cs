namespace ImageBrowser
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
            AddImage = new Button();
            SuspendLayout();
            // 
            // AddImage
            // 
            AddImage.Location = new Point(454, 2);
            AddImage.Name = "AddImage";
            AddImage.Size = new Size(94, 588);
            AddImage.TabIndex = 0;
            AddImage.Text = "Add Image";
            AddImage.UseVisualStyleBackColor = true;
            AddImage.Click += AddImage_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 590);
            Controls.Add(AddImage);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button AddImage;
    }
}
