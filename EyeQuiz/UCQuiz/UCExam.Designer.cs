
namespace EyeQuiz.UCQuiz
{
    partial class UCExam
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
            this.PanelUcQuestion = new System.Windows.Forms.Panel();
            this.LabelTimeLeft = new System.Windows.Forms.Label();
            this.ButtonPrev = new Guna.UI2.WinForms.Guna2Button();
            this.LabelCurrentQuestionNo = new System.Windows.Forms.Label();
            this.ButtonNext = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonSubmit = new Guna.UI2.WinForms.Guna2Button();
            this.PanelQuestionControl = new System.Windows.Forms.Panel();
            this.ButtonAccept = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonBack = new System.Windows.Forms.PictureBox();
            this.ButtonGetResult = new Guna.UI2.WinForms.Guna2Button();
            this.PanelQuestionControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonBack)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelUcQuestion
            // 
            this.PanelUcQuestion.Location = new System.Drawing.Point(19, 93);
            this.PanelUcQuestion.Name = "PanelUcQuestion";
            this.PanelUcQuestion.Size = new System.Drawing.Size(902, 493);
            this.PanelUcQuestion.TabIndex = 0;
            // 
            // LabelTimeLeft
            // 
            this.LabelTimeLeft.AutoSize = true;
            this.LabelTimeLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LabelTimeLeft.Location = new System.Drawing.Point(712, 25);
            this.LabelTimeLeft.Name = "LabelTimeLeft";
            this.LabelTimeLeft.Size = new System.Drawing.Size(209, 29);
            this.LabelTimeLeft.TabIndex = 8;
            this.LabelTimeLeft.Text = "Time left  01:00:00";
            // 
            // ButtonPrev
            // 
            this.ButtonPrev.CheckedState.Parent = this.ButtonPrev;
            this.ButtonPrev.CustomImages.Parent = this.ButtonPrev;
            this.ButtonPrev.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(128)))), ((int)(((byte)(212)))));
            this.ButtonPrev.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonPrev.ForeColor = System.Drawing.Color.White;
            this.ButtonPrev.HoverState.Parent = this.ButtonPrev;
            this.ButtonPrev.Location = new System.Drawing.Point(5, 2);
            this.ButtonPrev.Name = "ButtonPrev";
            this.ButtonPrev.ShadowDecoration.Parent = this.ButtonPrev;
            this.ButtonPrev.Size = new System.Drawing.Size(112, 45);
            this.ButtonPrev.TabIndex = 11;
            this.ButtonPrev.Text = "Previous";
            this.ButtonPrev.Click += new System.EventHandler(this.ButtonPrev_Click);
            // 
            // LabelCurrentQuestionNo
            // 
            this.LabelCurrentQuestionNo.AutoSize = true;
            this.LabelCurrentQuestionNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LabelCurrentQuestionNo.Location = new System.Drawing.Point(17, 608);
            this.LabelCurrentQuestionNo.Name = "LabelCurrentQuestionNo";
            this.LabelCurrentQuestionNo.Size = new System.Drawing.Size(136, 24);
            this.LabelCurrentQuestionNo.TabIndex = 12;
            this.LabelCurrentQuestionNo.Text = "Question 0 of 0";
            // 
            // ButtonNext
            // 
            this.ButtonNext.CheckedState.Parent = this.ButtonNext;
            this.ButtonNext.CustomImages.Parent = this.ButtonNext;
            this.ButtonNext.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(128)))), ((int)(((byte)(212)))));
            this.ButtonNext.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonNext.ForeColor = System.Drawing.Color.White;
            this.ButtonNext.HoverState.Parent = this.ButtonNext;
            this.ButtonNext.Location = new System.Drawing.Point(258, 2);
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.ShadowDecoration.Parent = this.ButtonNext;
            this.ButtonNext.Size = new System.Drawing.Size(112, 45);
            this.ButtonNext.TabIndex = 13;
            this.ButtonNext.Text = "Next";
            this.ButtonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // ButtonSubmit
            // 
            this.ButtonSubmit.CheckedState.Parent = this.ButtonSubmit;
            this.ButtonSubmit.CustomImages.Parent = this.ButtonSubmit;
            this.ButtonSubmit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(128)))), ((int)(((byte)(212)))));
            this.ButtonSubmit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonSubmit.ForeColor = System.Drawing.Color.White;
            this.ButtonSubmit.HoverState.Parent = this.ButtonSubmit;
            this.ButtonSubmit.Location = new System.Drawing.Point(778, 592);
            this.ButtonSubmit.Name = "ButtonSubmit";
            this.ButtonSubmit.ShadowDecoration.Parent = this.ButtonSubmit;
            this.ButtonSubmit.Size = new System.Drawing.Size(133, 45);
            this.ButtonSubmit.TabIndex = 14;
            this.ButtonSubmit.Text = "Submit";
            this.ButtonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // PanelQuestionControl
            // 
            this.PanelQuestionControl.Controls.Add(this.ButtonAccept);
            this.PanelQuestionControl.Controls.Add(this.ButtonNext);
            this.PanelQuestionControl.Controls.Add(this.ButtonPrev);
            this.PanelQuestionControl.Location = new System.Drawing.Point(392, 590);
            this.PanelQuestionControl.Name = "PanelQuestionControl";
            this.PanelQuestionControl.Size = new System.Drawing.Size(374, 52);
            this.PanelQuestionControl.TabIndex = 1;
            // 
            // ButtonAccept
            // 
            this.ButtonAccept.CheckedState.Parent = this.ButtonAccept;
            this.ButtonAccept.CustomImages.Parent = this.ButtonAccept;
            this.ButtonAccept.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(128)))), ((int)(((byte)(212)))));
            this.ButtonAccept.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonAccept.ForeColor = System.Drawing.Color.White;
            this.ButtonAccept.HoverState.Parent = this.ButtonAccept;
            this.ButtonAccept.Location = new System.Drawing.Point(131, 2);
            this.ButtonAccept.Name = "ButtonAccept";
            this.ButtonAccept.ShadowDecoration.Parent = this.ButtonAccept;
            this.ButtonAccept.Size = new System.Drawing.Size(112, 45);
            this.ButtonAccept.TabIndex = 14;
            this.ButtonAccept.Text = "Accept";
            this.ButtonAccept.Click += new System.EventHandler(this.ButtonAccept_Click);
            // 
            // ButtonBack
            // 
            this.ButtonBack.Image = global::EyeQuiz.Properties.Resources.back_to_light_100px;
            this.ButtonBack.Location = new System.Drawing.Point(19, 19);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(52, 50);
            this.ButtonBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ButtonBack.TabIndex = 7;
            this.ButtonBack.TabStop = false;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            this.ButtonBack.MouseEnter += new System.EventHandler(this.ButtonBack_MouseEnter);
            this.ButtonBack.MouseLeave += new System.EventHandler(this.ButtonBack_MouseLeave);
            // 
            // ButtonGetResult
            // 
            this.ButtonGetResult.CheckedState.Parent = this.ButtonGetResult;
            this.ButtonGetResult.CustomImages.Parent = this.ButtonGetResult;
            this.ButtonGetResult.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(128)))), ((int)(((byte)(212)))));
            this.ButtonGetResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonGetResult.ForeColor = System.Drawing.Color.White;
            this.ButtonGetResult.HoverState.Parent = this.ButtonGetResult;
            this.ButtonGetResult.Location = new System.Drawing.Point(778, 592);
            this.ButtonGetResult.Name = "ButtonGetResult";
            this.ButtonGetResult.ShadowDecoration.Parent = this.ButtonGetResult;
            this.ButtonGetResult.Size = new System.Drawing.Size(133, 45);
            this.ButtonGetResult.TabIndex = 15;
            this.ButtonGetResult.Text = "Get Result";
            this.ButtonGetResult.Visible = false;
            this.ButtonGetResult.Click += new System.EventHandler(this.ButtonGetResult_Click);
            // 
            // UCExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.PanelQuestionControl);
            this.Controls.Add(this.LabelCurrentQuestionNo);
            this.Controls.Add(this.LabelTimeLeft);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.PanelUcQuestion);
            this.Controls.Add(this.ButtonSubmit);
            this.Controls.Add(this.ButtonGetResult);
            this.Name = "UCExam";
            this.Size = new System.Drawing.Size(941, 655);
            this.Load += new System.EventHandler(this.UCExam_Load);
            this.PanelQuestionControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ButtonBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelUcQuestion;
        private System.Windows.Forms.PictureBox ButtonBack;
        private System.Windows.Forms.Label LabelTimeLeft;
        private Guna.UI2.WinForms.Guna2Button ButtonPrev;
        private System.Windows.Forms.Label LabelCurrentQuestionNo;
        private Guna.UI2.WinForms.Guna2Button ButtonNext;
        private Guna.UI2.WinForms.Guna2Button ButtonSubmit;
        private System.Windows.Forms.Panel PanelQuestionControl;
        private Guna.UI2.WinForms.Guna2Button ButtonAccept;
        private Guna.UI2.WinForms.Guna2Button ButtonGetResult;
    }
}
