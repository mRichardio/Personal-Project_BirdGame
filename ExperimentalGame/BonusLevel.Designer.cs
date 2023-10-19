namespace ExperimentalGame
{
    partial class BonusLevel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BonusLevel));
            groundBox = new PictureBox();
            obstacleBoundary = new PictureBox();
            playerBox = new PictureBox();
            scoreLblAmount = new Label();
            scoreLbl = new Label();
            pictureBox1 = new PictureBox();
            gameOverLbl = new Label();
            gravTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)groundBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)obstacleBoundary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groundBox
            // 
            groundBox.BackColor = Color.SpringGreen;
            groundBox.Location = new Point(0, 343);
            groundBox.Name = "groundBox";
            groundBox.Size = new Size(800, 25);
            groundBox.TabIndex = 17;
            groundBox.TabStop = false;
            // 
            // obstacleBoundary
            // 
            obstacleBoundary.BackColor = Color.Transparent;
            obstacleBoundary.Location = new Point(0, -1);
            obstacleBoundary.Name = "obstacleBoundary";
            obstacleBoundary.Size = new Size(259, 345);
            obstacleBoundary.TabIndex = 16;
            obstacleBoundary.TabStop = false;
            // 
            // playerBox
            // 
            playerBox.BackColor = Color.DodgerBlue;
            playerBox.BackgroundImage = (Image)resources.GetObject("playerBox.BackgroundImage");
            playerBox.Location = new Point(373, 214);
            playerBox.Name = "playerBox";
            playerBox.Size = new Size(54, 23);
            playerBox.TabIndex = 21;
            playerBox.TabStop = false;
            // 
            // scoreLblAmount
            // 
            scoreLblAmount.AutoSize = true;
            scoreLblAmount.BackColor = SystemColors.ButtonFace;
            scoreLblAmount.BorderStyle = BorderStyle.Fixed3D;
            scoreLblAmount.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            scoreLblAmount.Location = new Point(407, 387);
            scoreLblAmount.Name = "scoreLblAmount";
            scoreLblAmount.Padding = new Padding(5);
            scoreLblAmount.Size = new Size(37, 42);
            scoreLblAmount.TabIndex = 30;
            scoreLblAmount.Text = "0";
            // 
            // scoreLbl
            // 
            scoreLbl.AutoSize = true;
            scoreLbl.BackColor = SystemColors.ButtonFace;
            scoreLbl.BorderStyle = BorderStyle.Fixed3D;
            scoreLbl.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            scoreLbl.Location = new Point(332, 387);
            scoreLbl.Name = "scoreLbl";
            scoreLbl.Padding = new Padding(5);
            scoreLbl.Size = new Size(75, 42);
            scoreLbl.TabIndex = 29;
            scoreLbl.Text = "Flaps";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Sienna;
            pictureBox1.Location = new Point(0, 343);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 111);
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // gameOverLbl
            // 
            gameOverLbl.AutoSize = true;
            gameOverLbl.Font = new Font("Segoe UI", 32F, FontStyle.Bold, GraphicsUnit.Point);
            gameOverLbl.Location = new Point(265, 9);
            gameOverLbl.Name = "gameOverLbl";
            gameOverLbl.Size = new Size(272, 59);
            gameOverLbl.TabIndex = 31;
            gameOverLbl.Text = "Level Failed!";
            // 
            // gravTimer
            // 
            gravTimer.Enabled = true;
            gravTimer.Interval = 250;
            gravTimer.Tick += gravTimer_Tick;
            // 
            // BonusLevel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(obstacleBoundary);
            Controls.Add(gameOverLbl);
            Controls.Add(playerBox);
            Controls.Add(groundBox);
            Controls.Add(scoreLblAmount);
            Controls.Add(scoreLbl);
            Controls.Add(pictureBox1);
            Name = "BonusLevel";
            Text = "BonusLevel";
            KeyDown += BonusLevel_KeyDown;
            ((System.ComponentModel.ISupportInitialize)groundBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)obstacleBoundary).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox groundBox;
        private PictureBox obstacleBoundary;
        private PictureBox playerBox;
        private Label scoreLblAmount;
        private Label scoreLbl;
        private PictureBox pictureBox1;
        private Label gameOverLbl;
        private System.Windows.Forms.Timer gravTimer;
    }
}