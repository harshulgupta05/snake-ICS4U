namespace SnakeGame_HarshulGupta
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.pbGame = new System.Windows.Forms.PictureBox();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.gbSpeed = new System.Windows.Forms.GroupBox();
            this.rdMedium = new System.Windows.Forms.RadioButton();
            this.rdFast = new System.Windows.Forms.RadioButton();
            this.rdSlow = new System.Windows.Forms.RadioButton();
            this.btnOnePlayer = new System.Windows.Forms.Button();
            this.btnTwoPlayer = new System.Windows.Forms.Button();
            this.gbStart = new System.Windows.Forms.GroupBox();
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnColorP1 = new System.Windows.Forms.Button();
            this.btnColorP2 = new System.Windows.Forms.Button();
            this.lblHighScore = new System.Windows.Forms.Label();
            this.txtHighScore = new System.Windows.Forms.TextBox();
            this.lblcurrScoreP1 = new System.Windows.Forms.Label();
            this.txtcurrScoreP1 = new System.Windows.Forms.TextBox();
            this.txtcurrScoreP2 = new System.Windows.Forms.TextBox();
            this.lblcurrScoreP2 = new System.Windows.Forms.Label();
            this.txtP2Wins = new System.Windows.Forms.TextBox();
            this.lblP2Wins = new System.Windows.Forms.Label();
            this.txtP1Wins = new System.Windows.Forms.TextBox();
            this.lblP1Wins = new System.Windows.Forms.Label();
            this.txtTies = new System.Windows.Forms.TextBox();
            this.lblTies = new System.Windows.Forms.Label();
            this.btnResetScores = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbGame)).BeginInit();
            this.gbSpeed.SuspendLayout();
            this.gbStart.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbGame
            // 
            this.pbGame.Location = new System.Drawing.Point(12, 30);
            this.pbGame.Name = "pbGame";
            this.pbGame.Size = new System.Drawing.Size(400, 400);
            this.pbGame.TabIndex = 0;
            this.pbGame.TabStop = false;
            this.pbGame.Paint += new System.Windows.Forms.PaintEventHandler(this.pbGame_Paint);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(418, 69);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 2;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(497, 69);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // gbSpeed
            // 
            this.gbSpeed.Controls.Add(this.rdMedium);
            this.gbSpeed.Controls.Add(this.rdFast);
            this.gbSpeed.Controls.Add(this.rdSlow);
            this.gbSpeed.Location = new System.Drawing.Point(418, 98);
            this.gbSpeed.Name = "gbSpeed";
            this.gbSpeed.Size = new System.Drawing.Size(154, 107);
            this.gbSpeed.TabIndex = 4;
            this.gbSpeed.TabStop = false;
            this.gbSpeed.Text = "Speed";
            // 
            // rdMedium
            // 
            this.rdMedium.AutoSize = true;
            this.rdMedium.Location = new System.Drawing.Point(6, 51);
            this.rdMedium.Name = "rdMedium";
            this.rdMedium.Size = new System.Drawing.Size(62, 17);
            this.rdMedium.TabIndex = 2;
            this.rdMedium.TabStop = true;
            this.rdMedium.Text = "Medium";
            this.rdMedium.UseVisualStyleBackColor = true;
            this.rdMedium.CheckedChanged += new System.EventHandler(this.rdMedium_CheckedChanged);
            // 
            // rdFast
            // 
            this.rdFast.AutoSize = true;
            this.rdFast.Location = new System.Drawing.Point(6, 84);
            this.rdFast.Name = "rdFast";
            this.rdFast.Size = new System.Drawing.Size(45, 17);
            this.rdFast.TabIndex = 1;
            this.rdFast.TabStop = true;
            this.rdFast.Text = "Fast";
            this.rdFast.UseVisualStyleBackColor = true;
            this.rdFast.CheckedChanged += new System.EventHandler(this.rdFast_CheckedChanged);
            // 
            // rdSlow
            // 
            this.rdSlow.AutoSize = true;
            this.rdSlow.Location = new System.Drawing.Point(6, 19);
            this.rdSlow.Name = "rdSlow";
            this.rdSlow.Size = new System.Drawing.Size(48, 17);
            this.rdSlow.TabIndex = 0;
            this.rdSlow.TabStop = true;
            this.rdSlow.Text = "Slow";
            this.rdSlow.UseVisualStyleBackColor = true;
            this.rdSlow.CheckedChanged += new System.EventHandler(this.rdSlow_CheckedChanged);
            // 
            // btnOnePlayer
            // 
            this.btnOnePlayer.Location = new System.Drawing.Point(6, 19);
            this.btnOnePlayer.Name = "btnOnePlayer";
            this.btnOnePlayer.Size = new System.Drawing.Size(75, 23);
            this.btnOnePlayer.TabIndex = 5;
            this.btnOnePlayer.Text = "One Player";
            this.btnOnePlayer.UseVisualStyleBackColor = true;
            this.btnOnePlayer.Click += new System.EventHandler(this.btnOnePlayer_Click);
            // 
            // btnTwoPlayer
            // 
            this.btnTwoPlayer.Location = new System.Drawing.Point(79, 19);
            this.btnTwoPlayer.Name = "btnTwoPlayer";
            this.btnTwoPlayer.Size = new System.Drawing.Size(75, 23);
            this.btnTwoPlayer.TabIndex = 6;
            this.btnTwoPlayer.Text = "Two Player";
            this.btnTwoPlayer.UseVisualStyleBackColor = true;
            this.btnTwoPlayer.Click += new System.EventHandler(this.btnTwoPlayer_Click);
            // 
            // gbStart
            // 
            this.gbStart.Controls.Add(this.btnOnePlayer);
            this.gbStart.Controls.Add(this.btnTwoPlayer);
            this.gbStart.Location = new System.Drawing.Point(418, 7);
            this.gbStart.Name = "gbStart";
            this.gbStart.Size = new System.Drawing.Size(154, 56);
            this.gbStart.TabIndex = 7;
            this.gbStart.TabStop = false;
            this.gbStart.Text = "Start Game";
            // 
            // btnContinue
            // 
            this.btnContinue.Enabled = false;
            this.btnContinue.Location = new System.Drawing.Point(416, 69);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(75, 23);
            this.btnContinue.TabIndex = 8;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Visible = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // btnColorP1
            // 
            this.btnColorP1.Location = new System.Drawing.Point(418, 211);
            this.btnColorP1.Name = "btnColorP1";
            this.btnColorP1.Size = new System.Drawing.Size(154, 23);
            this.btnColorP1.TabIndex = 9;
            this.btnColorP1.Text = "Change P1 Color";
            this.btnColorP1.UseVisualStyleBackColor = true;
            this.btnColorP1.Click += new System.EventHandler(this.btnColorP1_Click);
            // 
            // btnColorP2
            // 
            this.btnColorP2.Location = new System.Drawing.Point(418, 240);
            this.btnColorP2.Name = "btnColorP2";
            this.btnColorP2.Size = new System.Drawing.Size(154, 23);
            this.btnColorP2.TabIndex = 10;
            this.btnColorP2.Text = "Change P2 Color";
            this.btnColorP2.UseVisualStyleBackColor = true;
            this.btnColorP2.Click += new System.EventHandler(this.btnColorP2_Click);
            // 
            // lblHighScore
            // 
            this.lblHighScore.AutoSize = true;
            this.lblHighScore.Location = new System.Drawing.Point(415, 269);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(63, 13);
            this.lblHighScore.TabIndex = 11;
            this.lblHighScore.Text = "High Score:";
            // 
            // txtHighScore
            // 
            this.txtHighScore.Enabled = false;
            this.txtHighScore.Location = new System.Drawing.Point(484, 266);
            this.txtHighScore.Name = "txtHighScore";
            this.txtHighScore.Size = new System.Drawing.Size(88, 20);
            this.txtHighScore.TabIndex = 12;
            // 
            // lblcurrScoreP1
            // 
            this.lblcurrScoreP1.AutoSize = true;
            this.lblcurrScoreP1.Location = new System.Drawing.Point(415, 295);
            this.lblcurrScoreP1.Name = "lblcurrScoreP1";
            this.lblcurrScoreP1.Size = new System.Drawing.Size(91, 13);
            this.lblcurrScoreP1.TabIndex = 13;
            this.lblcurrScoreP1.Text = "P1 Current Score:";
            // 
            // txtcurrScoreP1
            // 
            this.txtcurrScoreP1.Enabled = false;
            this.txtcurrScoreP1.Location = new System.Drawing.Point(512, 292);
            this.txtcurrScoreP1.Name = "txtcurrScoreP1";
            this.txtcurrScoreP1.Size = new System.Drawing.Size(60, 20);
            this.txtcurrScoreP1.TabIndex = 14;
            // 
            // txtcurrScoreP2
            // 
            this.txtcurrScoreP2.Enabled = false;
            this.txtcurrScoreP2.Location = new System.Drawing.Point(512, 318);
            this.txtcurrScoreP2.Name = "txtcurrScoreP2";
            this.txtcurrScoreP2.Size = new System.Drawing.Size(60, 20);
            this.txtcurrScoreP2.TabIndex = 16;
            this.txtcurrScoreP2.Visible = false;
            // 
            // lblcurrScoreP2
            // 
            this.lblcurrScoreP2.AutoSize = true;
            this.lblcurrScoreP2.Location = new System.Drawing.Point(415, 321);
            this.lblcurrScoreP2.Name = "lblcurrScoreP2";
            this.lblcurrScoreP2.Size = new System.Drawing.Size(91, 13);
            this.lblcurrScoreP2.TabIndex = 15;
            this.lblcurrScoreP2.Text = "P2 Current Score:";
            this.lblcurrScoreP2.Visible = false;
            // 
            // txtP2Wins
            // 
            this.txtP2Wins.Enabled = false;
            this.txtP2Wins.Location = new System.Drawing.Point(471, 373);
            this.txtP2Wins.Name = "txtP2Wins";
            this.txtP2Wins.Size = new System.Drawing.Size(101, 20);
            this.txtP2Wins.TabIndex = 20;
            this.txtP2Wins.Visible = false;
            // 
            // lblP2Wins
            // 
            this.lblP2Wins.AutoSize = true;
            this.lblP2Wins.Location = new System.Drawing.Point(415, 376);
            this.lblP2Wins.Name = "lblP2Wins";
            this.lblP2Wins.Size = new System.Drawing.Size(50, 13);
            this.lblP2Wins.TabIndex = 19;
            this.lblP2Wins.Text = "P2 Wins:";
            this.lblP2Wins.Visible = false;
            // 
            // txtP1Wins
            // 
            this.txtP1Wins.Enabled = false;
            this.txtP1Wins.Location = new System.Drawing.Point(471, 347);
            this.txtP1Wins.Name = "txtP1Wins";
            this.txtP1Wins.Size = new System.Drawing.Size(101, 20);
            this.txtP1Wins.TabIndex = 18;
            // 
            // lblP1Wins
            // 
            this.lblP1Wins.AutoSize = true;
            this.lblP1Wins.Location = new System.Drawing.Point(415, 350);
            this.lblP1Wins.Name = "lblP1Wins";
            this.lblP1Wins.Size = new System.Drawing.Size(50, 13);
            this.lblP1Wins.TabIndex = 17;
            this.lblP1Wins.Text = "P1 Wins:";
            // 
            // txtTies
            // 
            this.txtTies.Enabled = false;
            this.txtTies.Location = new System.Drawing.Point(451, 401);
            this.txtTies.Name = "txtTies";
            this.txtTies.Size = new System.Drawing.Size(121, 20);
            this.txtTies.TabIndex = 22;
            this.txtTies.Visible = false;
            // 
            // lblTies
            // 
            this.lblTies.AutoSize = true;
            this.lblTies.Location = new System.Drawing.Point(415, 404);
            this.lblTies.Name = "lblTies";
            this.lblTies.Size = new System.Drawing.Size(30, 13);
            this.lblTies.TabIndex = 21;
            this.lblTies.Text = "Ties:";
            this.lblTies.Visible = false;
            // 
            // btnResetScores
            // 
            this.btnResetScores.Location = new System.Drawing.Point(418, 427);
            this.btnResetScores.Name = "btnResetScores";
            this.btnResetScores.Size = new System.Drawing.Size(154, 23);
            this.btnResetScores.TabIndex = 23;
            this.btnResetScores.Text = "Reset Scores";
            this.btnResetScores.UseVisualStyleBackColor = true;
            this.btnResetScores.Click += new System.EventHandler(this.btnResetScores_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.btnResetScores);
            this.Controls.Add(this.txtTies);
            this.Controls.Add(this.lblTies);
            this.Controls.Add(this.txtP2Wins);
            this.Controls.Add(this.lblP2Wins);
            this.Controls.Add(this.txtP1Wins);
            this.Controls.Add(this.lblP1Wins);
            this.Controls.Add(this.txtcurrScoreP2);
            this.Controls.Add(this.lblcurrScoreP2);
            this.Controls.Add(this.txtcurrScoreP1);
            this.Controls.Add(this.lblcurrScoreP1);
            this.Controls.Add(this.txtHighScore);
            this.Controls.Add(this.lblHighScore);
            this.Controls.Add(this.btnColorP2);
            this.Controls.Add(this.btnColorP1);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.gbStart);
            this.Controls.Add(this.gbSpeed);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.pbGame);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form1_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbGame)).EndInit();
            this.gbSpeed.ResumeLayout(false);
            this.gbSpeed.PerformLayout();
            this.gbStart.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbGame;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.GroupBox gbSpeed;
        private System.Windows.Forms.RadioButton rdMedium;
        private System.Windows.Forms.RadioButton rdFast;
        private System.Windows.Forms.RadioButton rdSlow;
        private System.Windows.Forms.Button btnOnePlayer;
        private System.Windows.Forms.Button btnTwoPlayer;
        private System.Windows.Forms.GroupBox gbStart;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Button btnColorP1;
        private System.Windows.Forms.Button btnColorP2;
        private System.Windows.Forms.Label lblHighScore;
        private System.Windows.Forms.TextBox txtHighScore;
        private System.Windows.Forms.Label lblcurrScoreP1;
        private System.Windows.Forms.TextBox txtcurrScoreP1;
        private System.Windows.Forms.TextBox txtcurrScoreP2;
        private System.Windows.Forms.Label lblcurrScoreP2;
        private System.Windows.Forms.TextBox txtP2Wins;
        private System.Windows.Forms.Label lblP2Wins;
        private System.Windows.Forms.TextBox txtP1Wins;
        private System.Windows.Forms.Label lblP1Wins;
        private System.Windows.Forms.TextBox txtTies;
        private System.Windows.Forms.Label lblTies;
        private System.Windows.Forms.Button btnResetScores;
    }
}

