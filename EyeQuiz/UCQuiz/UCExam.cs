using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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
        public Dictionary<Guid, Guid> AnsweredQuestions { get; set; } 

        public int QuestionIndex { get; set; }

        public UCQuestion UcQuestion { get; set; }

        private List<ToolTip> _toolTips;
        private List<UCQuestion> UcQuestions { get; set; }

        private List<int> VerticalLoc { get; set; }
        private List<int> HorizontalLoc { get; set; }

        private QuizResult QuizResult { get; set; }

        public List<ResultQuestionBlock> ResultQuestionBlocks { get; set; }

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
            AnsweredQuestions = new Dictionary<Guid, Guid>();
            UcQuestions = new List<UCQuestion>();
            /*
             * Y 156
Y 236
Y 321
Y 413

X 7 - X - 47
             */
            VerticalLoc = new List<int>()
            {
                125, 189, 257, 329
            };

            HorizontalLoc = new List<int>()
            {
                6, 38,
            };

            ResultQuestionBlocks = new List<ResultQuestionBlock>();
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
            ucQuestion.Tag = question.Guid;
            ucQuestion.Controls["LabelQuestionNo"].Text = (QuestionIndex + 1).ToString();
            ucQuestion.Controls["LabelQuestion"].Text = question.Text.Trim();

            for (int i = 0; i < ucQuestion.Controls["PanelAnswers"].Controls.Count; i++)
            {
                if (ucQuestion.Controls["PanelAnswers"].Controls[i] is Label labelAnswer)
                {
                    labelAnswer.Text = question.Answers[i].Text.Trim();
                    ucQuestion.Controls["PanelRadioButtons"].Controls[i].Tag = question.Answers[i].Guid;
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
            if (Questions.Count != UcQuestions.Count)
            {
                var nextIndex = UcQuestions.Count;

                for (; nextIndex < Questions.Count; nextIndex++)
                {
                    QuestionIndex = nextIndex;
                    var ucQuestion = new UCQuestion();
                    this.PanelUcQuestion.Controls.Add(ucQuestion);
                    LoadQuestion(ucQuestion, Questions[nextIndex]);
                    UcQuestions.Add(ucQuestion);
                }
            }
            PanelQuestionControl.Controls["ButtonAccept"].Enabled = false;
            ButtonSubmit.Visible = false;
            ButtonGetResult.Visible = true;
            CheckQuestions();
            SetResults();

            QuestionIndex = 0;
            UcQuestion = UcQuestions[QuestionIndex];
            UcQuestion.BringToFront();
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

            this.ButtonAccept.Enabled = !UcQuestion.AcceptButtonClicked;
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

            this.ButtonAccept.Enabled = !UcQuestion.AcceptButtonClicked;
        }

        private void ButtonAccept_Click(object sender, EventArgs e)
        {
            if (!CheckUserAnswer())
                return;

            var answerIndex = GetAnswerIndex(UcQuestion);

            if (answerIndex < 0)
                return;

            var currentQuestion = Questions[QuestionIndex];

            AnsweredQuestions[currentQuestion.Guid] = currentQuestion.Answers[answerIndex].Guid;

            this.UcQuestion.AcceptButtonClicked = true;
            ButtonAccept.Enabled = false;
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

        private int GetAnswerIndex(UCQuestion panelUcQuestion)
        {
            var panelRadioButtons = panelUcQuestion.Controls["PanelRadioButtons"] as Panel;

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

        private void CheckQuestions()
        {
            var result = new QuizResult();

            for (var i = 0; i < UcQuestions.Count; i++)
            {
                var resultQuestionBlock = new ResultQuestionBlock(){QuestionId = Questions[i].Guid};

                var ucQuestion = UcQuestions[i];

                var answerIndex = GetAnswerIndex(ucQuestion);

                var correctAnswerId = Questions[i].Answers.SingleOrDefault(a => a.IsCorrect == "Yes").Guid;

                resultQuestionBlock.CorrectAnswerId = correctAnswerId;

                if (answerIndex < 0)
                {
                    var answerStatus = AnswerStatus.NotAnswered;
                    resultQuestionBlock.Answer = new CheckedAnswer()
                        {AnswerStatus = answerStatus, AnswerId = Guid.Empty};
                }
                else
                {
                    var radioButton =
                        ucQuestion.Controls["PanelRadioButtons"].Controls[answerIndex] as Guna2CustomRadioButton;

                    var answerId = (Guid)radioButton.Tag;

                    AnswerStatus answerStatus;
                    if (answerId == correctAnswerId)
                        answerStatus = AnswerStatus.CorrectAnswer;
                    else
                    {
                        answerStatus = AnswerStatus.IncorrectAnswer;
                    }

                    resultQuestionBlock.Answer = new CheckedAnswer() {AnswerId = answerId, AnswerStatus = answerStatus};
                }

                ResultQuestionBlocks.Add(resultQuestionBlock);
            }
        }

        private void SetResults()
        {
            for (int i = 0; i < ResultQuestionBlocks.Count; i++)
            {
                var resultQuestionBlock = ResultQuestionBlocks[i];

                var ucQuestion = UcQuestions[i];


                var pcBxCorrectAnswer = ucQuestion.Controls["PictureBoxCorrectAnswer"] as PictureBox;

                pcBxCorrectAnswer.Image = Properties.Resources.checked_40px;

                pcBxCorrectAnswer.Visible = true;

                var correctAnswerRdIndex = GetAnswerRadioButtonIndex(ucQuestion, resultQuestionBlock.CorrectAnswerId);

                pcBxCorrectAnswer.Location = new Point(HorizontalLoc[0], VerticalLoc[correctAnswerRdIndex]);


                var pcBxUserAnswer = ucQuestion.Controls["PictureBoxUserAnswer"] as PictureBox;

                if (resultQuestionBlock.Answer.AnswerStatus != AnswerStatus.NotAnswered)
                {
                    var userAnswerRdIndex = GetAnswerRadioButtonIndex(ucQuestion, resultQuestionBlock.Answer.AnswerId);

                    pcBxUserAnswer.Location = new Point(HorizontalLoc[1], VerticalLoc[userAnswerRdIndex]);

                    pcBxUserAnswer.Visible = true;

                    if (resultQuestionBlock.Answer.AnswerStatus == AnswerStatus.CorrectAnswer)
                        pcBxUserAnswer.Image = Properties.Resources.checked_green_80px;
                    else
                    {
                        pcBxUserAnswer.Image = Properties.Resources.multiply_24px;
                    }
                }
            }
        }

        private int GetAnswerRadioButtonIndex(UCQuestion ucQuestion, Guid questionAnswerId)
        {
            var panelRadioButtons = ucQuestion.Controls["PanelRadioButtons"] as Panel;

            for (int i = 0; i < panelRadioButtons.Controls.Count; i++)
            {
                if (panelRadioButtons.Controls[i] is Guna2CustomRadioButton rd)
                {
                    var answerId = (Guid)rd.Tag;

                    if (questionAnswerId == answerId)
                        return i;
                }
            }

            return -1;
        }
    }
}
