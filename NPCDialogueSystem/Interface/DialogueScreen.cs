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

        private bool isFiltering;
        public bool IsFiltering
        {
            get { return isFiltering; }
            set
            {
                isFiltering = value;
                UpdateCategories();
            }
        }

        private Category filter;
        public Category Filter
        {
            get { return filter; }
            set
            {
                filter = value;
                UpdateCategories();
            }
        }

        public MainForm()
        {
            InitializeComponent();

            if (DataManager.CanLoad)
            {
                Initialize();
            }
            else
            {
                ExceptionManager.Log("Could not find " + DataManager.Path + ".", true);
                Environment.Exit(0);
            }
        }

        public void Initialize()
        {
            IsFiltering = false;
            Dialogue = DataManager.Load<Dialogue>(1);
            Log(Dialogue.Name, Dialogue.Greeting);
            UpdateOptions();
        }

        public void UpdateOptions()
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
        
        public void UpdateCategories()
        {
            var defaultColor = Color.FromArgb(201, 174, 124);
            var selectionColor = Color.FromArgb(255, 0, 0);
            
            GeneralButton.FlatAppearance.BorderColor = defaultColor;
            QuestButton.FlatAppearance.BorderColor = defaultColor;
            PersonalButton.FlatAppearance.BorderColor = defaultColor;
            LocationButton.FlatAppearance.BorderColor = defaultColor;
            TradeButton.FlatAppearance.BorderColor = defaultColor;

            if (IsFiltering)
            {
                switch (Filter)
                {
                    case Category.Quest: QuestButton.FlatAppearance.BorderColor = selectionColor; break;
                    case Category.Personal: PersonalButton.FlatAppearance.BorderColor = selectionColor; break;
                    case Category.Location: LocationButton.FlatAppearance.BorderColor = selectionColor; break;
                    case Category.Trade: TradeButton.FlatAppearance.BorderColor = selectionColor; break;
                }
            }
            else GeneralButton.FlatAppearance.BorderColor = selectionColor;
        }

        public void Log(string name, string message)
        {
            var date = DateTime.UtcNow.ToLongTimeString();
            LogTextBox.AppendText('[' + date + "] " + name + ": " + message + Environment.NewLine);
        }

        #region Events
        private void DialogueButton_Click(object sender, EventArgs e)
        {
            var dialogueOption = (sender as DialogueButton).DialogueOption;

            Log("You", dialogueOption.Text);
            Log(Dialogue.Name, dialogueOption.Reply);
            Dialogue.Select(dialogueOption);
            UpdateOptions();
        }

        private void GeneralButton_Click(object sender, EventArgs e)
        {
            IsFiltering = false;
            OptionsPanel.Select();
            UpdateOptions();
        }

        private void QuestButton_Click(object sender, EventArgs e)
        {
            IsFiltering = true;
            Filter = Category.Quest;
            OptionsPanel.Select();
            UpdateOptions();
        }

        private void PersonalButton_Click(object sender, EventArgs e)
        {
            IsFiltering = true;
            Filter = Category.Personal;
            OptionsPanel.Select();
            UpdateOptions();
        }

        private void LocationButton_Click(object sender, EventArgs e)
        {
            IsFiltering = true;
            Filter = Category.Location;
            OptionsPanel.Select();
            UpdateOptions();
        }

        private void TradeButton_Click(object sender, EventArgs e)
        {
            IsFiltering = true;
            Filter = Category.Trade;
            OptionsPanel.Select();
            UpdateOptions();
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateOptions();
        }
        #endregion
    }
}
