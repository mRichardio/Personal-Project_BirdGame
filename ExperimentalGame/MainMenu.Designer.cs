namespace ExperimentalGame
{
    partial class MainMenu
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
            quitBtn = new Button();
            levelToggleBtn = new Button();
            levelsGrpBx = new GroupBox();
            LevelFourBtn = new Button();
            LevelThreeBtn = new Button();
            LevelTwoBtn = new Button();
            levelOneBtn = new Button();
            bonusBtn = new Button();
            infoGrpBx = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            richTextBox3 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            richTextBox1 = new RichTextBox();
            levelsGrpBx.SuspendLayout();
            infoGrpBx.SuspendLayout();
            SuspendLayout();
            // 
            // menuTitleLbl
            // 
            menuTitleLbl.Anchor = AnchorStyles.None;
            menuTitleLbl.AutoSize = true;
            menuTitleLbl.Font = new Font("Segoe UI", 34F, FontStyle.Bold, GraphicsUnit.Point);
            menuTitleLbl.ForeColor = SystemColors.ButtonFace;
            menuTitleLbl.Location = new Point(231, 9);
            menuTitleLbl.Name = "menuTitleLbl";
            menuTitleLbl.Size = new Size(346, 62);
            menuTitleLbl.TabIndex = 0;
            menuTitleLbl.Text = "The Bird Game";
            menuTitleLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // quitBtn
            // 
            quitBtn.BackColor = Color.Tomato;
            quitBtn.Cursor = Cursors.Hand;
            quitBtn.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            quitBtn.Location = new Point(317, 333);
            quitBtn.Name = "quitBtn";
            quitBtn.Size = new Size(177, 64);
            quitBtn.TabIndex = 1;
            quitBtn.Text = "Quit";
            quitBtn.UseVisualStyleBackColor = false;
            quitBtn.Click += quitBtn_Click;
            // 
            // levelToggleBtn
            // 
            levelToggleBtn.BackColor = Color.Khaki;
            levelToggleBtn.Cursor = Cursors.Hand;
            levelToggleBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            levelToggleBtn.Location = new Point(284, 174);
            levelToggleBtn.Name = "levelToggleBtn";
            levelToggleBtn.Size = new Size(243, 82);
            levelToggleBtn.TabIndex = 2;
            levelToggleBtn.Text = "Levels ▼";
            levelToggleBtn.UseVisualStyleBackColor = false;
            levelToggleBtn.Click += levelToggleBtn_Click;
            // 
            // levelsGrpBx
            // 
            levelsGrpBx.BackColor = Color.Transparent;
            levelsGrpBx.BackgroundImageLayout = ImageLayout.None;
            levelsGrpBx.Controls.Add(LevelFourBtn);
            levelsGrpBx.Controls.Add(LevelThreeBtn);
            levelsGrpBx.Controls.Add(LevelTwoBtn);
            levelsGrpBx.Controls.Add(levelOneBtn);
            levelsGrpBx.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            levelsGrpBx.ForeColor = Color.White;
            levelsGrpBx.Location = new Point(533, 74);
            levelsGrpBx.Name = "levelsGrpBx";
            levelsGrpBx.Size = new Size(255, 364);
            levelsGrpBx.TabIndex = 3;
            levelsGrpBx.TabStop = false;
            levelsGrpBx.Text = "Levels";
            // 
            // LevelFourBtn
            // 
            LevelFourBtn.BackColor = Color.Brown;
            LevelFourBtn.Cursor = Cursors.Hand;
            LevelFourBtn.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            LevelFourBtn.Location = new Point(41, 259);
            LevelFourBtn.Name = "LevelFourBtn";
            LevelFourBtn.Size = new Size(177, 64);
            LevelFourBtn.TabIndex = 7;
            LevelFourBtn.Text = "Level: 4";
            LevelFourBtn.UseVisualStyleBackColor = false;
            LevelFourBtn.Click += LevelFourBtn_Click;
            // 
            // LevelThreeBtn
            // 
            LevelThreeBtn.BackColor = Color.IndianRed;
            LevelThreeBtn.Cursor = Cursors.Hand;
            LevelThreeBtn.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            LevelThreeBtn.Location = new Point(41, 189);
            LevelThreeBtn.Name = "LevelThreeBtn";
            LevelThreeBtn.Size = new Size(177, 64);
            LevelThreeBtn.TabIndex = 6;
            LevelThreeBtn.Text = "Level: 3";
            LevelThreeBtn.UseVisualStyleBackColor = false;
            LevelThreeBtn.Click += LevelThreeBtn_Click;
            // 
            // LevelTwoBtn
            // 
            LevelTwoBtn.BackColor = Color.RosyBrown;
            LevelTwoBtn.Cursor = Cursors.Hand;
            LevelTwoBtn.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            LevelTwoBtn.Location = new Point(41, 119);
            LevelTwoBtn.Name = "LevelTwoBtn";
            LevelTwoBtn.Size = new Size(177, 64);
            LevelTwoBtn.TabIndex = 5;
            LevelTwoBtn.Text = "Level: 2";
            LevelTwoBtn.UseVisualStyleBackColor = false;
            LevelTwoBtn.Click += LevelTwoBtn_Click;
            // 
            // levelOneBtn
            // 
            levelOneBtn.BackColor = Color.Gray;
            levelOneBtn.Cursor = Cursors.Hand;
            levelOneBtn.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            levelOneBtn.Location = new Point(41, 49);
            levelOneBtn.Name = "levelOneBtn";
            levelOneBtn.Size = new Size(177, 64);
            levelOneBtn.TabIndex = 4;
            levelOneBtn.Text = "Level: 1";
            levelOneBtn.UseVisualStyleBackColor = false;
            levelOneBtn.Click += levelOneBtn_Click;
            // 
            // bonusBtn
            // 
            bonusBtn.BackColor = Color.CornflowerBlue;
            bonusBtn.Cursor = Cursors.Hand;
            bonusBtn.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            bonusBtn.Location = new Point(317, 263);
            bonusBtn.Name = "bonusBtn";
            bonusBtn.Size = new Size(177, 64);
            bonusBtn.TabIndex = 4;
            bonusBtn.Text = "Bonus";
            bonusBtn.UseVisualStyleBackColor = false;
            bonusBtn.Click += bonusBtn_Click;
            // 
            // infoGrpBx
            // 
            infoGrpBx.BackColor = Color.Transparent;
            infoGrpBx.BackgroundImageLayout = ImageLayout.None;
            infoGrpBx.Controls.Add(label3);
            infoGrpBx.Controls.Add(label2);
            infoGrpBx.Controls.Add(label1);
            infoGrpBx.Controls.Add(richTextBox3);
            infoGrpBx.Controls.Add(richTextBox2);
            infoGrpBx.Controls.Add(richTextBox1);
            infoGrpBx.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            infoGrpBx.ForeColor = Color.WhiteSmoke;
            infoGrpBx.Location = new Point(12, 74);
            infoGrpBx.Name = "infoGrpBx";
            infoGrpBx.Size = new Size(255, 364);
            infoGrpBx.TabIndex = 8;
            infoGrpBx.TabStop = false;
            infoGrpBx.Text = "Info";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(11, 268);
            label3.Name = "label3";
            label3.Size = new Size(70, 21);
            label3.TabIndex = 13;
            label3.Text = "Scoring:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(11, 156);
            label2.Name = "label2";
            label2.Size = new Size(70, 21);
            label2.TabIndex = 12;
            label2.Text = "Hunger:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(11, 48);
            label1.Name = "label1";
            label1.Size = new Size(47, 21);
            label1.TabIndex = 9;
            label1.Text = "Goal:";
            // 
            // richTextBox3
            // 
            richTextBox3.BackColor = SystemColors.ControlDark;
            richTextBox3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox3.Location = new Point(11, 72);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.ReadOnly = true;
            richTextBox3.Size = new Size(230, 62);
            richTextBox3.TabIndex = 11;
            richTextBox3.Text = "Do no hit the ground or any of the obstacles and try and make it as far as you can go.";
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = SystemColors.ControlDark;
            richTextBox2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox2.Location = new Point(11, 292);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ReadOnly = true;
            richTextBox2.Size = new Size(230, 62);
            richTextBox2.TabIndex = 10;
            richTextBox2.Text = "You gain score with every move you make along with a large score boost on seed pickup.";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.ControlDark;
            richTextBox1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(11, 180);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(230, 62);
            richTextBox1.TabIndex = 9;
            richTextBox1.Text = "Hunger goes down with every move you make. Replenish it by flying into seeds.";
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(800, 450);
            Controls.Add(infoGrpBx);
            Controls.Add(bonusBtn);
            Controls.Add(levelsGrpBx);
            Controls.Add(levelToggleBtn);
            Controls.Add(quitBtn);
            Controls.Add(menuTitleLbl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainMenu";
            Text = "MainMenu";
            levelsGrpBx.ResumeLayout(false);
            infoGrpBx.ResumeLayout(false);
            infoGrpBx.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label menuTitleLbl;
        private Button quitBtn;
        private Button levelToggleBtn;
        private GroupBox levelsGrpBx;
        private Button LevelFourBtn;
        private Button LevelThreeBtn;
        private Button LevelTwoBtn;
        private Button levelOneBtn;
        private Button bonusBtn;
        private GroupBox infoGrpBx;
        private RichTextBox richTextBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private RichTextBox richTextBox3;
        private RichTextBox richTextBox2;
    }
}