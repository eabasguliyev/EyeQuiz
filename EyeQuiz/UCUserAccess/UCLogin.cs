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
using EyeQuiz.AppExceptions;
using EyeQuiz.Entities;
using EyeQuiz.Extensions;
using EyeQuiz.HashAlgorithms;
using EyeQuiz.Helpers;
using Guna.UI2.WinForms;

namespace EyeQuiz.UCUserAccess
{
    public partial class UCLogin : UserControl
    {
        private bool _visible = false;
        private List<ToolTip> _toolTips;
        public UCLogin()
        {
            InitializeComponent();
            _toolTips = new List<ToolTip>()
            {
                new ToolTip(),
                new ToolTip(),
            };
        }

        private void FocusToLoginButton()
        {
            var button = this.Controls["ButtonLogin"] as Guna2Button;

            this.ActiveControl = button;
        }
        private void UCLogin_Load(object sender, EventArgs e)
        {
            FocusToLoginButton();
            
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
            if (!CheckUserInputs())
                return;

            var sha256 = new Sha256();
            var email = TextBoxEmail.Text;
            var pass = sha256.GetHash(TextBoxPassword.Text);

            User user = null;
            try
            {
                user = Program.Database.Login(email, pass);
            }
            catch (UserNotFoundException ex)
            {
                UxHelper.SetNewToolTip(TextBoxEmail, _toolTips[0], "Email",
                    "There is no user associated this email address.");
                return;
            }
            catch (PasswordWrongException ex)
            {
                TextBoxEmail.BorderColor = Color.FromArgb(213, 218, 223);

                UxHelper.SetNewToolTip(TextBoxPassword, _toolTips[1], "Password",
                    "Password is wrong!");
                return;
            }

            var form2 = new Form2();

            form2.User = user;

            Form1.Instance.Hide();

            form2.ShowDialog();

            Form1.Instance.Show();

            ClearUserInputs();
        }

        private void ClearUserInputs()
        {
            this.TextBoxEmail.Text = String.Empty;
            this.TextBoxPassword.Text = String.Empty;
        }

        private bool CheckUserInputs()
        {
            var status = true;

            if (String.IsNullOrWhiteSpace(TextBoxEmail.Text))
            {
                UxHelper.SetNewToolTip(TextBoxEmail, _toolTips[0], "Email", "Email address can not be empty");
                status = false;
            }
            else
            {
                TextBoxEmail.BorderColor = Color.FromArgb(213, 218, 223);
            }

            if (String.IsNullOrWhiteSpace(TextBoxPassword.Text))
            {
                UxHelper.SetNewToolTip(TextBoxPassword, _toolTips[1], "Password", "Password can not be empty");
                status = false;
            }
            else
            {
                TextBoxPassword.BorderColor = Color.FromArgb(213, 218, 223);
            }

            return status;
        }
        private void ButtonLoginFb_Click(object sender, EventArgs e)
        {
            //var ucFbLogin = new UCFacebookLogin();

            //Form1.Instance.Controls["PanelUcArea"].Controls.Add(ucFbLogin);
            //ucFbLogin.Login();
            //ucFbLogin.BringToFront();
        }

        private void UCLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;

            var button = this.Controls["ButtonLogin"] as Guna2Button;

            button?.PerformClick();
        }

        private void UCLogin_Click(object sender, EventArgs e)
        {
            FocusToLoginButton();
        }
    }
}
