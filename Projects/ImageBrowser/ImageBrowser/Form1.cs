using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ImageBrowser
{
    public partial class Form1 : Form
    {
        List<PictureBox> imageBoxes; // List to hold PictureBox objects

        public Form1()
        {
            InitializeComponent();
            imageBoxes = new List<PictureBox>(); // Initialize the list to hold PictureBox objects
        }

        private void AddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "My Image Browser"; // Title of the open file dialog
            openFile.Filter = "Images (*.PNG;*.BMP;*.JPG;*.GIF)|*.PNG;*.BMP;*.JPG;*.GIF|All files (*.*)|*.*"; // Set allowed file types
            openFile.Multiselect = true; // Enable multiple file selection
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                foreach (string filename in openFile.FileNames)
                {
                    PictureBox pictureBox = new PictureBox(); // Create a new PictureBox object
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom; // Fit the image into PictureBox
                    pictureBox.Size = new Size(100, 100); // Set the size of PictureBox

                    int horizontalDistance = (imageBoxes.Count % 4 + 1) * 10 + (imageBoxes.Count % 4) * 100; // Calculate x coordinate of PictureBox
                    int verticalDistance = (imageBoxes.Count / 4) * (100 + 10); // Calculate y coordinate of PictureBox

                    pictureBox.Location = new Point(horizontalDistance, verticalDistance); // Set the location of PictureBox

                    pictureBox.ImageLocation = filename;
                    pictureBox.Visible = true; // Make PictureBox visible

                    imageBoxes.Add(pictureBox); // Add the created PictureBox object to our list
                    Controls.Add(pictureBox); // Add PictureBox to the form
                }
            }
        }
    }
}
