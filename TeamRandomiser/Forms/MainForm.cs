using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TeamRandomiser.Classes;
using TeamRandomiser.Enums;
using TeamRandomiser.Helpers;

namespace TeamRandomiser.Forms
{
    public partial class MainForm : Form
    {
        List<Player> Players = new List<Player>();

        public MainForm()
        {
            InitializeComponent();
            InitApp();
        }

        #region Init

        public void InitApp()
        {
            Players = LiteDbHelper.GetPlayers();

            #region TeamsTab

            teamsPlayerCheckListBox.DataSource = Players;
            teamsPlayerCheckListBox.DisplayMember = "Name";

            #endregion

            #region PlayersTab

            playersListBox.DataSource = Players;
            playersListBox.DisplayMember = "Name";
            var ranks = new List<string>();
            foreach (PlayerRank rank in Enum.GetValues(typeof(PlayerRank)))
            {
                ranks.Add(rank.ToString());
            }

            playerRankCombo.DataSource = ranks;

            #endregion

        }

        #endregion

        #region Methods

        #region PlayerManagement
        private void SyncPlayerList()
        {
            playersListBox.DataSource = null;
            playersListBox.DataSource = Players;
            playersListBox.DisplayMember = "Name";

            teamsPlayerCheckListBox.DataSource = null;
            teamsPlayerCheckListBox.DataSource = Players;
            teamsPlayerCheckListBox.DisplayMember = "Name";
        }

        private void SavePlayer(Player player)
        {
            LiteDbHelper.UpsertPlayer(player);

            var existingPlayer = Players.FirstOrDefault(i => i.Id == player.Id);
            if (existingPlayer != null)
            {
                Players.Remove(existingPlayer);
            }
            Players.Add(player);
            SyncPlayerList();
        }

        private void RemovePlayer(Player player)
        {
            LiteDbHelper.DeletePlayer(player);
            var existingPlayer = Players.FirstOrDefault(i => i.Id == player.Id);
            if (existingPlayer != null)
            {
                Players.Remove(existingPlayer);
            }
            SyncPlayerList();

        }

        private void NewPlayer()
        {
            playersListBox.SelectedItem = null;
            playerIgnTxtBox.Text = "";
            playerNameTxtBox.Text = "";
            playerRankCombo.SelectedIndex = 0;

            playerDetailsNameLbl.Text = "New Player";
        }

        private void ManagePlayerPartners()
        {
            var availablePlayers = Players.Select(a => a.ToPlayerRef()).ToList();
            var selectedPlayer = playersListBox.SelectedItem;
            var selectedPartners = new List<PlayerRef>();
            Player existingPlayer = null;
            if (selectedPlayer is Player player)
            {
                existingPlayer = player;
                selectedPartners = player.Partners;
            }

            var partnerSelectionForm = new PartnerSelectionForm(availablePlayers, selectedPartners);
            partnerSelectionForm.ShowDialog(this);

            selectedPartners = partnerSelectionForm.SelectedPartners;
            if (existingPlayer != null)
            {
                existingPlayer.Partners = selectedPartners;
                playerPartnersListBox.DataSource = null;
                playerPartnersListBox.DataSource = existingPlayer.Partners;
                playerPartnersListBox.DisplayMember = "Name";
            }
        }

        #endregion

        #region TeamsManagement

        private void RandomiseTeams()
        {
            var playersToRandomise = new List<Player>();
            foreach (var item in teamsPlayerCheckListBox.CheckedItems)
            {
                if (item is Player checkedPlayer)
                {
                    playersToRandomise.Add(checkedPlayer);
                }
            }

            var teamCount = playersToRandomise.Count / 2;

            var teams = new List<Team>();
            for (var i = 0; i < teamCount; i++)
            {
                teams.Add(new Team()
                {
                    Name = $"Team {i+1}"
                });
            }

            var randomMax = teams.Count - 1;
            var random = new Random();
            foreach (var player in playersToRandomise)
            {
                var teamIndex = random.Next(0, randomMax);
                var teamToInsert = teams[teamIndex];

                teamToInsert.Add(player);
            }

            teamsSelectionListBox.DataSource = null;
            teamsSelectionListBox.DataSource = teams;
            teamsSelectionListBox.DisplayMember = "Name";
        }

        #endregion

        private void ExitApp()
        {
            Application.Exit();
        }
        #endregion

        #region Events

        private void playersListBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var combo = sender;
            var playerArgs = e;

            var selectedPlayer = playersListBox.SelectedItem;
            var player = new Player();
            if (selectedPlayer is Player existingPlayer)
            {
                player = existingPlayer;
            }
            playerDetailsNameLbl.Text = player.Name;

            playerIgnTxtBox.Text = player.Name;
            playerNameTxtBox.Text = player.DisplayName;
            playerRankCombo.SelectedItem = player.Rank.ToString();
            playerPartnersListBox.DataSource= player.Partners;
            playerPartnersListBox.DisplayMember = "Name";
        }

        private void playerSaveBtn_Click(object sender, System.EventArgs e)
        {
            var selectedPlayer = playersListBox.SelectedItem;
            var playerIgn = playerIgnTxtBox.Text;
            var playerName = playerNameTxtBox.Text;
            var playerRank = playerRankCombo.SelectedItem;
            Enum.TryParse(playerRank.ToString(), out PlayerRank rank);
            var player = new Player();
            if (selectedPlayer is Player existingPlayer)
            {
                player = existingPlayer;
            }

            player.DisplayName = playerName;
            player.Name = playerIgn;
            player.Rank = rank;

            SavePlayer(player);

        }

        private void playerDeleteBtn_Click(object sender, System.EventArgs e)
        {
            var selectedPlayer = playersListBox.SelectedItem;
            Player player = null;
            if (selectedPlayer is Player existingPlayer)
            {
                player = existingPlayer;
            }

            if (player != null)
            {
                RemovePlayer(player);
            }
        }

        private void playersAddNewBtn_Click(object sender, EventArgs e)
        {
            NewPlayer();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExitApp();
        }

        private void playerPartnersAddBtn_Click(object sender, EventArgs e)
        {
            ManagePlayerPartners();
        }

        private void teamsRandomiseBtn_Click(object sender, EventArgs e)
        {
            RandomiseTeams();
        }
        #endregion

        private void teamsSelectionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            var selectedTeam = playersListBox.SelectedItem;
            var team = new Team();
            if (selectedTeam is Team existingTeam)
            {
                team = existingTeam;
            }

            teamDetailsListBox.DataSource = team;
            teamDetailsListBox.DisplayMember = "Name";
        }
    }
}
