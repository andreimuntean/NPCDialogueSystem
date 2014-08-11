using System.Drawing;
using System.Windows.Forms;

namespace NPCDialogueSystem
{
    public class DialogueButton : Button
    {
        public bool Selected { get; set; }
        public DialogueOption DialogueOption {get; set;}

        public DialogueButton(DialogueOption dialogueOption)
        {
            DialogueOption = dialogueOption;

            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            BackColor = Color.FromArgb(100, 0, 0);
            ForeColor = Color.White;
            TextAlign = ContentAlignment.TopLeft;
            Width = 647;

            Text = DialogueOption.Text;
        }
    }
}
