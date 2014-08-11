using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace NPCDialogueSystem
{
    static class ExceptionManager
    {
        public static void Log(string message, bool alert = false)
        {
            Debugger.Log(5, "Error", "\n" + message);

            if (alert)
            {
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public static void Log(Exception exception, bool alert = false)
        {
            Debugger.Log(5, "Error", "\n" + exception.Message);

            if (alert)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}