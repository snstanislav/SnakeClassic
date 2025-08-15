using SnakeClassic.PL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeClassic
{
    /// <summary>
    /// Represents the main form of the Snake Classic application.
    /// </summary>
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Opens the game form when the "Start Game" button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainStartButton_Click(object sender, EventArgs e)
        {
            GameForm gameForm = new GameForm();
            gameForm.ShowDialog();
        }

        /// <summary>
        /// Opens the tutorial form when the "Tutorial" button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainTutorialButton_Click(object sender, EventArgs e)
        {
            TutorialForm tutorialForm = new TutorialForm();
            tutorialForm.Show();
        }

        /// <summary>
        /// Opens the "About" dialog when the main picture box is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainPictureBox_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        /// <summary>
        /// Opens the game form when the "Game" menu item is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameForm gameForm = new GameForm();
            gameForm.Show();
        }

        /// <summary>
        /// Opens the tutorial form when the "Tutorial" menu item is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tutorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TutorialForm tutorialForm = new TutorialForm();
            tutorialForm.Show();
        }

        /// <summary>
        /// Opens the "About" dialog when the "About" menu item is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        /// <summary>
        /// Performs an exit operation when the "Exit" menu item is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
