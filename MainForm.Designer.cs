namespace SummonerNotes {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.AlliedBox = new System.Windows.Forms.ListBox();
            this.StrongRadioButton = new System.Windows.Forms.RadioButton();
            this.WeakRadioButton = new System.Windows.Forms.RadioButton();
            this.AddButton = new System.Windows.Forms.Button();
            this.StrongBox = new System.Windows.Forms.ListBox();
            this.WeakBox = new System.Windows.Forms.ListBox();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.AlliedLabel = new System.Windows.Forms.Label();
            this.StrongListLabel = new System.Windows.Forms.Label();
            this.WeakListLabel = new System.Windows.Forms.Label();
            this.EnemyLabel = new System.Windows.Forms.Label();
            this.EnemyBox = new System.Windows.Forms.ListBox();
            this.DetailsButton = new System.Windows.Forms.Button();
            this.Instructions = new System.Windows.Forms.RichTextBox();
            this.InstructionLabel = new System.Windows.Forms.Label();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.SummonerBox = new System.Windows.Forms.TextBox();
            this.SummonerLabel = new System.Windows.Forms.Label();
            this.LookupButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.GamesCount = new System.Windows.Forms.Label();
            this.Count = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AlliedBox
            // 
            resources.ApplyResources(this.AlliedBox, "AlliedBox");
            this.AlliedBox.FormattingEnabled = true;
            this.AlliedBox.Name = "AlliedBox";
            this.AlliedBox.TabStop = false;
            // 
            // StrongRadioButton
            // 
            this.StrongRadioButton.Checked = true;
            resources.ApplyResources(this.StrongRadioButton, "StrongRadioButton");
            this.StrongRadioButton.Name = "StrongRadioButton";
            this.StrongRadioButton.TabStop = true;
            this.StrongRadioButton.UseVisualStyleBackColor = true;
            this.StrongRadioButton.CheckedChanged += new System.EventHandler(this.StrongRadioButton_CheckedChanged);
            // 
            // WeakRadioButton
            // 
            resources.ApplyResources(this.WeakRadioButton, "WeakRadioButton");
            this.WeakRadioButton.Name = "WeakRadioButton";
            this.WeakRadioButton.TabStop = true;
            this.WeakRadioButton.UseVisualStyleBackColor = true;
            this.WeakRadioButton.CheckedChanged += new System.EventHandler(this.WeakRadioButton_CheckedChanged);
            // 
            // AddButton
            // 
            resources.ApplyResources(this.AddButton, "AddButton");
            this.AddButton.Name = "AddButton";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // StrongBox
            // 
            resources.ApplyResources(this.StrongBox, "StrongBox");
            this.StrongBox.FormattingEnabled = true;
            this.StrongBox.Name = "StrongBox";
            this.StrongBox.TabStop = false;
            this.StrongBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.StrongBox_DrawItem);
            // 
            // WeakBox
            // 
            resources.ApplyResources(this.WeakBox, "WeakBox");
            this.WeakBox.FormattingEnabled = true;
            this.WeakBox.Name = "WeakBox";
            this.WeakBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.WeakBox.TabStop = false;
            this.WeakBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.WeakBox_DrawItem);
            // 
            // RemoveButton
            // 
            resources.ApplyResources(this.RemoveButton, "RemoveButton");
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // ClearButton
            // 
            resources.ApplyResources(this.ClearButton, "ClearButton");
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // AlliedLabel
            // 
            resources.ApplyResources(this.AlliedLabel, "AlliedLabel");
            this.AlliedLabel.Name = "AlliedLabel";
            // 
            // StrongListLabel
            // 
            resources.ApplyResources(this.StrongListLabel, "StrongListLabel");
            this.StrongListLabel.Name = "StrongListLabel";
            // 
            // WeakListLabel
            // 
            resources.ApplyResources(this.WeakListLabel, "WeakListLabel");
            this.WeakListLabel.Name = "WeakListLabel";
            // 
            // EnemyLabel
            // 
            resources.ApplyResources(this.EnemyLabel, "EnemyLabel");
            this.EnemyLabel.Name = "EnemyLabel";
            // 
            // EnemyBox
            // 
            resources.ApplyResources(this.EnemyBox, "EnemyBox");
            this.EnemyBox.FormattingEnabled = true;
            this.EnemyBox.Name = "EnemyBox";
            this.EnemyBox.TabStop = false;
            // 
            // DetailsButton
            // 
            resources.ApplyResources(this.DetailsButton, "DetailsButton");
            this.DetailsButton.Name = "DetailsButton";
            this.DetailsButton.UseVisualStyleBackColor = true;
            this.DetailsButton.Click += new System.EventHandler(this.DetailsButton_Click);
            // 
            // Instructions
            // 
            this.Instructions.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.Instructions, "Instructions");
            this.Instructions.Name = "Instructions";
            this.Instructions.ReadOnly = true;
            this.Instructions.ShortcutsEnabled = false;
            this.Instructions.TabStop = false;
            this.Instructions.TextChanged += new System.EventHandler(this.Instructions_TextChanged);
            // 
            // InstructionLabel
            // 
            resources.ApplyResources(this.InstructionLabel, "InstructionLabel");
            this.InstructionLabel.Name = "InstructionLabel";
            this.InstructionLabel.UseMnemonic = false;
            this.InstructionLabel.Click += new System.EventHandler(this.InstructionLabel_Click);
            // 
            // PreviousButton
            // 
            resources.ApplyResources(this.PreviousButton, "PreviousButton");
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.UseVisualStyleBackColor = true;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // NextButton
            // 
            resources.ApplyResources(this.NextButton, "NextButton");
            this.NextButton.Name = "NextButton";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // SummonerBox
            // 
            resources.ApplyResources(this.SummonerBox, "SummonerBox");
            this.SummonerBox.Name = "SummonerBox";
            this.SummonerBox.Enter += new System.EventHandler(this.SummonerBox_Enter);
            this.SummonerBox.Leave += new System.EventHandler(this.SummonerBox_Leave);
            // 
            // SummonerLabel
            // 
            resources.ApplyResources(this.SummonerLabel, "SummonerLabel");
            this.SummonerLabel.Name = "SummonerLabel";
            this.SummonerLabel.UseMnemonic = false;
            // 
            // LookupButton
            // 
            resources.ApplyResources(this.LookupButton, "LookupButton");
            this.LookupButton.Name = "LookupButton";
            this.LookupButton.UseVisualStyleBackColor = false;
            this.LookupButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LookupButton_MouseClick);
            // 
            // GamesCount
            // 
            this.GamesCount.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.GamesCount, "GamesCount");
            this.GamesCount.Name = "GamesCount";
            this.GamesCount.UseMnemonic = false;
            // 
            // Count
            // 
            resources.ApplyResources(this.Count, "Count");
            this.Count.Name = "Count";
            this.Count.TextChanged += new System.EventHandler(this.Count_TextChanged);
            this.Count.Enter += new System.EventHandler(this.Count_Enter);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            resources.ApplyResources(this, "$this");
            this.BackColor = System.Drawing.SystemColors.Info;
            this.Controls.Add(this.Count);
            this.Controls.Add(this.GamesCount);
            this.Controls.Add(this.LookupButton);
            this.Controls.Add(this.SummonerLabel);
            this.Controls.Add(this.SummonerBox);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.PreviousButton);
            this.Controls.Add(this.InstructionLabel);
            this.Controls.Add(this.Instructions);
            this.Controls.Add(this.DetailsButton);
            this.Controls.Add(this.EnemyLabel);
            this.Controls.Add(this.EnemyBox);
            this.Controls.Add(this.WeakListLabel);
            this.Controls.Add(this.StrongListLabel);
            this.Controls.Add(this.AlliedLabel);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.WeakBox);
            this.Controls.Add(this.StrongBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.WeakRadioButton);
            this.Controls.Add(this.StrongRadioButton);
            this.Controls.Add(this.AlliedBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox AlliedBox;
        private System.Windows.Forms.RadioButton StrongRadioButton;
        private System.Windows.Forms.RadioButton WeakRadioButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ListBox StrongBox;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label AlliedLabel;
        private System.Windows.Forms.Label StrongListLabel;
        private System.Windows.Forms.Label WeakListLabel;
        private System.Windows.Forms.Label EnemyLabel;
        private System.Windows.Forms.ListBox EnemyBox;
        public System.Windows.Forms.ListBox WeakBox;
        private System.Windows.Forms.Button DetailsButton;
        private System.Windows.Forms.RichTextBox Instructions;
        private System.Windows.Forms.Label InstructionLabel;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.TextBox SummonerBox;
        private System.Windows.Forms.Label SummonerLabel;
        private System.Windows.Forms.Button LookupButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label GamesCount;
        private System.Windows.Forms.TextBox Count;
    }
}

