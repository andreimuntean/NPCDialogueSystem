using System.Collections.Generic;
using System.Linq;

namespace NPCDialogueSystem
{
    public class Dialogue
    {
        public string Name { get; set; }
        public string Greeting { get; set; }
        public List<DialogueOption> DialogueOptions { get; set; }
        public List<DialogueOption> DisplayedOptions { get; set; }

        public void Select(DialogueOption dialogueOption)
        {
            if (dialogueOption.SubsequentOptions.Count > 0)
            {
                DisplayedOptions = dialogueOption.SubsequentOptions;
            }
            else
            {
                Initialize();
            }
        }

        public void Initialize()
        {
            DisplayedOptions = new List<DialogueOption>(DialogueOptions.Where(dialogueOption => dialogueOption.Visible));
        }

        public List<DialogueOption> FilterBy(Category category)
        {
            return DisplayedOptions.Where(option => option.Category == category) as List<DialogueOption>;
        }

        public List<DialogueButton> GetDialogueButtons(Category categoryFilter, string textFilter = "")
        {
            return new List<DialogueButton>(DisplayedOptions.Where(option => option.Category == categoryFilter && option.Text.ToUpper().Contains(textFilter.ToUpper())).Select(option => new DialogueButton(option)));
        }

        public List<DialogueButton> GetDialogueButtons(string textFilter = "")
        {
            return new List<DialogueButton>(DisplayedOptions.Where(option => option.Text.ToUpper().Contains(textFilter.ToUpper())).Select(option => new DialogueButton(option)));
        }
    }
}
