using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EyeQuiz.AppException;
using EyeQuiz.Entities;
using Guna.UI2.WinForms;

namespace EyeQuiz.UCQuiz
{
    public partial class UCCreateNewQuestion : UserControl
    {
        public UserControl LastUc;
        public int QuestionCounter = 0;
        public List<QuestionBlock> Questions { get; set; }

        private List<List<ToolTip>> ToolTips;

        public UCCreateNewQuestion()
        {
            InitializeComponent();
            Questions = new List<QuestionBlock>();
            ToolTips = new List<List<ToolTip>>();
        }

        private void ButtonBack_MouseEnter(object sender, EventArgs e)
        {
            ButtonBack.Image = Properties.Resources.back_to_100px;
        }

        private void ButtonBack_MouseLeave(object sender, EventArgs e)
        {
            ButtonBack.Image = Properties.Resources.back_to_light_100px;
        }

        private void UCCreateNewQuestion_Load(object sender, EventArgs e)
        {
            var ucNewQuestion = CreateNewQuestionInstance();
            this.PanelQuestions.Controls.Add(ucNewQuestion);
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            Form2.Instance.Controls["PanelUserControls"].Controls["UCCreateNewQuestion"].Dispose();
            LastUc.BringToFront();
        }

        private UCNewQuestion CreateNewQuestionInstance()
        {
            QuestionCounter++;

            var ucNewQuestion = new UCNewQuestion {Dock = DockStyle.Top, QuestionNo = QuestionCounter};

            //ucNewQuestion.Location = new Point(0, QuestionCounter * 442);
            ucNewQuestion.Controls["LabelQuestionNo"].Text = ucNewQuestion.QuestionNo.ToString();
            return ucNewQuestion;
        }

        private void ButtonAddNew_Click(object sender, EventArgs e)
        {
            if (!AddQuestionAndUpdate())
                return;

            var ucNewQuestion = CreateNewQuestionInstance();
            this.PanelQuestions.Controls.Add(ucNewQuestion);
            this.PanelQuestions.VerticalScroll.Value = 0;
            this.PanelQuestions.AutoScrollPosition = new Point(0, 0);
        }

        private void ButtonGoLast_Click(object sender, EventArgs e)
        {
            this.PanelQuestions.AutoScrollPosition = new Point(0, 0);
        }

        private void ButtonFirst_Click(object sender, EventArgs e)
        {
            this.PanelQuestions.AutoScrollPosition = new Point(0, QuestionCounter * 442);
        }

