using System.Windows.Forms;

namespace SummonerNotes {
    public partial class DetailsForm : Form {
        public DetailsForm(string selectedItemDetails) {
            InitializeComponent();
            DetailsLabel.Text = selectedItemDetails; // Display the selected item's details
        }
    }

}

