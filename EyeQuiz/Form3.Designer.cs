
namespace EyeQuiz
{
    partial class Form3
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonOk = new Guna.UI2.WinForms.Guna2Button();
            this.TextBoxFileName = new Guna.UI2.WinForms.Guna2TextBox();
            this.ButtonCancel = new Guna.UI2.WinForms.Guna2Button();
            this.PanelFormTop = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // ButtonOk
            // 
            this.ButtonOk.CheckedState.Parent = this.ButtonOk;
            this.ButtonOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonOk.CustomImages.Parent = this.ButtonOk;
            this.ButtonOk.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(114)))), ((int)(((byte)(207)))));
            this.ButtonOk.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonOk.ForeColor = System.Drawing.Color.White;
            this.ButtonOk.HoverState.Parent = this.ButtonOk;
            this.ButtonOk.Location = new System.Drawing.Point(27, 95);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.ShadowDecoration.Parent = this.ButtonOk;
            this.ButtonOk.Size = new System.Drawing.Size(141, 45);
            this.ButtonOk.TabIndex = 6;
            this.ButtonOk.Text = "Ok";
            this.ButtonOk.Click += new System.EventHandler(this.ButtonOk_Click);
            // 
            // TextBoxFileName
            // 
            this.TextBoxFileName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxFileName.DefaultText = "";
            this.TextBoxFileName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxFileName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxFileName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxFileName.DisabledState.Parent = this.TextBoxFileName;
            this.TextBoxFileName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxFileName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxFileName.FocusedState.Parent = this.TextBoxFileName;
            this.TextBoxFileName.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.TextBoxFileName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxFileName.HoverState.Parent = this.TextBoxFileName;
            this.TextBoxFileName.Location = new System.Drawing.Point(27, 43);
            this.TextBoxFileName.MaxLength = 40;
            this.TextBoxFileName.Name = "TextBoxFileName";
            this.TextBoxFileName.PasswordChar = '\0';
            this.TextBoxFileName.PlaceholderText = "File Name";
            this.TextBoxFileName.SelectedText = "";
            this.TextBoxFileName.ShadowDecoration.Parent = this.TextBoxFileName;
            this.TextBoxFileName.Size = new System.Drawing.Size(292, 36);
            this.TextBoxFileName.TabIndex = 5;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.CheckedState.Parent = this.ButtonCancel;
            this.ButtonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonCancel.CustomImages.Parent = this.ButtonCancel;
            this.ButtonCancel.FillColor = System.Drawing.Color.Red;
            this.ButtonCancel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonCancel.ForeColor = System.Drawing.Color.White;
            this.ButtonCancel.HoverState.Parent = this.ButtonCancel;
            this.ButtonCancel.Location = new System.Drawing.Point(178, 95);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.ShadowDecoration.Parent = this.ButtonCancel;
            this.ButtonCancel.Size = new System.Drawing.Size(141, 45);
            this.ButtonCancel.TabIndex = 7;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // PanelFormTop
            // 
            this.PanelFormTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(40)))));
            this.PanelFormTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelFormTop.Location = new System.Drawing.Point(0, 0);
            this.PanelFormTop.Name = "PanelFormTop";
            this.PanelFormTop.Size = new System.Drawing.Size(350, 20);
            this.PanelFormTop.TabIndex = 9;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 158);
            this.Controls.Add(this.PanelFormTop);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonOk);
            this.Controls.Add(this.TextBoxFileName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button ButtonOk;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxFileName;
        private Guna.UI2.WinForms.Guna2Button ButtonCancel;
        private System.Windows.Forms.FlowLayoutPanel PanelFormTop;
    }
}