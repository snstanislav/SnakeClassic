using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeClassic.PL
{
    /// <summary>
    /// Represents an "About" dialog form that displays general application information.
    /// </summary>
    public partial class AboutForm : Form
    {
        /// <summary>
        /// Represents the URL to the author's GitHub profile.
        /// </summary>
        private const string AUTHOR_LINK = "https://github.com/snstanislav/";

        /// <summary>
        /// Initializes properties of the <see cref="AboutForm"/>.
        /// Assigns the information about the apllication to the aboutTextBox.
        /// </summary>
        public AboutForm()
        {
            InitializeComponent();

            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.aboutTextBox.ReadOnly = true;
            this.aboutTextBox.TabStop = false;
            this.aboutTextBox.BorderStyle = BorderStyle.None;
            this.aboutTextBox.BackColor = this.BackColor;

            aboutTextBox.Text = $"Kharkiv National University of Radio Electronics, NURE ©\r\n\r\nv1.0 -- 2011\r\nv2.0 -- 07/2025 (Deep remastered)\r\n";
        }

        /// <summary>
        /// Closes the "About" dialog when the OK button is clicked.
        /// </summary>
        private void aboutOkButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Opens the author's GitHub profile when clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(AUTHOR_LINK);
        }
    }
}
