using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace NPCDialogueSystem
{
    static class ExceptionManager
    {
        public static void Log(string message)
        {
            // Debugger.Log(5, "Error", "\n" + message);
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static void Log(Exception exception)
        {
            // Debugger.Log(5, "Error", "\n" + exception.Message);
            MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}