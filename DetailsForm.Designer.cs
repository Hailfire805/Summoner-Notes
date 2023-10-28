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
            this.Match_History = new System.Windows.Forms.TabPage();
            this.Synergy_Stats = new System.Windows.Forms.TabPage();
            this.Ranked = new System.Windows.Forms.TabPage();
            this.Champions = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Detail_Tabs.SuspendLayout();
            this.Notes.SuspendLayout();
            this.Match_History.SuspendLayout();
            this.SuspendLayout();
            // 
            // DetailsLabel
            // 
            this.DetailsLabel.Location = new System.Drawing.Point(25, 9);
            this.DetailsLabel.Name = "DetailsLabel";
            this.DetailsLabel.Size = new System.Drawing.Size(176, 25);
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
            this.Notes.Controls.Add(this.textBox2);
            this.Notes.Controls.Add(this.textBox1);
            this.Notes.Location = new System.Drawing.Point(4, 25);
            this.Notes.Name = "Notes";
            this.Notes.Padding = new System.Windows.Forms.Padding(3);
            this.Notes.Size = new System.Drawing.Size(768, 390);
            this.Notes.TabIndex = 0;
            this.Notes.Text = "Notes";
            this.Notes.UseVisualStyleBackColor = true;
            // 
            // Match_History
            // 
            this.Match_History.Controls.Add(this.listBox1);
            this.Match_History.Location = new System.Drawing.Point(4, 25);
            this.Match_History.Name = "Match_History";
            this.Match_History.Padding = new System.Windows.Forms.Padding(3);
            this.Match_History.Size = new System.Drawing.Size(768, 390);
            this.Match_History.TabIndex = 1;
            this.Match_History.Text = "Match History";
            this.Match_History.UseVisualStyleBackColor = true;
            // 
            // Synergy_Stats
            // 
            this.Synergy_Stats.Location = new System.Drawing.Point(4, 25);
            this.Synergy_Stats.Name = "Synergy_Stats";
            this.Synergy_Stats.Size = new System.Drawing.Size(768, 390);
            this.Synergy_Stats.TabIndex = 2;
            this.Synergy_Stats.Text = "Synergy Stats";
            this.Synergy_Stats.UseVisualStyleBackColor = true;
            // 
            // Ranked
            // 
            this.Ranked.Location = new System.Drawing.Point(4, 25);
            this.Ranked.Name = "Ranked";
            this.Ranked.Size = new System.Drawing.Size(768, 390);
            this.Ranked.TabIndex = 3;
            this.Ranked.Text = "Ranked";
            this.Ranked.UseVisualStyleBackColor = true;
            // 
            // Champions
            // 
            this.Champions.Location = new System.Drawing.Point(4, 25);
            this.Champions.Name = "Champions";
            this.Champions.Size = new System.Drawing.Size(768, 390);
            this.Champions.TabIndex = 4;
            this.Champions.Text = "Champions";
            this.Champions.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(756, 355);
            this.listBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 21);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(255, 362);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(273, 22);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(255, 361);
            this.textBox2.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBox1.Location = new System.Drawing.Point(535, 22);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(227, 73);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.TabStop = false;
            this.richTextBox1.Text = "";
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
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}