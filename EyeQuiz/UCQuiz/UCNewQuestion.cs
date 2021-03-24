using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace EyeQuiz.UCQuiz
{
    public partial class UCNewQuestion : UserControl
    {
        public UCNewQuestion()
        {
            InitializeComponent();
        }

        private void TextBoxQuestion_TextChanged(object sender, EventArgs e)
        {
            if (sender is Guna2TextBox textBox)
                textBox.ForeColor = Color.Black;
        }

        private void ChangeRadioButtonsColor(Guna2CustomRadioButton rd)
        {
            foreach (Control control in this.PanelAnswers.Controls)
            {
                if (control is Guna2CustomRadioButton radioButton)
                {
                    if (radioButton != rd)
                    {
                        radioButton.UncheckedState.BorderColor = Color.Red;
                        radioButton.UncheckedState.FillColor = Color.Red;
                    }
                    else
                    {
                        radioButton.CheckedState.BorderColor = Color.Green;
                        radioButton.CheckedState.FillColor = Color.Green;
                        radioButton.CheckedState.InnerColor = Color.Green;
                    }
                }
            }
        }

        private void RadioButtonAnswer1_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is Guna2CustomRadioButton rd)
            {
                ChangeRadioButtonsColor(rd);
            }
        }

        private void PictureBoxRemove_MouseEnter(object sender, EventArgs e)
        {
            PictureBoxRemove.Image = Properties.Resources.remove_red_100px;
        }

        private void PictureBoxRemove_MouseLeave(object sender, EventArgs e)
        {
            PictureBoxRemove.Image = Properties.Resources.remove_100px;
        }

        private void PictureBoxRemove_Click(object sender, EventArgs e)
        {
            this.Dispose();
            var uc = Form2.Instance.Controls["PanelUserControls"]
                .Controls["UCCreateNewQuestion"] as UCCreateNewQuestion;

            uc?.ChangeQuestionsNo();
        }
    }
}
