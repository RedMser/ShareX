using System.Windows.Forms;

namespace ShareX.HelpersLib
{
    public static class ConfirmExit
    {
        /// <summary>
        /// Prompts user for exitting despite unsaved changes. Returns whether the user wants to exit (pressed "Yes").
        /// </summary>
        public static bool PromptExit()
        {
            const MessageBoxOptions topmost = (MessageBoxOptions)0x40000;
            var res = MessageBox.Show("You have unsaved changes pending!\n\nAre you sure you want to exit?", "Unsaved changes",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, topmost);
            return res == DialogResult.Yes;
        }
    }
}
