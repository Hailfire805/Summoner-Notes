using System.Collections.Generic;
using System.Windows.Forms;

namespace SummonerNotes {
    public partial class DetailsForm : Form {
        public DetailsForm(string selectedItemDetails) {
            InitializeComponent();
            DetailsLabel.Text = GetName(selectedItemDetails); // Display the selected item's details
            GetNotes(selectedItemDetails);        
            }
        private string GetName(string selectedItemDetails)
            {
            string[] player = selectedItemDetails.Split(':');
            return player[0];
            }
        private void GetNotes(string selectedItemDetails)
            {
            string[] player = selectedItemDetails.Split(':');
            string[] notes = player[1].Split(',', '.');
            foreach (string note in notes) {
                NoteBox1.AppendText($"{note.Trim()} \r\n");
                }
            }
        private void statsTogetherToolStripMenuItem_Click(object sender, System.EventArgs e) {

        }

        private void groupBox1_Enter(object sender, System.EventArgs e) {

        }

        private void HistoryBox_SelectedIndexChanged(object sender, System.EventArgs e)
            {

            }

        private void SynergyBox_SelectedIndexChanged(object sender, System.EventArgs e)
            {

            }
        }

}

