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
    public partial class UCCreateQuiz : UserControl
    {
        public UserControl LastUc;

        public UCCreateQuiz()
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
        private void ButtonBack_Click(object sender, EventArgs e)
        {
            Form2.Instance.Controls["PanelUserControls"].Controls["UCCreateQuiz"].Dispose();
            LastUc.BringToFront();
        }

        private void ButtonCreateNex_Click(object sender, EventArgs e)
        {
            var next = new UCCreateNewQuestion(){LastUc = this};

            Form2.Instance.Controls["PanelUserControls"].Controls.Add(next);
            next.BringToFront();
        }

        private void UCCreateQuiz_Load(object sender, EventArgs e)
        {

        }

        private void ButtonDragAndDropNext_Click(object sender, EventArgs e)
        {
            var next = new UCDragDrop(){LastUc = this};

            Form2.Instance.Controls["PanelUserControls"].Controls.Add(next);
            next.BringToFront();
        }
    }
}
