using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DifficultySettings
{
    public partial class Form1 : Form
    {
        string heroName = "hero";
        string difficulty;

        public Form1()
        {
            InitializeComponent();
        }

        private void EasyButton_Click(object sender, EventArgs e)
        {
            easyButton.BackColor = Color.Lime;
            mediumButton.BackColor = Color.Black;
            hardButton.BackColor = Color.Black;
            difficulty = "easy";
        }

        private void MediumButton_Click(object sender, EventArgs e)
        {
            mediumButton.BackColor = Color.Orange;
            easyButton.BackColor = Color.Black;
            hardButton.BackColor = Color.Black;
            difficulty = "medium";
        }

        private void HardButton_Click(object sender, EventArgs e)
        {
            hardButton.BackColor = Color.Red;
            mediumButton.BackColor = Color.Black;
            easyButton.BackColor = Color.Black;
            difficulty = "hard";
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            heroName = nameInput.Text;
            outputLabel.Visible = true;
            outputLabel.Text = $"Venture forth on the {difficulty} path, hero {heroName}. . .";
        }
    }
}
