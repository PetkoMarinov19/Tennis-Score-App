namespace Tennis_Score_App
{
    partial class PlayerInfoForm
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
            labelPlayerName = new Label();
            labelVictories = new Label();
            labelLosses = new Label();
            labelDraw = new Label();
            listViewVictories = new ListView();
            competitorVictories = new ColumnHeader();
            scoreVictories = new ColumnHeader();
            listViewLosses = new ListView();
            competitorLosses = new ColumnHeader();
            scoreLosses = new ColumnHeader();
            listViewDraw = new ListView();
            competitorDraw = new ColumnHeader();
            scoreDraw = new ColumnHeader();
            SuspendLayout();
            // 
            // labelPlayerName
            // 
            labelPlayerName.AutoSize = true;
            labelPlayerName.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            labelPlayerName.Location = new Point(321, 49);
            labelPlayerName.Name = "labelPlayerName";
            labelPlayerName.Size = new Size(193, 40);
            labelPlayerName.TabIndex = 0;
            labelPlayerName.Text = "Player Name";
            // 
            // labelVictories
            // 
            labelVictories.AutoSize = true;
            labelVictories.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            labelVictories.Location = new Point(61, 178);
            labelVictories.Name = "labelVictories";
            labelVictories.Size = new Size(99, 30);
            labelVictories.TabIndex = 1;
            labelVictories.Text = "Victories";
            // 
            // labelLosses
            // 
            labelLosses.AutoSize = true;
            labelLosses.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            labelLosses.Location = new Point(369, 178);
            labelLosses.Name = "labelLosses";
            labelLosses.Size = new Size(74, 30);
            labelLosses.TabIndex = 2;
            labelLosses.Text = "Losses";
            // 
            // labelDraw
            // 
            labelDraw.AutoSize = true;
            labelDraw.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            labelDraw.Location = new Point(637, 178);
            labelDraw.Name = "labelDraw";
            labelDraw.Size = new Size(66, 30);
            labelDraw.TabIndex = 3;
            labelDraw.Text = "Draw";
            // 
            // listViewVictories
            // 
            listViewVictories.BackColor = Color.Coral;
            listViewVictories.Columns.AddRange(new ColumnHeader[] { competitorVictories, scoreVictories });
            listViewVictories.Location = new Point(26, 227);
            listViewVictories.Name = "listViewVictories";
            listViewVictories.Size = new Size(212, 126);
            listViewVictories.TabIndex = 4;
            listViewVictories.UseCompatibleStateImageBehavior = false;
            listViewVictories.View = View.Details;
            // 
            // competitorVictories
            // 
            competitorVictories.Text = "Competitor";
            competitorVictories.Width = 90;
            // 
            // scoreVictories
            // 
            scoreVictories.Text = "Score";
            scoreVictories.TextAlign = HorizontalAlignment.Right;
            scoreVictories.Width = 90;
            // 
            // listViewLosses
            // 
            listViewLosses.BackColor = Color.Coral;
            listViewLosses.Columns.AddRange(new ColumnHeader[] { competitorLosses, scoreLosses });
            listViewLosses.Location = new Point(300, 227);
            listViewLosses.Name = "listViewLosses";
            listViewLosses.Size = new Size(214, 126);
            listViewLosses.TabIndex = 5;
            listViewLosses.UseCompatibleStateImageBehavior = false;
            listViewLosses.View = View.Details;
            // 
            // competitorLosses
            // 
            competitorLosses.Text = "Competitor";
            competitorLosses.Width = 90;
            // 
            // scoreLosses
            // 
            scoreLosses.Text = "Score";
            scoreLosses.TextAlign = HorizontalAlignment.Right;
            scoreLosses.Width = 90;
            // 
            // listViewDraw
            // 
            listViewDraw.BackColor = Color.Coral;
            listViewDraw.Columns.AddRange(new ColumnHeader[] { competitorDraw, scoreDraw });
            listViewDraw.Location = new Point(566, 227);
            listViewDraw.Name = "listViewDraw";
            listViewDraw.Size = new Size(216, 126);
            listViewDraw.TabIndex = 6;
            listViewDraw.UseCompatibleStateImageBehavior = false;
            listViewDraw.View = View.Details;
            // 
            // competitorDraw
            // 
            competitorDraw.Text = "Competitor";
            competitorDraw.Width = 90;
            // 
            // scoreDraw
            // 
            scoreDraw.Text = "Score";
            scoreDraw.TextAlign = HorizontalAlignment.Right;
            scoreDraw.Width = 90;
            // 
            // PlayerInfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(listViewDraw);
            Controls.Add(listViewLosses);
            Controls.Add(listViewVictories);
            Controls.Add(labelDraw);
            Controls.Add(labelLosses);
            Controls.Add(labelVictories);
            Controls.Add(labelPlayerName);
            Name = "PlayerInfoForm";
            Text = "PlayerInfoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPlayerName;
        private Label labelVictories;
        private Label labelLosses;
        private Label labelDraw;
        private ListView listViewVictories;
        private ColumnHeader competitorVictories;
        private ColumnHeader scoreVictories;
        private ListView listViewLosses;
        private ListView listViewDraw;
        private ColumnHeader competitorLosses;
        private ColumnHeader scoreLosses;
        private ColumnHeader competitorDraw;
        private ColumnHeader scoreDraw;
    }
}