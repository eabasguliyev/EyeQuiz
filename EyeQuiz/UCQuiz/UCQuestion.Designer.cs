
namespace EyeQuiz.UCQuiz
{
    partial class UCQuestion
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
            this.LabelQuestionNo = new System.Windows.Forms.Label();
            this.LabelQuestion = new System.Windows.Forms.Label();
            this.PanelRadioButtons = new System.Windows.Forms.Panel();
            this.RadioButtonAnswer4 = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.RadioButtonAnswer3 = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.RadioButtonAnswer2 = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.RadioButtonAnswer1 = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.PanelAnswers = new System.Windows.Forms.Panel();
            this.PictureBoxUserAnswer = new System.Windows.Forms.PictureBox();
            this.PictureBoxCorrectAnswer = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PanelRadioButtons.SuspendLayout();
            this.PanelAnswers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxUserAnswer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCorrectAnswer)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelQuestionNo
            // 
            this.LabelQuestionNo.AutoSize = true;
            this.LabelQuestionNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LabelQuestionNo.Location = new System.Drawing.Point(30, 17);
            this.LabelQuestionNo.Name = "LabelQuestionNo";
            this.LabelQuestionNo.Size = new System.Drawing.Size(26, 29);
            this.LabelQuestionNo.TabIndex = 4;
            this.LabelQuestionNo.Text = "0";
            // 
            // LabelQuestion
            // 
            this.LabelQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LabelQuestion.Location = new System.Drawing.Point(74, 16);
            this.LabelQuestion.Name = "LabelQuestion";
            this.LabelQuestion.Size = new System.Drawing.Size(805, 129);
            this.LabelQuestion.TabIndex = 5;
            this.LabelQuestion.Text = "Question";
            this.LabelQuestion.Click += new System.EventHandler(this.LabelQuestion_Click);
            // 
            // PanelRadioButtons
            // 
            this.PanelRadioButtons.Controls.Add(this.RadioButtonAnswer4);
            this.PanelRadioButtons.Controls.Add(this.RadioButtonAnswer3);
            this.PanelRadioButtons.Controls.Add(this.RadioButtonAnswer2);
            this.PanelRadioButtons.Controls.Add(this.RadioButtonAnswer1);
            this.PanelRadioButtons.Location = new System.Drawing.Point(82, 131);
            this.PanelRadioButtons.Name = "PanelRadioButtons";
            this.PanelRadioButtons.Size = new System.Drawing.Size(49, 333);
            this.PanelRadioButtons.TabIndex = 12;
            // 
            // RadioButtonAnswer4
            // 
            this.RadioButtonAnswer4.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RadioButtonAnswer4.CheckedState.BorderThickness = 0;
            this.RadioButtonAnswer4.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RadioButtonAnswer4.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RadioButtonAnswer4.CheckedState.Parent = this.RadioButtonAnswer4;
            this.RadioButtonAnswer4.Location = new System.Drawing.Point(15, 26);
            this.RadioButtonAnswer4.Name = "RadioButtonAnswer4";
            this.RadioButtonAnswer4.ShadowDecoration.Parent = this.RadioButtonAnswer4;
            this.RadioButtonAnswer4.Size = new System.Drawing.Size(20, 21);
            this.RadioButtonAnswer4.TabIndex = 1;
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
            this.RadioButtonAnswer3.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RadioButtonAnswer3.CheckedState.Parent = this.RadioButtonAnswer3;
            this.RadioButtonAnswer3.Location = new System.Drawing.Point(15, 106);
            this.RadioButtonAnswer3.Name = "RadioButtonAnswer3";
            this.RadioButtonAnswer3.ShadowDecoration.Parent = this.RadioButtonAnswer3;
            this.RadioButtonAnswer3.Size = new System.Drawing.Size(20, 21);
            this.RadioButtonAnswer3.TabIndex = 4;
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
            this.RadioButtonAnswer2.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RadioButtonAnswer2.CheckedState.Parent = this.RadioButtonAnswer2;
            this.RadioButtonAnswer2.Location = new System.Drawing.Point(15, 191);
            this.RadioButtonAnswer2.Name = "RadioButtonAnswer2";
            this.RadioButtonAnswer2.ShadowDecoration.Parent = this.RadioButtonAnswer2;
            this.RadioButtonAnswer2.Size = new System.Drawing.Size(20, 21);
            this.RadioButtonAnswer2.TabIndex = 8;
            this.RadioButtonAnswer2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RadioButtonAnswer2.UncheckedState.BorderThickness = 2;
            this.RadioButtonAnswer2.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.RadioButtonAnswer2.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.RadioButtonAnswer2.UncheckedState.Parent = this.RadioButtonAnswer2;
            this.RadioButtonAnswer2.CheckedChanged += new System.EventHandler(this.RadioButtonAnswer1_CheckedChanged);
            // 
            // RadioButtonAnswer1
            // 
            this.RadioButtonAnswer1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RadioButtonAnswer1.CheckedState.BorderThickness = 0;
            this.RadioButtonAnswer1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RadioButtonAnswer1.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RadioButtonAnswer1.CheckedState.Parent = this.RadioButtonAnswer1;
            this.RadioButtonAnswer1.Location = new System.Drawing.Point(15, 280);
            this.RadioButtonAnswer1.Name = "RadioButtonAnswer1";
            this.RadioButtonAnswer1.ShadowDecoration.Parent = this.RadioButtonAnswer1;
            this.RadioButtonAnswer1.Size = new System.Drawing.Size(20, 21);
            this.RadioButtonAnswer1.TabIndex = 6;
            this.RadioButtonAnswer1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RadioButtonAnswer1.UncheckedState.BorderThickness = 2;
            this.RadioButtonAnswer1.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.RadioButtonAnswer1.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.RadioButtonAnswer1.UncheckedState.Parent = this.RadioButtonAnswer1;
            this.RadioButtonAnswer1.CheckedChanged += new System.EventHandler(this.RadioButtonAnswer1_CheckedChanged);
            // 
            // PanelAnswers
            // 
            this.PanelAnswers.Controls.Add(this.label3);
            this.PanelAnswers.Controls.Add(this.label2);
            this.PanelAnswers.Controls.Add(this.label1);
            this.PanelAnswers.Controls.Add(this.label4);
            this.PanelAnswers.Location = new System.Drawing.Point(131, 148);
            this.PanelAnswers.Name = "PanelAnswers";
            this.PanelAnswers.Size = new System.Drawing.Size(765, 361);
            this.PanelAnswers.TabIndex = 16;
            // 
            // PictureBoxUserAnswer
            // 
            this.PictureBoxUserAnswer.Image = global::EyeQuiz.Properties.Resources.multiply_24px;
            this.PictureBoxUserAnswer.Location = new System.Drawing.Point(41, 411);
            this.PictureBoxUserAnswer.Name = "PictureBoxUserAnswer";
            this.PictureBoxUserAnswer.Size = new System.Drawing.Size(37, 36);
            this.PictureBoxUserAnswer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxUserAnswer.TabIndex = 18;
            this.PictureBoxUserAnswer.TabStop = false;
            this.PictureBoxUserAnswer.Visible = false;
            // 
            // PictureBoxCorrectAnswer
            // 
            this.PictureBoxCorrectAnswer.Image = global::EyeQuiz.Properties.Resources.checked_40px;
            this.PictureBoxCorrectAnswer.Location = new System.Drawing.Point(1, 411);
            this.PictureBoxCorrectAnswer.Name = "PictureBoxCorrectAnswer";
            this.PictureBoxCorrectAnswer.Size = new System.Drawing.Size(37, 36);
            this.PictureBoxCorrectAnswer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxCorrectAnswer.TabIndex = 17;
            this.PictureBoxCorrectAnswer.TabStop = false;
            this.PictureBoxCorrectAnswer.Visible = false;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(1, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(764, 79);
            this.label4.TabIndex = 16;
            this.label4.Text = "Answer";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(764, 79);
            this.label1.TabIndex = 17;
            this.label1.Text = "Answer";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(3, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(764, 79);
            this.label2.TabIndex = 18;
            this.label2.Text = "Answer";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(764, 79);
            this.label3.TabIndex = 19;
            this.label3.Text = "Answer";
            // 
            // UCQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.PictureBoxUserAnswer);
            this.Controls.Add(this.PictureBoxCorrectAnswer);
            this.Controls.Add(this.LabelQuestion);
            this.Controls.Add(this.PanelAnswers);
            this.Controls.Add(this.PanelRadioButtons);
            this.Controls.Add(this.LabelQuestionNo);
            this.Name = "UCQuestion";
            this.Size = new System.Drawing.Size(902, 493);
            this.Load += new System.EventHandler(this.UCQuestion_Load);
            this.PanelRadioButtons.ResumeLayout(false);
            this.PanelAnswers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxUserAnswer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCorrectAnswer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelQuestionNo;
        private System.Windows.Forms.Label LabelQuestion;
        private System.Windows.Forms.Panel PanelRadioButtons;
        private Guna.UI2.WinForms.Guna2CustomRadioButton RadioButtonAnswer4;
        private Guna.UI2.WinForms.Guna2CustomRadioButton RadioButtonAnswer3;
        private Guna.UI2.WinForms.Guna2CustomRadioButton RadioButtonAnswer2;
        private Guna.UI2.WinForms.Guna2CustomRadioButton RadioButtonAnswer1;
        private System.Windows.Forms.Panel PanelAnswers;
        private System.Windows.Forms.PictureBox PictureBoxCorrectAnswer;
        private System.Windows.Forms.PictureBox PictureBoxUserAnswer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}