        public void ChangeQuestionsNo()
        {
            QuestionCounter = 0;
            foreach (UCNewQuestion ucQuestion in this.PanelQuestions.Controls)
            {
                QuestionCounter++;
                ucQuestion.QuestionNo = QuestionCounter;
                ucQuestion.Controls["LabelQuestionNo"].Text = ucQuestion.QuestionNo.ToString();
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            this.PanelQuestions.Controls.Clear();
            QuestionCounter = 0;
            this.Questions.Clear();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (!AddQuestionAndUpdate())
                return;
        }

        private bool AddQuestionAndUpdate()
        {
            if (QuestionCounter > 0)
            {
                var ucLastQuestion = this.PanelQuestions.Controls[QuestionCounter - 1] as UCNewQuestion;

                if (!CheckUserInput(ucLastQuestion))
                    return false;

                if (ucLastQuestion?.Changed == true && QuestionCounter != Questions.Count)
                {
                    try
                    {
                        AddNewQuestionToList(ucLastQuestion);
                    }
                    catch
                    {
                        // ignored
                    }
                }
                UpdateQuestions();
            }

            return true;
        }
        private void AddNewQuestionToList(UCNewQuestion ucNewQuestion)
        {
            var textBoxQuestion = ucNewQuestion?.Controls["TextBoxQuestion"] as Guna2TextBox;

            var newQuestionBlock = new QuestionBlock {Text = textBoxQuestion?.Text};

            var answerCount = ucNewQuestion?.Controls["PanelRadioButtons"].Controls.Count;

            for (var i = 0; i < answerCount; i++)
            {
                var newAnswerTextBox = ucNewQuestion.Controls["PanelAnswers"].Controls[i] as Guna2TextBox;

                var newAnswer = new Answer {Text = newAnswerTextBox?.Text};

                if (!(ucNewQuestion.Controls["PanelRadioButtons"].Controls[i] is Guna2CustomRadioButton rd))
                    throw new InvalidOperationException();

                newAnswer.IsCorrect = rd.Checked ? "Yes" : "No";

                newQuestionBlock.Answers.Add(newAnswer);
            }

            ucNewQuestion.Changed = false;
            Questions.Add(newQuestionBlock);
        }

        private void UpdateQuestions()
        {
            for (var i = 0; i < this.PanelQuestions.Controls.Count; i++)
            {
                var ucQuestion = this.PanelQuestions.Controls[i] as UCNewQuestion;

                if (ucQuestion?.Changed != true) continue;

                var questionBlock = Questions[i];

                var textBoxQuestion = ucQuestion.Controls["TextBoxQuestion"] as Guna2TextBox;

                questionBlock.Text = textBoxQuestion?.Text;

                var answerCount = ucQuestion?.Controls["PanelRadioButtons"].Controls.Count;

                for (var j = 0; j < answerCount; j++)
                {
                    var newAnswerTextBox = ucQuestion.Controls["PanelAnswers"].Controls[j] as Guna2TextBox;

                    var answer = questionBlock.Answers[j];

                    answer.Text = newAnswerTextBox?.Text;

                    if (!(ucQuestion.Controls["PanelRadioButtons"].Controls[j] is Guna2CustomRadioButton rd))
                        throw new InvalidOperationException();

                    answer.IsCorrect = rd.Checked ? "Yes" : "No";
                }

                ucQuestion.Changed = false;
            }
        }

        public void RemoveQuestionFromList(int index)
        {
            if (index <= Questions.Count)
                throw new QuestionException($"There is no question associated this index: {index}");

            Questions.RemoveAt(index);
        }

        private bool CheckUserInput(UCNewQuestion ucQuestion)
        {
            var status = true;
            var questionTextBox = ucQuestion.Controls["TextBoxQuestion"] as Guna2TextBox;

            var index = ucQuestion.QuestionNo - 1;

            if (ToolTips.Count == index)
            {
                ToolTips.Add(new List<ToolTip>()
                {
                    new ToolTip(),
                    new ToolTip(),
                    new ToolTip(),
                    new ToolTip(),
                    new ToolTip(),
                    new ToolTip(),
                    new ToolTip(),
                    new ToolTip(),
                    new ToolTip(),
                });
            }

            if (String.IsNullOrWhiteSpace(questionTextBox?.Text))
            {
                status = false;
                SetNewToolTip(questionTextBox, ToolTips[index][0], "Question", "Question text can not be empty!");

            }
            else if(ToolTips[index][0] != null)
            {
                ToolTips[index][0] = new ToolTip();

                questionTextBox.BorderColor = Color.FromArgb(213, 218, 223);
            }

            var radioButtonChecked = false;
            for (int i = 0; i < ucQuestion.Controls["PanelAnswers"].Controls.Count; i++)
            {
                var textBoxAnswer = ucQuestion.Controls["PanelAnswers"].Controls[i] as Guna2TextBox;

                if (String.IsNullOrWhiteSpace(textBoxAnswer.Text))
                {
                    status = false;
                    SetNewToolTip(textBoxAnswer, ToolTips[index][i + 1], "Answer", "Answer text can not be empty!");
                }
                else
                {
                    ToolTips[index][i + 1] = new ToolTip();

                    textBoxAnswer.BorderColor = Color.FromArgb(213, 218, 223);
                }

                var radioButtonAnswer = ucQuestion.Controls["PanelRadioButtons"].Controls[i] as Guna2CustomRadioButton;

                if (radioButtonAnswer?.Checked == true)
                    radioButtonChecked = true;
            }

            if (!radioButtonChecked)
            {
                for (int i = 0; i < ucQuestion.Controls["PanelRadioButtons"].Controls.Count; i++)
                {
                    var radioButtonAnswer = ucQuestion.Controls["PanelRadioButtons"].Controls[i] as Guna2CustomRadioButton;

                    SetNewToolTip(radioButtonAnswer, ToolTips[index][i + ucQuestion.Controls["PanelAnswers"].Controls.Count + 1], "Correct answer", "You must be select correct answer");
                }

                status = false;
            }
            else
            {
                for (int i = 0; i < ucQuestion.Controls["PanelRadioButtons"].Controls.Count; i++)
                {
                    var radioButtonAnswer = ucQuestion.Controls["PanelRadioButtons"].Controls[i] as Guna2CustomRadioButton;

                    ToolTips[index][i + ucQuestion.Controls["PanelAnswers"].Controls.Count + 1] = new ToolTip();
                }
            }
            return status;
        }

        private void SetNewToolTip(Control control, ToolTip toolTip, string title, string caption)
        {
            toolTip.ToolTipTitle = title;
            toolTip.ToolTipIcon = ToolTipIcon.Error;

            toolTip.SetToolTip(control, caption);
            

            if (control is Guna2TextBox questionTextBox)
            {
                questionTextBox.BorderColor = Color.Red;
            }
            else if(control is Guna2CustomRadioButton rd)
            {
                rd.UncheckedState.BorderColor = Color.Red;
            }
        }
    }
}
