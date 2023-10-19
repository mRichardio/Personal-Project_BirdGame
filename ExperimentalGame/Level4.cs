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
    public partial class Level4 : Form
    {

        Player player = new();
        GameOver gameOver = new();


        Random rnd = new Random();


        // Obstacles
        PictureBox firstRocket = new PictureBox
        {

            Name = "obstacle",
            Size = new Size(60, 20),
            Location = new Point(753, 40),
            BackColor = Color.Red,
            Image = Image.FromFile("C:\\Users\\mathe\\Desktop\\ExperimentalGame\\ExperimentalGame\\Images\\rocketObstacle.jpg"),
        };


        PictureBox secondRocket = new PictureBox
        {
            Name = "obstacle",
            Size = new Size(60, 20),
            Location = new Point(753, 250),
            BackColor = Color.Red,
            Image = Image.FromFile("C:\\Users\\mathe\\Desktop\\ExperimentalGame\\ExperimentalGame\\Images\\rocketObstacle.jpg"),
        };

        PictureBox thirdRocket = new PictureBox
        {
            Name = "obstacle",
            Size = new Size(60, 20),
            Location = new Point(753, 250),
            BackColor = Color.Red,
            Image = Image.FromFile("C:\\Users\\mathe\\Desktop\\ExperimentalGame\\ExperimentalGame\\Images\\rocketObstacle.jpg"),
        };

        PictureBox fourthRocket = new PictureBox
        {
            Name = "obstacle",
            Size = new Size(60, 20),
            Location = new Point(753, 250),
            BackColor = Color.Red,
            Image = Image.FromFile("C:\\Users\\mathe\\Desktop\\ExperimentalGame\\ExperimentalGame\\Images\\rocketObstacle.jpg"),
        };


        PictureBox seedFood = new PictureBox // Need another obstacle idea
        {
            Name = "obstacle",
            Size = new Size(40, 20),
            Location = new Point(753, 150),
            BackColor = Color.Purple,
            Image = Image.FromFile("C:\\Users\\mathe\\Desktop\\ExperimentalGame\\ExperimentalGame\\Images\\seedFood.jpg"),
        };

        public Level4()
        {
            InitializeComponent();

            player.Reset();
            gameOverLbl.Hide();
        }

        private void Level4_KeyDown(object sender, KeyEventArgs e)
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
                    int firstStartingLocation = rnd.Next(15, 80);
                    int secondStartingLocation = rnd.Next(210, 250);
                    int thirdStartingLocation = rnd.Next(100, 190);
                    int fourthStartingLocation = rnd.Next(260, 310);

                    firstRocket.Location = new Point(753, firstStartingLocation);
                    secondRocket.Location = new Point(753, secondStartingLocation);
                    thirdRocket.Location = new Point(753, thirdStartingLocation);
                    fourthRocket.Location = new Point(753, fourthStartingLocation);

                    this.Controls.Add(firstRocket);
                    this.Controls.Add(secondRocket);
                    this.Controls.Add(thirdRocket);
                    this.Controls.Add(fourthRocket);
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



                int firstMoveSpeed = rnd.Next(38, 53);
                int secondMoveSpeed = rnd.Next(40, 48);
                int thirdMoveSpeed = rnd.Next(50, 55);
                int fourthMoveSpeed = rnd.Next(45, 57);

                firstRocket.Left -= firstMoveSpeed;
                secondRocket.Left -= secondMoveSpeed;
                thirdRocket.Left -= thirdMoveSpeed;
                fourthRocket.Left -= fourthMoveSpeed;
                seedFood.Left -= 20;

                if (playerBox.Bounds.IntersectsWith(firstRocket.Bounds))
                {
                    GameOver();
                }

                if (playerBox.Bounds.IntersectsWith(secondRocket.Bounds))
                {
                    GameOver();
                }

                if (playerBox.Bounds.IntersectsWith(thirdRocket.Bounds))
                {
                    GameOver();
                }

                if (playerBox.Bounds.IntersectsWith(fourthRocket.Bounds))
                {
                    GameOver();
                }

                if (playerBox.Bounds.IntersectsWith(seedFood.Bounds))
                {
                    player.ScoreAdd(150);
                    player.HungerAdd(20);

                    if (player.GetHunger() > 100)
                    {
                        player.SetHunger(100);
                    }
                }

                if (firstRocket.Left <= obstacleBoundary.Right)
                {
                    int firstLocation = rnd.Next(15, 80);
                    firstRocket.Location = new Point(753, firstLocation);
                }

                if (secondRocket.Left <= obstacleBoundary.Right)
                {
                    int secondLocation = rnd.Next(210, 250);
                    secondRocket.Location = new Point(753, secondLocation);
                }

                if (thirdRocket.Left <= obstacleBoundary.Right)
                {
                    int secondLocation = rnd.Next(100, 190);
                    thirdRocket.Location = new Point(753, secondLocation);
                }

                if (fourthRocket.Left <= obstacleBoundary.Right)
                {
                    int secondLocation = rnd.Next(260, 310);
                    fourthRocket.Location = new Point(753, secondLocation);
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
