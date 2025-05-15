using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Tennis_Score_App
{
    public partial class ScoreForm : Form
    {
        private static Dictionary<string, int> playersWithPoints = new Dictionary<string, int>();

        private static Dictionary<(string, int), List<(string, int)>> games = new() {
            { ("Dimitrov", 3), new List<(string, int)>{ ("Nadal", 2), ("Jokovich", 2)} },
            { ("Nadal", 3), new List<(string, int)>{("Federer", 1)} },
            { ("Dimitrov", 2), new List<(string, int)>{("Federer", 3)} }
        };

        public ScoreForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            playersWithPoints.Add("Dimitrov", 1);
            playersWithPoints.Add("Federer", 2);
            playersWithPoints.Add("Nadal", 3);

            FillRankingListView();
            FillLatestGamesListView();
        }

        private void FillRankingListView()
        {
            listViewRanking.Items.Clear();
            foreach (var player in playersWithPoints)
            {
                ListViewItem item = new ListViewItem(player.Key);
                item.SubItems.Add(player.Value.ToString());
                listViewRanking.Items.Add(item);
            }
        }

        private void FillListView((string, int) FirstPlayer, (string, int) SecondPlayer)
        {
            string winner = GetWinner(FirstPlayer, SecondPlayer);
            string score = $"{FirstPlayer.Item2} : {SecondPlayer.Item2}";

            ListViewItem item = new ListViewItem(FirstPlayer.Item1);
            item.SubItems.Add(SecondPlayer.Item1);
            item.SubItems.Add(winner);
            item.SubItems.Add(score);

            listViewLastestGames.Items.Add(item);
        }

        private string GetWinner((string, int) FirstPlayer, (string, int) SecondPlayer)
        {
            if (FirstPlayer.Item2 > SecondPlayer.Item2)
                return FirstPlayer.Item1;
            else if (SecondPlayer.Item2 > FirstPlayer.Item2)
                return SecondPlayer.Item1;
            else
                return "Draw";
        }

        private void FillLatestGamesListView()
        {
            listViewLastestGames.Items.Clear();
            foreach (var game in games)
            {
                foreach (var opponent in game.Value)
                {
                    FillListView(game.Key, opponent);
                }
            }
        }

        private void AddNewGameButtonClick(object sender, MouseEventArgs e)
        {
            using (NewGameForm newGameForm = new NewGameForm())
            {
                if (newGameForm.ShowDialog() == DialogResult.OK)
                {
                    AddNewGame(newGameForm.FirstPlayer, newGameForm.SecondPlayer);
                }
            }
        }

        private void AddNewGame((string, int) firstPlayer, (string, int) secondPlayer)
        {
            // Актуализиране на точките на играчите
            UpdatePlayerPoints(firstPlayer);
            UpdatePlayerPoints(secondPlayer);

            // Добавяне на новата игра в games
            if (games.ContainsKey(firstPlayer))
            {
                games[firstPlayer].Add(secondPlayer);
            }
            else
            {
                games[firstPlayer] = new List<(string, int)> { secondPlayer };
            }

            // Актуализиране на ListView компонентите
            FillRankingListView();
            FillLatestGamesListView();
        }

        private void UpdatePlayerPoints((string, int) player)
        {
            if (playersWithPoints.ContainsKey(player.Item1))
            {
                playersWithPoints[player.Item1] += player.Item2;
            }
            else
            {
                playersWithPoints[player.Item1] = player.Item2;
            }
        }

        private void ViewProfileButtonClick(object sender, EventArgs e)
        {
            if (listViewRanking.SelectedItems.Count == 0) return;

            ListViewItem selectedRow = listViewRanking.SelectedItems[0];
            string playerName = selectedRow.SubItems[0].Text;

            using (PlayerInfoForm playerInfoForm = new PlayerInfoForm(playerName, GetPlayerGames(playerName)))
            {
                playerInfoForm.ShowDialog();
            }
        }

        private Dictionary<(string, int), List<(string, int)>> GetPlayerGames(string playerName)
        {
            return games
                .Where(x => x.Key.Item1 == playerName || x.Value.Any(y => y.Item1 == playerName))
                .ToDictionary(
                    x => x.Key,
                    x => x.Value.Where(y => y.Item1 == playerName || x.Key.Item1 == playerName).ToList()
                );
        }
    }
}

