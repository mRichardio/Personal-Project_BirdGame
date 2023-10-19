namespace ExperimentalGame
{
    partial class Level2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Level2));
            obstacleBoundary = new PictureBox();
            groundBox = new PictureBox();
            gameOverLbl = new Label();
            gravTimer = new System.Windows.Forms.Timer(components);
            playerBox = new PictureBox();
            scoreLblAmount = new Label();
            scoreLbl = new Label();
            hungerLblAmount = new Label();
            hungerLbl = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)obstacleBoundary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groundBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // obstacleBoundary
            // 
            obstacleBoundary.BackColor = SystemColors.ControlDarkDark;
            obstacleBoundary.Location = new Point(-1, -1);
            obstacleBoundary.Name = "obstacleBoundary";
            obstacleBoundary.Size = new Size(259, 353);
            obstacleBoundary.TabIndex = 14;
            obstacleBoundary.TabStop = false;
            // 
            // groundBox
            // 
            groundBox.BackColor = Color.Crimson;
            groundBox.Location = new Point(-1, 341);
            groundBox.Name = "groundBox";
            groundBox.Size = new Size(800, 11);
            groundBox.TabIndex = 15;
            groundBox.TabStop = false;
            // 
            // gameOverLbl
            // 
            gameOverLbl.AutoSize = true;
            gameOverLbl.Font = new Font("Segoe UI", 32F, FontStyle.Bold, GraphicsUnit.Point);
            gameOverLbl.Location = new Point(265, 19);
            gameOverLbl.Name = "gameOverLbl";
            gameOverLbl.Size = new Size(272, 59);
            gameOverLbl.TabIndex = 19;
            gameOverLbl.Text = "Level Failed!";
            // 
            // gravTimer
            // 
            gravTimer.Enabled = true;
            gravTimer.Interval = 250;
            gravTimer.Tick += gravTimer_Tick;
            // 
            // playerBox
            // 
            playerBox.BackColor = Color.DodgerBlue;
            playerBox.BackgroundImage = (Image)resources.GetObject("playerBox.BackgroundImage");
            playerBox.Location = new Point(373, 214);
            playerBox.Name = "playerBox";
            playerBox.Size = new Size(54, 23);
            playerBox.TabIndex = 20;
            playerBox.TabStop = false;
            // 
            // scoreLblAmount
            // 
            scoreLblAmount.AutoSize = true;
            scoreLblAmount.BackColor = SystemColors.ControlDarkDark;
            scoreLblAmount.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            scoreLblAmount.Location = new Point(720, 391);
            scoreLblAmount.Name = "scoreLblAmount";
            scoreLblAmount.Size = new Size(25, 30);
            scoreLblAmount.TabIndex = 25;
            scoreLblAmount.Text = "0";
            // 
            // scoreLbl
            // 
            scoreLbl.AutoSize = true;
            scoreLbl.BackColor = SystemColors.ControlDarkDark;
            scoreLbl.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            scoreLbl.Location = new Point(641, 391);
            scoreLbl.Name = "scoreLbl";
            scoreLbl.Size = new Size(73, 30);
            scoreLbl.TabIndex = 24;
            scoreLbl.Text = "Score:";
            // 
            // hungerLblAmount
            // 
            hungerLblAmount.AutoSize = true;
            hungerLblAmount.BackColor = SystemColors.ControlDarkDark;
            hungerLblAmount.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            hungerLblAmount.Location = new Point(139, 391);
            hungerLblAmount.Name = "hungerLblAmount";
            hungerLblAmount.Size = new Size(25, 30);
            hungerLblAmount.TabIndex = 22;
            hungerLblAmount.Text = "0";
            // 
            // hungerLbl
            // 
            hungerLbl.AutoSize = true;
            hungerLbl.BackColor = SystemColors.ControlDarkDark;
            hungerLbl.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            hungerLbl.Location = new Point(39, 391);
            hungerLbl.Name = "hungerLbl";
            hungerLbl.Size = new Size(94, 30);
            hungerLbl.TabIndex = 21;
            hungerLbl.Text = "Hunger:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlDarkDark;
            pictureBox1.Location = new Point(0, 341);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 111);
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // Level2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(800, 450);
            Controls.Add(obstacleBoundary);
            Controls.Add(playerBox);
            Controls.Add(gameOverLbl);
            Controls.Add(groundBox);
            Controls.Add(scoreLblAmount);
            Controls.Add(scoreLbl);
            Controls.Add(hungerLblAmount);
            Controls.Add(hungerLbl);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Level2";
            Text = "Level2";
            KeyDown += Level2_KeyDown;
            ((System.ComponentModel.ISupportInitialize)obstacleBoundary).EndInit();
            ((System.ComponentModel.ISupportInitialize)groundBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox obstacleBoundary;
        private PictureBox groundBox;
        private Label gameOverLbl;
        private System.Windows.Forms.Timer gravTimer;
        private PictureBox playerBox;
        private Label scoreLblAmount;
        private Label scoreLbl;
        private Label hungerLblAmount;
        private Label hungerLbl;
        private PictureBox pictureBox1;
    }
}