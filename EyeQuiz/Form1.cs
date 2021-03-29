using System;
using System.Drawing;
using System.Windows.Forms;
using EyeQuiz.Entities;
using EyeQuiz.Helpers;
using EyeQuiz.UCQuiz;
using EyeQuiz.UCUserAccess;
using Guna.UI2.WinForms;

namespace EyeQuiz
{
    public partial class Form1 : Form
    {

        private static Form1 Obj;

        public static Form1 Instance => Obj ?? (Obj = new Form1());

        public Form1()
        {
            InitializeComponent();
        }

        private void PictureBoxClose_MouseEnter(object sender, EventArgs e)
        {
            PictureBoxClose.Image = Properties.Resources.close_window_red_26px;
        }

        private void PictureBoxClose_MouseLeave(object sender, EventArgs e)
        {
            PictureBoxClose.Image = Properties.Resources.close_window_26px;
        }

        private void PictureBoxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PictureBoxDrag_MouseDown(object sender, MouseEventArgs e)
        {
            FormHelper.MouseDown(Cursor.Position, this.Location);
        }

        private void PictureBoxDrag_MouseMove(object sender, MouseEventArgs e)
        {
            var newLocation = FormHelper.MouseMove();

            this.Location = (newLocation != Point.Empty) ? newLocation : this.Location;
        }

        private void PictureBoxDrag_MouseUp(object sender, MouseEventArgs e)
        {
            FormHelper.MouseUp();
        }

        private void PictureBoxMinimize_MouseEnter(object sender, EventArgs e)
        {
            PictureBoxMinimize.Image = Properties.Resources.minimize_window_green_50px;
        }

        private void PictureBoxMinimize_MouseLeave(object sender, EventArgs e)
        {
            PictureBoxMinimize.Image = Properties.Resources.macos_minimize_24px;
        }

        private void PictureBoxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Obj = this;
            
            var login = new UCLogin();
            Form1.Instance.Controls["PanelUcArea"].Controls.Add(login);
        }

        public void Login(User user)
        {
            var form2 = new Form2();

            form2.User = user;

            Form1.Instance.Hide();

            form2.ShowDialog();

            Form1.Instance.Show();
        }
        private void PanelUcArea_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
