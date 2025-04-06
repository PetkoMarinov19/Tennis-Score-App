namespace Tennis_Score_App
{
    partial class ScoreForm
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
            labelTennisScore = new Label();
            labelRanking = new Label();
            listViewRanking = new ListView();
            playerNameColumn = new ColumnHeader();
            scoreColumn = new ColumnHeader();
            labelLatestGames = new Label();
            buttonAddNewGame = new Button();
            listViewLastestGames = new ListView();
            firstPlayerColumn = new ColumnHeader();
            secondPlayerColumn = new ColumnHeader();
            winnerColumn = new ColumnHeader();
            totalScoreColumn = new ColumnHeader();
            labelClickOnName = new Label();
            SuspendLayout();
            // 
            // labelTennisScore
            // 
            labelTennisScore.Anchor = AnchorStyles.Top;
            labelTennisScore.AutoSize = true;
            labelTennisScore.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            labelTennisScore.Location = new Point(233, 9);
            labelTennisScore.Name = "labelTennisScore";
            labelTennisScore.Size = new Size(216, 45);
            labelTennisScore.TabIndex = 0;
            labelTennisScore.Text = " Tennis Score";
            // 
            // labelRanking
            // 
            labelRanking.AutoSize = true;
            labelRanking.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            labelRanking.Location = new Point(43, 92);
            labelRanking.Name = "labelRanking";
            labelRanking.Size = new Size(106, 32);
            labelRanking.TabIndex = 1;
            labelRanking.Text = "Ranking";
            // 
            // listViewRanking
            // 
            listViewRanking.BackColor = Color.Coral;
            listViewRanking.Columns.AddRange(new ColumnHeader[] { playerNameColumn, scoreColumn });
            listViewRanking.Location = new Point(43, 142);
            listViewRanking.Name = "listViewRanking";
            listViewRanking.Size = new Size(611, 97);
            listViewRanking.TabIndex = 2;
            listViewRanking.UseCompatibleStateImageBehavior = false;
            listViewRanking.View = View.Details;
            listViewRanking.Click += ViewProfileButtonClick;
            // 
            // playerNameColumn
            // 
            playerNameColumn.Text = "Player Name";
            playerNameColumn.Width = 90;
            // 
            // scoreColumn
            // 
            scoreColumn.Text = "Score";
            scoreColumn.TextAlign = HorizontalAlignment.Right;
            scoreColumn.Width = 350;
            // 
            // labelLatestGames
            // 
            labelLatestGames.AutoSize = true;
            labelLatestGames.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            labelLatestGames.Location = new Point(43, 279);
            labelLatestGames.Name = "labelLatestGames";
            labelLatestGames.Size = new Size(164, 32);
            labelLatestGames.TabIndex = 3;
            labelLatestGames.Text = "Latest Games";
            // 
            // buttonAddNewGame
            // 
            buttonAddNewGame.BackColor = Color.SteelBlue;
            buttonAddNewGame.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            buttonAddNewGame.ForeColor = Color.White;
            buttonAddNewGame.Location = new Point(442, 279);
            buttonAddNewGame.Name = "buttonAddNewGame";
            buttonAddNewGame.Size = new Size(212, 45);
            buttonAddNewGame.TabIndex = 4;
            buttonAddNewGame.Text = "Add New Game";
            buttonAddNewGame.UseVisualStyleBackColor = false;
            buttonAddNewGame.MouseClick += AddNewGameButtonClick;
            // 
            // listViewLastestGames
            // 
            listViewLastestGames.BackColor = Color.Coral;
            listViewLastestGames.Columns.AddRange(new ColumnHeader[] { firstPlayerColumn, secondPlayerColumn, winnerColumn, totalScoreColumn });
            listViewLastestGames.Location = new Point(43, 329);
            listViewLastestGames.Name = "listViewLastestGames";
            listViewLastestGames.Size = new Size(611, 97);
            listViewLastestGames.TabIndex = 5;
            listViewLastestGames.UseCompatibleStateImageBehavior = false;
            listViewLastestGames.View = View.Details;
            // 
            // firstPlayerColumn
            // 
            firstPlayerColumn.Text = "First Player";
            firstPlayerColumn.Width = 90;
            // 
            // secondPlayerColumn
            // 
            secondPlayerColumn.Text = "Second Player";
            secondPlayerColumn.TextAlign = HorizontalAlignment.Right;
            secondPlayerColumn.Width = 200;
            // 
            // winnerColumn
            // 
            winnerColumn.Text = "Winner";
            winnerColumn.TextAlign = HorizontalAlignment.Right;
            winnerColumn.Width = 100;
            // 
            // totalScoreColumn
            // 
            totalScoreColumn.Text = "Score";
            totalScoreColumn.TextAlign = HorizontalAlignment.Right;
            totalScoreColumn.Width = 200;
            // 
            // labelClickOnName
            // 
            labelClickOnName.AutoSize = true;
            labelClickOnName.Location = new Point(43, 242);
            labelClickOnName.Name = "labelClickOnName";
            labelClickOnName.Size = new Size(384, 15);
            labelClickOnName.TabIndex = 6;
            labelClickOnName.Text = " *click on a player's name to see more information about their matches.";
            // 
            // ScoreForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(670, 450);
            Controls.Add(labelClickOnName);
            Controls.Add(listViewLastestGames);
            Controls.Add(buttonAddNewGame);
            Controls.Add(labelLatestGames);
            Controls.Add(listViewRanking);
            Controls.Add(labelRanking);
            Controls.Add(labelTennisScore);
            Name = "ScoreForm";
            Text = "ScoreForm";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTennisScore;
        private Label labelRanking;
        private ListView listViewRanking;
        private Label labelLatestGames;
        private Button buttonAddNewGame;
        private ColumnHeader playerNameColumn;
        private ColumnHeader scoreColumn;
        private ListView listViewLastestGames;
        private ColumnHeader firstPlayerColumn;
        private ColumnHeader secondPlayerColumn;
        private ColumnHeader winnerColumn;
        private ColumnHeader totalScoreColumn;
        private Label labelClickOnName;
    }
}