using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EyeQuiz.Entities;
using EyeQuiz.Helpers.FileHelpers;

namespace EyeQuiz.UCQuiz
{
    public partial class UCDragDrop : UserControl
    {
        public UserControl LastUc;
        public QuestionsBlock QuestionsBlock { get; set; }
        public UCDragDrop()
        {
            InitializeComponent();
            QuestionsBlock = new QuestionsBlock();
        }

        private void UCDragDrop_Load(object sender, EventArgs e)
        {
            this.AllowDrop = true;
        }

        private void UCDragDrop_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void UCDragDrop_DragDrop(object sender, DragEventArgs e)
        {
            string[] fileNames = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (fileNames.Length != 1)
            {
                MessageBox.Show("You can drag and drop only one file", "Drag and drop", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            var fileName = fileNames[0];

            XmlHelper.Deserialize(fileName, QuestionsBlock);

            var next = new UCCreateNewQuestion() { LastUc = this, 
                QuestionsBlock =  QuestionsBlock, Loaded = true};
            
            Form2.Instance.Controls["PanelUserControls"].Controls.Add(next);
            next.BringToFront();
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
            Form2.Instance.Controls["PanelUserControls"].Controls["UCDragDrop"].Dispose();
            LastUc.BringToFront();
        }
    }
}
