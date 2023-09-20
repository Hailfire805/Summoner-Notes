﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SummonerNotes {
    public partial class DetailsForm : Form {
        public DetailsForm(string selectedItemDetails) {
            InitializeComponent();
            DetailsLabel.Text = selectedItemDetails; // Display the selected item's details
        }
    }

}
