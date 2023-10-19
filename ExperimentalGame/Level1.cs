using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace ExperimentalGame
{
    public partial class Level1 : Form
    {
        // ADD ARTWORK
        // BALANCING/MAKE MORE FUN // ADD GAME OVER STATE IN TIMER FOR WHEN PLAYER RUNS OUT OF HUNGER <------
        // THEN BUILD IT AND EXPORT AS A PACKAGED GAME!

        Player player = new();
        GameOver gameOver = new();


        Random rnd = new Random();


        // Obstacles
        PictureBox firstBird = new PictureBox
        {

            Name = "obstacle",
            Size = new Size(60, 30),
            Location = new Point(753, 40),
            BackColor = Color.Red,
            Image = Image.FromFile("C:\\Users\\mathe\\Desktop\\ExperimentalGame\\ExperimentalGame\\Images\\birdObstacle.jpg"), // Prob will need a better method for this?
        };


        PictureBox secondBird = new PictureBox
        {
            Name = "obstacle",
            Size = new Size(60, 30),
            Location = new Point(753, 250),
            BackColor = Color.Red,
            Image = Image.FromFile("C:\\Users\\mathe\\Desktop\\ExperimentalGame\\ExperimentalGame\\Images\\birdObstacle.jpg"),
        };

        PictureBox thirdBird = new PictureBox
        {
            Name = "obstacle",
            Size = new Size(60, 30),
            Location = new Point(753, 150),
            BackColor = Color.Red,
            Image = Image.FromFile("C:\\Users\\mathe\\Desktop\\ExperimentalGame\\ExperimentalGame\\Images\\birdObstacle.jpg"),
        };


        PictureBox seedFood = new PictureBox // Need another obstacle idea
        {
            Name = "obstacle",
            Size = new Size(40, 20),
            Location = new Point(753, 150),
            BackColor = Color.Purple,
            Image = Image.FromFile("C:\\Users\\mathe\\Desktop\\ExperimentalGame\\ExperimentalGame\\Images\\seedFood.jpg"),
        };


        public Level1()
        {
            InitializeComponent();

            player.Reset();
            gameOverLbl.Hide();
        }


        // Program Events

        private void Level1_KeyDown(object sender, KeyEventArgs e)
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
                    int secondStartingLocation = rnd.Next(215, 300);
                    int thirdStartingLocation = rnd.Next(100, 190);

                    firstBird.Location = new Point(753, firstStartingLocation);
                    secondBird.Location = new Point(753, secondStartingLocation);
                    thirdBird.Location = new Point(753, thirdStartingLocation);

                    this.Controls.Add(firstBird);
                    this.Controls.Add(secondBird);
                    this.Controls.Add(thirdBird);
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


        private void gravity_Tick(object sender, EventArgs e)
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


                int firstMoveSpeed = rnd.Next(17, 30);
                int secondMoveSpeed = rnd.Next(20, 35);
                int thirdMoveSpeed = rnd.Next(25, 40);

                firstBird.Left -= firstMoveSpeed;
                secondBird.Left -= secondMoveSpeed;
                thirdBird.Left -= thirdMoveSpeed;
                seedFood.Left -= 20;

                if (playerBox.Bounds.IntersectsWith(firstBird.Bounds))
                {
                    GameOver();
                }

                if (playerBox.Bounds.IntersectsWith(secondBird.Bounds))
                {
                    GameOver();
                }

                if (playerBox.Bounds.IntersectsWith(thirdBird.Bounds))
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

                if (firstBird.Left <= obstacleBoundary.Right)
                {
                    int firstLocation = rnd.Next(15, 80);
                    firstBird.Location = new Point(753, firstLocation);
                }

                if (secondBird.Left <= obstacleBoundary.Right)
                {
                    int secondLocation = rnd.Next(215, 275);
                    secondBird.Location = new Point(753, secondLocation);
                }

                if (thirdBird.Left <= obstacleBoundary.Right)
                {
                    int thirdLocation = rnd.Next(100, 190);
                    thirdBird.Location = new Point(753, thirdLocation);
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


        private void Level1_Load(object sender, EventArgs e)
        {

        }

    }
}