using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace EyeQuiz.UCUserAccess
{
    public partial class UCLogin : UserControl
    {
        private bool _visible = false;
        public UCLogin()
        {
            InitializeComponent();
        }

        private void UCLogin_Load(object sender, EventArgs e)
        {
            Form1.Instance.Text = "Login";
            Form1.Instance.Controls["PanelFormLeft"].Controls["label1"].Text = "Login";
            Form1.Instance.Controls["PanelFormLeft"].Controls["LabelNote"].Text = @"Hello, Let's get started!";
            Form1.Instance.Controls["PanelFormLeft"].Controls["PanelInner"].Controls["label2"].Text = "You don't have any account?";
            Form1.Instance.Controls["PanelFormLeft"].Controls["PanelInner"].Controls["LabelSwitch"].Text = "Create account";
            Form1.Instance.Controls["PanelFormLeft"].Controls["PanelInner"].Controls["LabelSwitch"].Click += LabelSwitch_Click;
        }

        private void LabelSwitch_Click(object sender, EventArgs e)
        {
            var signUp = new UCSignUp();
            Form1.Instance.Controls["PanelUcArea"].Controls["UCLogin"].Dispose();
            Form1.Instance.Controls["PanelUcArea"].Controls.Add(signUp);
            Form1.Instance.Controls["PanelFormLeft"].Controls["PanelInner"].Controls["LabelSwitch"].Click -= LabelSwitch_Click;
        }

        private void TextBoxEmail_TextChanged(object sender, EventArgs e)
        {
            if (sender is Guna2TextBox textBox) 
                textBox.ForeColor = Color.Black;
        }

        private void PictureBoxPasswordVisibility_Click(object sender, EventArgs e)
        {
            if (_visible)
            {
                PictureBoxPasswordVisibility.Image = Properties.Resources.eye_30px;
                TextBoxPassword.PasswordChar = '*';
            }
            else
            {
                PictureBoxPasswordVisibility.Image = Properties.Resources.invisible_30px;
                TextBoxPassword.PasswordChar = '\0';
            }

            _visible = !_visible;
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();

            Form1.Instance.Hide();

            form2.ShowDialog();

            Form1.Instance.Show();
        }
    }
}
