using System.Drawing;
using System.Windows.Forms;

namespace EyeQuiz.Helpers
{
    public static class ScreenShot
    {
        public static Bitmap TakeArea(Control control)
        {
            var bmp = new Bitmap(control.Width, control.Height);

            control.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));

            return bmp;
        }
    }
}