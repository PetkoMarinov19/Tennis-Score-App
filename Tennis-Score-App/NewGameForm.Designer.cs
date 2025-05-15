namespace Tennis_Score_App
{
    partial class NewGameForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBoxFisrtPlayerName = new TextBox();
            textBoxSecondPlayerName = new TextBox();
            numericUpDownFirstPlayerPoints = new NumericUpDown();
            numericUpDownSecondPlayerPoints = new NumericUpDown();
            buttonSaveGame = new Button();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFirstPlayerPoints).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSecondPlayerPoints).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(299, 31);
            label1.Name = "label1";
            label1.Size = new Size(211, 50);
            label1.TabIndex = 0;
            label1.Text = "New Game";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.Location = new Point(98, 120);
            label2.Name = "label2";
            label2.Size = new Size(144, 32);
            label2.TabIndex = 1;
            label2.Text = "First Player";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label3.Location = new Point(477, 120);
            label3.Name = "label3";
            label3.Size = new Size(171, 32);
            label3.TabIndex = 2;
            label3.Text = "Second Player";
            label3.Click += label3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label5.Location = new Point(157, 266);
            label5.Name = "label5";
            label5.Size = new Size(85, 32);
            label5.TabIndex = 6;
            label5.Text = "Points";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label6.Location = new Point(553, 266);
            label6.Name = "label6";
            label6.Size = new Size(85, 32);
            label6.TabIndex = 7;
            label6.Text = "Points";
            label6.Click += label6_Click;
            // 
            // textBoxFisrtPlayerName
            // 
            textBoxFisrtPlayerName.BackColor = Color.Coral;
            textBoxFisrtPlayerName.Location = new Point(98, 164);
            textBoxFisrtPlayerName.Multiline = true;
            textBoxFisrtPlayerName.Name = "textBoxFisrtPlayerName";
            textBoxFisrtPlayerName.Size = new Size(247, 28);
            textBoxFisrtPlayerName.TabIndex = 1;
            // 
            // textBoxSecondPlayerName
            // 
            textBoxSecondPlayerName.BackColor = Color.Coral;
            textBoxSecondPlayerName.Location = new Point(477, 164);
            textBoxSecondPlayerName.Multiline = true;
            textBoxSecondPlayerName.Name = "textBoxSecondPlayerName";
            textBoxSecondPlayerName.Size = new Size(240, 28);
            textBoxSecondPlayerName.TabIndex = 9;
            // 
            // numericUpDownFirstPlayerPoints
            // 
            numericUpDownFirstPlayerPoints.Location = new Point(175, 318);
            numericUpDownFirstPlayerPoints.Name = "numericUpDownFirstPlayerPoints";
            numericUpDownFirstPlayerPoints.Size = new Size(35, 23);
            numericUpDownFirstPlayerPoints.TabIndex = 10;
            // 
            // numericUpDownSecondPlayerPoints
            // 
            numericUpDownSecondPlayerPoints.Location = new Point(581, 318);
            numericUpDownSecondPlayerPoints.Name = "numericUpDownSecondPlayerPoints";
            numericUpDownSecondPlayerPoints.Size = new Size(39, 23);
            numericUpDownSecondPlayerPoints.TabIndex = 11;
            // 
            // buttonSaveGame
            // 
            buttonSaveGame.BackColor = Color.SteelBlue;
            buttonSaveGame.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            buttonSaveGame.ForeColor = Color.White;
            buttonSaveGame.Location = new Point(353, 383);
            buttonSaveGame.Name = "buttonSaveGame";
            buttonSaveGame.Size = new Size(136, 42);
            buttonSaveGame.TabIndex = 12;
            buttonSaveGame.Text = "Save";
            buttonSaveGame.UseVisualStyleBackColor = false;
            buttonSaveGame.Click += ButtonSaveGameClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Matura MT Script Capitals", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(353, 248);
            label7.Name = "label7";
            label7.Size = new Size(102, 50);
            label7.TabIndex = 13;
            label7.Text = "VS";
            // 
            // NewGameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(833, 450);
            Controls.Add(label7);
            Controls.Add(buttonSaveGame);
            Controls.Add(numericUpDownSecondPlayerPoints);
            Controls.Add(numericUpDownFirstPlayerPoints);
            Controls.Add(textBoxSecondPlayerName);
            Controls.Add(textBoxFisrtPlayerName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.Black;
            Name = "NewGameForm";
            Text = "NewGameForm";
            ((System.ComponentModel.ISupportInitialize)numericUpDownFirstPlayerPoints).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSecondPlayerPoints).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private TextBox textBoxFisrtPlayerName;
        private TextBox textBoxSecondPlayerName;
        private NumericUpDown numericUpDownFirstPlayerPoints;
        private NumericUpDown numericUpDownSecondPlayerPoints;
        private Button buttonSaveGame;
        private Label label7;
    }
}