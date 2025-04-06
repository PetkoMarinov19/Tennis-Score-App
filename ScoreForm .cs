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

        // Popylva tablicata s igrachite
        private void FillRankingListView()
        {
            this.listViewRanking.Items.Clear();
            foreach (var player in playersWithPoints)
            {

                string playerName = player.Key;
                string playerPoints = player.Value.ToString();

                ListViewItem item = new();
                item.SubItems[0].Text = playerName;
                item.SubItems.Add(playerPoints);
                this.listViewRanking.Items.Add(item);

            }
        }

        // Добавя ред в таблицата с мачовете
        private void FillListView((String, int) FirstPlayer, (String, int) SecondPlayer)
        {

            string winner = GetWinner(FirstPlayer, SecondPlayer);
            string score = FirstPlayer.Item2 + " : " + SecondPlayer.Item2;

            ListViewItem item = new ListViewItem();
            item.SubItems[0].Text = FirstPlayer.Item1;
            item.SubItems.Add(SecondPlayer.Item1);
            item.SubItems.Add(winner);
            item.SubItems.Add(score);
            listViewLastestGames.Items.Add(item);
        }

        //
        // Тук трябва да определиш кой е победителя
        //
        private string GetWinner((String, int) FirstPlayer, (String, int) SecondPlayer)
        {
            // ДА СЕ ДОВЪРШИ
            // точките на първия са FirstPlayer.Item2, на втория - SecondPlayer.Item2
            return "Who is the winner";
        }

        //
        // Попълва Latest Games 
        //
        private void FillLatestGamesListView()
        {
            this.listViewLastestGames.Items.Clear();
            foreach (var game in games)
            {
                foreach (var item in game.Value)
                {
                    FillListView(game.Key, item);
                }
            }

        }

        //
        // Показва формата с инфо за мачовете на играча на клик
        //
        private void ViewProfileButtonClick(object sender, EventArgs e)
        {
 

            ListViewItem selectedRow = this.listViewRanking.SelectedItems[0];

            var playerNameCell = selectedRow.SubItems[0];

            var playerName = playerNameCell.Text;

            using (PlayerInfoForm playerInfoForm = new PlayerInfoForm(playerName, GetPlayerGames(playerName)))
            {
                playerInfoForm.ShowDialog();
            }
        }

        Dictionary<(string, int), List<(string, int)>> GetPlayerGames(string PlayerName)
        {
            Dictionary<(string, int), List<(string, int)>> playerGames = new();

            playerGames = games.Where(x => x.Key.Item1 == PlayerName || x.Value.Any(y => y.Item1 == PlayerName))
            .ToDictionary(x => x.Key, x => x.Value.Where(y => y.Item1 == PlayerName || x.Key.Item1 == PlayerName)
            .ToList());
            return playerGames;

            //=> games.Where(x => x.Key.Item1 == PlayerName || x.Value.Any(y => y.Item1 == PlayerName))
            //.ToDictionary(x => x.Key, x => x.Value.Where(y => y.Item1 == PlayerName || x.Key.Item1 == PlayerName)
            //.ToList());
        }

        private void AddNewGameButtonClick(object sender, MouseEventArgs e)
        {
            using (NewGameForm newGameForm = new NewGameForm())
            {             
                if (newGameForm.ShowDialog() == DialogResult.OK) {
                    AddNewGame(newGameForm.FirstPlayer, newGameForm.SecondPlayer);
                }
            }
        }


        private void AddNewGame((string, int) firstPlayer, (String, int) secondPlayer) {
            // ДА СЕ ДОВЪРШИ
            //FillGamesData(firstPlayer, secondPlayer);
            //FillPlayerWithPoints(firstPlayer);
            //FillPlayerWithPoints(secondPlayer);
            
            FillRankingListView();
            FillLatestGamesListView();
        }
    };


}
