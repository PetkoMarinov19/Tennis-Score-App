
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        
        private void ButtonSaveGameClick(object sender, EventArgs e)
        {
            FirstPlayer = (textBoxFisrtPlayerName.Text, (int)numericUpDownFirstPlayerPoints.Value);
            SecondPlayer = (textBoxSecondPlayerName.Text,(int)numericUpDownSecondPlayerPoints.Value);     
            
            // ДА СЕ ДОВЪРШИ ОБРАБОТКАТА НА ГРЕШКИ

            this.DialogResult = DialogResult.OK;
        }
    }
}
