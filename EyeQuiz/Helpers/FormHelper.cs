using System.Drawing;
using System.Windows.Forms;

namespace EyeQuiz.Helpers
{
    public static class FormHelper
    {
        private static bool _dragging = false;
        private static Point _dragCursorPoint;
        private static Point _dragFormPoint;

        public static void MouseDown(Point cursorPosition, Point formLocation)
        {
            _dragging = true;
            _dragCursorPoint = cursorPosition;
            _dragFormPoint = formLocation;
        }

        public static Point MouseMove()
        {
            if (_dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(_dragCursorPoint));
                return Point.Add(_dragFormPoint, new Size(dif));
            }
            return Point.Empty;
        }

        public static void MouseUp()
        {
            _dragging = false;
        }
    }
}