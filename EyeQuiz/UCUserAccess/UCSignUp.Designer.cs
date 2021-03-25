
namespace EyeQuiz.UCUserAccess
{
    partial class UCSignUp
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
            this.ButtonSignUp = new Guna.UI2.WinForms.Guna2Button();
            this.TextBoxPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxFullname = new Guna.UI2.WinForms.Guna2TextBox();
            this.PictureBoxPasswordVisibility = new System.Windows.Forms.PictureBox();
            this.PictureBoxPasswordVisibility2 = new System.Windows.Forms.PictureBox();
            this.TextBoxPassword2 = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPasswordVisibility)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPasswordVisibility2)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonSignUp
            // 
            this.ButtonSignUp.CheckedState.Parent = this.ButtonSignUp;
            this.ButtonSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSignUp.CustomImages.Parent = this.ButtonSignUp;
            this.ButtonSignUp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(114)))), ((int)(((byte)(207)))));
            this.ButtonSignUp.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonSignUp.ForeColor = System.Drawing.Color.White;
            this.ButtonSignUp.HoverState.Parent = this.ButtonSignUp;
            this.ButtonSignUp.Location = new System.Drawing.Point(152, 302);
            this.ButtonSignUp.Name = "ButtonSignUp";
            this.ButtonSignUp.ShadowDecoration.Parent = this.ButtonSignUp;
            this.ButtonSignUp.Size = new System.Drawing.Size(292, 45);
            this.ButtonSignUp.TabIndex = 6;
            this.ButtonSignUp.Text = "Create Account";
            this.ButtonSignUp.Click += new System.EventHandler(this.ButtonSignUp_Click);
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
            this.TextBoxPassword.TabIndex = 4;
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
            this.TextBoxEmail.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
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
            this.TextBoxEmail.TabIndex = 3;
            // 
            // TextBoxFullname
            // 
            this.TextBoxFullname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxFullname.DefaultText = "";
            this.TextBoxFullname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxFullname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxFullname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxFullname.DisabledState.Parent = this.TextBoxFullname;
            this.TextBoxFullname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxFullname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxFullname.FocusedState.Parent = this.TextBoxFullname;
            this.TextBoxFullname.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TextBoxFullname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxFullname.HoverState.Parent = this.TextBoxFullname;
            this.TextBoxFullname.Location = new System.Drawing.Point(152, 129);
            this.TextBoxFullname.MaxLength = 40;
            this.TextBoxFullname.Name = "TextBoxFullname";
            this.TextBoxFullname.PasswordChar = '\0';
            this.TextBoxFullname.PlaceholderText = "Full Name";
            this.TextBoxFullname.SelectedText = "";
            this.TextBoxFullname.ShadowDecoration.Parent = this.TextBoxFullname;
            this.TextBoxFullname.Size = new System.Drawing.Size(292, 36);
            this.TextBoxFullname.TabIndex = 2;
            // 
            // PictureBoxPasswordVisibility
            // 
            this.PictureBoxPasswordVisibility.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxPasswordVisibility.Image = global::EyeQuiz.Properties.Resources.eye_30px;
            this.PictureBoxPasswordVisibility.Location = new System.Drawing.Point(452, 213);
            this.PictureBoxPasswordVisibility.Name = "PictureBoxPasswordVisibility";
            this.PictureBoxPasswordVisibility.Size = new System.Drawing.Size(29, 36);
            this.PictureBoxPasswordVisibility.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxPasswordVisibility.TabIndex = 9;
            this.PictureBoxPasswordVisibility.TabStop = false;
            this.PictureBoxPasswordVisibility.Click += new System.EventHandler(this.PictureBoxPasswordVisibility_Click);
            // 
            // PictureBoxPasswordVisibility2
            // 
            this.PictureBoxPasswordVisibility2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxPasswordVisibility2.Image = global::EyeQuiz.Properties.Resources.eye_30px;
            this.PictureBoxPasswordVisibility2.Location = new System.Drawing.Point(452, 255);
            this.PictureBoxPasswordVisibility2.Name = "PictureBoxPasswordVisibility2";
            this.PictureBoxPasswordVisibility2.Size = new System.Drawing.Size(29, 36);
            this.PictureBoxPasswordVisibility2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxPasswordVisibility2.TabIndex = 11;
            this.PictureBoxPasswordVisibility2.TabStop = false;
            this.PictureBoxPasswordVisibility2.Click += new System.EventHandler(this.PictureBoxPasswordVisibility2_Click);
            // 
            // TextBoxPassword2
            // 
            this.TextBoxPassword2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxPassword2.DefaultText = "";
            this.TextBoxPassword2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxPassword2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxPassword2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxPassword2.DisabledState.Parent = this.TextBoxPassword2;
            this.TextBoxPassword2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxPassword2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxPassword2.FocusedState.Parent = this.TextBoxPassword2;
            this.TextBoxPassword2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TextBoxPassword2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxPassword2.HoverState.Parent = this.TextBoxPassword2;
            this.TextBoxPassword2.Location = new System.Drawing.Point(152, 255);
            this.TextBoxPassword2.MaxLength = 40;
            this.TextBoxPassword2.Name = "TextBoxPassword2";
            this.TextBoxPassword2.PasswordChar = '*';
            this.TextBoxPassword2.PlaceholderText = "Verify Password";
            this.TextBoxPassword2.SelectedText = "";
            this.TextBoxPassword2.ShadowDecoration.Parent = this.TextBoxPassword2;
            this.TextBoxPassword2.Size = new System.Drawing.Size(292, 36);
            this.TextBoxPassword2.TabIndex = 5;
            // 
            // UCSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.PictureBoxPasswordVisibility2);
            this.Controls.Add(this.TextBoxPassword2);
            this.Controls.Add(this.PictureBoxPasswordVisibility);
            this.Controls.Add(this.TextBoxFullname);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.TextBoxEmail);
            this.Controls.Add(this.ButtonSignUp);
            this.Name = "UCSignUp";
            this.Size = new System.Drawing.Size(619, 528);
            this.Load += new System.EventHandler(this.UCSignUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPasswordVisibility)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPasswordVisibility2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button ButtonSignUp;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxPassword;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxEmail;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxFullname;
        private System.Windows.Forms.PictureBox PictureBoxPasswordVisibility;
        private System.Windows.Forms.PictureBox PictureBoxPasswordVisibility2;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxPassword2;
    }
}
