using System;
using System.Collections.Generic;
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
            InitializeListViewColumns();
        }

        public PlayerInfoForm(string playerName, Dictionary<(string, int), List<(string, int)>> games)
        {
            InitializeComponent();
            this.games = games;
            this.playerName = playerName;
            InitializeListViewColumns();
            this.labelPlayerName.Text = playerName;
            FillVictoriesAndLossesListViews();
        }

        private void InitializeListViewColumns()
        {
            // Инициализация на колоните за Победи
            listViewVictories.Columns.Clear();
            listViewVictories.Columns.Add("Opponent", 150);
            listViewVictories.Columns.Add("Score", 100);
            listViewVictories.View = View.Details;

            // Инициализация на колоните за Загуби
            listViewLosses.Columns.Clear();
            listViewLosses.Columns.Add("Opponent", 150);
            listViewLosses.Columns.Add("Score", 100);
            listViewLosses.View = View.Details;

            // Инициализация на колоните за Равенства
            listViewDraw.Columns.Clear();
            listViewDraw.Columns.Add("Opponent", 150);
            listViewDraw.Columns.Add("Score", 100);
            listViewDraw.View = View.Details;
        }

        private void FillVictoriesAndLossesListViews()
        {
            // Изчистваме всички ListView преди попълване
            listViewVictories.Items.Clear();
            listViewLosses.Items.Clear();
            listViewDraw.Items.Clear();

            foreach (var game in games)
            {
                string firstPlayerName = game.Key.Item1;
                int firstPlayerPoints = game.Key.Item2;

                foreach (var item in game.Value)
                {
                    string secondPlayerName = item.Item1;
                    int secondPlayerPoints = item.Item2;

                    (this.currentPlayer, this.competitor) =
                        GetCurrentPlayerAndCompetitor((firstPlayerName, firstPlayerPoints),
                                                     (secondPlayerName, secondPlayerPoints));

                    UpdateListView();
                }
            }
        }

        private void UpdateListView()
        {
            string competitorName = competitor.Item1;
            int competitorPoints = competitor.Item2;
            int currentPlayerPoints = currentPlayer.Item2;

            string score = $"{currentPlayerPoints} - {competitorPoints}";
            ListView currentListView = GetCurrentListView(currentPlayerPoints, competitorPoints);
            AddDataToListView(competitorName, score, currentListView);
        }

        private void AddDataToListView(string competitor, string score, ListView listView)
        {
            ListViewItem listViewItem = new ListViewItem(competitor);
            listViewItem.SubItems.Add(score);
            listView.Items.Add(listViewItem);
        }

        private ListView GetCurrentListView(int currentPlayerPoints, int competitorPoints)
        {
            if (currentPlayerPoints > competitorPoints)
            {
                return listViewVictories;
            }
            else if (currentPlayerPoints < competitorPoints)
            {
                return listViewLosses;
            }
            else
            {
                return listViewDraw;
            }
        }

        private ((string, int), (string, int)) GetCurrentPlayerAndCompetitor((string, int) firstPlayer, (string, int) secondPlayer)
        {
            if (firstPlayer.Item1 == playerName)
            {
                return (firstPlayer, secondPlayer);
            }
            else
            {
                return (secondPlayer, firstPlayer);
            }
        }
    }
}
