using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EyeQuiz.Entities;
using EyeQuiz.Extensions;
using EyeQuiz.Helpers;

namespace EyeQuiz.UCUserAccess
{
    public partial class UCSignUp : UserControl
    {
        private bool _visible = false;
        private bool _visible2 = false;

        private List<ToolTip> _toolTips;
        public UCSignUp()
        {
            InitializeComponent();
            _toolTips = new List<ToolTip>()
            {
                new ToolTip(),
                new ToolTip(),
                new ToolTip(),
                new ToolTip(),
            };
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
            SwitchToLogin();
        }

        private void SwitchToLogin()
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

        private void ButtonSignUp_Click(object sender, EventArgs e)
        {
            if (!CheckUserInputs())
                return;

            var user = new User()
            {
                Fullname = TextBoxFullname.Text,
                Email =  TextBoxEmail.Text,
                Password = TextBoxPassword.Text
            };

            Program.Database.Register(user);

            var form2 = new Form2();
            
            form2.User = user;

            Form1.Instance.Hide();

            form2.ShowDialog();

            SwitchToLogin();

            Form1.Instance.Show();
        }

        private bool CheckUserInputs()
        {
            var status = true;
            if (!UserHelper.ValidateFullname(TextBoxFullname.Text))
            {
                UxHelper.SetNewToolTip(TextBoxFullname, _toolTips[0], "Full name", "Full name must be max 40 alphabetic characters and include only one space");
                status = false;
            }
            else
            {
                TextBoxFullname.BorderColor = Color.FromArgb(213, 218, 223);
                _toolTips[0].RemoveAll();
            }

            if (!UserHelper.ValidateEmail(TextBoxEmail.Text))
            {
                UxHelper.SetNewToolTip(TextBoxEmail, _toolTips[1], "Email", "Email format is wrong. (ex. example@gmail.com)");
                status = false;
            }
            else
            {
                TextBoxEmail.BorderColor = Color.FromArgb(213, 218, 223);
                _toolTips[1].RemoveAll();
            }

            if (!UserHelper.ValidatePassword(TextBoxPassword.Text))
            {
                UxHelper.SetNewToolTip(TextBoxPassword, _toolTips[2], "Password", "Password must be minimum eight characters, at least one letter and one number");
                status = false;
            }
            else
            {
                TextBoxPassword.BorderColor = Color.FromArgb(213, 218, 223);
                _toolTips[2].RemoveAll();
            }

            if (!UserHelper.ValidatePassword(TextBoxPassword2.Text))
            {
                UxHelper.SetNewToolTip(TextBoxPassword2, _toolTips[3], "Verify password", "Password must be minimum eight characters, at least one letter and one number");
                status = false;
            }
            else
            {
                if (TextBoxPassword.Text != TextBoxPassword2.Text)
                {
                    UxHelper.SetNewToolTip(TextBoxPassword2, _toolTips[3], "Verify password", "Verify password must be same as above.");
                    status = false;
                }
                else
                {
                    TextBoxPassword2.BorderColor = Color.FromArgb(213, 218, 223);
                    _toolTips[3].RemoveAll();
                }
            }


            if (!Program.Database.CheckEmail(TextBoxEmail.Text))
            {
                UxHelper.SetNewToolTip(TextBoxEmail, _toolTips[1], "Email", "This email address already registered.");
                status = false;
            }
            else
            {
                TextBoxEmail.BorderColor = Color.FromArgb(213, 218, 223);
                _toolTips[1].RemoveAll();
            }

            return status;
        }
    }
}
