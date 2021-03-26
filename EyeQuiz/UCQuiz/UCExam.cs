using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using EyeQuiz.Entities;
using EyeQuiz.Helpers;
using Guna.UI2.WinForms;

namespace EyeQuiz.UCQuiz
{
    public partial class UCExam : UserControl
    {
        public UserControl LastUc { get; set; }

        public List<QuestionBlock> Questions { get; set; }
        public List<QuestionBlock> AnsweredQuestions { get; set; }

        public int QuestionIndex { get; set; }

        public UCQuestion UcQuestion { get; set; }

        private List<ToolTip> _toolTips;
        private List<UCQuestion> UcQuestions { get; set; }

        public UCExam()
        {
            InitializeComponent();

            _toolTips = new List<ToolTip>()
            {
                new ToolTip(),
                new ToolTip(),
                new ToolTip(),
                new ToolTip(),
            };
            AnsweredQuestions = new List<QuestionBlock>();
            UcQuestions = new List<UCQuestion>();
        }

        private void UCExam_Load(object sender, EventArgs e)
        {
            UcQuestion = new UCQuestion();

            this.PanelUcQuestion.Controls.Add(UcQuestion);
            
            UcQuestions.Add(UcQuestion);

            LoadQuestion(this.UcQuestion, Questions[QuestionIndex]);

            ChangeLabelQuestionNo();
        }


        private void ChangeLabelQuestionNo()
        {
            this.LabelCurrentQuestionNo.Text = $"Question {QuestionIndex + 1} of {Questions.Count}";
        }
        private void LoadQuestion(UCQuestion ucQuestion, QuestionBlock question)
        {
            ucQuestion.Controls["LabelQuestionNo"].Text = (QuestionIndex + 1).ToString();
            ucQuestion.Controls["LabelQuestion"].Text = question.Text.Trim();

            for (int i = 0; i < this.UcQuestion.Controls["PanelAnswers"].Controls.Count; i++)
            {
                if (this.UcQuestion.Controls["PanelAnswers"].Controls[i] is Label labelAnswer)
                {
                    labelAnswer.Text = question.Answers[i].Text.Trim();
                }
            }
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


            UcQuestion = UcQuestions[QuestionIndex];

            UcQuestion.BringToFront();

            ChangeLabelQuestionNo();
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            if (QuestionIndex + 1 == Questions.Count)
                return;

            QuestionIndex++;

            if (QuestionIndex < UcQuestions.Count)
            {
                UcQuestion = UcQuestions[QuestionIndex];
            }
            else
            {
                UcQuestion = new UCQuestion();

                this.PanelUcQuestion.Controls.Add(UcQuestion);
                UcQuestions.Add(UcQuestion);

                LoadQuestion(this.UcQuestion, Questions[QuestionIndex]);
            }

            UcQuestion.BringToFront();
            ChangeLabelQuestionNo();
        }

        private void ButtonAccept_Click(object sender, EventArgs e)
        {
            if (!CheckUserAnswer())
                return;

            var answerIndex = GetAnswerIndex();

            if (answerIndex < 0)
                return;

            var currentQuestion = Questions[QuestionIndex];

            var answeredQuestion = new QuestionBlock()
            {
                Guid = currentQuestion.Guid,
                Text = currentQuestion.Text,
            };

            answeredQuestion.Answers.Add(currentQuestion.Answers[answerIndex]);
        }

        private bool CheckUserAnswer()
        {
            var panelRadioButtons = this.PanelUcQuestion.Controls["UcQuestion"].Controls["PanelRadioButtons"] as Panel;


            var radioButtonChecked = false;
            for (int i = 0; i < panelRadioButtons.Controls.Count; i++)
            {
                if (panelRadioButtons.Controls[i] is Guna2CustomRadioButton rd)
                {
                    if(rd.Checked)
                    {
                        radioButtonChecked = true;
                        break;
                    }
                }
            }


            if (!radioButtonChecked)
            {
                for (int i = 0; i < panelRadioButtons.Controls.Count; i++)
                {
                    if (panelRadioButtons.Controls[i] is Guna2CustomRadioButton rd)
                    {
                        rd.UncheckedState.BorderColor = Color.Red;

                        UxHelper.SetNewToolTip(rd, _toolTips[i], "Answer", "You must be select answer");
                    }
                }
            }

            return radioButtonChecked;
        }

        private int GetAnswerIndex()
        {
            var panelRadioButtons = this.PanelUcQuestion.Controls["UcQuestion"].Controls["PanelRadioButtons"] as Panel;

            for (int i = 0; i < panelRadioButtons.Controls.Count; i++)
            {
                if (panelRadioButtons.Controls[i] is Guna2CustomRadioButton rd)
                {
                    if (rd.Checked)
                    {
                        return i;
                    }
                }
            }

            return -1;
        }
    }
}
