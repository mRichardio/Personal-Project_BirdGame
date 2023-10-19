using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace ExperimentalGame
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            levelsGrpBx.Hide();
        }

        private void levelToggleBtn_Click(object sender, EventArgs e)
        {
            if (levelsGrpBx.Visible)
            {
                levelsGrpBx.Visible = false;
            }
            else { levelsGrpBx.Visible = true; }
        }

        private void quitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void levelOneBtn_Click(object sender, EventArgs e)
        {
            Level1 l1 = new Level1();
            l1.ShowDialog();
        }

        private void LevelTwoBtn_Click(object sender, EventArgs e)
        {
            Level2 l2 = new Level2();
            l2.ShowDialog();
        }

        private void LevelThreeBtn_Click(object sender, EventArgs e)
        {
            Level3 l3 = new Level3();
            l3.ShowDialog();
        }

        private void LevelFourBtn_Click(object sender, EventArgs e)
        {
            Level4 l4 = new Level4();
            l4.ShowDialog();
        }

        private void bonusBtn_Click(object sender, EventArgs e)
        {
            BonusLevel bl = new BonusLevel();
            bl.ShowDialog();
        }
    }
}
