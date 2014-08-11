using System.Collections.Generic;

namespace NPCDialogueSystem
{
    public class DialogueOption
    {
        public Category Category { get; set; }
        public bool Visible { get; set; }
        public string Text { get; set; }
        public string Reply { get; set; }
        public List<DialogueOption> SubsequentOptions { get; set; }

        public DialogueOption()
        {
            SubsequentOptions = new List<DialogueOption>();
        }
    }
}
