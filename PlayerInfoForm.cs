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
    public partial class PlayerInfoForm : Form
    {
        private string playerName = "Unknown";
        private Dictionary<(string, int), List<(string, int)>> games = new();
        
        private (string, int) currentPlayer = new();
        private (string, int) competitor = new();


        public PlayerInfoForm()
        {
            InitializeComponent();
        }

        public PlayerInfoForm(string playerName, Dictionary<(string, int), List<(string, int)>> games)
        {
            InitializeComponent();
            this.games = games;
            this.playerName = playerName;
            this.labelPlayerName.Text = playerName;        
            FillVictoriesAndLossesListViews();
        }

        private void FillVictoriesAndLossesListViews() {

            //ClearListViews
            foreach (var game in games) {
                string firstPlayerName = game.Key.Item1;
                int firstPlayerPoints = game.Key.Item2;

                //currentPlayer.Item1 = firstPlayerName;
                //currentPlayer.Item2 = firstPlayerPoints;

                foreach (var item in game.Value) {

                    string secondPlayerName = item.Item1;
                    int secondPlayerPoints = item.Item2;

                    //competitor.Item1 = secondPlayerName;
                    //competitor.Item2 = secondPlayerPoints;

                    (this.currentPlayer, this.competitor) =
                        GetCurrentPlayerAndCompetitor((firstPlayerName, firstPlayerPoints),
                                                        (secondPlayerName, secondPlayerPoints));



                    UpdateListView();
                }
            }
        }

        private void UpdateListView() {
            string competitorName = competitor.Item1;
            int competitorPoints = competitor.Item2;
            int currentPlayerPoints = currentPlayer.Item2;

            string score = $"{currentPlayerPoints} - {competitorPoints}";
            ListView currentListView = GetCurrentListView(currentPlayerPoints, competitorPoints);
            AddDataToListView(competitorName, score, currentListView);
        }


        void AddDataToListView(string competitor, String score, ListView listView) { 
            ListViewItem listViewItem = new ListViewItem();
            listViewItem.SubItems[0].Text = competitor;
            listViewItem.SubItems.Add(score);   
            listView.Items.Add(listViewItem);
        }


        private ListView GetCurrentListView(int currentPlayerPoints, int competitorPoints) {
            // ЗА ДОВЪРШВАНЕ:
            // тук в зависимост от currentPlayerPoints, int competitorPoints трябва да върнеш
            // listViewVictories, listViewlosses или listViewDraw
            // 
            return listViewVictories;
        }


        private ((string, int), (string, int)) GetCurrentPlayerAndCompetitor((string, int) firstPlayer, (string, int) secondPlayer) {
            if (firstPlayer.Item1 == playerName)
            {
                return (firstPlayer, secondPlayer);
            }
            else { 
                return (secondPlayer, firstPlayer);
            }
        }
    }
}
