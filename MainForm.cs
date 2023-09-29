using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Configuration;
using System.Windows.Forms;

using Button = System.Windows.Forms.Button;
using Label = System.Windows.Forms.Label;
using ListBox = System.Windows.Forms.ListBox;
using TextBox = System.Windows.Forms.TextBox;

namespace SummonerNotes {
    public partial class MainForm : Form {
        private const string RiotApiBaseUrl = "https://na1.api.riotgames.com";
        private const string RiotApiSecondUrl = "https://americas.api.riotgames.com";
        public string match = "";
        public string puuid = "";
        public List<string> PlayerNames = new List<string>();
        public List<string> participantIds = new List<string>();
        private List<string> StrongList = new List<string>();
        private List<string> WeakList = new List<string>();
        public string[] InstructionLists = new string[] { ($"1/4\tSummoner Notes is an application for recording notes on different players that you meet while playing League of Legends.\n\nTo do this it uses the Riot API to lookup the names of the players on each team and allows you to add players you meet to one of two list:\n\nList 1 is for players you felt were playing skillfully or who overall impressed you and that you'd want to play around if you meet them again in the future.\n\nList 2 is for players you felt were playing poorly and who you'd not put your life in the hands of in the future.\n\nThe value of this application is determined by how you chose to use it.\n\nWhen used correctly, you are able to prepare yourself and play around your strongest allies.\n\nIt also allows you to know who on the enemy team you need to shutdown."), ($"2/4\tUsages:\n\nSummoner Notes is an effective tool for a few different tasks a player may wish to complete in their time playing league."), ($"3/4\tPlayer Details and History"), ($"4/4\tMaking Valuable notes for the future") };
        public int InstructionPage = 1;
        public MainForm() {
            InitializeComponent();
            LoadListsFromFile();

            WeakBox.DrawItem += WeakBox_DrawItem;
            StrongBox.DrawItem += StrongBox_DrawItem;
            WeakBox.SelectedIndexChanged += SelectedChanged;
            StrongBox.SelectedIndexChanged += SelectedChanged;
            AlliedBox.SelectedIndexChanged += SelectedChanged;
            EnemyBox.SelectedIndexChanged += SelectedChanged;
        }

        // Public Methods
        public void LoadListsFromFile() {
            if (System.IO.File.Exists("./lists.txt")) {
                StrongList.Clear();
                WeakList.Clear();

                string[] lines = System.IO.File.ReadAllLines("./lists.txt");
                foreach (string line in lines) {
                    if (!string.IsNullOrWhiteSpace(line)) {
                        if (line.StartsWith("List1: ")) {
                            StrongList.Add(line.Substring(7)); // Remove "List1: " prefix
                        }
                        else if (line.StartsWith("List2: ")) {
                            WeakList.Add(line.Substring(7)); // Remove "List2: " prefix
                        }
                    }
                    UpdateLists();
                }
            }
        }
        public void SaveListsToFile() {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter("./lists.txt")) {
                foreach (string name in StrongList) {
                    file.WriteLine($"List1: {name}");
                }
                foreach (string name in WeakList) {
                    file.WriteLine($"List2: {name}");
                }
            }
        }
        public void UpdateLists() {
            StrongBox.Items.Clear();
            WeakBox.Items.Clear();
            StrongBox.Items.AddRange(StrongList.ToArray());
            WeakBox.Items.AddRange(WeakList.ToArray());
        }

