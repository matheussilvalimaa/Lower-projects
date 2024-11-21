namespace RockPaperScissors
{
    partial class MainGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGame));
            WinTitle = new Panel();
            WinName = new Label();
            WinIcon = new PictureBox();
            BtnMinimize = new Button();
            WinGame = new Panel();
            WinRounds = new Panel();
            WinStart = new Panel();
            ExitGame = new Label();
            BtnExit = new Button();
            BtnLinkedln = new Button();
            BtnGit = new Button();
            TxtStartGame = new Label();
            BtnStart = new Button();
            Round7Name = new Label();
            Round5Name = new Label();
            Round3Name = new Label();
            BtnRound7 = new Button();
            BtnRound5 = new Button();
            BtnRound3 = new Button();
            BtnScissors = new Button();
            BtnPaper = new Button();
            BtnRock = new Button();
            RockName = new Label();
            PaperName = new Label();
            ScissorsName = new Label();
            WinEndGame = new Panel();
            ExitGame2 = new Label();
            PlayAgain = new Label();
            BtnExit2 = new Button();
            BtnPlayAgain = new Button();
            TxtEndGame = new TextBox();
            TxtPlayer = new TextBox();
            TxtPoint = new TextBox();
            TxtPC = new TextBox();
            WinTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)WinIcon).BeginInit();
            WinGame.SuspendLayout();
            WinRounds.SuspendLayout();
            WinStart.SuspendLayout();
            WinEndGame.SuspendLayout();
            SuspendLayout();
            // 
            // WinTitle
            // 
            WinTitle.BackColor = Color.FromArgb(5, 142, 133);
            WinTitle.Controls.Add(WinName);
            WinTitle.Controls.Add(WinIcon);
            WinTitle.Controls.Add(BtnMinimize);
            WinTitle.Location = new Point(0, 0);
            WinTitle.Name = "WinTitle";
            WinTitle.Size = new Size(345, 31);
            WinTitle.TabIndex = 0;
            // 
            // WinName
            // 
            WinName.AutoSize = true;
            WinName.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            WinName.Location = new Point(31, 5);
            WinName.Name = "WinName";
            WinName.Size = new Size(147, 21);
            WinName.TabIndex = 2;
            WinName.Text = "Rock Paper Scissors";
            // 
            // WinIcon
            // 
            WinIcon.BackgroundImage = (Image)resources.GetObject("WinIcon.BackgroundImage");
            WinIcon.BackgroundImageLayout = ImageLayout.Center;
            WinIcon.Location = new Point(3, 0);
            WinIcon.Name = "WinIcon";
            WinIcon.Size = new Size(31, 31);
            WinIcon.TabIndex = 2;
            WinIcon.TabStop = false;
            // 
            // BtnMinimize
            // 
            BtnMinimize.BackgroundImage = (Image)resources.GetObject("BtnMinimize.BackgroundImage");
            BtnMinimize.BackgroundImageLayout = ImageLayout.Center;
            BtnMinimize.Dock = DockStyle.Right;
            BtnMinimize.FlatStyle = FlatStyle.Flat;
            BtnMinimize.ForeColor = Color.FromArgb(5, 142, 133);
            BtnMinimize.Location = new Point(299, 0);
            BtnMinimize.Margin = new Padding(0);
            BtnMinimize.Name = "BtnMinimize";
            BtnMinimize.Size = new Size(46, 31);
            BtnMinimize.TabIndex = 1;
            BtnMinimize.UseVisualStyleBackColor = true;
            BtnMinimize.Click += BtnMin_Click;
            // 
            // WinGame
            // 
            WinGame.BackColor = Color.FromArgb(4, 93, 87);
            WinGame.Controls.Add(WinRounds);
            WinGame.Controls.Add(BtnScissors);
            WinGame.Controls.Add(BtnPaper);
            WinGame.Controls.Add(BtnRock);
            WinGame.Controls.Add(RockName);
            WinGame.Controls.Add(PaperName);
            WinGame.Controls.Add(ScissorsName);
            WinGame.Location = new Point(0, 81);
            WinGame.Name = "WinGame";
            WinGame.Size = new Size(345, 196);
            WinGame.TabIndex = 1;
            // 
            // WinRounds
            // 
            WinRounds.BackColor = Color.FromArgb(4, 93, 87);
            WinRounds.Controls.Add(WinStart);
            WinRounds.Controls.Add(Round7Name);
            WinRounds.Controls.Add(Round5Name);
            WinRounds.Controls.Add(Round3Name);
            WinRounds.Controls.Add(BtnRound7);
            WinRounds.Controls.Add(BtnRound5);
            WinRounds.Controls.Add(BtnRound3);
            WinRounds.Location = new Point(0, 0);
            WinRounds.Name = "WinRounds";
            WinRounds.Size = new Size(345, 196);
            WinRounds.TabIndex = 0;
            // 
            // WinStart
            // 
            WinStart.Controls.Add(ExitGame);
            WinStart.Controls.Add(BtnExit);
            WinStart.Controls.Add(BtnLinkedln);
            WinStart.Controls.Add(BtnGit);
            WinStart.Controls.Add(TxtStartGame);
            WinStart.Controls.Add(BtnStart);
            WinStart.Location = new Point(0, 0);
            WinStart.Name = "WinStart";
            WinStart.Size = new Size(345, 196);
            WinStart.TabIndex = 6;
            // 
            // ExitGame
            // 
            ExitGame.AutoSize = true;
            ExitGame.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ExitGame.Location = new Point(264, 168);
            ExitGame.Name = "ExitGame";
            ExitGame.Size = new Size(71, 20);
            ExitGame.TabIndex = 5;
            ExitGame.Text = "Exit Game";
            // 
            // BtnExit
            // 
            BtnExit.BackgroundImage = (Image)resources.GetObject("BtnExit.BackgroundImage");
            BtnExit.BackgroundImageLayout = ImageLayout.Center;
            BtnExit.Location = new Point(276, 126);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(50, 43);
            BtnExit.TabIndex = 4;
            BtnExit.UseVisualStyleBackColor = true;
            BtnExit.Click += BtnExit1_Click;
            // 
            // BtnLinkedln
            // 
            BtnLinkedln.BackgroundImage = (Image)resources.GetObject("BtnLinkedln.BackgroundImage");
            BtnLinkedln.BackgroundImageLayout = ImageLayout.Stretch;
            BtnLinkedln.FlatStyle = FlatStyle.Flat;
            BtnLinkedln.Location = new Point(25, 172);
            BtnLinkedln.Name = "BtnLinkedln";
            BtnLinkedln.Size = new Size(22, 23);
            BtnLinkedln.TabIndex = 3;
            BtnLinkedln.UseVisualStyleBackColor = true;
            BtnLinkedln.Click += BtnLink_Click;
            // 
            // BtnGit
            // 
            BtnGit.BackgroundImage = (Image)resources.GetObject("BtnGit.BackgroundImage");
            BtnGit.BackgroundImageLayout = ImageLayout.Stretch;
            BtnGit.FlatStyle = FlatStyle.Flat;
            BtnGit.Location = new Point(3, 172);
            BtnGit.Name = "BtnGit";
            BtnGit.Size = new Size(22, 23);
            BtnGit.TabIndex = 2;
            BtnGit.UseVisualStyleBackColor = true;
            BtnGit.Click += BtnGit_Click;
            // 
            // TxtStartGame
            // 
            TxtStartGame.AutoSize = true;
            TxtStartGame.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtStartGame.Location = new Point(121, 40);
            TxtStartGame.Name = "TxtStartGame";
            TxtStartGame.Size = new Size(107, 26);
            TxtStartGame.TabIndex = 1;
            TxtStartGame.Text = "Start Game";
            TxtStartGame.Click += BtnIniciar_Click;
            // 
            // BtnStart
            // 
            BtnStart.BackgroundImage = (Image)resources.GetObject("BtnStart.BackgroundImage");
            BtnStart.BackgroundImageLayout = ImageLayout.Center;
            BtnStart.Location = new Point(148, 74);
            BtnStart.Name = "BtnStart";
            BtnStart.Size = new Size(59, 52);
            BtnStart.TabIndex = 0;
            BtnStart.UseVisualStyleBackColor = true;
            BtnStart.Click += BtnIniciar_Click;
            // 
            // Round7Name
            // 
            Round7Name.AutoSize = true;
            Round7Name.Font = new Font("Impact", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Round7Name.ForeColor = SystemColors.ControlText;
            Round7Name.Location = new Point(242, 126);
            Round7Name.Name = "Round7Name";
            Round7Name.Size = new Size(52, 17);
            Round7Name.TabIndex = 5;
            Round7Name.Text = "Best of 7";
            // 
            // Round5Name
            // 
            Round5Name.AutoSize = true;
            Round5Name.Font = new Font("Impact", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Round5Name.ForeColor = SystemColors.ControlText;
            Round5Name.Location = new Point(146, 126);
            Round5Name.Name = "Round5Name";
            Round5Name.Size = new Size(54, 17);
            Round5Name.TabIndex = 4;
            Round5Name.Text = "Best of 5";
            // 
            // Round3Name
            // 
            Round3Name.AutoSize = true;
            Round3Name.Font = new Font("Impact", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Round3Name.ForeColor = SystemColors.ControlText;
            Round3Name.Location = new Point(46, 126);
            Round3Name.Name = "Round3Name";
            Round3Name.Size = new Size(54, 17);
            Round3Name.TabIndex = 3;
            Round3Name.Text = "Best of 3";
            // 
            // BtnRound7
            // 
            BtnRound7.BackgroundImage = (Image)resources.GetObject("BtnRound7.BackgroundImage");
            BtnRound7.BackgroundImageLayout = ImageLayout.Center;
            BtnRound7.Location = new Point(230, 55);
            BtnRound7.Name = "BtnRound7";
            BtnRound7.Size = new Size(75, 68);
            BtnRound7.TabIndex = 2;
            BtnRound7.UseVisualStyleBackColor = true;
            BtnRound7.Click += BtnRnd7_Click;
            // 
            // BtnRound5
            // 
            BtnRound5.BackgroundImage = (Image)resources.GetObject("BtnRound5.BackgroundImage");
            BtnRound5.BackgroundImageLayout = ImageLayout.Center;
            BtnRound5.Location = new Point(135, 55);
            BtnRound5.Name = "BtnRound5";
            BtnRound5.Size = new Size(75, 68);
            BtnRound5.TabIndex = 1;
            BtnRound5.UseVisualStyleBackColor = true;
            BtnRound5.Click += BtnRnd5_Click;
            // 
            // BtnRound3
            // 
            BtnRound3.BackgroundImage = (Image)resources.GetObject("BtnRound3.BackgroundImage");
            BtnRound3.BackgroundImageLayout = ImageLayout.Center;
            BtnRound3.Location = new Point(35, 55);
            BtnRound3.Name = "BtnRound3";
            BtnRound3.Size = new Size(75, 68);
            BtnRound3.TabIndex = 0;
            BtnRound3.UseVisualStyleBackColor = true;
            BtnRound3.Click += BtnRnd3_Click;
            // 
            // BtnScissors
            // 
            BtnScissors.BackgroundImage = (Image)resources.GetObject("BtnScissors.BackgroundImage");
            BtnScissors.BackgroundImageLayout = ImageLayout.Center;
            BtnScissors.Location = new Point(230, 55);
            BtnScissors.Name = "BtnScissors";
            BtnScissors.Size = new Size(75, 68);
            BtnScissors.TabIndex = 5;
            BtnScissors.UseVisualStyleBackColor = true;
            BtnScissors.Click += BtnScissors_Click;
            // 
            // BtnPaper
            // 
            BtnPaper.BackgroundImage = (Image)resources.GetObject("BtnPaper.BackgroundImage");
            BtnPaper.BackgroundImageLayout = ImageLayout.Center;
            BtnPaper.Location = new Point(135, 55);
            BtnPaper.Name = "BtnPaper";
            BtnPaper.Size = new Size(75, 68);
            BtnPaper.TabIndex = 4;
            BtnPaper.UseVisualStyleBackColor = true;
            BtnPaper.Click += BtnPaper_Click;
            // 
            // BtnRock
            // 
            BtnRock.BackgroundImage = (Image)resources.GetObject("BtnRock.BackgroundImage");
            BtnRock.BackgroundImageLayout = ImageLayout.Center;
            BtnRock.Location = new Point(35, 55);
            BtnRock.Name = "BtnRock";
            BtnRock.Size = new Size(75, 68);
            BtnRock.TabIndex = 3;
            BtnRock.UseVisualStyleBackColor = true;
            BtnRock.Click += BtnRock_Click;
            // 
            // RockName
            // 
            RockName.AutoSize = true;
            RockName.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RockName.Location = new Point(55, 126);
            RockName.Name = "RockName";
            RockName.Size = new Size(31, 16);
            RockName.TabIndex = 7;
            RockName.Text = "Rock";
            // 
            // PaperName
            // 
            PaperName.AutoSize = true;
            PaperName.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PaperName.Location = new Point(155, 126);
            PaperName.Name = "PaperName";
            PaperName.Size = new Size(35, 16);
            PaperName.TabIndex = 8;
            PaperName.Text = "Paper";
            // 
            // ScissorsName
            // 
            ScissorsName.AutoSize = true;
            ScissorsName.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ScissorsName.Location = new Point(244, 126);
            ScissorsName.Name = "ScissorsName";
            ScissorsName.Size = new Size(50, 16);
            ScissorsName.TabIndex = 9;
            ScissorsName.Text = "Scissors";
            // 
            // WinEndGame
            // 
            WinEndGame.BackColor = Color.FromArgb(4, 93, 87);
            WinEndGame.Controls.Add(ExitGame2);
            WinEndGame.Controls.Add(PlayAgain);
            WinEndGame.Controls.Add(BtnExit2);
            WinEndGame.Controls.Add(BtnPlayAgain);
            WinEndGame.Controls.Add(TxtEndGame);
            WinEndGame.Location = new Point(0, 84);
            WinEndGame.Name = "WinEndGame";
            WinEndGame.Size = new Size(342, 193);
            WinEndGame.TabIndex = 4;
            // 
            // ExitGame2
            // 
            ExitGame2.AutoSize = true;
            ExitGame2.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ExitGame2.Location = new Point(198, 130);
            ExitGame2.Name = "ExitGame2";
            ExitGame2.Size = new Size(84, 23);
            ExitGame2.TabIndex = 4;
            ExitGame2.Text = "Exit Game";
            // 
            // PlayAgain
            // 
            PlayAgain.AutoSize = true;
            PlayAgain.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PlayAgain.Location = new Point(59, 130);
            PlayAgain.Name = "PlayAgain";
            PlayAgain.Size = new Size(91, 23);
            PlayAgain.TabIndex = 3;
            PlayAgain.Text = "Play Again";
            // 
            // BtnExit2
            // 
            BtnExit2.BackColor = Color.FromArgb(5, 142, 133);
            BtnExit2.BackgroundImage = (Image)resources.GetObject("BtnExit2.BackgroundImage");
            BtnExit2.BackgroundImageLayout = ImageLayout.Center;
            BtnExit2.FlatStyle = FlatStyle.Flat;
            BtnExit2.Location = new Point(184, 73);
            BtnExit2.Name = "BtnExit2";
            BtnExit2.Size = new Size(108, 54);
            BtnExit2.TabIndex = 2;
            BtnExit2.UseVisualStyleBackColor = false;
            BtnExit2.Click += BtnExit2_Click;
            // 
            // BtnPlayAgain
            // 
            BtnPlayAgain.BackColor = Color.FromArgb(5, 142, 133);
            BtnPlayAgain.BackgroundImage = (Image)resources.GetObject("BtnPlayAgain.BackgroundImage");
            BtnPlayAgain.BackgroundImageLayout = ImageLayout.Center;
            BtnPlayAgain.FlatStyle = FlatStyle.Flat;
            BtnPlayAgain.Location = new Point(46, 73);
            BtnPlayAgain.Name = "BtnPlayAgain";
            BtnPlayAgain.Size = new Size(111, 54);
            BtnPlayAgain.TabIndex = 1;
            BtnPlayAgain.UseVisualStyleBackColor = false;
            BtnPlayAgain.Click += BtnPlayAgain_Click;
            // 
            // TxtEndGame
            // 
            TxtEndGame.BackColor = Color.FromArgb(4, 93, 87);
            TxtEndGame.BorderStyle = BorderStyle.None;
            TxtEndGame.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtEndGame.Location = new Point(51, 26);
            TxtEndGame.Name = "TxtEndGame";
            TxtEndGame.Size = new Size(237, 26);
            TxtEndGame.TabIndex = 0;
            TxtEndGame.TextAlign = HorizontalAlignment.Center;
            // 
            // TxtPlayer
            // 
            TxtPlayer.BackColor = Color.Aquamarine;
            TxtPlayer.BorderStyle = BorderStyle.None;
            TxtPlayer.Font = new Font("Gadugi", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtPlayer.ForeColor = SystemColors.MenuText;
            TxtPlayer.Location = new Point(100, 32);
            TxtPlayer.Name = "TxtPlayer";
            TxtPlayer.Size = new Size(45, 47);
            TxtPlayer.TabIndex = 2;
            TxtPlayer.Text = "0";
            TxtPlayer.TextAlign = HorizontalAlignment.Right;
            // 
            // TxtPoint
            // 
            TxtPoint.BackColor = Color.Aquamarine;
            TxtPoint.BorderStyle = BorderStyle.None;
            TxtPoint.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtPoint.Location = new Point(157, 31);
            TxtPoint.Name = "TxtPoint";
            TxtPoint.Size = new Size(34, 47);
            TxtPoint.TabIndex = 3;
            TxtPoint.Text = ":";
            TxtPoint.TextAlign = HorizontalAlignment.Center;
            // 
            // TxtPC
            // 
            TxtPC.BackColor = Color.Aquamarine;
            TxtPC.BorderStyle = BorderStyle.None;
            TxtPC.Font = new Font("Gadugi", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtPC.ForeColor = SystemColors.MenuText;
            TxtPC.Location = new Point(201, 32);
            TxtPC.Name = "TxtPC";
            TxtPC.Size = new Size(43, 47);
            TxtPC.TabIndex = 4;
            TxtPC.Text = "0";
            // 
            // MainGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aquamarine;
            ClientSize = new Size(342, 276);
            Controls.Add(TxtPC);
            Controls.Add(TxtPoint);
            Controls.Add(TxtPlayer);
            Controls.Add(WinTitle);
            Controls.Add(WinGame);
            Controls.Add(WinEndGame);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainGame";
            Text = "MainWindow";
            WinTitle.ResumeLayout(false);
            WinTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)WinIcon).EndInit();
            WinGame.ResumeLayout(false);
            WinGame.PerformLayout();
            WinRounds.ResumeLayout(false);
            WinRounds.PerformLayout();
            WinStart.ResumeLayout(false);
            WinStart.PerformLayout();
            WinEndGame.ResumeLayout(false);
            WinEndGame.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel WinTitle;
        private Panel WinGame;
        private Button BtnMinimize;
        private Panel WinRounds;
        private PictureBox WinIcon;
        private Label WinName;
        private Button BtnRound3;
        private Button BtnScissors;
        private Button BtnPaper;
        private Button BtnRock;
        private Button BtnRound7;
        private Button BtnRound5;
        private Label Round7Name;
        private Label Round5Name;
        private Label Round3Name;
        private Panel WinStart;
        private Button BtnStart;
        private Label TxtStartGame;
        private Button BtnLinkedln;
        private Button BtnGit;
        private Label ScissorsName;
        private Label PaperName;
        private Label RockName;
        private TextBox TxtPlayer;
        private TextBox TxtPoint;
        private TextBox TxtPC;
        private Panel WinEndGame;
        private TextBox TxtEndGame;
        private Button BtnExit2;
        private Button BtnPlayAgain;
        private Button BtnExit;
        private Label ExitGame;
        private Label ExitGame2;
        private Label PlayAgain;
    }
}
