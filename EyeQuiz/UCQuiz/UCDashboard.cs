using System;
using System.Windows.Forms;

namespace EyeQuiz.UCQuiz
{
    public partial class UCDashboard : UserControl
    {
        public UCDashboard()
        {
            InitializeComponent();
        }

        private void ButtonCreateQuizNext_Click(object sender, EventArgs e)
        {
            var next = new UCCreateQuiz {LastUc = this};
            //next.Controls["ButtonBack"].Visible = true;
            Form2.Instance.Controls["PanelUserControls"].Controls.Add(next);
            next.BringToFront();
        }

        private void ButtonTakeQuizNext_Click(object sender, EventArgs e)
        {
            var next = new UCQuizeList() {LastUc = this};

            Form2.Instance.Controls["PanelUserControls"].Controls.Add(next);
            next.BringToFront();
        }
    }
}
