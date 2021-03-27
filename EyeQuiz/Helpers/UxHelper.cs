using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace EyeQuiz.Helpers
{
    public static class UxHelper
    {
        public static void SetNewToolTip(Control control, ToolTip toolTip, string title, string caption)
        {
            toolTip.ToolTipTitle = title;
            toolTip.ToolTipIcon = ToolTipIcon.Error;

            toolTip.SetToolTip(control, caption);


            if (control is Guna2TextBox questionTextBox)
            {
                questionTextBox.BorderColor = Color.Red;
            }
            else if (control is Guna2CustomRadioButton rd)
            {
                rd.UncheckedState.BorderColor = Color.Red;
            }
        }

        public static DialogResult AreYouSure(string text)
        {
            var status = MessageBox.Show(text, "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            return status;
        }
    }
}