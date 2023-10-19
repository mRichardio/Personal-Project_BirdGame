namespace ExperimentalGame
{
    partial class Level1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Level1));
            gravTimer = new System.Windows.Forms.Timer(components);
            groundBox = new PictureBox();
            gameOverLbl = new Label();
            obstacleBoundary = new PictureBox();
            playerBox = new PictureBox();
            hungerLbl = new Label();
            hungerLblAmount = new Label();
            pictureBox1 = new PictureBox();
            scoreLblAmount = new Label();
            scoreLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)groundBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)obstacleBoundary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // gravTimer
            // 
            gravTimer.Enabled = true;
            gravTimer.Interval = 250;
            gravTimer.Tick += gravity_Tick;
            // 
            // groundBox
            // 
            groundBox.BackColor = Color.Crimson;
            groundBox.Location = new Point(-1, 341);
            groundBox.Name = "groundBox";
            groundBox.Size = new Size(800, 11);
            groundBox.TabIndex = 3;
            groundBox.TabStop = false;
            // 
            // gameOverLbl
            // 
            gameOverLbl.AutoSize = true;
            gameOverLbl.Font = new Font("Segoe UI", 32F, FontStyle.Bold, GraphicsUnit.Point);
            gameOverLbl.Location = new Point(265, 19);
            gameOverLbl.Name = "gameOverLbl";
            gameOverLbl.Size = new Size(272, 59);
            gameOverLbl.TabIndex = 4;
            gameOverLbl.Text = "Level Failed!";
            // 
            // obstacleBoundary
            // 
            obstacleBoundary.BackColor = SystemColors.ControlDarkDark;
            obstacleBoundary.BorderStyle = BorderStyle.FixedSingle;
            obstacleBoundary.Location = new Point(-1, -1);
            obstacleBoundary.Name = "obstacleBoundary";
            obstacleBoundary.Size = new Size(259, 353);
            obstacleBoundary.TabIndex = 13;
            obstacleBoundary.TabStop = false;
            // 
            // playerBox
            // 
            playerBox.BackColor = Color.DodgerBlue;
            playerBox.BackgroundImage = (Image)resources.GetObject("playerBox.BackgroundImage");
            playerBox.Location = new Point(373, 214);
            playerBox.Name = "playerBox";
            playerBox.Size = new Size(54, 23);
            playerBox.TabIndex = 14;
            playerBox.TabStop = false;
            // 
            // hungerLbl
            // 
            hungerLbl.AutoSize = true;
            hungerLbl.BackColor = SystemColors.ControlDarkDark;
            hungerLbl.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            hungerLbl.Location = new Point(38, 391);
            hungerLbl.Name = "hungerLbl";
            hungerLbl.Size = new Size(94, 30);
            hungerLbl.TabIndex = 15;
            hungerLbl.Text = "Hunger:";
            // 
            // hungerLblAmount
            // 
            hungerLblAmount.AutoSize = true;
            hungerLblAmount.BackColor = SystemColors.ControlDarkDark;
            hungerLblAmount.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            hungerLblAmount.Location = new Point(138, 391);
            hungerLblAmount.Name = "hungerLblAmount";
            hungerLblAmount.Size = new Size(25, 30);
            hungerLblAmount.TabIndex = 16;
            hungerLblAmount.Text = "0";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlDarkDark;
            pictureBox1.Location = new Point(-1, 341);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 111);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // scoreLblAmount
            // 
            scoreLblAmount.AutoSize = true;
            scoreLblAmount.BackColor = SystemColors.ControlDarkDark;
            scoreLblAmount.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            scoreLblAmount.Location = new Point(719, 391);
            scoreLblAmount.Name = "scoreLblAmount";
            scoreLblAmount.Size = new Size(25, 30);
            scoreLblAmount.TabIndex = 19;
            scoreLblAmount.Text = "0";
            // 
            // scoreLbl
            // 
            scoreLbl.AutoSize = true;
            scoreLbl.BackColor = SystemColors.ControlDarkDark;
            scoreLbl.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            scoreLbl.Location = new Point(640, 391);
            scoreLbl.Name = "scoreLbl";
            scoreLbl.Size = new Size(73, 30);
            scoreLbl.TabIndex = 18;
            scoreLbl.Text = "Score:";
            // 
            // Level1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(800, 450);
            Controls.Add(scoreLblAmount);
            Controls.Add(scoreLbl);
            Controls.Add(hungerLblAmount);
            Controls.Add(hungerLbl);
            Controls.Add(playerBox);
            Controls.Add(obstacleBoundary);
            Controls.Add(gameOverLbl);
            Controls.Add(groundBox);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Level1";
            Text = "Form1";
            Load += Level1_Load;
            KeyDown += Level1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)groundBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)obstacleBoundary).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer gravTimer;
        private PictureBox groundBox;
        private Label gameOverLbl;
        private PictureBox obstacleBoundary;
        private PictureBox playerBox;
        private Label hungerLbl;
        private Label hungerLblAmount;
        private PictureBox pictureBox1;
        private Label scoreLblAmount;
        private Label scoreLbl;
    }
}