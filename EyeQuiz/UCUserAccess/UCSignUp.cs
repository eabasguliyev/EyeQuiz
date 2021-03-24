using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EyeQuiz.UCUserAccess
{
    public partial class UCSignUp : UserControl
    {
        private bool _visible = false;
        private bool _visible2 = false;
        public UCSignUp()
        {
            InitializeComponent();
        }

        private void UCSignUp_Load(object sender, EventArgs e)
        {
            Form1.Instance.Text = "Sign Up";
            Form1.Instance.Controls["PanelFormLeft"].Controls["label1"].Text = "Sign Up";
            Form1.Instance.Controls["PanelFormLeft"].Controls["LabelNote"].Text = @"Get started in a few clicks 
and create or take quiz.";
            Form1.Instance.Controls["PanelFormLeft"].Controls["PanelInner"].Controls["label2"].Text = "Have an account?";
            Form1.Instance.Controls["PanelFormLeft"].Controls["PanelInner"].Controls["LabelSwitch"].Text = "Login";
            Form1.Instance.Controls["PanelFormLeft"].Controls["PanelInner"].Controls["LabelSwitch"].Click += LabelSwitch_Click;
        }
        private void LabelSwitch_Click(object sender, EventArgs e)
        {
            var login = new UCLogin();
            Form1.Instance.Controls["PanelUcArea"].Controls["UCSignUp"].Dispose();
            Form1.Instance.Controls["PanelUcArea"].Controls.Add(login);

            Form1.Instance.Controls["PanelFormLeft"].Controls["PanelInner"].Controls["LabelSwitch"].Click -= LabelSwitch_Click;
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

        private void PictureBoxPasswordVisibility2_Click(object sender, EventArgs e)
        {
            if (_visible2)
            {
                PictureBoxPasswordVisibility.Image = Properties.Resources.eye_30px;
                TextBoxPassword2.PasswordChar = '*';
            }
            else
            {
                PictureBoxPasswordVisibility.Image = Properties.Resources.invisible_30px;
                TextBoxPassword2.PasswordChar = '\0';
            }

            _visible2 = !_visible2;
        }
    }
}
