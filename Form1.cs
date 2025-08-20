using System;
using System.Drawing;
using System.Windows.Forms;

namespace cp_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = Color.Indigo; // Set background color to white

            // Create the 'Play' button with blue and white theme
            Button playButton = new Button
            {
                Text = "Play",
                Location = new System.Drawing.Point(200, 400), // Static position
                Size = new System.Drawing.Size(150, 75),
                BackColor = Color.DarkBlue,
                ForeColor = Color.White,
                Font = new Font("Times New Roman", 30, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat
            };

            Button closeButton = new Button
            {
                Text = "Close",
                Location = new System.Drawing.Point(900, 400), // Static position
                Size = new System.Drawing.Size(150, 75),
                BackColor = Color.DarkBlue,
                ForeColor = Color.White,
                Font = new Font("Times New Roman", 30, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat
            };
            
            // Add event handlers for the buttons
            playButton.Click += (s, e) => new Form2().Show();
            closeButton.Click += (s, e) => this.Close();

            // Add buttons to the form
            this.Controls.Add(playButton);
            this.Controls.Add(closeButton);
        }

    }
}
