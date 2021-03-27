using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            //MessageBox.Show($"{PictureBoxCorrectAnswer.Location}");
            //MessageBox.Show($"{PictureBoxUserAnswer.Location}");

            //for (int i = 0; i < this.PanelAnswers.Controls.Count; i++)
            //{
            //    if (this.PanelAnswers.Controls[i] is Label lbl)
            //    {
            //        MessageBox.Show($"{lbl.Name}");
            //    }
            //}

            //for (int i = 0; i < this.PanelRadioButtons.Controls.Count; i++)
            //{
            //    if (this.PanelRadioButtons.Controls[i] is Guna2CustomRadioButton lbl)
            //    {
            //        MessageBox.Show($"{lbl.Name}");
            //    }
            //}
        }

        private void LabelQuestion_Click(object sender, EventArgs e)
        {

        }
    }
}
