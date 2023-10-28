using System.Windows.Forms;

namespace SummonerNotes {
    public partial class DetailsForm : Form {
        public DetailsForm(string selectedItemDetails) {
            InitializeComponent();
            DetailsLabel.Text = selectedItemDetails; // Display the selected item's details
        }

        private void statsTogetherToolStripMenuItem_Click(object sender, System.EventArgs e) {

        }

        private void groupBox1_Enter(object sender, System.EventArgs e) {

        }
    }

}

