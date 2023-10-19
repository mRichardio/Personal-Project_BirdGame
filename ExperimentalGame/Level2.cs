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
    public partial class Level2 : Form
    {

        Player player = new();
        GameOver gameOver = new();


        Random rnd = new Random();


        // Obstacles
        PictureBox firstRock = new PictureBox
        {

            Name = "obstacle",
            Size = new Size(80, 80),
            Location = new Point(753, 40),
            BackColor = Color.Red,
            Image = Image.FromFile("C:\\Users\\mathe\\Desktop\\ExperimentalGame\\ExperimentalGame\\Images\\rockObstacle.jpg"),
        };


        PictureBox secondRock = new PictureBox
        {
            Name = "obstacle",
            Size = new Size(80, 80),
            Location = new Point(753, 250),
            BackColor = Color.Red,
            Image = Image.FromFile("C:\\Users\\mathe\\Desktop\\ExperimentalGame\\ExperimentalGame\\Images\\rockObstacle.jpg"),
        };


        PictureBox seedFood = new PictureBox // Need another obstacle idea
        {
            Name = "obstacle",
            Size = new Size(40, 20),
            Location = new Point(753, 150),
            BackColor = Color.Purple,
            Image = Image.FromFile("C:\\Users\\mathe\\Desktop\\ExperimentalGame\\ExperimentalGame\\Images\\seedFood.jpg"),
        };


        public Level2()
        {
            InitializeComponent();

            player.Reset();
            gameOverLbl.Hide();
        }


        private void gravTimer_Tick(object sender, EventArgs e)
        {
            hungerLblAmount.Text = player.GetHunger().ToString();
            scoreLblAmount.Text = player.GetScore().ToString();

            if (playerBox.Bottom >= groundBox.Top)
            {
                Gravity(0);
                GameOver();
            }
            else
            {
                Gravity(15);



                int firstMoveSpeed = rnd.Next(32, 47);
                int secondMoveSpeed = rnd.Next(25, 40);
                //int thirdMoveSpeed = rnd.Next(30, 45);

                firstRock.Left -= firstMoveSpeed;
                secondRock.Left -= secondMoveSpeed;
                //thirdRock.Left -= thirdMoveSpeed;
                seedFood.Left -= 20;

                if (playerBox.Bounds.IntersectsWith(firstRock.Bounds))
                {
                    GameOver();
                }

                if (playerBox.Bounds.IntersectsWith(secondRock.Bounds))
                {
                    GameOver();
                }

                //if (playerBox.Bounds.IntersectsWith(thirdRock.Bounds))
                //{
                //    GameOver();
                //}

                if (playerBox.Bounds.IntersectsWith(seedFood.Bounds))
                {
                    player.ScoreAdd(150);
                    player.HungerAdd(20);

                    if (player.GetHunger() > 100)
                    {
                        player.SetHunger(100);
                    }
                }

                if (firstRock.Left <= obstacleBoundary.Right)
                {
                    int firstLocation = rnd.Next(60, 100);
                    firstRock.Location = new Point(753, firstLocation);
                }


                if (secondRock.Left <= obstacleBoundary.Right)
                {
                    int secondLocation = rnd.Next(222, 252);
                    secondRock.Location = new Point(753, secondLocation);
                }

                if (seedFood.Left <= obstacleBoundary.Right || seedFood.Bounds.IntersectsWith(playerBox.Bounds))
                {
                    int seedLocation = rnd.Next(30, 300);
                    seedFood.Location = new Point(753, seedLocation);
                }

                if (player.GetHunger() <= 0)
                {
                    GameOver();
                }
            }
        }

        private void Level2_KeyDown(object sender, KeyEventArgs e)
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
                hungerLblAmount.Text = player.GetHunger().ToString();

                player.ScoreAdd(1);
                scoreLblAmount.Text = player.GetScore().ToString();

                player.FlapAdd(1);

                if (player.GetScore() == 1)
                {
                    int firstStartingLocation = rnd.Next(60, 100);
                    int secondStartingLocation = rnd.Next(222, 252);

                    firstRock.Location = new Point(753, firstStartingLocation);
                    secondRock.Location = new Point(753, secondStartingLocation);

                    this.Controls.Add(firstRock);
                    this.Controls.Add(secondRock);
                    this.Controls.Add(seedFood);
                }
            }

            if (e.KeyCode == Keys.Left)
            {
                MoveBackward(20);
                player.MoveAdd(1);

                int moveHunger = rnd.Next(1, 2);
                player.HungerMinus(moveHunger);

                if (playerBox.Left < 257)
                {
                    playerBox.Location = new Point(257, playerBox.Location.Y);
                }
            }

            if (e.KeyCode == Keys.Right)
            {
                MoveForward(20);
                player.MoveAdd(1);

                int moveHunger = rnd.Next(1, 2);
                player.HungerMinus(moveHunger);

                if (playerBox.Right > 753)
                {
                    playerBox.Location = new Point(753, playerBox.Location.Y);
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
