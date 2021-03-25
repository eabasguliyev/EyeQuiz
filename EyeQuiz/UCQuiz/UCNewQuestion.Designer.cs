
namespace EyeQuiz.UCQuiz
{
    partial class UCNewQuestion
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
            this.TextBoxQuestion = new Guna.UI2.WinForms.Guna2TextBox();
            this.RadioButtonAnswer1 = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.PanelAnswers = new System.Windows.Forms.Panel();
            this.TextBoxAnswer4 = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxAnswer3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxAnswer2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxAnswer1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.RadioButtonAnswer4 = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.RadioButtonAnswer3 = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.RadioButtonAnswer2 = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.LabelQuestionNo = new System.Windows.Forms.Label();
            this.PictureBoxRemove = new System.Windows.Forms.PictureBox();
            this.PanelRadioButtons = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PanelAnswers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxRemove)).BeginInit();
            this.PanelRadioButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxQuestion
            // 
            this.TextBoxQuestion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxQuestion.DefaultText = "";
            this.TextBoxQuestion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxQuestion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxQuestion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxQuestion.DisabledState.Parent = this.TextBoxQuestion;
            this.TextBoxQuestion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxQuestion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxQuestion.FocusedState.Parent = this.TextBoxQuestion;
            this.TextBoxQuestion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxQuestion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxQuestion.HoverState.Parent = this.TextBoxQuestion;
            this.TextBoxQuestion.Location = new System.Drawing.Point(79, 24);
            this.TextBoxQuestion.Multiline = true;
            this.TextBoxQuestion.Name = "TextBoxQuestion";
            this.TextBoxQuestion.PasswordChar = '\0';
            this.TextBoxQuestion.PlaceholderText = "Type question";
            this.TextBoxQuestion.SelectedText = "";
            this.TextBoxQuestion.ShadowDecoration.Parent = this.TextBoxQuestion;
            this.TextBoxQuestion.Size = new System.Drawing.Size(601, 113);
            this.TextBoxQuestion.TabIndex = 0;
            this.TextBoxQuestion.TextChanged += new System.EventHandler(this.TextBoxQuestion_TextChanged);
            // 
            // RadioButtonAnswer1
            // 
            this.RadioButtonAnswer1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RadioButtonAnswer1.CheckedState.BorderThickness = 0;
            this.RadioButtonAnswer1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RadioButtonAnswer1.CheckedState.InnerColor = System.Drawing.Color.White;
            this.RadioButtonAnswer1.CheckedState.Parent = this.RadioButtonAnswer1;
            this.RadioButtonAnswer1.Location = new System.Drawing.Point(15, 264);
            this.RadioButtonAnswer1.Name = "RadioButtonAnswer1";
            this.RadioButtonAnswer1.ShadowDecoration.Parent = this.RadioButtonAnswer1;
            this.RadioButtonAnswer1.Size = new System.Drawing.Size(20, 21);
            this.RadioButtonAnswer1.TabIndex = 1;
            this.RadioButtonAnswer1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RadioButtonAnswer1.UncheckedState.BorderThickness = 2;
            this.RadioButtonAnswer1.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.RadioButtonAnswer1.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.RadioButtonAnswer1.UncheckedState.Parent = this.RadioButtonAnswer1;
            this.RadioButtonAnswer1.CheckedChanged += new System.EventHandler(this.RadioButtonAnswer1_CheckedChanged);
            // 
            // PanelAnswers
            // 
            this.PanelAnswers.Controls.Add(this.TextBoxAnswer4);
            this.PanelAnswers.Controls.Add(this.TextBoxAnswer3);
            this.PanelAnswers.Controls.Add(this.TextBoxAnswer2);
            this.PanelAnswers.Controls.Add(this.TextBoxAnswer1);
            this.PanelAnswers.Location = new System.Drawing.Point(64, 143);
            this.PanelAnswers.Name = "PanelAnswers";
            this.PanelAnswers.Size = new System.Drawing.Size(643, 319);
            this.PanelAnswers.TabIndex = 2;
            // 
            // TextBoxAnswer4
            // 
            this.TextBoxAnswer4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxAnswer4.DefaultText = "";
            this.TextBoxAnswer4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxAnswer4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxAnswer4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxAnswer4.DisabledState.Parent = this.TextBoxAnswer4;
            this.TextBoxAnswer4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxAnswer4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxAnswer4.FocusedState.Parent = this.TextBoxAnswer4;
            this.TextBoxAnswer4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxAnswer4.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxAnswer4.HoverState.Parent = this.TextBoxAnswer4;
            this.TextBoxAnswer4.Location = new System.Drawing.Point(15, 237);
            this.TextBoxAnswer4.Multiline = true;
            this.TextBoxAnswer4.Name = "TextBoxAnswer4";
            this.TextBoxAnswer4.PasswordChar = '\0';
            this.TextBoxAnswer4.PlaceholderText = "Answer 4";
            this.TextBoxAnswer4.SelectedText = "";
            this.TextBoxAnswer4.ShadowDecoration.Parent = this.TextBoxAnswer4;
            this.TextBoxAnswer4.Size = new System.Drawing.Size(604, 70);
            this.TextBoxAnswer4.TabIndex = 9;
            this.TextBoxAnswer4.TextChanged += new System.EventHandler(this.TextBoxQuestion_TextChanged);
            // 
            // TextBoxAnswer3
            // 
            this.TextBoxAnswer3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxAnswer3.DefaultText = "";
            this.TextBoxAnswer3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxAnswer3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxAnswer3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxAnswer3.DisabledState.Parent = this.TextBoxAnswer3;
            this.TextBoxAnswer3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxAnswer3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxAnswer3.FocusedState.Parent = this.TextBoxAnswer3;
            this.TextBoxAnswer3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxAnswer3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxAnswer3.HoverState.Parent = this.TextBoxAnswer3;
            this.TextBoxAnswer3.Location = new System.Drawing.Point(15, 161);
            this.TextBoxAnswer3.Multiline = true;
            this.TextBoxAnswer3.Name = "TextBoxAnswer3";
            this.TextBoxAnswer3.PasswordChar = '\0';
            this.TextBoxAnswer3.PlaceholderText = "Answer 3";
            this.TextBoxAnswer3.SelectedText = "";
            this.TextBoxAnswer3.ShadowDecoration.Parent = this.TextBoxAnswer3;
            this.TextBoxAnswer3.Size = new System.Drawing.Size(604, 70);
            this.TextBoxAnswer3.TabIndex = 7;
            this.TextBoxAnswer3.TextChanged += new System.EventHandler(this.TextBoxQuestion_TextChanged);
            // 
            // TextBoxAnswer2
            // 
            this.TextBoxAnswer2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxAnswer2.DefaultText = "";
            this.TextBoxAnswer2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxAnswer2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxAnswer2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxAnswer2.DisabledState.Parent = this.TextBoxAnswer2;
            this.TextBoxAnswer2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxAnswer2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxAnswer2.FocusedState.Parent = this.TextBoxAnswer2;
            this.TextBoxAnswer2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxAnswer2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxAnswer2.HoverState.Parent = this.TextBoxAnswer2;
            this.TextBoxAnswer2.Location = new System.Drawing.Point(15, 85);
            this.TextBoxAnswer2.Multiline = true;
            this.TextBoxAnswer2.Name = "TextBoxAnswer2";
            this.TextBoxAnswer2.PasswordChar = '\0';
            this.TextBoxAnswer2.PlaceholderText = "Answer 2";
            this.TextBoxAnswer2.SelectedText = "";
            this.TextBoxAnswer2.ShadowDecoration.Parent = this.TextBoxAnswer2;
            this.TextBoxAnswer2.Size = new System.Drawing.Size(604, 70);
            this.TextBoxAnswer2.TabIndex = 5;
            this.TextBoxAnswer2.TextChanged += new System.EventHandler(this.TextBoxQuestion_TextChanged);
            // 
            // TextBoxAnswer1
            // 
            this.TextBoxAnswer1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxAnswer1.DefaultText = "";
            this.TextBoxAnswer1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxAnswer1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxAnswer1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxAnswer1.DisabledState.Parent = this.TextBoxAnswer1;
            this.TextBoxAnswer1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxAnswer1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxAnswer1.FocusedState.Parent = this.TextBoxAnswer1;
            this.TextBoxAnswer1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxAnswer1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxAnswer1.HoverState.Parent = this.TextBoxAnswer1;
            this.TextBoxAnswer1.Location = new System.Drawing.Point(15, 9);
            this.TextBoxAnswer1.Multiline = true;
            this.TextBoxAnswer1.Name = "TextBoxAnswer1";
            this.TextBoxAnswer1.PasswordChar = '\0';
            this.TextBoxAnswer1.PlaceholderText = "Answer 1";
            this.TextBoxAnswer1.SelectedText = "";
            this.TextBoxAnswer1.ShadowDecoration.Parent = this.TextBoxAnswer1;
            this.TextBoxAnswer1.Size = new System.Drawing.Size(604, 70);
            this.TextBoxAnswer1.TabIndex = 3;
            this.TextBoxAnswer1.TextChanged += new System.EventHandler(this.TextBoxQuestion_TextChanged);
            // 
            // RadioButtonAnswer4
            // 
            this.RadioButtonAnswer4.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RadioButtonAnswer4.CheckedState.BorderThickness = 0;
            this.RadioButtonAnswer4.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RadioButtonAnswer4.CheckedState.InnerColor = System.Drawing.Color.White;
            this.RadioButtonAnswer4.CheckedState.Parent = this.RadioButtonAnswer4;
            this.RadioButtonAnswer4.Location = new System.Drawing.Point(15, 112);
            this.RadioButtonAnswer4.Name = "RadioButtonAnswer4";
            this.RadioButtonAnswer4.ShadowDecoration.Parent = this.RadioButtonAnswer4;
            this.RadioButtonAnswer4.Size = new System.Drawing.Size(20, 21);
            this.RadioButtonAnswer4.TabIndex = 8;
            this.RadioButtonAnswer4.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RadioButtonAnswer4.UncheckedState.BorderThickness = 2;
            this.RadioButtonAnswer4.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.RadioButtonAnswer4.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.RadioButtonAnswer4.UncheckedState.Parent = this.RadioButtonAnswer4;
            this.RadioButtonAnswer4.CheckedChanged += new System.EventHandler(this.RadioButtonAnswer1_CheckedChanged);
            // 
            // RadioButtonAnswer3
            // 
            this.RadioButtonAnswer3.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RadioButtonAnswer3.CheckedState.BorderThickness = 0;
            this.RadioButtonAnswer3.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RadioButtonAnswer3.CheckedState.InnerColor = System.Drawing.Color.White;
            this.RadioButtonAnswer3.CheckedState.Parent = this.RadioButtonAnswer3;
            this.RadioButtonAnswer3.Location = new System.Drawing.Point(15, 39);
            this.RadioButtonAnswer3.Name = "RadioButtonAnswer3";
            this.RadioButtonAnswer3.ShadowDecoration.Parent = this.RadioButtonAnswer3;
            this.RadioButtonAnswer3.Size = new System.Drawing.Size(20, 21);
            this.RadioButtonAnswer3.TabIndex = 6;
            this.RadioButtonAnswer3.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RadioButtonAnswer3.UncheckedState.BorderThickness = 2;
            this.RadioButtonAnswer3.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.RadioButtonAnswer3.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.RadioButtonAnswer3.UncheckedState.Parent = this.RadioButtonAnswer3;
            this.RadioButtonAnswer3.CheckedChanged += new System.EventHandler(this.RadioButtonAnswer1_CheckedChanged);
            // 
            // RadioButtonAnswer2
            // 
            this.RadioButtonAnswer2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RadioButtonAnswer2.CheckedState.BorderThickness = 0;
            this.RadioButtonAnswer2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RadioButtonAnswer2.CheckedState.InnerColor = System.Drawing.Color.White;
            this.RadioButtonAnswer2.CheckedState.Parent = this.RadioButtonAnswer2;
            this.RadioButtonAnswer2.Location = new System.Drawing.Point(15, 187);
            this.RadioButtonAnswer2.Name = "RadioButtonAnswer2";
            this.RadioButtonAnswer2.ShadowDecoration.Parent = this.RadioButtonAnswer2;
            this.RadioButtonAnswer2.Size = new System.Drawing.Size(20, 21);
            this.RadioButtonAnswer2.TabIndex = 4;
            this.RadioButtonAnswer2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RadioButtonAnswer2.UncheckedState.BorderThickness = 2;
            this.RadioButtonAnswer2.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.RadioButtonAnswer2.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.RadioButtonAnswer2.UncheckedState.Parent = this.RadioButtonAnswer2;
            this.RadioButtonAnswer2.CheckedChanged += new System.EventHandler(this.RadioButtonAnswer1_CheckedChanged);
            // 
            // LabelQuestionNo
            // 
            this.LabelQuestionNo.AutoSize = true;
            this.LabelQuestionNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LabelQuestionNo.Location = new System.Drawing.Point(25, 67);
            this.LabelQuestionNo.Name = "LabelQuestionNo";
            this.LabelQuestionNo.Size = new System.Drawing.Size(26, 29);
            this.LabelQuestionNo.TabIndex = 3;
            this.LabelQuestionNo.Text = "0";
            // 
            // PictureBoxRemove
            // 
            this.PictureBoxRemove.Image = global::EyeQuiz.Properties.Resources.remove_100px;
            this.PictureBoxRemove.Location = new System.Drawing.Point(680, 54);
            this.PictureBoxRemove.Name = "PictureBoxRemove";
            this.PictureBoxRemove.Size = new System.Drawing.Size(44, 52);
            this.PictureBoxRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxRemove.TabIndex = 4;
            this.PictureBoxRemove.TabStop = false;
            this.PictureBoxRemove.Click += new System.EventHandler(this.PictureBoxRemove_Click);
            this.PictureBoxRemove.MouseEnter += new System.EventHandler(this.PictureBoxRemove_MouseEnter);
            this.PictureBoxRemove.MouseLeave += new System.EventHandler(this.PictureBoxRemove_MouseLeave);
            // 
            // PanelRadioButtons
            // 
            this.PanelRadioButtons.Controls.Add(this.RadioButtonAnswer1);
            this.PanelRadioButtons.Controls.Add(this.RadioButtonAnswer2);
            this.PanelRadioButtons.Controls.Add(this.RadioButtonAnswer4);
            this.PanelRadioButtons.Controls.Add(this.RadioButtonAnswer3);
            this.PanelRadioButtons.Location = new System.Drawing.Point(8, 143);
            this.PanelRadioButtons.Name = "PanelRadioButtons";
            this.PanelRadioButtons.Size = new System.Drawing.Size(49, 319);
            this.PanelRadioButtons.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(49, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(49, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(49, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 29);
            this.label3.TabIndex = 13;
            this.label3.Text = "C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(49, 404);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 29);
            this.label4.TabIndex = 14;
            this.label4.Text = "D";
            // 
            // UCNewQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PanelRadioButtons);
            this.Controls.Add(this.TextBoxQuestion);
            this.Controls.Add(this.PictureBoxRemove);
            this.Controls.Add(this.LabelQuestionNo);
            this.Controls.Add(this.PanelAnswers);
            this.Name = "UCNewQuestion";
            this.Size = new System.Drawing.Size(724, 478);
            this.Load += new System.EventHandler(this.UCNewQuestion_Load);
            this.PanelAnswers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxRemove)).EndInit();
            this.PanelRadioButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox TextBoxQuestion;
        private Guna.UI2.WinForms.Guna2CustomRadioButton RadioButtonAnswer1;
        private System.Windows.Forms.Panel PanelAnswers;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxAnswer4;
        private Guna.UI2.WinForms.Guna2CustomRadioButton RadioButtonAnswer4;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxAnswer3;
        private Guna.UI2.WinForms.Guna2CustomRadioButton RadioButtonAnswer3;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxAnswer2;
        private Guna.UI2.WinForms.Guna2CustomRadioButton RadioButtonAnswer2;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxAnswer1;
        private System.Windows.Forms.Label LabelQuestionNo;
        private System.Windows.Forms.PictureBox PictureBoxRemove;
        private System.Windows.Forms.Panel PanelRadioButtons;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
