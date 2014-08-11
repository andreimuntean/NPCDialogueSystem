using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace NPCDialogueSystem
{
    public partial class MainForm : Form
    {
        public Dialogue Dialogue { get; set; }
        public List<DialogueButton> DialogueButtons { get; set; }
        public bool IsFiltering { get; set; }
        public Category Filter { get; set; }

        public MainForm()
        {
            InitializeComponent();
            Initialize();
        }

        public void Initialize()
        {
            Dialogue = DataManager.Load<Dialogue>(1);
            Log(Dialogue.Name, Dialogue.Greeting);
            RefreshOptions();
        }

        public void RefreshOptions()
        {
            OptionsPanel.Controls.Clear();

            if (IsFiltering)
            {
                DialogueButtons = Dialogue.GetDialogueButtons(Filter, SearchTextBox.Text);
            }
            else DialogueButtons = Dialogue.GetDialogueButtons(SearchTextBox.Text);
            
            for (var i = 0; i < DialogueButtons.Count; ++i)
            {
                var x = 10;
                var y = (DialogueButtons[i].Height + 5) * i;

                DialogueButtons[i].Location = new Point(x, y);
                DialogueButtons[i].Click += DialogueButton_Click;

                OptionsPanel.Controls.Add(DialogueButtons[i]);
            }
        }

        public void Log(string name, string message)
        {
            LogTextBox.Text += name + ": " + message + Environment.NewLine;
        }

        #region Events
        private void DialogueButton_Click(object sender, EventArgs e)
        {
            var dialogueOption = (sender as DialogueButton).DialogueOption;

            Log("You", dialogueOption.Text);
            Log(Dialogue.Name, dialogueOption.Reply);
            Dialogue.Select(dialogueOption);
            RefreshOptions();
        }

        private void GeneralButton_Click(object sender, EventArgs e)
        {
            IsFiltering = false;
            OptionsPanel.Select();
            RefreshOptions();
        }

        private void QuestButton_Click(object sender, EventArgs e)
        {
            IsFiltering = true;
            Filter = Category.Quest;
            OptionsPanel.Select();
            RefreshOptions();
        }

        private void PersonalButton_Click(object sender, EventArgs e)
        {
            IsFiltering = true;
            Filter = Category.Personal;
            OptionsPanel.Select();
            RefreshOptions();
        }

        private void LocationButton_Click(object sender, EventArgs e)
        {
            IsFiltering = true;
            Filter = Category.Location;
            OptionsPanel.Select();
            RefreshOptions();
        }

        private void TradeButton_Click(object sender, EventArgs e)
        {
            IsFiltering = true;
            Filter = Category.Trade;
            OptionsPanel.Select();
            RefreshOptions();
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            RefreshOptions();
        }
        #endregion
    }
}
