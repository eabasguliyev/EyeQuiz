
namespace EyeQuiz.UCQuiz
{
    partial class UCCreateNewQuestion
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
            this.PanelQuestions = new System.Windows.Forms.Panel();
            this.PanelFormRight = new System.Windows.Forms.Panel();
            this.ButtonAddNew = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonSave = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonFirst = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonGoLast = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonBack = new System.Windows.Forms.PictureBox();
            this.ButtonClear = new Guna.UI2.WinForms.Guna2Button();
            this.PanelFormRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonBack)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelQuestions
            // 
            this.PanelQuestions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PanelQuestions.AutoScroll = true;
            this.PanelQuestions.Location = new System.Drawing.Point(0, 86);
            this.PanelQuestions.Name = "PanelQuestions";
            this.PanelQuestions.Size = new System.Drawing.Size(744, 545);
            this.PanelQuestions.TabIndex = 6;
            // 
            // PanelFormRight
            // 
            this.PanelFormRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelFormRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(128)))), ((int)(((byte)(212)))));
            this.PanelFormRight.Controls.Add(this.ButtonClear);
            this.PanelFormRight.Controls.Add(this.ButtonGoLast);
            this.PanelFormRight.Controls.Add(this.ButtonFirst);
            this.PanelFormRight.Controls.Add(this.ButtonSave);
            this.PanelFormRight.Controls.Add(this.ButtonAddNew);
            this.PanelFormRight.Location = new System.Drawing.Point(742, 86);
            this.PanelFormRight.Name = "PanelFormRight";
            this.PanelFormRight.Size = new System.Drawing.Size(192, 545);
            this.PanelFormRight.TabIndex = 7;
            // 
            // ButtonAddNew
            // 
            this.ButtonAddNew.CheckedState.Parent = this.ButtonAddNew;
            this.ButtonAddNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAddNew.CustomImages.Parent = this.ButtonAddNew;
            this.ButtonAddNew.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(114)))), ((int)(((byte)(207)))));
            this.ButtonAddNew.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonAddNew.ForeColor = System.Drawing.Color.White;
            this.ButtonAddNew.HoverState.Parent = this.ButtonAddNew;
            this.ButtonAddNew.Location = new System.Drawing.Point(0, 155);
            this.ButtonAddNew.Name = "ButtonAddNew";
            this.ButtonAddNew.ShadowDecoration.Parent = this.ButtonAddNew;
            this.ButtonAddNew.Size = new System.Drawing.Size(192, 45);
            this.ButtonAddNew.TabIndex = 6;
            this.ButtonAddNew.Text = "Add New";
            this.ButtonAddNew.Click += new System.EventHandler(this.ButtonAddNew_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.CheckedState.Parent = this.ButtonSave;
            this.ButtonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSave.CustomImages.Parent = this.ButtonSave;
            this.ButtonSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(114)))), ((int)(((byte)(207)))));
            this.ButtonSave.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonSave.ForeColor = System.Drawing.Color.White;
            this.ButtonSave.HoverState.Parent = this.ButtonSave;
            this.ButtonSave.Location = new System.Drawing.Point(0, 332);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.ShadowDecoration.Parent = this.ButtonSave;
            this.ButtonSave.Size = new System.Drawing.Size(192, 45);
            this.ButtonSave.TabIndex = 7;
            this.ButtonSave.Text = "Save";
            // 
            // ButtonFirst
            // 
            this.ButtonFirst.CheckedState.Parent = this.ButtonFirst;
            this.ButtonFirst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonFirst.CustomImages.Parent = this.ButtonFirst;
            this.ButtonFirst.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(114)))), ((int)(((byte)(207)))));
            this.ButtonFirst.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonFirst.ForeColor = System.Drawing.Color.White;
            this.ButtonFirst.HoverState.Parent = this.ButtonFirst;
            this.ButtonFirst.Location = new System.Drawing.Point(0, 197);
            this.ButtonFirst.Name = "ButtonFirst";
            this.ButtonFirst.ShadowDecoration.Parent = this.ButtonFirst;
            this.ButtonFirst.Size = new System.Drawing.Size(192, 45);
            this.ButtonFirst.TabIndex = 8;
            this.ButtonFirst.Text = "Go first";
            this.ButtonFirst.Click += new System.EventHandler(this.ButtonFirst_Click);
            // 
            // ButtonGoLast
            // 
            this.ButtonGoLast.CheckedState.Parent = this.ButtonGoLast;
            this.ButtonGoLast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonGoLast.CustomImages.Parent = this.ButtonGoLast;
            this.ButtonGoLast.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(114)))), ((int)(((byte)(207)))));
            this.ButtonGoLast.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonGoLast.ForeColor = System.Drawing.Color.White;
            this.ButtonGoLast.HoverState.Parent = this.ButtonGoLast;
            this.ButtonGoLast.Location = new System.Drawing.Point(0, 242);
            this.ButtonGoLast.Name = "ButtonGoLast";
            this.ButtonGoLast.ShadowDecoration.Parent = this.ButtonGoLast;
            this.ButtonGoLast.Size = new System.Drawing.Size(192, 45);
            this.ButtonGoLast.TabIndex = 9;
            this.ButtonGoLast.Text = "Go last";
            this.ButtonGoLast.Click += new System.EventHandler(this.ButtonGoLast_Click);
            // 
            // ButtonBack
            // 
            this.ButtonBack.Image = global::EyeQuiz.Properties.Resources.back_to_light_100px;
            this.ButtonBack.Location = new System.Drawing.Point(19, 19);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(52, 50);
            this.ButtonBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ButtonBack.TabIndex = 5;
            this.ButtonBack.TabStop = false;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            this.ButtonBack.MouseEnter += new System.EventHandler(this.ButtonBack_MouseEnter);
            this.ButtonBack.MouseLeave += new System.EventHandler(this.ButtonBack_MouseLeave);
            // 
            // ButtonClear
            // 
            this.ButtonClear.CheckedState.Parent = this.ButtonClear;
            this.ButtonClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonClear.CustomImages.Parent = this.ButtonClear;
            this.ButtonClear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(114)))), ((int)(((byte)(207)))));
            this.ButtonClear.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonClear.ForeColor = System.Drawing.Color.White;
            this.ButtonClear.HoverState.Parent = this.ButtonClear;
            this.ButtonClear.Location = new System.Drawing.Point(0, 287);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.ShadowDecoration.Parent = this.ButtonClear;
            this.ButtonClear.Size = new System.Drawing.Size(192, 45);
            this.ButtonClear.TabIndex = 10;
            this.ButtonClear.Text = "Clear";
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // UCCreateNewQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.PanelFormRight);
            this.Controls.Add(this.PanelQuestions);
            this.Controls.Add(this.ButtonBack);
            this.Name = "UCCreateNewQuestion";
            this.Size = new System.Drawing.Size(934, 631);
            this.Load += new System.EventHandler(this.UCCreateNewQuestion_Load);
            this.PanelFormRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ButtonBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ButtonBack;
        private System.Windows.Forms.Panel PanelQuestions;
        private System.Windows.Forms.Panel PanelFormRight;
        private Guna.UI2.WinForms.Guna2Button ButtonAddNew;
        private Guna.UI2.WinForms.Guna2Button ButtonSave;
        private Guna.UI2.WinForms.Guna2Button ButtonGoLast;
        private Guna.UI2.WinForms.Guna2Button ButtonFirst;
        private Guna.UI2.WinForms.Guna2Button ButtonClear;
    }
}
