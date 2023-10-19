using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExperimentalGame
{
    public partial class BonusLevel : Form
    {

        Player player = new();
        GameOver gameOver = new();


        Random rnd = new Random();


        // Obstacles
        PictureBox topPipeA = new PictureBox
        {
            Name = "obstacle",
            Size = new Size(40, 60),
            Location = new Point(753, 10),
            BackColor = Color.DarkGreen,
            //Image = Image.FromFile("hello.jpg"),
        };
        PictureBox bottomPipeA = new PictureBox
        {
            Name = "obstacle",
            Size = new Size(40, 60),
            Location = new Point(753, 300),
            BackColor = Color.DarkGreen,
            //Image = Image.FromFile("hello.jpg"),
        };

        PictureBox topPipeB = new PictureBox
        {
            Name = "topPipeB",
            Size = new Size(40, 60),
            Location = new Point(753, 10),
            BackColor = Color.DarkGreen,
            //Image = Image.FromFile("hello.jpg"),
        };
        PictureBox bottomPipeB = new PictureBox
        {
            Name = "bottomPipeB",
            Size = new Size(40, 60),
            Location = new Point(753, 300),
            BackColor = Color.DarkGreen,
            //Image = Image.FromFile("hello.jpg"),
        };


        PictureBox topPipeC = new PictureBox
        {
            Name = "topPipeC",
            Size = new Size(40, 60),
            Location = new Point(753, 10),
            BackColor = Color.DarkGreen,
            //Image = Image.FromFile("hello.jpg"),
        };
        PictureBox bottomPipeC = new PictureBox
        {
            Name = "bottomPipeC",
            Size = new Size(40, 60),
            Location = new Point(753, 300),
            BackColor = Color.DarkGreen,
            //Image = Image.FromFile("hello.jpg"),
        };


        public BonusLevel()
        {
            InitializeComponent();

            player.Reset();
            gameOverLbl.Hide();
        }

        private void gravTimer_Tick(object sender, EventArgs e)
        {

            scoreLblAmount.Text = player.GetScore().ToString();

            if (playerBox.Bottom >= groundBox.Top)
            {
                Gravity(0);
                GameOver();
            }
            else
            {
                Gravity(15);

                topPipeA.Left -= 30;
                bottomPipeA.Left -= 30;

                topPipeB.Left -= 30;
                bottomPipeB.Left -= 30;

                topPipeC.Left -= 30;
                bottomPipeC.Left -= 30;


                if (playerBox.Bounds.IntersectsWith(topPipeA.Bounds))
                {
                    GameOver();
                }
                if (playerBox.Bounds.IntersectsWith(bottomPipeA.Bounds))
                {
                    GameOver();
                }

                if (playerBox.Bounds.IntersectsWith(topPipeB.Bounds))
                {
                    GameOver();
                }
                if (playerBox.Bounds.IntersectsWith(bottomPipeB.Bounds))
                {
                    GameOver();
                }

                if (playerBox.Bounds.IntersectsWith(topPipeC.Bounds))
                {
                    GameOver();
                }
                if (playerBox.Bounds.IntersectsWith(bottomPipeC.Bounds))
                {
                    GameOver();
                }


                if (topPipeA.Left <= obstacleBoundary.Right)
                {
                    int topSize = rnd.Next(150, 225);
                    topPipeA.Location = new Point(753, 10);
                    topPipeA.Size = new Size(40, topSize);
                }
                if (bottomPipeA.Left <= obstacleBoundary.Right)
                {
                    int bottomSize = rnd.Next(150, 225);
                    bottomPipeA.Location = new Point(753, 300);
                    bottomPipeA.Size = new Size(40, bottomSize);
                }

                if (topPipeB.Left <= obstacleBoundary.Right)
                {
                    int topSize = rnd.Next(150, 225);
                    topPipeB.Location = new Point(753, 10);
                    topPipeB.Size = new Size(40, topSize);
                }
                if (bottomPipeB.Left <= obstacleBoundary.Right)
                {
                    int bottomSize = rnd.Next(150, 225);
                    bottomPipeB.Location = new Point(753, 300);
                    bottomPipeB.Size = new Size(40, bottomSize);
                }

                if (topPipeC.Left <= obstacleBoundary.Right)
                {
                    int topSize = rnd.Next(150, 225);
                    topPipeC.Location = new Point(753, 10);
                    topPipeC.Size = new Size(40, topSize);
                }
                if (bottomPipeC.Left <= obstacleBoundary.Right)
                {
                    int bottomSize = rnd.Next(150, 225);
                    bottomPipeC.Location = new Point(753, 300);
                    bottomPipeC.Size = new Size(40, bottomSize);


                }
            }
        }

        private async void BonusLevel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space || e.KeyCode == Keys.Up)
            {
                flap(35);

                if (playerBox.Top < 0)
                {
                    playerBox.Location = new Point(playerBox.Location.X, 0);
                }

                int hunger = rnd.Next(2, 4);

                player.HungerMinus(hunger);

                player.ScoreAdd(1);
                scoreLblAmount.Text = player.GetScore().ToString();

                player.FlapAdd(1);

                if (player.GetScore() == 1)
                {
                    int topSize = rnd.Next(125, 235);
                    int bottomSize = rnd.Next(156, 205);
                    topPipeA.Location = new Point(753, 10);
                    bottomPipeA.Location = new Point(753, 300);
                    topPipeA.Size = new Size(40, topSize);
                    bottomPipeA.Size = new Size(40, bottomSize);

                    this.Controls.Add(topPipeA);
                    this.Controls.Add(bottomPipeA);
                }
                if (topPipeA.Location.X < 550 && !this.Controls.ContainsKey("topPipeB"))
                {
                    int topSize = rnd.Next(125, 235);
                    int bottomSize = rnd.Next(156, 205);
                    topPipeB.Location = new Point(753, 10);
                    bottomPipeB.Location = new Point(753, 300);
                    topPipeB.Size = new Size(40, topSize);
                    bottomPipeB.Size = new Size(40, bottomSize);

                    this.Controls.Add(topPipeB);
                    this.Controls.Add(bottomPipeB);
                }
                if (topPipeA.Location.X < 340 && !this.Controls.ContainsKey("topPipeC"))
                {
                    int topSize = rnd.Next(125, 235);
                    int bottomSize = rnd.Next(156, 205);
                    topPipeC.Location = new Point(753, 10);
                    bottomPipeC.Location = new Point(753, 300);
                    topPipeC.Size = new Size(40, topSize);
                    bottomPipeC.Size = new Size(40, bottomSize);

                    this.Controls.Add(topPipeC);
                    this.Controls.Add(bottomPipeC);
                }
            }
        }

        // Main Functions

        public void MoveForward(int moveAmount)
        {
            int newX = playerBox.Location.X;
            newX += moveAmount;

            playerBox.Location = new Point(newX, playerBox.Location.Y);
        }


        public void MoveBackward(int moveAmount)
        {
            int newX = playerBox.Location.X;
            newX -= moveAmount;

            playerBox.Location = new Point(newX, playerBox.Location.Y);
        }


        public void flap(int flapAmount)
        {
            int newY = playerBox.Location.Y;
            newY -= flapAmount;

            playerBox.Location = new Point(playerBox.Location.X, newY);
        }


        public void Gravity(int gravAmount)
        {
            int newY = playerBox.Location.Y;
            newY += gravAmount;

            playerBox.Location = new Point(playerBox.Location.X, newY);
        }


        public void GameOver()
        {
            gravTimer.Stop();
            gameOverLbl.Show();

            int finalScore = player.GetScore();
            int finalFlapCount = player.GetFlapCount();
            int finalMoveCount = player.GetMoveCount();

            gameOver.UpdateScore(finalScore);
            gameOver.UpdateFlaps(finalFlapCount);
            gameOver.UpdateMoves(finalMoveCount);

            gameOver.UpdateGameOverLabels();
            gameOver.ShowDialog();

            Close();
        }
    }
}
