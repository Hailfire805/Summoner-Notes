using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SummonerNotes {
    public partial class Form1 : Form {
        private List<string> list1 = new List<string>();
        private List<string> list2 = new List<string>();

        public Form1() {
            InitializeComponent();
            PopulatePlayerList();
            LoadListsFromFile();
        }
        private void PopulatePlayerList() {
            // Simulated Riot API response
            List<string> participantNames = new List<string>
            {
                "Alice", "Bob", "Charlie", "David", "Eve", "Frank", "Grace", "Helen", "Isaac", "Jack"
            };

            foreach (var name in participantNames) {
                if (name != "YourSummonerName") {
                    PlayersListBox.Items.Add(name);
                }
            }
        }
        private void AddButton_Click(object sender, EventArgs e) {
            if (PlayersListBox.SelectedIndex != -1) {
                string selectedPlayer = PlayersListBox.SelectedItem.ToString();
                string reason = InputBox.Show("Add Player", $"Notes for {selectedPlayer}?");
                string selectedList = "";
                if (!string.IsNullOrWhiteSpace(reason)) {
                    if (List1RadioButton.Checked) {
                        list1.Add($"{selectedPlayer}: {reason}");
                        selectedList = "List 1";
                    }
                    else if (List2RadioButton.Checked) {
                        list2.Add($"{selectedPlayer}: {reason}");
                        selectedList = "List 2";
                    }
                    UpdateLists();
                    MessageBox.Show($"{selectedPlayer} added to the {selectedList} with reason: {reason}");

                }
            }
        }
        private void RefreshButton_Click(object sender, EventArgs e) {
            // Clear and repopulate the player list
            PlayersListBox.Items.Clear();
            PopulatePlayerList();
        }

        private void List1RadioButton_CheckedChanged(object sender, EventArgs e) {
            // Update the list box with selected list's items
            List1Box.Items.Clear();
            List1Box.Items.AddRange(list1.ToArray());
        }

        private void List2RadioButton_CheckedChanged(object sender, EventArgs e) {
            // Update the list box with selected list's items
            List2Box.Items.Clear();
            List2Box.Items.AddRange(list2.ToArray());
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            SaveListsToFile();
        }
        private void SaveListsToFile() {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter("./lists.txt")) {
                foreach (string name in list1) {
                    file.WriteLine($"List1: {name}");
                }
                foreach (string name in list2) {
                    file.WriteLine($"List2: {name}");
                }
            }
        }
        private void UpdateLists() {
            List1Box.Items.Clear();
            List2Box.Items.Clear();
            List1Box.Items.AddRange(list1.ToArray());
            List2Box.Items.AddRange(list2.ToArray());
        }
        private void LoadListsFromFile() {
            if (System.IO.File.Exists("./lists.txt")) {
                list1.Clear();
                list2.Clear();

                string[] lines = System.IO.File.ReadAllLines("./lists.txt");
                foreach (string line in lines) {
                    if (!string.IsNullOrWhiteSpace(line)) {
                        if (line.StartsWith("List1: ")) {
                            list1.Add(line.Substring(7)); // Remove "List1: " prefix
                        }
                        else if (line.StartsWith("List2: ")) {
                            list2.Add(line.Substring(7)); // Remove "List2: " prefix
                        }
                    }
                    UpdateLists();
                }
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e) {
            if (List1Box.SelectedIndex != -1) {
                string selectedPlayer = List1Box.SelectedValue.ToString();
                list1.Remove($"{selectedPlayer}");
            }
            else if (List2Box.SelectedIndex != -1) {
                string selectedPlayer = List2Box.SelectedValue.ToString();
                list2.Remove($"{selectedPlayer}");
            }
            UpdateLists();
        }

        private void ClearButton_Click(object sender, EventArgs e) {
            list1.Clear();
            list2.Clear();
            SaveListsToFile();
            LoadListsFromFile();
            UpdateLists();
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
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
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
            if (dialogResult == DialogResult.OK) {
                return textBox.Text;
            }
            return "";
        }
    }
}