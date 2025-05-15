using System;
using System.Windows.Forms;

namespace Tennis_Score_App
{
    public partial class NewGameForm : Form
    {
        private string playerName;
        public (string, int) FirstPlayer { get; set; }
        public (string, int) SecondPlayer { get; set; }

        public NewGameForm()
        {
            InitializeComponent();

            buttonSaveGame.Enabled = false;

            textBoxFisrtPlayerName.TextChanged += ValidateInputs;
            textBoxSecondPlayerName.TextChanged += ValidateInputs;
        }

        private void ValidateInputs(object sender, EventArgs e)
        {
            string firstName = textBoxFisrtPlayerName.Text.Trim();
            string secondName = textBoxSecondPlayerName.Text.Trim();

            bool namesAreNotEmpty = !string.IsNullOrWhiteSpace(firstName) && !string.IsNullOrWhiteSpace(secondName);
            bool namesAreDifferent = !firstName.Equals(secondName, StringComparison.OrdinalIgnoreCase);

            buttonSaveGame.Enabled = namesAreNotEmpty && namesAreDifferent;
        }

        private void ButtonSaveGameClick(object sender, EventArgs e)
        {
            // Допълнителна проверка при Save натискане - предпазва от грешки, ако бутонът е активиран по погрешка
            string firstName = textBoxFisrtPlayerName.Text.Trim();
            string secondName = textBoxSecondPlayerName.Text.Trim();

            if (firstName.Equals(secondName, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Player names must be different.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FirstPlayer = (firstName, (int)numericUpDownFirstPlayerPoints.Value);
            SecondPlayer = (secondName, (int)numericUpDownSecondPlayerPoints.Value);

            this.DialogResult = DialogResult.OK;
        }

        // Останалите евентуални методи (например празни обработчици) можеш да оставиш както са или да ги махнеш ако не се ползват
        private void listView2_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
    }
}
