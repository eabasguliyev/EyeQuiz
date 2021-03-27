
namespace EyeQuiz.UCQuiz
{
    partial class UCResult
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
            this.ButtonBack = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelProgressBars = new System.Windows.Forms.Panel();
            this.ProgressBarNotAnsweredResult = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.LabelNotAnsweredResult = new System.Windows.Forms.Label();
            this.ProgressBarIncorrectResult = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.LabelIncorrectResult = new System.Windows.Forms.Label();
            this.ProgressBarNotSureResult = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.LabelNotSureResult = new System.Windows.Forms.Label();
            this.ProgressBarCorrectResult = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.LabelCorrectResult = new System.Windows.Forms.Label();
            this.PanelAnswersCount = new System.Windows.Forms.Panel();
            this.LabelNotAnsweredCounts = new System.Windows.Forms.Label();
            this.LabelCorrectCounts = new System.Windows.Forms.Label();
            this.LabelIncorrectCounts = new System.Windows.Forms.Label();
            this.LabelNotSureCounts = new System.Windows.Forms.Label();
            this.ButtonSave = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonBack)).BeginInit();
            this.PanelProgressBars.SuspendLayout();
            this.ProgressBarNotAnsweredResult.SuspendLayout();
            this.ProgressBarIncorrectResult.SuspendLayout();
            this.ProgressBarNotSureResult.SuspendLayout();
            this.ProgressBarCorrectResult.SuspendLayout();
            this.PanelAnswersCount.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonBack
            // 
            this.ButtonBack.Image = global::EyeQuiz.Properties.Resources.back_to_light_100px;
            this.ButtonBack.Location = new System.Drawing.Point(19, 19);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(52, 50);
            this.ButtonBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ButtonBack.TabIndex = 8;
            this.ButtonBack.TabStop = false;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            this.ButtonBack.MouseEnter += new System.EventHandler(this.ButtonBack_MouseEnter);
            this.ButtonBack.MouseLeave += new System.EventHandler(this.ButtonBack_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(128)))), ((int)(((byte)(212)))));
            this.label1.Location = new System.Drawing.Point(77, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 43);
            this.label1.TabIndex = 7;
            this.label1.Text = "Quiz Result";
            // 
            // PanelProgressBars
            // 
            this.PanelProgressBars.Controls.Add(this.ProgressBarNotAnsweredResult);
            this.PanelProgressBars.Controls.Add(this.ProgressBarIncorrectResult);
            this.PanelProgressBars.Controls.Add(this.ProgressBarNotSureResult);
            this.PanelProgressBars.Controls.Add(this.ProgressBarCorrectResult);
            this.PanelProgressBars.Location = new System.Drawing.Point(130, 202);
            this.PanelProgressBars.Name = "PanelProgressBars";
            this.PanelProgressBars.Size = new System.Drawing.Size(648, 185);
            this.PanelProgressBars.TabIndex = 9;
            // 
            // ProgressBarNotAnsweredResult
            // 
            this.ProgressBarNotAnsweredResult.Controls.Add(this.LabelNotAnsweredResult);
            this.ProgressBarNotAnsweredResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(26)))), ((int)(((byte)(219)))));
            this.ProgressBarNotAnsweredResult.Location = new System.Drawing.Point(481, 17);
            this.ProgressBarNotAnsweredResult.Name = "ProgressBarNotAnsweredResult";
            this.ProgressBarNotAnsweredResult.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(198)))));
            this.ProgressBarNotAnsweredResult.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(26)))), ((int)(((byte)(219)))));
            this.ProgressBarNotAnsweredResult.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ProgressBarNotAnsweredResult.ShadowDecoration.Parent = this.ProgressBarNotAnsweredResult;
            this.ProgressBarNotAnsweredResult.Size = new System.Drawing.Size(147, 147);
            this.ProgressBarNotAnsweredResult.TabIndex = 1;
            this.ProgressBarNotAnsweredResult.Tag = "LabelNotAnsweredCounts";
            this.ProgressBarNotAnsweredResult.Value = 15;
            // 
            // LabelNotAnsweredResult
            // 
            this.LabelNotAnsweredResult.AutoSize = true;
            this.LabelNotAnsweredResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LabelNotAnsweredResult.Location = new System.Drawing.Point(38, 61);
            this.LabelNotAnsweredResult.Name = "LabelNotAnsweredResult";
            this.LabelNotAnsweredResult.Size = new System.Drawing.Size(64, 29);
            this.LabelNotAnsweredResult.TabIndex = 13;
            this.LabelNotAnsweredResult.Text = "15%";
            // 
            // ProgressBarIncorrectResult
            // 
            this.ProgressBarIncorrectResult.Controls.Add(this.LabelIncorrectResult);
            this.ProgressBarIncorrectResult.Location = new System.Drawing.Point(328, 17);
            this.ProgressBarIncorrectResult.Name = "ProgressBarIncorrectResult";
            this.ProgressBarIncorrectResult.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(128)))), ((int)(((byte)(212)))));
            this.ProgressBarIncorrectResult.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(64)))), ((int)(((byte)(58)))));
            this.ProgressBarIncorrectResult.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ProgressBarIncorrectResult.ShadowDecoration.Parent = this.ProgressBarIncorrectResult;
            this.ProgressBarIncorrectResult.Size = new System.Drawing.Size(147, 147);
            this.ProgressBarIncorrectResult.TabIndex = 1;
            this.ProgressBarIncorrectResult.Tag = "LabelIncorrectCounts";
            this.ProgressBarIncorrectResult.Value = 15;
            // 
            // LabelIncorrectResult
            // 
            this.LabelIncorrectResult.AutoSize = true;
            this.LabelIncorrectResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LabelIncorrectResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(64)))), ((int)(((byte)(58)))));
            this.LabelIncorrectResult.Location = new System.Drawing.Point(37, 61);
            this.LabelIncorrectResult.Name = "LabelIncorrectResult";
            this.LabelIncorrectResult.Size = new System.Drawing.Size(64, 29);
            this.LabelIncorrectResult.TabIndex = 12;
            this.LabelIncorrectResult.Text = "15%";
            // 
            // ProgressBarNotSureResult
            // 
            this.ProgressBarNotSureResult.Controls.Add(this.LabelNotSureResult);
            this.ProgressBarNotSureResult.Location = new System.Drawing.Point(175, 17);
            this.ProgressBarNotSureResult.Name = "ProgressBarNotSureResult";
            this.ProgressBarNotSureResult.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(128)))), ((int)(((byte)(212)))));
            this.ProgressBarNotSureResult.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(203)))), ((int)(((byte)(64)))));
            this.ProgressBarNotSureResult.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ProgressBarNotSureResult.ShadowDecoration.Parent = this.ProgressBarNotSureResult;
            this.ProgressBarNotSureResult.Size = new System.Drawing.Size(147, 147);
            this.ProgressBarNotSureResult.TabIndex = 1;
            this.ProgressBarNotSureResult.Tag = "LabelNotSureCounts";
            this.ProgressBarNotSureResult.Value = 30;
            this.ProgressBarNotSureResult.ValueChanged += new System.EventHandler(this.guna2CircleProgressBar2_ValueChanged);
            // 
            // LabelNotSureResult
            // 
            this.LabelNotSureResult.AutoSize = true;
            this.LabelNotSureResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LabelNotSureResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(203)))), ((int)(((byte)(64)))));
            this.LabelNotSureResult.Location = new System.Drawing.Point(41, 61);
            this.LabelNotSureResult.Name = "LabelNotSureResult";
            this.LabelNotSureResult.Size = new System.Drawing.Size(64, 29);
            this.LabelNotSureResult.TabIndex = 11;
            this.LabelNotSureResult.Text = "30%";
            // 
            // ProgressBarCorrectResult
            // 
            this.ProgressBarCorrectResult.Controls.Add(this.LabelCorrectResult);
            this.ProgressBarCorrectResult.Location = new System.Drawing.Point(22, 17);
            this.ProgressBarCorrectResult.Name = "ProgressBarCorrectResult";
            this.ProgressBarCorrectResult.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(128)))), ((int)(((byte)(212)))));
            this.ProgressBarCorrectResult.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.ProgressBarCorrectResult.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round;
            this.ProgressBarCorrectResult.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ProgressBarCorrectResult.ShadowDecoration.Parent = this.ProgressBarCorrectResult;
            this.ProgressBarCorrectResult.Size = new System.Drawing.Size(147, 147);
            this.ProgressBarCorrectResult.TabIndex = 0;
            this.ProgressBarCorrectResult.Tag = "LabelCorrectCounts";
            this.ProgressBarCorrectResult.Value = 40;
            this.ProgressBarCorrectResult.ValueChanged += new System.EventHandler(this.ProgressBarCorrectResult_ValueChanged);
            // 
            // LabelCorrectResult
            // 
            this.LabelCorrectResult.AutoSize = true;
            this.LabelCorrectResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LabelCorrectResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(77)))));
            this.LabelCorrectResult.Location = new System.Drawing.Point(39, 61);
            this.LabelCorrectResult.Name = "LabelCorrectResult";
            this.LabelCorrectResult.Size = new System.Drawing.Size(64, 29);
            this.LabelCorrectResult.TabIndex = 10;
            this.LabelCorrectResult.Text = "40%";
            // 
            // PanelAnswersCount
            // 
            this.PanelAnswersCount.Controls.Add(this.LabelNotAnsweredCounts);
            this.PanelAnswersCount.Controls.Add(this.LabelCorrectCounts);
            this.PanelAnswersCount.Controls.Add(this.LabelNotSureCounts);
            this.PanelAnswersCount.Controls.Add(this.LabelIncorrectCounts);
            this.PanelAnswersCount.Location = new System.Drawing.Point(386, 455);
            this.PanelAnswersCount.Name = "PanelAnswersCount";
            this.PanelAnswersCount.Size = new System.Drawing.Size(69, 137);
            this.PanelAnswersCount.TabIndex = 10;
            // 
            // LabelNotAnsweredCounts
            // 
            this.LabelNotAnsweredCounts.AutoSize = true;
            this.LabelNotAnsweredCounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LabelNotAnsweredCounts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(26)))), ((int)(((byte)(219)))));
            this.LabelNotAnsweredCounts.Location = new System.Drawing.Point(10, 100);
            this.LabelNotAnsweredCounts.Name = "LabelNotAnsweredCounts";
            this.LabelNotAnsweredCounts.Size = new System.Drawing.Size(18, 20);
            this.LabelNotAnsweredCounts.TabIndex = 3;
            this.LabelNotAnsweredCounts.Text = "0";
            // 
            // LabelCorrectCounts
            // 
            this.LabelCorrectCounts.AutoSize = true;
            this.LabelCorrectCounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LabelCorrectCounts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(77)))));
            this.LabelCorrectCounts.Location = new System.Drawing.Point(10, 17);
            this.LabelCorrectCounts.Name = "LabelCorrectCounts";
            this.LabelCorrectCounts.Size = new System.Drawing.Size(18, 20);
            this.LabelCorrectCounts.TabIndex = 0;
            this.LabelCorrectCounts.Text = "0";
            // 
            // LabelIncorrectCounts
            // 
            this.LabelIncorrectCounts.AutoSize = true;
            this.LabelIncorrectCounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LabelIncorrectCounts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(64)))), ((int)(((byte)(58)))));
            this.LabelIncorrectCounts.Location = new System.Drawing.Point(10, 73);
            this.LabelIncorrectCounts.Name = "LabelIncorrectCounts";
            this.LabelIncorrectCounts.Size = new System.Drawing.Size(18, 20);
            this.LabelIncorrectCounts.TabIndex = 1;
            this.LabelIncorrectCounts.Text = "0";
            // 
            // LabelNotSureCounts
            // 
            this.LabelNotSureCounts.AutoSize = true;
            this.LabelNotSureCounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LabelNotSureCounts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(203)))), ((int)(((byte)(64)))));
            this.LabelNotSureCounts.Location = new System.Drawing.Point(10, 45);
            this.LabelNotSureCounts.Name = "LabelNotSureCounts";
            this.LabelNotSureCounts.Size = new System.Drawing.Size(18, 20);
            this.LabelNotSureCounts.TabIndex = 2;
            this.LabelNotSureCounts.Text = "0";
            // 
            // ButtonSave
            // 
            this.ButtonSave.CheckedState.Parent = this.ButtonSave;
            this.ButtonSave.CustomImages.Parent = this.ButtonSave;
            this.ButtonSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(128)))), ((int)(((byte)(212)))));
            this.ButtonSave.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(128)))), ((int)(((byte)(212)))));
            this.ButtonSave.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonSave.ForeColor = System.Drawing.Color.White;
            this.ButtonSave.HoverState.Parent = this.ButtonSave;
            this.ButtonSave.Location = new System.Drawing.Point(500, 492);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.ShadowDecoration.Parent = this.ButtonSave;
            this.ButtonSave.Size = new System.Drawing.Size(147, 56);
            this.ButtonSave.TabIndex = 11;
            this.ButtonSave.Text = "SAVE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(26)))), ((int)(((byte)(219)))));
            this.label2.Location = new System.Drawing.Point(237, 554);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Not answered:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(77)))));
            this.label3.Location = new System.Drawing.Point(237, 471);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Correct answers:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(64)))), ((int)(((byte)(58)))));
            this.label4.Location = new System.Drawing.Point(237, 528);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Incorrect answers:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(203)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(237, 500);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Not sure answers:";
            // 
            // UCResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PanelAnswersCount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PanelProgressBars);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "UCResult";
            this.Size = new System.Drawing.Size(941, 655);
            this.Load += new System.EventHandler(this.UCResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ButtonBack)).EndInit();
            this.PanelProgressBars.ResumeLayout(false);
            this.ProgressBarNotAnsweredResult.ResumeLayout(false);
            this.ProgressBarNotAnsweredResult.PerformLayout();
            this.ProgressBarIncorrectResult.ResumeLayout(false);
            this.ProgressBarIncorrectResult.PerformLayout();
            this.ProgressBarNotSureResult.ResumeLayout(false);
            this.ProgressBarNotSureResult.PerformLayout();
            this.ProgressBarCorrectResult.ResumeLayout(false);
            this.ProgressBarCorrectResult.PerformLayout();
            this.PanelAnswersCount.ResumeLayout(false);
            this.PanelAnswersCount.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ButtonBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelProgressBars;
        private Guna.UI2.WinForms.Guna2CircleProgressBar ProgressBarNotAnsweredResult;
        private System.Windows.Forms.Label LabelNotAnsweredResult;
        private Guna.UI2.WinForms.Guna2CircleProgressBar ProgressBarIncorrectResult;
        private System.Windows.Forms.Label LabelIncorrectResult;
        private Guna.UI2.WinForms.Guna2CircleProgressBar ProgressBarNotSureResult;
        private System.Windows.Forms.Label LabelNotSureResult;
        private Guna.UI2.WinForms.Guna2CircleProgressBar ProgressBarCorrectResult;
        private System.Windows.Forms.Label LabelCorrectResult;
        private System.Windows.Forms.Panel PanelAnswersCount;
        private System.Windows.Forms.Label LabelNotAnsweredCounts;
        private System.Windows.Forms.Label LabelNotSureCounts;
        private System.Windows.Forms.Label LabelIncorrectCounts;
        private System.Windows.Forms.Label LabelCorrectCounts;
        private Guna.UI2.WinForms.Guna2GradientButton ButtonSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
