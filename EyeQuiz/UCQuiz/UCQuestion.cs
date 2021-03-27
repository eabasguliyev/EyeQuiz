using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EyeQuiz.Entities;
using Guna.UI2.WinForms;

namespace EyeQuiz.UCQuiz
{
    public partial class UCQuestion : UserControl
    {
        public bool AcceptButtonClicked { get; set; }
        public UCQuestion()
        {
            InitializeComponent();
        }

        private void RadioButtonAnswer1_CheckedChanged(object sender, EventArgs e)
        {
            if (!(sender is Guna2CustomRadioButton exceptThis)) return;

            if (!exceptThis.Checked) return;

            for (var i = 0; i < this.PanelRadioButtons.Controls.Count; i++)
            {
                if (!(this.PanelRadioButtons.Controls[i] is Guna2CustomRadioButton rd)) continue;

                if(rd != exceptThis)
                {
                    rd.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
                }
            }
        }

        private void UCQuestion_Load(object sender, EventArgs e)
        {
           
        }

        private void LabelQuestion_Click(object sender, EventArgs e)
        {

        }

        public Bitmap TakeScreenShot()
        {
            var bmp = new Bitmap(this.Width, this.Height);

            this.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
            
            return bmp;
        }
    }
}
