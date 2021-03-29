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
using EyeQuiz.Helpers;
using EyeQuiz.Interfaces;
using Guna.UI2.WinForms;

namespace EyeQuiz.UCQuiz
{
    public partial class UCQuestion : UserControl, IScreenShot
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
            return ScreenShot.TakeArea(this);
        }
    }
}
