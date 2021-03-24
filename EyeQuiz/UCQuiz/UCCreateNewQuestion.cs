using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EyeQuiz.UCQuiz
{
    public partial class UCCreateNewQuestion : UserControl
    {
        public UserControl LastUc;
        public int QuestionCounter = 0;
        public UCCreateNewQuestion()
        {
            InitializeComponent();
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
            var ucNewQuestion = new UCNewQuestion();
            ucNewQuestion.Dock = DockStyle.Top;
            //ucNewQuestion.Location = new Point(0, QuestionCounter * 442);
            QuestionCounter++;
            ucNewQuestion.Controls["LabelQuestionNo"].Text = QuestionCounter.ToString();
            return ucNewQuestion;
        }

        private bool CheckCurrentQuestion()
        {
            return true; // hal hazirki sualin tam doldurulub doldurulmadighini yoxla.
        }

        private void ButtonAddNew_Click(object sender, EventArgs e)
        {
            if (!CheckCurrentQuestion())
                throw new NotImplementedException();

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
                ucQuestion.Controls["LabelQuestionNo"].Text = QuestionCounter.ToString();
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            this.PanelQuestions.Controls.Clear();
            QuestionCounter = 0;
        }
    }
}
