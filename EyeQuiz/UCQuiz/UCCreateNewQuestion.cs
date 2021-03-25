using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using EyeQuiz.AppExceptions;
using EyeQuiz.Entities;
using EyeQuiz.Helpers.FileHelpers;
using Guna.UI2.WinForms;

namespace EyeQuiz.UCQuiz
{
    public partial class UCCreateNewQuestion : UserControl
    {
        public UserControl LastUc;
        public int QuestionCounter = 0;
        public bool Loaded = false;
        public QuestionsBlock QuestionsBlock { get; set; }

        private List<List<ToolTip>> ToolTips;

        public UCCreateNewQuestion()
        {
            InitializeComponent();
            QuestionsBlock = new QuestionsBlock();
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
            if (!Loaded)
            {
                var ucNewQuestion = CreateNewQuestionInstance();
                this.PanelQuestions.Controls.Add(ucNewQuestion);
            }
            else
            {
                LoadQuestions(QuestionsBlock.Questions);
            }
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
            this.QuestionsBlock.Questions.Clear();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (!AddQuestionAndUpdate())
                return;

            if (!Directory.Exists(@"Questions\"))
            {
                Directory.CreateDirectory("Questions");
            }

            XmlHelper.DirectoryName = @"Questions";

            if (string.IsNullOrWhiteSpace(QuestionsBlock.FileName))
            {
                var getFileNameForm = new Form3();

                if (getFileNameForm.ShowDialog() == DialogResult.Cancel)
                    return;

                QuestionsBlock.FileName = getFileNameForm.FileName;
            }

            XmlHelper.Serialize(QuestionsBlock);
        }

        private bool AddQuestionAndUpdate()
        {
            if (QuestionCounter > 0)
            {
                var ucLastQuestion = this.PanelQuestions.Controls[QuestionCounter - 1] as UCNewQuestion;

                if (!CheckUserInput(ucLastQuestion))
                    return false;

                if (ucLastQuestion?.Changed == true && QuestionCounter != QuestionsBlock.Questions.Count)
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
            QuestionsBlock.Questions.Add(newQuestionBlock);
        }

        private void UpdateQuestions()
        {
            for (var i = 0; i < this.PanelQuestions.Controls.Count; i++)
            {
                var ucQuestion = this.PanelQuestions.Controls[i] as UCNewQuestion;

                if (ucQuestion?.Changed != true) continue;

                var questionBlock = QuestionsBlock.Questions[i];

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
            if (index <= QuestionsBlock.Questions.Count)
                throw new QuestionException($"There is no question associated this index: {index}");

            QuestionsBlock.Questions.RemoveAt(index);
        }

        private bool CheckUserInput(UCNewQuestion ucQuestion)
        {
            var status = true;
            var questionTextBox = ucQuestion.Controls["TextBoxQuestion"] as Guna2TextBox;

            var index = ucQuestion.QuestionNo - 1;

            if (!Loaded)
            {
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
            }
            else
            {
                for (int i = 0; i < ucQuestion.QuestionNo; i++)
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

                Loaded = false;
            }

            if (String.IsNullOrWhiteSpace(questionTextBox?.Text))
            {
                status = false;
                SetNewToolTip(questionTextBox, ToolTips[index][0], "Question", "Question text can not be empty!");

            }
            else if(ToolTips[index] != null)
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

        public void LoadQuestions(List<QuestionBlock> questions)
        {
            if (questions == null)
                throw new ArgumentNullException(nameof(questions));

            foreach (var questionBlock in questions)
            {
                var ucNewQuestion = CreateNewQuestionInstance();

                var ucNewQuestionTextBox = ucNewQuestion.Controls["TextBoxQuestion"] as Guna2TextBox;

                ucNewQuestionTextBox.Text = questionBlock.Text;

                
                for (int i = 0; i < questionBlock.Answers.Count; i++)
                {
                    
                    var answerTextBox = ucNewQuestion.Controls["PanelAnswers"].Controls[i] as Guna2TextBox;

                    answerTextBox.Text = questionBlock.Answers[i].Text;

                    if (questionBlock.Answers[i].IsCorrect == "Yes")
                    {
                        var answerRadioButton = ucNewQuestion.Controls["PanelRadioButtons"].Controls[i] as Guna2CustomRadioButton;
                        answerRadioButton.Checked = true;
                    }
                }

                ucNewQuestion.Changed = true;

                this.PanelQuestions.Controls.Add(ucNewQuestion);
            }
        }
        public static void SetNewToolTip(Control control, ToolTip toolTip, string title, string caption)
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
