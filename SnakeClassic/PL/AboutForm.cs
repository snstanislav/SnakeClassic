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
    public partial class AboutForm : Form
    {
        private const string AUTHOR_LINK = "https://github.com/snstanislav/";

        public AboutForm()
        {
            InitializeComponent();

            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;

            // Make the form non-resizable
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // Make the TextBox look like a label
            this.aboutTextBox.ReadOnly = true;
            this.aboutTextBox.TabStop = false;
            this.aboutTextBox.BorderStyle = BorderStyle.None;
            this.aboutTextBox.BackColor = this.BackColor;

            aboutTextBox.Text = $"Kharkiv National University of Radio Electronics, NURE ©\r\n\r\nv1.0 -- 2011\r\nv2.0 -- 07/2025 (Deep remastered)\r\n";       
        
        }

        private void aboutOkButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Makes the link clickable
            System.Diagnostics.Process.Start(AUTHOR_LINK);
        }
    }
}
