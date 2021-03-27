using System.CodeDom;
using System.Text;
using System.Windows.Forms.VisualStyles;

namespace EyeQuiz.Entities
{
    public struct Time
    {
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public bool Status { get; set; }

        public void Decrement()
        {
            if (this.Seconds > 0)
                this.Seconds--;
            else
            {
                if (this.Minutes > 0)
                {
                    this.Minutes--;
                    this.Seconds = 59;
                }
                else
                {
                    this.Status = true;
                }
            }
        }

        public override string ToString()
        {
            return $"{((Minutes < 10) ? "0" : "")}{Minutes}:{((Seconds < 10) ? "0" : "")}{Seconds}";
        }
    }
}