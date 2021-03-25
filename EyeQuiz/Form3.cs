using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EyeQuiz.Helpers;
using EyeQuiz.UCQuiz;

namespace EyeQuiz
{
    public partial class Form3 : Form
    {
        public string FileName { get; set; }
        public ToolTip ToolTip;
        public Form3()
        {
            InitializeComponent();
            ToolTip = new ToolTip();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        private void ButtonOk_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(TextBoxFileName.Text))
            {
                UxHelper.SetNewToolTip(TextBoxFileName, ToolTip, "File Name", "File name can not be empty!");
                return;
            }
            else if (TextBoxFileName.Text.Contains(".") && !TextBoxFileName.Text.EndsWith(".xml"))
            {
                UxHelper.SetNewToolTip(TextBoxFileName, ToolTip, "File Name", "File name format is not correct. Only *.xml acceptable.");
                return;
            }

            FileName = TextBoxFileName.Text;

            if (!FileName.EndsWith(".xml"))
                FileName += ".xml";

            this.DialogResult = DialogResult.OK;
        }
    }
}
