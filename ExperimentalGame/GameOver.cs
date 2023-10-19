using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExperimentalGame
{
    public partial class GameOver : Form
    {

        Player player = new();


        int finalFlapCount;
        int finalMoveCount;
        int finalScore;

        public GameOver()
        {
            InitializeComponent();
        }


        public int UpdateScore(int score)
        {
            return finalScore = score;
        }

        public int UpdateMoves(int moves)
        {
            return finalMoveCount = moves;
        }

        public int UpdateFlaps(int flaps)
        {
            return finalFlapCount = flaps;
        }

        public void UpdateGameOverLabels()
        {
            flapCountAmountLbl.Text = finalFlapCount.ToString();
            moveCountAmountLbl.Text = finalMoveCount.ToString();
            scoreAmountLbl.Text = finalScore.ToString();
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void quitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