        // Private Methods
        private void AddButton_Click(object sender, EventArgs e) {
            if (AlliedBox.SelectedIndex != -1) {
                string selectedPlayer = AlliedBox.SelectedItem.ToString();
                string reason = InputBox.Show("Add Player", $"Notes for {selectedPlayer}?");
                string selectedList = "";
                if (!string.IsNullOrWhiteSpace(reason)) {
                    if (StrongRadioButton.Checked) {
                        StrongList.Add($"{selectedPlayer}: {reason}");
                        selectedList = "Strong List";
                    }
                    else if (WeakRadioButton.Checked) {
                        WeakList.Add($"{selectedPlayer}: {reason}");
                        selectedList = "Weak List";
                    }
                    UpdateLists();
                    MessageBox.Show($"{selectedPlayer} added to the {selectedList} with reason: {reason}");
                }
            }
            else if (EnemyBox.SelectedIndex != -1) {
                string selectedPlayer = EnemyBox.SelectedItem.ToString();
                string reason = InputBox.Show("Add Player", $"Notes for {selectedPlayer}?");
                string selectedList = "";
                if (!string.IsNullOrWhiteSpace(reason)) {
                    if (StrongRadioButton.Checked) {
                        StrongList.Add($"{selectedPlayer}: {reason}");
                        selectedList = "Strong List";
                    }
                    else if (WeakRadioButton.Checked) {
                        WeakList.Add($"{selectedPlayer}: {reason}");
                        selectedList = "Weak List";
                    }
                    UpdateLists();
                    MessageBox.Show($"{selectedPlayer} added to the {selectedList} with reason: {reason}");

                }
            }
        }
        private void CheckSelection(ListBox listBox, ListBox Reference) {
            if (listBox != Reference) {
                ClearSelection(Reference);
            }
        }
        private void ClearButton_Click(object sender, EventArgs e) {
            StrongList.Clear();
            WeakList.Clear();
            SaveListsToFile();
            LoadListsFromFile();
            UpdateLists();
        }
        private void ClearSelection(ListBox listBox) {
            listBox.SelectedIndexChanged -= SelectedChanged;
            listBox.SelectedIndex = -1;
            listBox.SelectedIndexChanged += SelectedChanged;
        }
        private void DetailsButton_Click(object sender, EventArgs e) {
            if (WeakBox.SelectedIndex != -1) {
                ShowDetailsForm(WeakBox.SelectedItem.ToString());
            }
            else if (StrongBox.SelectedIndex != -1) {
                ShowDetailsForm(StrongBox.SelectedItem.ToString());
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            SaveListsToFile();
        }
        private void RefreshButton_Click(object sender, EventArgs e) {
            // Clear and repopulate the player list
            AlliedBox.Items.Clear();
            LookupButton.PerformClick();

        }
        private void RemoveButton_Click(object sender, EventArgs e) {
            if (StrongBox.SelectedIndex != -1) {
                string selectedPlayer = StrongBox.SelectedItem.ToString(); // Use SelectedItem instead of SelectedValue
                StrongList.Remove(selectedPlayer); // Remove the entire entry
            }
            else if (WeakBox.SelectedIndex != -1) {
                string selectedPlayer = WeakBox.SelectedItem.ToString(); // Use SelectedItem instead of SelectedValue
                WeakList.Remove(selectedPlayer); // Remove the entire entry
            }
            UpdateLists();
        }
        private void SelectedChanged(object sender, EventArgs e) {
            ListBox selectedListBox = (ListBox) sender;

            CheckSelection(selectedListBox, StrongBox);
            CheckSelection(selectedListBox, WeakBox);
            CheckSelection(selectedListBox, AlliedBox);
            CheckSelection(selectedListBox, EnemyBox);
        }


        private void ShowDetailsForm(string selectedItemDetails) {
            DetailsForm detailsForm = new DetailsForm(selectedItemDetails);
            detailsForm.ShowDialog();
        }
        private void StrongBox_DrawItem(object sender, DrawItemEventArgs e) {
        }
        private void WeakBox_DrawItem(object sender, DrawItemEventArgs e) {
        }

        private void PreviousButton_Click(object sender, EventArgs e) {
            int newpage = InstructionPage > 1 ? InstructionPage -= 1 : InstructionPage;
            if (newpage == 1) {
                PreviousButton.Visible = false;
            }
            NextButton.Visible = true;
            Instructions.Text = $"{InstructionLists[newpage - 1]}";
        }
        private void NextButton_Click(object sender, EventArgs e) {
            int newpage = InstructionPage < 4 ? InstructionPage += 1 : InstructionPage;
            if (newpage == 4) {
                NextButton.Visible = false;
            }
            PreviousButton.Visible = true;
            Instructions.Text = $"{InstructionLists[newpage - 1]}";

        }

        private void StrongRadioButton_CheckedChanged(object sender, EventArgs e) {

        }

        private void WeakRadioButton_CheckedChanged(object sender, EventArgs e) {

        }
        private void EnemyLabel_Click(object sender, EventArgs e) {

        }

        private void Instructions_TextChanged(object sender, EventArgs e) {

        }

        private void SummonerBox_Enter(object sender, EventArgs e) {
            if (SummonerBox.Text == "Name...") {
                SummonerBox.Text = "";
            }
        }

        private void SummonerBox_Leave(object sender, EventArgs e) {
            if (SummonerBox.Text == "") {
                SummonerBox.Text = "Name...";
            }
        }

        private void LookupButton_MouseClick(object sender, EventArgs e) {
            GetPlayers();
        }


        private async void GetPlayers() {
            string RiotApiKey = WebConfigurationManager.AppSettings["RiotApiKey"];
            using (HttpClient client = new HttpClient()) {
                string summonerNamesEndpoint = "/lol/summoner/v4/summoners/by-name/";

                List<string> participantNames = new List<string>();

                string player = SummonerBox.Text;
                string CurrentSummonerName = player;
                Console.WriteLine(Uri.EscapeDataString(CurrentSummonerName));
                UriBuilder GetSummonerUri = new UriBuilder(RiotApiBaseUrl + summonerNamesEndpoint + Uri.EscapeDataString(CurrentSummonerName)) {
                    Query = $"api_key={RiotApiKey}"
                };

                try {
                    HttpResponseMessage response = await client.GetAsync(GetSummonerUri.Uri);
                    if (response.IsSuccessStatusCode) {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        int lineNumber = 1;
                        foreach (string line in responseBody.Split(new char[] { ',' })) {
                            string[] lineParts = line.Split(':');
                            string CleanedLine = $"{lineParts[0]} : {lineParts[1]}";
                            if (lineParts[0].Trim() == "\"name\"") {
                                participantNames.Add(lineParts[1]);
                            }
                            else if (lineParts[0].Trim() == "\"puuid\"") {

                                puuid = lineParts[1];
                                puuid = puuid.Substring(1, puuid.Length - 2);
                                Console.WriteLine($"{puuid}");
                            }
                            Console.WriteLine($"Line {lineNumber}: {CleanedLine}");
                            lineNumber++;
                        }
                    }
                }
                catch (Exception) {

                }
            }
            using (HttpClient client2 = new HttpClient()) {
                string matchesEndpoint = $"/lol/match/v5/matches/by-puuid/{puuid}/ids";
                UriBuilder GetMatchesUri = new UriBuilder(RiotApiSecondUrl + matchesEndpoint) {
                    Query = $"api_key={RiotApiKey}"
                };
                Console.WriteLine(GetMatchesUri.ToString());
                try {
                    HttpResponseMessage response = await client2.GetAsync(GetMatchesUri.Uri);
                    Console.WriteLine(response.StatusCode.ToString());
                    if (response.IsSuccessStatusCode) {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        string matchclean = responseBody.Substring(1, responseBody.Length - 2);
                        string[] matchlist = matchclean.Split(new char[] { ',' });
                        // Console.WriteLine($"{matchlist[0]}");
                        string matchcleaned = matchlist[0].Substring(1, matchlist[0].Length - 2);
                        match = matchcleaned;
                    }
                }
                catch (Exception) {

                }
            }
            using (HttpClient client3 = new HttpClient()) {
                string matchEndpoint = $"/lol/match/v5/matches/{match.Trim()}";
                UriBuilder GetMatchUri = new UriBuilder(RiotApiSecondUrl + matchEndpoint) {
                    Query = $"api_key={RiotApiKey}"
                };
                // Console.WriteLine(GetMatchUri.ToString());
                try {
                    HttpResponseMessage response = await client3.GetAsync(GetMatchUri.Uri);
                    Console.WriteLine(response.StatusCode.ToString());
                    if (response.IsSuccessStatusCode) {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        Console.WriteLine(responseBody);
                        string searcher = $"\"participants\":";
                        int searcherLength = searcher.Length;
                        int participantStart = responseBody.IndexOf(searcher) + searcherLength;
                        string participantSection = responseBody.Substring(participantStart, responseBody.Length - participantStart);
                        int particpantEnd = participantSection.IndexOf("]");
                        string participants = participantSection.Substring(1, particpantEnd - 1);
                        // Console.WriteLine($"{participants}");
                        string[] Ids = participants.Split(',');
                        // Console.WriteLine(Ids.Length);
                        foreach (string Id in Ids) {
                            participantIds.Add(Id);
                        }
                    }

                }
                catch (Exception) {

                }
            }
            using (HttpClient client4 = new HttpClient()) {
                foreach (string participantId in participantIds) {
                    int idLength = participantId.Length - 2;
                    string trimmedId = participantId.Substring(1, idLength);
                    // Console.WriteLine(trimmedId);
                    string ParticipantNameEndpoint = $"/lol/summoner/v4/summoners/by-puuid/{trimmedId}";
                    UriBuilder GetParticipantUri = new UriBuilder(RiotApiBaseUrl + ParticipantNameEndpoint) {
                        Query = $"api_key={RiotApiKey}"
                    };
                    // Console.WriteLine(GetParticipantUri);
                    try {
                        HttpResponseMessage response = await client4.GetAsync(GetParticipantUri.Uri);
                        if (response.IsSuccessStatusCode) {
                            string resultBody = await response.Content.ReadAsStringAsync();
                            Console.WriteLine(resultBody);
                            string[] playerInfo = resultBody.Split(',');
                            foreach (string info in playerInfo) {
                                string[] infoParts = info.Split(':');
                                if (infoParts[0].Trim() == "\"name\"") {
                                    Console.WriteLine(infoParts[1]);
                                    string cleanedName = infoParts[1].Substring(1, infoParts[1].Length - 2);
                                    PlayerNames.Add(cleanedName);
                                }
                            }
                        }
                    }
                    catch (Exception) {
                    }
                }
                foreach(string Player in PlayerNames) {
                    AlliedBox.Items.Add(Player);
                }
            }
        }


        public static class InputBox {
            public static string Show(string title, string promptText) {
                Form form = new Form();
                Label label = new Label();
                TextBox textBox = new TextBox();
                Button buttonOk = new Button();
                Button buttonCancel = new Button();

                form.Text = title;
                label.Text = promptText;

                buttonOk.Text = "OK";
                buttonCancel.Text = "Cancel";
                buttonOk.DialogResult = DialogResult.OK;
                buttonCancel.DialogResult = DialogResult.Cancel;

                label.SetBounds(9, 20, 372, 13);
                textBox.SetBounds(12, 36, 372, 20);
                buttonOk.SetBounds(228, 72, 75, 23);
                buttonCancel.SetBounds(309, 72, 75, 23);

                label.AutoSize = true;
                textBox.Anchor |= AnchorStyles.Right;
                buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
                buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

                form.ClientSize = new System.Drawing.Size(396, 107);
                form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
                form.ClientSize = new System.Drawing.Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
                form.FormBorderStyle = FormBorderStyle.FixedDialog;
                form.StartPosition = FormStartPosition.CenterScreen;
                form.MinimizeBox = false;
                form.MaximizeBox = false;
                form.AcceptButton = buttonOk;
                form.CancelButton = buttonCancel;

                DialogResult dialogResult = form.ShowDialog();
                return dialogResult == DialogResult.OK ? textBox.Text : "";
            }
        }
    }
}