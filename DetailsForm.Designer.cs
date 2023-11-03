namespace SummonerNotes {
    partial class DetailsForm {
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
            this.DetailsLabel = new System.Windows.Forms.Label();
            this.Detail_Tabs = new System.Windows.Forms.TabControl();
            this.Notes = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.NoteBox2 = new System.Windows.Forms.TextBox();
            this.Match_History = new System.Windows.Forms.TabPage();
            this.HistoryBox = new System.Windows.Forms.ListBox();
            this.Synergy_Stats = new System.Windows.Forms.TabPage();
            this.Ranked = new System.Windows.Forms.TabPage();
            this.Champions = new System.Windows.Forms.TabPage();
            this.SynergyBox = new System.Windows.Forms.ListBox();
            this.RankedBox = new System.Windows.Forms.ListBox();
            this.ChampionsBox = new System.Windows.Forms.ListBox();
            this.NoteBox1 = new System.Windows.Forms.TextBox();
            this.Detail_Tabs.SuspendLayout();
            this.Notes.SuspendLayout();
            this.Match_History.SuspendLayout();
            this.Synergy_Stats.SuspendLayout();
            this.Ranked.SuspendLayout();
            this.Champions.SuspendLayout();
            this.SuspendLayout();
            // 
            // DetailsLabel
            // 
            this.DetailsLabel.Location = new System.Drawing.Point(25, 9);
            this.DetailsLabel.Name = "DetailsLabel";
            this.DetailsLabel.Size = new System.Drawing.Size(478, 25);
            this.DetailsLabel.TabIndex = 0;
            this.DetailsLabel.Text = "Selected Player";
            // 
            // Detail_Tabs
            // 
            this.Detail_Tabs.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.Detail_Tabs.Controls.Add(this.Notes);
            this.Detail_Tabs.Controls.Add(this.Match_History);
            this.Detail_Tabs.Controls.Add(this.Synergy_Stats);
            this.Detail_Tabs.Controls.Add(this.Ranked);
            this.Detail_Tabs.Controls.Add(this.Champions);
            this.Detail_Tabs.HotTrack = true;
            this.Detail_Tabs.Location = new System.Drawing.Point(12, 30);
            this.Detail_Tabs.Multiline = true;
            this.Detail_Tabs.Name = "Detail_Tabs";
            this.Detail_Tabs.SelectedIndex = 0;
            this.Detail_Tabs.Size = new System.Drawing.Size(776, 419);
            this.Detail_Tabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.Detail_Tabs.TabIndex = 2;
            // 
            // Notes
            // 
            this.Notes.Controls.Add(this.richTextBox1);
            this.Notes.Controls.Add(this.NoteBox2);
            this.Notes.Controls.Add(this.NoteBox1);
            this.Notes.Location = new System.Drawing.Point(4, 25);
            this.Notes.Name = "Notes";
            this.Notes.Padding = new System.Windows.Forms.Padding(3);
            this.Notes.Size = new System.Drawing.Size(768, 390);
            this.Notes.TabIndex = 0;
            this.Notes.Text = "Notes";
            this.Notes.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBox1.Location = new System.Drawing.Point(535, 22);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(227, 73);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.TabStop = false;
            this.richTextBox1.Text = "";
            // 
            // NoteBox2
            // 
            this.NoteBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.NoteBox2.Location = new System.Drawing.Point(273, 22);
            this.NoteBox2.Multiline = true;
            this.NoteBox2.Name = "NoteBox2";
            this.NoteBox2.Size = new System.Drawing.Size(255, 361);
            this.NoteBox2.TabIndex = 1;
            // 
            // Match_History
            // 
            this.Match_History.Controls.Add(this.HistoryBox);
            this.Match_History.Location = new System.Drawing.Point(4, 25);
            this.Match_History.Name = "Match_History";
            this.Match_History.Padding = new System.Windows.Forms.Padding(3);
            this.Match_History.Size = new System.Drawing.Size(768, 390);
            this.Match_History.TabIndex = 1;
            this.Match_History.Text = "Match History";
            this.Match_History.UseVisualStyleBackColor = true;
            // 
            // HistoryBox
            // 
            this.HistoryBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.HistoryBox.FormattingEnabled = true;
            this.HistoryBox.Location = new System.Drawing.Point(6, 27);
            this.HistoryBox.Name = "HistoryBox";
            this.HistoryBox.Size = new System.Drawing.Size(756, 355);
            this.HistoryBox.TabIndex = 0;
            this.HistoryBox.SelectedIndexChanged += new System.EventHandler(this.HistoryBox_SelectedIndexChanged);
            // 
            // Synergy_Stats
            // 
            this.Synergy_Stats.Controls.Add(this.SynergyBox);
            this.Synergy_Stats.Location = new System.Drawing.Point(4, 25);
            this.Synergy_Stats.Name = "Synergy_Stats";
            this.Synergy_Stats.Size = new System.Drawing.Size(768, 390);
            this.Synergy_Stats.TabIndex = 2;
            this.Synergy_Stats.Text = "Synergy Stats";
            this.Synergy_Stats.UseVisualStyleBackColor = true;
            // 
            // Ranked
            // 
            this.Ranked.Controls.Add(this.RankedBox);
            this.Ranked.Location = new System.Drawing.Point(4, 25);
            this.Ranked.Name = "Ranked";
            this.Ranked.Size = new System.Drawing.Size(768, 390);
            this.Ranked.TabIndex = 3;
            this.Ranked.Text = "Ranked";
            this.Ranked.UseVisualStyleBackColor = true;
            // 
            // Champions
            // 
            this.Champions.Controls.Add(this.ChampionsBox);
            this.Champions.Location = new System.Drawing.Point(4, 25);
            this.Champions.Name = "Champions";
            this.Champions.Size = new System.Drawing.Size(768, 390);
            this.Champions.TabIndex = 4;
            this.Champions.Text = "Champions";
            this.Champions.UseVisualStyleBackColor = true;
            // 
            // SynergyBox
            // 
            this.SynergyBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SynergyBox.FormattingEnabled = true;
            this.SynergyBox.Location = new System.Drawing.Point(6, 27);
            this.SynergyBox.Name = "SynergyBox";
            this.SynergyBox.Size = new System.Drawing.Size(756, 355);
            this.SynergyBox.TabIndex = 1;
            this.SynergyBox.SelectedIndexChanged += new System.EventHandler(this.SynergyBox_SelectedIndexChanged);
            // 
            // RankedBox
            // 
            this.RankedBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RankedBox.FormattingEnabled = true;
            this.RankedBox.Location = new System.Drawing.Point(6, 27);
            this.RankedBox.Name = "RankedBox";
            this.RankedBox.Size = new System.Drawing.Size(756, 355);
            this.RankedBox.TabIndex = 1;
            // 
            // ChampionsBox
            // 
            this.ChampionsBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ChampionsBox.FormattingEnabled = true;
            this.ChampionsBox.Location = new System.Drawing.Point(6, 27);
            this.ChampionsBox.Name = "ChampionsBox";
            this.ChampionsBox.Size = new System.Drawing.Size(756, 355);
            this.ChampionsBox.TabIndex = 1;
            // 
            // NoteBox1
            // 
            this.NoteBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.NoteBox1.Location = new System.Drawing.Point(12, 21);
            this.NoteBox1.Multiline = true;
            this.NoteBox1.Name = "NoteBox1";
            this.NoteBox1.Size = new System.Drawing.Size(255, 362);
            this.NoteBox1.TabIndex = 0;
            // 
            // DetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Detail_Tabs);
            this.Controls.Add(this.DetailsLabel);
            this.Name = "DetailsForm";
            this.Text = "Form2";
            this.Detail_Tabs.ResumeLayout(false);
            this.Notes.ResumeLayout(false);
            this.Notes.PerformLayout();
            this.Match_History.ResumeLayout(false);
            this.Synergy_Stats.ResumeLayout(false);
            this.Ranked.ResumeLayout(false);
            this.Champions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label DetailsLabel;
        private System.Windows.Forms.TabControl Detail_Tabs;
        private System.Windows.Forms.TabPage Notes;
        private System.Windows.Forms.TabPage Match_History;
        private System.Windows.Forms.TabPage Synergy_Stats;
        private System.Windows.Forms.TabPage Ranked;
        private System.Windows.Forms.TabPage Champions;
        private System.Windows.Forms.TextBox NoteBox2;
        private System.Windows.Forms.ListBox HistoryBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ListBox SynergyBox;
        private System.Windows.Forms.ListBox RankedBox;
        private System.Windows.Forms.ListBox ChampionsBox;
        private System.Windows.Forms.TextBox NoteBox1;
        }
}