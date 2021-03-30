using System.Drawing;
using Guna.UI2.WinForms;

namespace EyeQuiz.Helpers
{
    public static class ControlHelper
    {
        public static void ChangeTextBoxForeColor(Guna2TextBox txtBox)
        {
            if (txtBox.ForeColor == Color.FromArgb(125, 137, 149))
                txtBox.ForeColor = Color.Black;
        }
    }
}