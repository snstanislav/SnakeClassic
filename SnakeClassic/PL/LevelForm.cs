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
    public partial class LevelForm : Form
    {
        public const string LEVEL_1 = "1";
        public const string LEVEL_2 = "2";
        public const string LEVEL_3 = "3";
        public const string LEVEL_4 = "4";
        public const string LEVEL_5 = "5";
        public const string LEVEL_6 = "6";

        public LevelForm()
        {
            InitializeComponent();
        }

        public string SelectedLevel { get; private set; }
        private void levelConformButton_Click(object sender, EventArgs e)
        {
            if (levelRadioButton1.Checked)
            {
                this.SelectedLevel = LEVEL_1;
            }
            else if (levelRadioButton2.Checked)
            {
                this.SelectedLevel = LEVEL_2;
            }
            else if (levelRadioButton3.Checked)
            {
                this.SelectedLevel = LEVEL_3;
            }
            else if (levelRadioButton4.Checked)
            {
                this.SelectedLevel = LEVEL_4;
            }
            else if (levelRadioButton5.Checked)
            {
                this.SelectedLevel = LEVEL_5;
            }
            else if (levelRadioButton6.Checked)
            {
                this.SelectedLevel = LEVEL_6;
            }
            Close();
        }
    }
}
