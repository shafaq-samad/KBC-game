using System;
using System.Drawing;
using System.Windows.Forms;

namespace cp_project
{
    public partial class Form3 : Form
    {
        public Form3(int finalScore)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.Text = "Kaun Banega Crorepati - Final Score";
            this.BackColor = Color.White; // Set background color to white

            // Create a label to display the final score
            Label scoreLabel = new Label
            {
                Text = $"YOUR SCORE IS {finalScore}",
                Location = new System.Drawing.Point(50, 50),
                Size = new System.Drawing.Size(300, 150),
                BackColor = Color.DarkBlue,
                ForeColor = Color.White,
                Font = new Font("Arial", 15, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter // Center the text in the label
            };

            Button closeButton = new Button
            {
                Text = "Close",
                Location = new System.Drawing.Point(100, 400),
                Size = new System.Drawing.Size(150, 100),
                BackColor = Color.DarkBlue,
                ForeColor = Color.White,
                Font = new Font("Times New Roman", 20, FontStyle.Bold), // Bold text style
                FlatStyle = FlatStyle.Flat, // Flat style for a modern look
            };
            Button RetryButton = new Button
            {
                Text = "Retry",
                Location = new System.Drawing.Point(300, 400),
                Size = new System.Drawing.Size(150, 100),
                BackColor = Color.DarkBlue,
                ForeColor = Color.White,
                Font = new Font("Times New Roman", 20, FontStyle.Bold), // Bold text style
                FlatStyle = FlatStyle.Flat, // Flat style for a modern look
            };
            // Close button click event
            closeButton.Click += (s, e) => this.Close();
            RetryButton.Click += (s, e) => new Form2().Show();
            // Add controls to the form
            this.Controls.Add(scoreLabel);
            this.Controls.Add(closeButton);
            this.Controls.Add(RetryButton);
        }
    }
}