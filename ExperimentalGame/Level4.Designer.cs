namespace ExperimentalGame
{
    partial class Level4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Level4));
            groundBox = new PictureBox();
            obstacleBoundary = new PictureBox();
            playerBox = new PictureBox();
            gravTimer = new System.Windows.Forms.Timer(components);
            scoreLblAmount = new Label();
            scoreLbl = new Label();
            hungerLblAmount = new Label();
            hungerLbl = new Label();
            pictureBox1 = new PictureBox();
            gameOverLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)groundBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)obstacleBoundary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groundBox
            // 
            groundBox.BackColor = Color.Crimson;
            groundBox.Location = new Point(-1, 341);
            groundBox.Name = "groundBox";
            groundBox.Size = new Size(800, 11);
            groundBox.TabIndex = 17;
            groundBox.TabStop = false;
            // 
            // obstacleBoundary
            // 
            obstacleBoundary.BackColor = SystemColors.ControlDarkDark;
            obstacleBoundary.Location = new Point(0, -1);
            obstacleBoundary.Name = "obstacleBoundary";
            obstacleBoundary.Size = new Size(258, 353);
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
            playerBox.TabIndex = 18;
            playerBox.TabStop = false;
            // 
            // gravTimer
            // 
            gravTimer.Enabled = true;
            gravTimer.Interval = 250;
            gravTimer.Tick += gravTimer_Tick;
            // 
            // scoreLblAmount
            // 
            scoreLblAmount.AutoSize = true;
            scoreLblAmount.BackColor = SystemColors.ControlDarkDark;
            scoreLblAmount.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            scoreLblAmount.Location = new Point(720, 391);
            scoreLblAmount.Name = "scoreLblAmount";
            scoreLblAmount.Size = new Size(25, 30);
            scoreLblAmount.TabIndex = 36;
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
            scoreLbl.TabIndex = 35;
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
            hungerLblAmount.TabIndex = 33;
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
            hungerLbl.TabIndex = 32;
            hungerLbl.Text = "Hunger:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlDarkDark;
            pictureBox1.Location = new Point(0, 341);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 111);
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // gameOverLbl
            // 
            gameOverLbl.AutoSize = true;
            gameOverLbl.Font = new Font("Segoe UI", 32F, FontStyle.Bold, GraphicsUnit.Point);
            gameOverLbl.ForeColor = SystemColors.ButtonHighlight;
            gameOverLbl.Location = new Point(264, 9);
            gameOverLbl.Name = "gameOverLbl";
            gameOverLbl.Size = new Size(272, 59);
            gameOverLbl.TabIndex = 43;
            gameOverLbl.Text = "Level Failed!";
            // 
            // Level4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(obstacleBoundary);
            Controls.Add(gameOverLbl);
            Controls.Add(playerBox);
            Controls.Add(groundBox);
            Controls.Add(scoreLblAmount);
            Controls.Add(scoreLbl);
            Controls.Add(hungerLblAmount);
            Controls.Add(hungerLbl);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Level4";
            Text = "Level4";
            KeyDown += Level4_KeyDown;
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
        private System.Windows.Forms.Timer gravTimer;
        private Label scoreLblAmount;
        private Label scoreLbl;
        private Label hungerLblAmount;
        private Label hungerLbl;
        private PictureBox pictureBox1;
        private Label gameOverLbl;
    }
}