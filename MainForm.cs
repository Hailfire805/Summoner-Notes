using Camille.Enums;
using Camille.RiotGames;
using Camille.RiotGames.MatchV5;

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Web.Configuration;
using System.Windows.Forms;

using Button = System.Windows.Forms.Button;
using Label = System.Windows.Forms.Label;
using ListBox = System.Windows.Forms.ListBox;
using TextBox = System.Windows.Forms.TextBox;

namespace SummonerNotes
    {
    public partial class MainForm : Form
        {
        // Defualt & Core Variable Declarations
        public string[] InstructionsList = new string[] { };
        public int playerTeam = 100 | 200;
        public List<string> StrongList = new List<string>();
        public List<string> WeakList = new List<string>();
        public int InstructionPage = 1;

        public MainForm()
            {

            // Initalization
            InitializeComponent();
            LoadWeakAndStrong();
            getInstructions();
            LoadPlayer();

            // Startup Events
            WeakBox.SelectedIndexChanged += SelectedChanged;
            StrongBox.SelectedIndexChanged += SelectedChanged;
            AlliedBox.SelectedIndexChanged += SelectedChanged;
            EnemyBox.SelectedIndexChanged += SelectedChanged;
            }

        // Button Events
        public void AddToList(ListBox[] Boxes)
            {
            foreach (ListBox Box in Boxes) {
                if (Box.SelectedIndex != -1) {
                    string selectedPlayer = Box.SelectedItem.ToString();
                    string parsedPlayer = $"{selectedPlayer.Split(':')[0].Substring(0, (selectedPlayer.Split(':')[0].Length - 6)).Trim()}";
                    string reason = InputBox.Show("Add Player", $"Notes for {parsedPlayer}?");
                    string text = $"{parsedPlayer}: {reason}";
                    if (!string.IsNullOrWhiteSpace(reason)) {
                        if (StrongRadioButton.Checked) {
                            StrongList.Add(text);
                            }
                        else if (WeakRadioButton.Checked) {
                            WeakList.Add(text);
                            }
                        RefreshLists();
                        MessageBox.Show($"{parsedPlayer} added to {(StrongRadioButton.Checked ? "High Impact List" : "Low Impact List")}");
                        }
                    }
                }
            }
        public void OpenDetails(ListBox[] Boxes)
            {
            foreach (ListBox Box in Boxes) {
                if (Box.SelectedIndex != -1) {
                    ShowDetailsForm(Box.SelectedItem.ToString());
                    }
                }
            }
        public void AddButton_Click(object sender, EventArgs e)
            {
            ListBox[] boxes = { AlliedBox, EnemyBox };
            AddToList(boxes);
            }
        public void ClearButton_Click(object sender, EventArgs e)
            {
            StrongList.Clear();
            WeakList.Clear();
            SaveWeakAndStrong();
            LoadWeakAndStrong();
            }
        public void DetailsButton_Click(object sender, EventArgs e)
            {
            ListBox[] Boxes = { StrongBox, WeakBox };
            OpenDetails(Boxes);
            }
        public void RemoveButton_Click(object sender, EventArgs e)
            {
            if (StrongBox.SelectedIndex != -1) {
                string selectedPlayer = StrongBox.SelectedItem.ToString(); // Use SelectedItem instead of SelectedValue
                StrongList.Remove(selectedPlayer); // Remove the entire entry
                }
            else if (WeakBox.SelectedIndex != -1) {
                string selectedPlayer = WeakBox.SelectedItem.ToString(); // Use SelectedItem instead of SelectedValue
                WeakList.Remove(selectedPlayer); // Remove the entire entry
                };
            }
        public void PreviousButton_Click(object sender, EventArgs e)
            {
            int newpage = InstructionPage > 1 ? InstructionPage -= 1 : InstructionPage;
            if (newpage == 1) {
                PreviousButton.Visible = false;
                }
            NextButton.Visible = true;
            Instructions.Text = $"{InstructionsList[newpage - 1]}";
            }
        public void NextButton_Click(object sender, EventArgs e)
            {
            int newpage = InstructionPage < 4 ? InstructionPage += 1 : InstructionPage;
            if (newpage == 4) {
                NextButton.Visible = false;
                }
            PreviousButton.Visible = true;
            Instructions.Text = $"{InstructionsList[newpage - 1]}";

            }
        public void LookupButton_MouseClick(object sender, EventArgs e)
            {
            AlliedBox.Items.Clear();
            EnemyBox.Items.Clear();
            GetPlayers();
            }

        // Text Events
        public void SummonerBox_Enter(object sender, EventArgs e)
            {
            if (SummonerBox.Text == "Name...") {
                SummonerBox.Text = "";
                }
            }
        public void Count_Enter(object sender, EventArgs e)
            {
            if (Count.Text == "Games To Return") {
                Count.Text = "";
                }
            }
        public void SummonerBox_Leave(object sender, EventArgs e)
            {
            if (SummonerBox.Text == "") {
                SummonerBox.Text = "Name...";
                }
            }
        public void SelectedChanged(object sender, EventArgs e)
            {
            ListBox selectedListBox = (ListBox) sender;

            CheckSelection(selectedListBox, StrongBox);
            CheckSelection(selectedListBox, WeakBox);
            CheckSelection(selectedListBox, AlliedBox);
            CheckSelection(selectedListBox, EnemyBox);
            }
        public void ClearSelection(ListBox listBox)
            {
            listBox.SelectedIndexChanged -= SelectedChanged;
            listBox.SelectedIndex = -1;
            listBox.SelectedIndexChanged += SelectedChanged;
            }
        public void CheckSelection(ListBox listBox, ListBox Reference)
            {
            if (listBox != Reference) {
                ClearSelection(Reference);
                }
            }

        // Task Functions
        public void ShowDetailsForm(string selectedItemDetails) {
            DetailsForm detailsForm = new DetailsForm(selectedItemDetails);
            detailsForm.ShowDialog();
        }
        public void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            SaveWeakAndStrong();
            SavePlayer();
        }
        public void getInstructions()
            {
            string filePath = "C:\\Users\\bradc\\DevDrives\\SummonerNotes\\InstructionsList.txt";
            List<string> sections = new List<string>();
            string currentSection = string.Empty;

            using (StreamReader reader = new StreamReader(filePath)) {
                string line;
                while ((line = reader.ReadLine()) != null) {
                    // Use a regular expression to match lines with the pattern of a number followed by a slash and another number.
                    if (Regex.IsMatch(line, @"\d+/\d+")) {
                        if (!string.IsNullOrEmpty(currentSection)) {
                            sections.Add(currentSection);
                            }
                        line = Regex.Replace(line, pattern: @"\d+/\d+", "");
                        currentSection = line;
                        }
                    else {
                        currentSection += Environment.NewLine + line;
                        }
                    }

                if (!string.IsNullOrEmpty(currentSection)) {
                    sections.Add(currentSection);
                    }
                }
            InstructionsList = sections.ToArray();
            Instructions.Text = InstructionsList[0];
            }
        public void RefreshLists()
            {
            SaveWeakAndStrong();
            LoadWeakAndStrong();
            }

        // Save Functions
        public void SavePlayer()
            {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter("./Lists/Player.txt")) {
                if (SummonerBox.Text != null && SummonerBox.Text != "Name...") {
                    var player = SummonerBox.Text;
                    file.WriteLine($"{player}");
                    }
                }
            }
        public void SaveList(List<string> list, string file)
            {
            using (System.IO.StreamWriter Savefile = new System.IO.StreamWriter(file)) {
                foreach (string name in list) {
                    var currentPlayer = name;
                    Savefile.WriteLine($"{currentPlayer}");
                    }
                }
            }
        public void SaveWeakAndStrong() {
            var Strong = (StrongList, "./Lists/Strong_list.txt");
            var Weak = (WeakList, "./Lists/Weak_list.txt");
            SaveList(Strong.ToTuple().Item1, Strong.ToTuple().Item2);
            SaveList(Weak.ToTuple().Item1, Weak.ToTuple().Item2);
            }

        // Load Functions
        public void LoadPlayer()
            {
            if (System.IO.File.Exists("./Lists/Player.txt")) {
                var lines = System.IO.File.ReadAllLines("./Lists/Player.txt");
                SummonerBox.Text = lines[0];
                }
            }
        public string[] LoadFile(string file)
            {
            if (System.IO.File.Exists(file)) {
                var lines = System.IO.File.ReadAllLines(file);
                return lines;
                }
            else {
                throw new ArgumentException("Invalid File Name");
                }
            }
        public void LoadAndClearList(string file, List<string> list)
            {
            string[] fileLines = LoadFile(file);
            list.Clear();
            foreach (string line in fileLines) {
                list.Add(line);
                }
            }
        public void LoadWeakAndStrong()
            {
            var Weak = ("./Lists/Weak_list.txt", WeakList);
            var Strong = ("./Lists/Strong_list.txt", StrongList);
            LoadAndClearList(Weak.ToTuple().Item1, Weak.ToTuple().Item2);
            LoadAndClearList(Strong.ToTuple().Item1, Strong.ToTuple().Item2);
            }
        
        // Riot API Functions
        public void GetPlayers() {
            var RiotApiKey = WebConfigurationManager.AppSettings["RiotApiKey"];
            var riotApi = RiotGamesApi.NewInstance(RiotApiKey);

            // Get summoners by name synchronously. (Note: async is faster as it allows simultaneous requests).
            var summoners = new[]
            {
                riotApi.SummonerV4().GetBySummonerName(PlatformRoute.NA1, SummonerBox.Text)
            };
            var matchList = new List<Camille.RiotGames.MatchV5.Match>();
            ;
            var games = 1;
            foreach (var summoner in summoners) {
                if (Count.Text == null | Count.Text == "") {
                    break;
                }
                else {
                    games = Int32.Parse(Count.Text);
                }
                var matches = riotApi.MatchV5().GetMatchIdsByPUUID(RegionalRoute.AMERICAS, summoner.Puuid, games);

                for (var matchNumber = 0; matchNumber < matches.Length; matchNumber++) {
                    matchList.Add(riotApi.MatchV5().GetMatch(RegionalRoute.AMERICAS, matches[matchNumber]));
                }
            }
            for (var matchNumber = 0; matchNumber < matchList.Count; matchNumber++) {
                Console.WriteLine(matchList[matchNumber]);
                var participants = matchList[matchNumber].Info.Participants;

                foreach (var participant in participants) {
                    if (participant != null) {
                        if (participant.SummonerName == SummonerBox.Text) {
                            playerTeam = (int) participant.TeamId;
                        }
                    }
                }
                var data = GetData(participants);
                string[] infos = new string[data.Length + 1];
                for (int i = 0; i < data.Length; i++) {
                    var d = data[i];
                    decimal KDA = (d.Kills + d.Assists) / (d.Deaths == 0 ? 1: d.Deaths);
                    infos[i] = $"Played: {((d.ChampionPlayed.Length >= 15) ? d.ChampionPlayed.PadRight(10) : d.ChampionPlayed.PadRight(10))}\t\t{(d.TeamPosition.Length == 0 ? "ARAM" : d.TeamPosition)}\tKDA: {data[i].Kills} \\ {data[i].Deaths} \\ {data[i].Assists}\t({(decimal) KDA:0.00})";
                }

                for (var participantNumber = 0; participantNumber < participants.Length; participantNumber++) {
                    var p = participants[participantNumber];
                    if (((int) participants[participantNumber].TeamId) == playerTeam && participants[participantNumber].SummonerName != SummonerBox.Text) {
                        AlliedBox.Items.Add(((p.SummonerName.Length >= 31) ? p.SummonerName.PadRight(31) : p.SummonerName.PadRight(31)) + "\t" + infos[participantNumber]);
                        ;
                    }
                    else if (((int) participants[participantNumber].TeamId) != playerTeam) {
                        EnemyBox.Items.Add(((p.SummonerName.Length >= 31) ? p.SummonerName.PadRight(31) : p.SummonerName.PadRight(31)) + "\t" + infos[participantNumber]);

                    }
                }
            }
        }
        public class ParticipantData {
            public string ChampionPlayed;
            public string TeamPosition;
            public int Kills;
            public int Deaths;
            public int Assists;
        }
        public ParticipantData[] GetData(Participant[] participants) {
            ParticipantData[] payload = new ParticipantData[participants.Length];
            for (int i = 0; i < participants.Length; i++) {
                payload[i] = ParticipantReturn(participants, i);
            }
            return payload;
        }
        public ParticipantData ParticipantReturn(Participant[] participants, int participantNumber) {
            Participant participant = participants[participantNumber];
            string champion = participant.ChampionName;
            string position = participant.TeamPosition;
            int kills = participant.Kills;
            int deaths = participant.Deaths;
            int assists = participant.Assists;

            ParticipantData data = new ParticipantData();
            data.ChampionPlayed = champion;
            data.TeamPosition = position;
            data.Kills = kills;
            data.Deaths = deaths;
            data.Assists = assists;
            return data;
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