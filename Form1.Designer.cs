namespace SummonerNotes {
    partial class Form1 {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PlayersListBox = new System.Windows.Forms.ListBox();
            this.List1RadioButton = new System.Windows.Forms.RadioButton();
            this.List2RadioButton = new System.Windows.Forms.RadioButton();
            this.AddButton = new System.Windows.Forms.Button();
            this.List1Box = new System.Windows.Forms.ListBox();
            this.List2Box = new System.Windows.Forms.ListBox();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlayersListBox
            // 
            resources.ApplyResources(this.PlayersListBox, "PlayersListBox");
            this.PlayersListBox.FormattingEnabled = true;
            this.PlayersListBox.Name = "PlayersListBox";
            // 
            // List1RadioButton
            // 
            resources.ApplyResources(this.List1RadioButton, "List1RadioButton");
            this.List1RadioButton.Checked = true;
            this.List1RadioButton.Name = "List1RadioButton";
            this.List1RadioButton.TabStop = true;
            this.List1RadioButton.UseVisualStyleBackColor = true;
            // 
            // List2RadioButton
            // 
            resources.ApplyResources(this.List2RadioButton, "List2RadioButton");
            this.List2RadioButton.Name = "List2RadioButton";
            this.List2RadioButton.TabStop = true;
            this.List2RadioButton.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            resources.ApplyResources(this.AddButton, "AddButton");
            this.AddButton.Name = "AddButton";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // List1Box
            // 
            resources.ApplyResources(this.List1Box, "List1Box");
            this.List1Box.FormattingEnabled = true;
            this.List1Box.Name = "List1Box";
            // 
            // List2Box
            // 
            resources.ApplyResources(this.List2Box, "List2Box");
            this.List2Box.FormattingEnabled = true;
            this.List2Box.Name = "List2Box";
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
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.BackColor = System.Drawing.SystemColors.Info;
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.List2Box);
            this.Controls.Add(this.List1Box);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.List2RadioButton);
            this.Controls.Add(this.List1RadioButton);
            this.Controls.Add(this.PlayersListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox PlayersListBox;
        private System.Windows.Forms.RadioButton List1RadioButton;
        private System.Windows.Forms.RadioButton List2RadioButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ListBox List1Box;
        private System.Windows.Forms.ListBox List2Box;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button ClearButton;
    }
}

