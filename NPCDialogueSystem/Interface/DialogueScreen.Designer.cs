namespace NPCDialogueSystem
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DialoguePanel = new System.Windows.Forms.Panel();
            this.CategoryPanel = new System.Windows.Forms.Panel();
            this.TradeButton = new System.Windows.Forms.Button();
            this.LocationButton = new System.Windows.Forms.Button();
            this.PersonalButton = new System.Windows.Forms.Button();
            this.QuestButton = new System.Windows.Forms.Button();
            this.GeneralButton = new System.Windows.Forms.Button();
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.SearchIcon = new System.Windows.Forms.PictureBox();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.LogPanel = new System.Windows.Forms.Panel();
            this.OptionsPanel = new System.Windows.Forms.Panel();
            this.LogTextBox = new System.Windows.Forms.TextBox();
            this.DialoguePanel.SuspendLayout();
            this.CategoryPanel.SuspendLayout();
            this.SearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchIcon)).BeginInit();
            this.LogPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DialoguePanel
            // 
            this.DialoguePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DialoguePanel.Controls.Add(this.OptionsPanel);
            this.DialoguePanel.Controls.Add(this.CategoryPanel);
            this.DialoguePanel.Controls.Add(this.SearchPanel);
            this.DialoguePanel.Location = new System.Drawing.Point(12, 209);
            this.DialoguePanel.Name = "DialoguePanel";
            this.DialoguePanel.Size = new System.Drawing.Size(690, 200);
            this.DialoguePanel.TabIndex = 0;
            // 
            // CategoryPanel
            // 
            this.CategoryPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CategoryPanel.Controls.Add(this.TradeButton);
            this.CategoryPanel.Controls.Add(this.LocationButton);
            this.CategoryPanel.Controls.Add(this.PersonalButton);
            this.CategoryPanel.Controls.Add(this.QuestButton);
            this.CategoryPanel.Controls.Add(this.GeneralButton);
            this.CategoryPanel.Location = new System.Drawing.Point(3, 3);
            this.CategoryPanel.Name = "CategoryPanel";
            this.CategoryPanel.Size = new System.Drawing.Size(684, 36);
            this.CategoryPanel.TabIndex = 7;
            // 
            // TradeButton
            // 
            this.TradeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TradeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(174)))), ((int)(((byte)(124)))));
            this.TradeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TradeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TradeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TradeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TradeButton.ForeColor = System.Drawing.Color.White;
            this.TradeButton.Location = new System.Drawing.Point(549, 3);
            this.TradeButton.Name = "TradeButton";
            this.TradeButton.Size = new System.Drawing.Size(130, 30);
            this.TradeButton.TabIndex = 6;
            this.TradeButton.Text = "Trade";
            this.TradeButton.UseVisualStyleBackColor = false;
            this.TradeButton.Click += new System.EventHandler(this.TradeButton_Click);
            // 
            // LocationButton
            // 
            this.LocationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LocationButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(174)))), ((int)(((byte)(124)))));
            this.LocationButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LocationButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.LocationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LocationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LocationButton.ForeColor = System.Drawing.Color.White;
            this.LocationButton.Location = new System.Drawing.Point(413, 3);
            this.LocationButton.Name = "LocationButton";
            this.LocationButton.Size = new System.Drawing.Size(130, 30);
            this.LocationButton.TabIndex = 5;
            this.LocationButton.Text = "Location";
            this.LocationButton.UseVisualStyleBackColor = false;
            this.LocationButton.Click += new System.EventHandler(this.LocationButton_Click);
            // 
            // PersonalButton
            // 
            this.PersonalButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PersonalButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(174)))), ((int)(((byte)(124)))));
            this.PersonalButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PersonalButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.PersonalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PersonalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PersonalButton.ForeColor = System.Drawing.Color.White;
            this.PersonalButton.Location = new System.Drawing.Point(277, 3);
            this.PersonalButton.Name = "PersonalButton";
            this.PersonalButton.Size = new System.Drawing.Size(130, 30);
            this.PersonalButton.TabIndex = 4;
            this.PersonalButton.Text = "Personal";
            this.PersonalButton.UseVisualStyleBackColor = false;
            this.PersonalButton.Click += new System.EventHandler(this.PersonalButton_Click);
            // 
            // QuestButton
            // 
            this.QuestButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.QuestButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(174)))), ((int)(((byte)(124)))));
            this.QuestButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.QuestButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.QuestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.QuestButton.ForeColor = System.Drawing.Color.White;
            this.QuestButton.Location = new System.Drawing.Point(141, 3);
            this.QuestButton.Name = "QuestButton";
            this.QuestButton.Size = new System.Drawing.Size(130, 30);
            this.QuestButton.TabIndex = 3;
            this.QuestButton.Text = "Quest";
            this.QuestButton.UseVisualStyleBackColor = false;
            this.QuestButton.Click += new System.EventHandler(this.QuestButton_Click);
            // 
            // GeneralButton
            // 
            this.GeneralButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.GeneralButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(174)))), ((int)(((byte)(124)))));
            this.GeneralButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.GeneralButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.GeneralButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GeneralButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.GeneralButton.ForeColor = System.Drawing.Color.White;
            this.GeneralButton.Location = new System.Drawing.Point(5, 3);
            this.GeneralButton.Name = "GeneralButton";
            this.GeneralButton.Size = new System.Drawing.Size(130, 30);
            this.GeneralButton.TabIndex = 2;
            this.GeneralButton.Text = "General";
            this.GeneralButton.UseVisualStyleBackColor = false;
            this.GeneralButton.Click += new System.EventHandler(this.GeneralButton_Click);
            // 
            // SearchPanel
            // 
            this.SearchPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(65)))), ((int)(((byte)(57)))));
            this.SearchPanel.Controls.Add(this.SearchIcon);
            this.SearchPanel.Controls.Add(this.SearchTextBox);
            this.SearchPanel.Location = new System.Drawing.Point(3, 167);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(684, 30);
            this.SearchPanel.TabIndex = 0;
            // 
            // SearchIcon
            // 
            this.SearchIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SearchIcon.Location = new System.Drawing.Point(0, 0);
            this.SearchIcon.Name = "SearchIcon";
            this.SearchIcon.Size = new System.Drawing.Size(30, 30);
            this.SearchIcon.TabIndex = 3;
            this.SearchIcon.TabStop = false;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(65)))), ((int)(((byte)(57)))));
            this.SearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SearchTextBox.ForeColor = System.Drawing.Color.White;
            this.SearchTextBox.Location = new System.Drawing.Point(36, 7);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(643, 16);
            this.SearchTextBox.TabIndex = 2;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // LogPanel
            // 
            this.LogPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LogPanel.Controls.Add(this.LogTextBox);
            this.LogPanel.Location = new System.Drawing.Point(12, 12);
            this.LogPanel.Name = "LogPanel";
            this.LogPanel.Size = new System.Drawing.Size(690, 191);
            this.LogPanel.TabIndex = 1;
            // 
            // OptionsPanel
            // 
            this.OptionsPanel.AutoScroll = true;
            this.OptionsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.OptionsPanel.Location = new System.Drawing.Point(3, 48);
            this.OptionsPanel.Name = "OptionsPanel";
            this.OptionsPanel.Size = new System.Drawing.Size(684, 110);
            this.OptionsPanel.TabIndex = 0;
            // 
            // LogTextBox
            // 
            this.LogTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LogTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LogTextBox.ForeColor = System.Drawing.Color.White;
            this.LogTextBox.Location = new System.Drawing.Point(13, 8);
            this.LogTextBox.Multiline = true;
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LogTextBox.Size = new System.Drawing.Size(664, 175);
            this.LogTextBox.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(714, 421);
            this.Controls.Add(this.LogPanel);
            this.Controls.Add(this.DialoguePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "NPC Dialogue";
            this.DialoguePanel.ResumeLayout(false);
            this.CategoryPanel.ResumeLayout(false);
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchIcon)).EndInit();
            this.LogPanel.ResumeLayout(false);
            this.LogPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DialoguePanel;
        private System.Windows.Forms.Panel SearchPanel;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Panel LogPanel;
        private System.Windows.Forms.Button GeneralButton;
        private System.Windows.Forms.Panel CategoryPanel;
        private System.Windows.Forms.Button TradeButton;
        private System.Windows.Forms.Button LocationButton;
        private System.Windows.Forms.Button PersonalButton;
        private System.Windows.Forms.Button QuestButton;
        private System.Windows.Forms.PictureBox SearchIcon;
        private System.Windows.Forms.Panel OptionsPanel;
        private System.Windows.Forms.TextBox LogTextBox;
    }
}

