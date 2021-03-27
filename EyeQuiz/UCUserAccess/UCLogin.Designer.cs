
namespace EyeQuiz.UCUserAccess
{
    partial class UCLogin
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelForgotPassword = new System.Windows.Forms.Label();
            this.ButtonLogin = new Guna.UI2.WinForms.Guna2Button();
            this.TextBoxPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.PictureBoxPasswordVisibility = new System.Windows.Forms.PictureBox();
            this.ButtonLoginFb = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPasswordVisibility)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelForgotPassword
            // 
            this.LabelForgotPassword.AutoSize = true;
            this.LabelForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelForgotPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LabelForgotPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            this.LabelForgotPassword.Location = new System.Drawing.Point(148, 261);
            this.LabelForgotPassword.Name = "LabelForgotPassword";
            this.LabelForgotPassword.Size = new System.Drawing.Size(145, 20);
            this.LabelForgotPassword.TabIndex = 5;
            this.LabelForgotPassword.Text = "Forgot Password?";
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.CheckedState.Parent = this.ButtonLogin;
            this.ButtonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonLogin.CustomImages.Parent = this.ButtonLogin;
            this.ButtonLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(114)))), ((int)(((byte)(207)))));
            this.ButtonLogin.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonLogin.ForeColor = System.Drawing.Color.White;
            this.ButtonLogin.HoverState.Parent = this.ButtonLogin;
            this.ButtonLogin.Location = new System.Drawing.Point(152, 302);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.ShadowDecoration.Parent = this.ButtonLogin;
            this.ButtonLogin.Size = new System.Drawing.Size(292, 45);
            this.ButtonLogin.TabIndex = 4;
            this.ButtonLogin.Text = "Login";
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxPassword.DefaultText = "";
            this.TextBoxPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxPassword.DisabledState.Parent = this.TextBoxPassword;
            this.TextBoxPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxPassword.FocusedState.Parent = this.TextBoxPassword;
            this.TextBoxPassword.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TextBoxPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxPassword.HoverState.Parent = this.TextBoxPassword;
            this.TextBoxPassword.Location = new System.Drawing.Point(152, 213);
            this.TextBoxPassword.MaxLength = 40;
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = '*';
            this.TextBoxPassword.PlaceholderText = "Password";
            this.TextBoxPassword.SelectedText = "";
            this.TextBoxPassword.ShadowDecoration.Parent = this.TextBoxPassword;
            this.TextBoxPassword.Size = new System.Drawing.Size(292, 36);
            this.TextBoxPassword.TabIndex = 3;
            this.TextBoxPassword.TextChanged += new System.EventHandler(this.TextBoxEmail_TextChanged);
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxEmail.DefaultText = "";
            this.TextBoxEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxEmail.DisabledState.Parent = this.TextBoxEmail;
            this.TextBoxEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxEmail.FocusedState.Parent = this.TextBoxEmail;
            this.TextBoxEmail.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.TextBoxEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxEmail.HoverState.Parent = this.TextBoxEmail;
            this.TextBoxEmail.Location = new System.Drawing.Point(152, 171);
            this.TextBoxEmail.MaxLength = 40;
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.PasswordChar = '\0';
            this.TextBoxEmail.PlaceholderText = "Email Address";
            this.TextBoxEmail.SelectedText = "";
            this.TextBoxEmail.ShadowDecoration.Parent = this.TextBoxEmail;
            this.TextBoxEmail.Size = new System.Drawing.Size(292, 36);
            this.TextBoxEmail.TabIndex = 2;
            this.TextBoxEmail.TextChanged += new System.EventHandler(this.TextBoxEmail_TextChanged);
            // 
            // PictureBoxPasswordVisibility
            // 
            this.PictureBoxPasswordVisibility.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxPasswordVisibility.Image = global::EyeQuiz.Properties.Resources.eye_30px;
            this.PictureBoxPasswordVisibility.Location = new System.Drawing.Point(452, 213);
            this.PictureBoxPasswordVisibility.Name = "PictureBoxPasswordVisibility";
            this.PictureBoxPasswordVisibility.Size = new System.Drawing.Size(29, 36);
            this.PictureBoxPasswordVisibility.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxPasswordVisibility.TabIndex = 8;
            this.PictureBoxPasswordVisibility.TabStop = false;
            this.PictureBoxPasswordVisibility.Click += new System.EventHandler(this.PictureBoxPasswordVisibility_Click);
            // 
            // ButtonLoginFb
            // 
            this.ButtonLoginFb.CheckedState.Parent = this.ButtonLoginFb;
            this.ButtonLoginFb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonLoginFb.CustomImages.Parent = this.ButtonLoginFb;
            this.ButtonLoginFb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(114)))), ((int)(((byte)(207)))));
            this.ButtonLoginFb.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonLoginFb.ForeColor = System.Drawing.Color.White;
            this.ButtonLoginFb.HoverState.Parent = this.ButtonLoginFb;
            this.ButtonLoginFb.Location = new System.Drawing.Point(152, 353);
            this.ButtonLoginFb.Name = "ButtonLoginFb";
            this.ButtonLoginFb.ShadowDecoration.Parent = this.ButtonLoginFb;
            this.ButtonLoginFb.Size = new System.Drawing.Size(292, 45);
            this.ButtonLoginFb.TabIndex = 9;
            this.ButtonLoginFb.Text = "Login with Facebook";
            this.ButtonLoginFb.Click += new System.EventHandler(this.ButtonLoginFb_Click);
            // 
            // UCLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.ButtonLoginFb);
            this.Controls.Add(this.PictureBoxPasswordVisibility);
            this.Controls.Add(this.LabelForgotPassword);
            this.Controls.Add(this.ButtonLogin);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.TextBoxEmail);
            this.Name = "UCLogin";
            this.Size = new System.Drawing.Size(619, 528);
            this.Load += new System.EventHandler(this.UCLogin_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UCLogin_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPasswordVisibility)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelForgotPassword;
        private Guna.UI2.WinForms.Guna2Button ButtonLogin;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxPassword;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxEmail;
        private System.Windows.Forms.PictureBox PictureBoxPasswordVisibility;
        private Guna.UI2.WinForms.Guna2Button ButtonLoginFb;
    }
}
