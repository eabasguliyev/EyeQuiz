using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using EyeQuiz.Entities;
using EyeQuiz.Enums;
using EyeQuiz.Helpers;
using EyeQuiz.Helpers.FileHelpers;
using EyeQuiz.Interfaces;
using Guna.UI2.AnimatorNS;
using Guna.UI2.WinForms;

namespace EyeQuiz.UCQuiz
{
    public partial class UCResult : UserControl, IScreenShot
    {
        public UserControl LastUc { get; set; }

        private Random _random;

        private Timer _timer;
        private int _timerCounter = 10;
        public Result QuizResult { get; set; }

        public bool AnimationStatus { get; set; }
        public UCResult()
        {
            InitializeComponent();
            _random = new Random();
            _timer = new Timer();

            _timer.Interval = 500;
            _timer.Tick += _timer_Tick;
        }

        private void _timer_Tick(object sender, EventArgs e)
        {
            Animation();
            _timerCounter--;

            if(_timerCounter == 0)
            {
                _timer.Stop();
                SetResults();
                this.ButtonSave.Visible = true;
            }
        }

        private void guna2CircleProgressBar2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ProgressBarCorrectResult_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ButtonBack_MouseEnter(object sender, EventArgs e)
        {
            ButtonBack.Image = Properties.Resources.back_to_100px;
        }

        private void ButtonBack_MouseLeave(object sender, EventArgs e)
        {
            ButtonBack.Image = Properties.Resources.back_to_light_100px;
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            LastUc.BringToFront();
        }

        private void UCResult_Load(object sender, EventArgs e)
        {
            if(AnimationStatus)
                _timer.Start();
            else
            {
                SetResults();
                this.ButtonSave.Visible = true;
            }
        }

        private void Animation()
        {
            var min = 0;
            var max = 100;

            for (int i = 0, length = this.PanelProgressBars.Controls.Count; i < length; i++)
            {
                var progressBar = this.PanelProgressBars.Controls[i] as Guna2CircleProgressBar;

                var label = progressBar.Controls[0] as Label;

                if (i == length - 1)
                {
                    ChangeValueObjects(progressBar, label, max);
                    break;
                }
                var randomValue = _random.Next(min, max);

                ChangeValueObjects(progressBar, label, randomValue);

                max -= randomValue;
            }
        }

        private void ChangeValueObjects(Guna2CircleProgressBar progressBar, Label label, int value)
        {
            progressBar.Value = value;
            label.Text = $"{value}%";
        }

        private void SetResults()
        {
            var totalQuestionCount = QuizResult.Results.Sum(s => s.Value);

            for (int i = this.PanelProgressBars.Controls.Count - 1; i >= 0; i--)
            {
                var progressBar = this.PanelProgressBars.Controls[i] as Guna2CircleProgressBar;


                var answerStatus = (AnswerStatus)(3 - i);

                var answerCount = QuizResult.Results[answerStatus];


                var percent = answerCount * 100 / totalQuestionCount;

                ChangeValueObjects(progressBar, progressBar.Controls[0] as Label, percent);

                var labelName = (string)progressBar.Tag;

                var label = this.PanelAnswersCount.Controls[labelName] as Label;

                label.Text = answerCount.ToString();
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            var ucExam = Form2.Instance.Controls["PanelUserControls"].Controls["UcExam"] as UCExam;

            var save = new SaveFileDialog();

            save.Filter = "Pdf files (*.pdf)|*.pdf";


            if (save.ShowDialog() != DialogResult.OK)
                return;

            var fileName = save.FileName.EndsWith(".pdf") ? save.FileName : save.FileName + ".pdf";

            var images = ucExam?.GetQuestionScreenShots();

            if (images == null)
            {
                MessageBox.Show("Result could not be save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var quizResult = new QuizResult();

            quizResult.QuestionImages = images;

            quizResult.Result = TakeScreenShot();

            quizResult.result = QuizResult;

            PdfHelper.ManipulatePdf(fileName, quizResult);

            MessageBox.Show("Result saved", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public Bitmap TakeScreenShot()
        {
            return ScreenShot.TakeArea(this.PanelProgressBars);
        }
    }
}
