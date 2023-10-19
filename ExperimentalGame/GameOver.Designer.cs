namespace ExperimentalGame
{
    partial class GameOver
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
            menuTitleLbl = new Label();
            flapCountLbl = new Label();
            moveCountLbl = new Label();
            scoreLbl = new Label();
            flapCountAmountLbl = new Label();
            moveCountAmountLbl = new Label();
            scoreAmountLbl = new Label();
            menuBtn = new Button();
            quitBtn = new Button();
            statsGrpBx = new GroupBox();
            SuspendLayout();
            // 
            // menuTitleLbl
            // 
            menuTitleLbl.Anchor = AnchorStyles.None;
            menuTitleLbl.AutoSize = true;
            menuTitleLbl.Font = new Font("Segoe UI", 34F, FontStyle.Bold, GraphicsUnit.Point);
            menuTitleLbl.Location = new Point(35, 9);
            menuTitleLbl.Name = "menuTitleLbl";
            menuTitleLbl.Size = new Size(283, 62);
            menuTitleLbl.TabIndex = 1;
            menuTitleLbl.Text = "Game Over!";
            menuTitleLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flapCountLbl
            // 
            flapCountLbl.AutoSize = true;
            flapCountLbl.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            flapCountLbl.Location = new Point(70, 98);
            flapCountLbl.Name = "flapCountLbl";
            flapCountLbl.Size = new Size(118, 30);
            flapCountLbl.TabIndex = 2;
            flapCountLbl.Text = "Flap Count:";
            // 
            // moveCountLbl
            // 
            moveCountLbl.AutoSize = true;
            moveCountLbl.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            moveCountLbl.Location = new Point(70, 142);
            moveCountLbl.Name = "moveCountLbl";
            moveCountLbl.Size = new Size(132, 30);
            moveCountLbl.TabIndex = 3;
            moveCountLbl.Text = "Move Count:";
            // 
            // scoreLbl
            // 
            scoreLbl.AutoSize = true;
            scoreLbl.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            scoreLbl.Location = new Point(70, 185);
            scoreLbl.Name = "scoreLbl";
            scoreLbl.Size = new Size(73, 30);
            scoreLbl.TabIndex = 4;
            scoreLbl.Text = "Score:";
            // 
            // flapCountAmountLbl
            // 
            flapCountAmountLbl.AutoSize = true;
            flapCountAmountLbl.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            flapCountAmountLbl.Location = new Point(212, 98);
            flapCountAmountLbl.Name = "flapCountAmountLbl";
            flapCountAmountLbl.Size = new Size(25, 30);
            flapCountAmountLbl.TabIndex = 5;
            flapCountAmountLbl.Text = "0";
            // 
            // moveCountAmountLbl
            // 
            moveCountAmountLbl.AutoSize = true;
            moveCountAmountLbl.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            moveCountAmountLbl.Location = new Point(212, 142);
            moveCountAmountLbl.Name = "moveCountAmountLbl";
            moveCountAmountLbl.Size = new Size(25, 30);
            moveCountAmountLbl.TabIndex = 6;
            moveCountAmountLbl.Text = "0";
            // 
            // scoreAmountLbl
            // 
            scoreAmountLbl.AutoSize = true;
            scoreAmountLbl.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            scoreAmountLbl.Location = new Point(212, 185);
            scoreAmountLbl.Name = "scoreAmountLbl";
            scoreAmountLbl.Size = new Size(25, 30);
            scoreAmountLbl.TabIndex = 7;
            scoreAmountLbl.Text = "0";
            // 
            // menuBtn
            // 
            menuBtn.BackColor = Color.FromArgb(128, 255, 128);
            menuBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            menuBtn.Location = new Point(45, 255);
            menuBtn.Name = "menuBtn";
            menuBtn.Size = new Size(121, 55);
            menuBtn.TabIndex = 8;
            menuBtn.Text = "Main Menu";
            menuBtn.UseVisualStyleBackColor = false;
            menuBtn.Click += menuBtn_Click;
            // 
            // quitBtn
            // 
            quitBtn.BackColor = Color.IndianRed;
            quitBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            quitBtn.Location = new Point(187, 255);
            quitBtn.Name = "quitBtn";
            quitBtn.Size = new Size(121, 55);
            quitBtn.TabIndex = 9;
            quitBtn.Text = "Quit";
            quitBtn.UseVisualStyleBackColor = false;
            quitBtn.Click += quitBtn_Click;
            // 
            // statsGrpBx
            // 
            statsGrpBx.Location = new Point(61, 81);
            statsGrpBx.Name = "statsGrpBx";
            statsGrpBx.Size = new Size(234, 168);
            statsGrpBx.TabIndex = 10;
            statsGrpBx.TabStop = false;
            statsGrpBx.Text = "Statistics";
            // 
            // GameOver
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 334);
            ControlBox = false;
            Controls.Add(quitBtn);
            Controls.Add(menuBtn);
            Controls.Add(scoreAmountLbl);
            Controls.Add(moveCountAmountLbl);
            Controls.Add(flapCountAmountLbl);
            Controls.Add(scoreLbl);
            Controls.Add(moveCountLbl);
            Controls.Add(flapCountLbl);
            Controls.Add(menuTitleLbl);
            Controls.Add(statsGrpBx);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "GameOver";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Game Over";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label menuTitleLbl;
        private Label flapCountLbl;
        private Label moveCountLbl;
        private Label scoreLbl;
        private Label flapCountAmountLbl;
        private Label moveCountAmountLbl;
        private Label scoreAmountLbl;
        private Button menuBtn;
        private Button quitBtn;
        private GroupBox statsGrpBx;
    }
}