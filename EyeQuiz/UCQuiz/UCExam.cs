using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EyeQuiz.Entities;

namespace EyeQuiz.UCQuiz
{
    public partial class UCExam : UserControl
    {
        public UserControl LastUc { get; set; }

        public List<QuestionBlock> Questions { get; set; }

        public int QuestionIndex { get; set; }

        public UCQuestion UcQuestion { get; set; }
        public UCExam()
        {
            InitializeComponent();
        }

        private void UCExam_Load(object sender, EventArgs e)
        {
            UcQuestion = new UCQuestion();

            this.PanelUcQuestion.Controls.Add(UcQuestion);

            LoadQuestion(Questions[QuestionIndex]);
        }

        private void LoadQuestion(QuestionBlock question)
        {
            this.UcQuestion.Controls["LabelQuestionNo"].Text = (QuestionIndex + 1).ToString();
            this.UcQuestion.Controls["LabelQuestion"].Text = question.Text.Trim();

            for (int i = 0; i < this.UcQuestion.Controls["PanelAnswers"].Controls.Count; i++)
            {
                if (this.UcQuestion.Controls["PanelAnswers"].Controls[i] is Label labelAnswer)
                {
                    labelAnswer.Text = question.Answers[i].Text.Trim();
                }
            }

            this.LabelCurrentQuestionNo.Text = $"Question {QuestionIndex + 1} of {Questions.Count}";
        }

        private void ButtonBack_MouseEnter(object sender, EventArgs e)
        {
            ButtonBack.Image = Properties.Resources.back_to_100px;
        }

        private void ButtonBack_MouseLeave(object sender, EventArgs e)
        {
            ButtonBack.Image = Properties.Resources.back_to_light_100px;
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            PanelQuestionControl.Dispose();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            LastUc.BringToFront();
        }

        private void ButtonPrev_Click(object sender, EventArgs e)
        {
            if (QuestionIndex == 0)
                return;

            QuestionIndex--;

            LoadQuestion(Questions[QuestionIndex]);
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            if (QuestionIndex + 1 == Questions.Count)
                return;

            QuestionIndex++;

            LoadQuestion(Questions[QuestionIndex]);
        }
    }
}
