
namespace EyeQuiz.UCQuiz
{
    partial class UCQuizeList
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
            this.PanelQuizeList = new System.Windows.Forms.Panel();
            this.ContextMenuPanel = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.PanelQuiz = new System.Windows.Forms.Panel();
            this.LabelQuizName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonAdd = new Guna.UI2.WinForms.Guna2Button();
            this.TextBoxSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.PanelFilter = new System.Windows.Forms.Panel();
            this.LabelMine = new System.Windows.Forms.Label();
            this.LabelAllQuiz = new System.Windows.Forms.Label();
            this.RadioButtonOnlyMe = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.RadioButtonAll = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.ButtonStart = new Guna.UI2.WinForms.Guna2Button();
            this.TextBoxQuestionCount = new Guna.UI2.WinForms.Guna2TextBox();
            this.ButtonBack = new System.Windows.Forms.PictureBox();
            this.PanelQuizeList.SuspendLayout();
            this.ContextMenuPanel.SuspendLayout();
            this.PanelQuiz.SuspendLayout();
            this.PanelFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonBack)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelQuizeList
            // 
            this.PanelQuizeList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelQuizeList.AutoScroll = true;
            this.PanelQuizeList.ContextMenuStrip = this.ContextMenuPanel;
            this.PanelQuizeList.Controls.Add(this.label2);
            this.PanelQuizeList.Location = new System.Drawing.Point(25, 77);
            this.PanelQuizeList.Name = "PanelQuizeList";
            this.PanelQuizeList.Size = new System.Drawing.Size(880, 509);
            this.PanelQuizeList.TabIndex = 0;
            // 
            // ContextMenuPanel
            // 
            this.ContextMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(128)))), ((int)(((byte)(212)))));
            this.ContextMenuPanel.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ContextMenuPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem});
            this.ContextMenuPanel.Name = "ContextMenuPanel";
            this.ContextMenuPanel.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.ContextMenuPanel.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.ContextMenuPanel.RenderStyle.ColorTable = null;
            this.ContextMenuPanel.RenderStyle.RoundedEdges = true;
            this.ContextMenuPanel.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.ContextMenuPanel.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ContextMenuPanel.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.ContextMenuPanel.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.ContextMenuPanel.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.ContextMenuPanel.Size = new System.Drawing.Size(128, 28);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(128)))), ((int)(((byte)(212)))));
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(362, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "There is no quize.";
            // 
            // PanelQuiz
            // 
            this.PanelQuiz.BackColor = System.Drawing.Color.Red;
            this.PanelQuiz.Controls.Add(this.LabelQuizName);
            this.PanelQuiz.Location = new System.Drawing.Point(911, 145);
            this.PanelQuiz.Name = "PanelQuiz";
            this.PanelQuiz.Size = new System.Drawing.Size(190, 215);
            this.PanelQuiz.TabIndex = 0;
            this.PanelQuiz.Visible = false;
            // 
            // LabelQuizName
            // 
            this.LabelQuizName.BackColor = System.Drawing.Color.Transparent;
            this.LabelQuizName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LabelQuizName.ForeColor = System.Drawing.Color.Black;
            this.LabelQuizName.Location = new System.Drawing.Point(45, 68);
            this.LabelQuizName.Name = "LabelQuizName";
            this.LabelQuizName.Size = new System.Drawing.Size(97, 81);
            this.LabelQuizName.TabIndex = 6;
            this.LabelQuizName.Text = "Airwaytest";
            this.LabelQuizName.Click += new System.EventHandler(this.PanelQuiz_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(128)))), ((int)(((byte)(212)))));
            this.label1.Location = new System.Drawing.Point(77, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 43);
            this.label1.TabIndex = 5;
            this.label1.Text = "Quiz List";
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.CheckedState.Parent = this.ButtonAdd;
            this.ButtonAdd.CustomImages.Parent = this.ButtonAdd;
            this.ButtonAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonAdd.ForeColor = System.Drawing.Color.White;
            this.ButtonAdd.HoverState.Parent = this.ButtonAdd;
            this.ButtonAdd.Location = new System.Drawing.Point(293, 19);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.ShadowDecoration.Parent = this.ButtonAdd;
            this.ButtonAdd.Size = new System.Drawing.Size(92, 45);
            this.ButtonAdd.TabIndex = 7;
            this.ButtonAdd.Text = "Add";
            this.ButtonAdd.Visible = false;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxSearch.DefaultText = "";
            this.TextBoxSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxSearch.DisabledState.Parent = this.TextBoxSearch;
            this.TextBoxSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxSearch.FocusedState.Parent = this.TextBoxSearch;
            this.TextBoxSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxSearch.HoverState.Parent = this.TextBoxSearch;
            this.TextBoxSearch.Location = new System.Drawing.Point(701, 19);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.PasswordChar = '\0';
            this.TextBoxSearch.PlaceholderText = "Search";
            this.TextBoxSearch.SelectedText = "";
            this.TextBoxSearch.ShadowDecoration.Parent = this.TextBoxSearch;
            this.TextBoxSearch.Size = new System.Drawing.Size(204, 36);
            this.TextBoxSearch.TabIndex = 8;
            this.TextBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            // 
            // PanelFilter
            // 
            this.PanelFilter.Controls.Add(this.LabelMine);
            this.PanelFilter.Controls.Add(this.LabelAllQuiz);
            this.PanelFilter.Controls.Add(this.RadioButtonOnlyMe);
            this.PanelFilter.Controls.Add(this.RadioButtonAll);
            this.PanelFilter.Location = new System.Drawing.Point(498, 10);
            this.PanelFilter.Name = "PanelFilter";
            this.PanelFilter.Size = new System.Drawing.Size(184, 58);
            this.PanelFilter.TabIndex = 9;
            // 
            // LabelMine
            // 
            this.LabelMine.AutoSize = true;
            this.LabelMine.BackColor = System.Drawing.Color.Transparent;
            this.LabelMine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LabelMine.ForeColor = System.Drawing.Color.Black;
            this.LabelMine.Location = new System.Drawing.Point(108, 17);
            this.LabelMine.Name = "LabelMine";
            this.LabelMine.Size = new System.Drawing.Size(71, 20);
            this.LabelMine.TabIndex = 8;
            this.LabelMine.Text = "Only me";
            this.LabelMine.Click += new System.EventHandler(this.LabelMine_Click);
            // 
            // LabelAllQuiz
            // 
            this.LabelAllQuiz.AutoSize = true;
            this.LabelAllQuiz.BackColor = System.Drawing.Color.Transparent;
            this.LabelAllQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LabelAllQuiz.ForeColor = System.Drawing.Color.Black;
            this.LabelAllQuiz.Location = new System.Drawing.Point(33, 17);
            this.LabelAllQuiz.Name = "LabelAllQuiz";
            this.LabelAllQuiz.Size = new System.Drawing.Size(28, 20);
            this.LabelAllQuiz.TabIndex = 7;
            this.LabelAllQuiz.Text = "All";
            this.LabelAllQuiz.Click += new System.EventHandler(this.LabelAllQuiz_Click);
            // 
            // RadioButtonOnlyMe
            // 
            this.RadioButtonOnlyMe.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RadioButtonOnlyMe.CheckedState.BorderThickness = 0;
            this.RadioButtonOnlyMe.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RadioButtonOnlyMe.CheckedState.InnerColor = System.Drawing.Color.White;
            this.RadioButtonOnlyMe.CheckedState.Parent = this.RadioButtonOnlyMe;
            this.RadioButtonOnlyMe.Location = new System.Drawing.Point(84, 19);
            this.RadioButtonOnlyMe.Name = "RadioButtonOnlyMe";
            this.RadioButtonOnlyMe.ShadowDecoration.Parent = this.RadioButtonOnlyMe;
            this.RadioButtonOnlyMe.Size = new System.Drawing.Size(20, 20);
            this.RadioButtonOnlyMe.TabIndex = 1;
            this.RadioButtonOnlyMe.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RadioButtonOnlyMe.UncheckedState.BorderThickness = 2;
            this.RadioButtonOnlyMe.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.RadioButtonOnlyMe.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.RadioButtonOnlyMe.UncheckedState.Parent = this.RadioButtonOnlyMe;
            this.RadioButtonOnlyMe.CheckedChanged += new System.EventHandler(this.RadioButtonOnlyMe_CheckedChanged);
            // 
            // RadioButtonAll
            // 
            this.RadioButtonAll.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RadioButtonAll.CheckedState.BorderThickness = 0;
            this.RadioButtonAll.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RadioButtonAll.CheckedState.InnerColor = System.Drawing.Color.White;
            this.RadioButtonAll.CheckedState.Parent = this.RadioButtonAll;
            this.RadioButtonAll.Location = new System.Drawing.Point(7, 19);
            this.RadioButtonAll.Name = "RadioButtonAll";
            this.RadioButtonAll.ShadowDecoration.Parent = this.RadioButtonAll;
            this.RadioButtonAll.Size = new System.Drawing.Size(20, 20);
            this.RadioButtonAll.TabIndex = 0;
            this.RadioButtonAll.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RadioButtonAll.UncheckedState.BorderThickness = 2;
            this.RadioButtonAll.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.RadioButtonAll.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.RadioButtonAll.UncheckedState.Parent = this.RadioButtonAll;
            this.RadioButtonAll.CheckedChanged += new System.EventHandler(this.RadioButtonAll_CheckedChanged);
            // 
            // ButtonStart
            // 
            this.ButtonStart.CheckedState.Parent = this.ButtonStart;
            this.ButtonStart.CustomImages.Parent = this.ButtonStart;
            this.ButtonStart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(128)))), ((int)(((byte)(212)))));
            this.ButtonStart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonStart.ForeColor = System.Drawing.Color.White;
            this.ButtonStart.HoverState.Parent = this.ButtonStart;
            this.ButtonStart.Location = new System.Drawing.Point(766, 595);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.ShadowDecoration.Parent = this.ButtonStart;
            this.ButtonStart.Size = new System.Drawing.Size(139, 45);
            this.ButtonStart.TabIndex = 10;
            this.ButtonStart.Text = "Start Exam";
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // TextBoxQuestionCount
            // 
            this.TextBoxQuestionCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxQuestionCount.DefaultText = "";
            this.TextBoxQuestionCount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxQuestionCount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxQuestionCount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxQuestionCount.DisabledState.Parent = this.TextBoxQuestionCount;
            this.TextBoxQuestionCount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxQuestionCount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxQuestionCount.FocusedState.Parent = this.TextBoxQuestionCount;
            this.TextBoxQuestionCount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxQuestionCount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxQuestionCount.HoverState.Parent = this.TextBoxQuestionCount;
            this.TextBoxQuestionCount.Location = new System.Drawing.Point(44, 595);
            this.TextBoxQuestionCount.Name = "TextBoxQuestionCount";
            this.TextBoxQuestionCount.PasswordChar = '\0';
            this.TextBoxQuestionCount.PlaceholderText = "Total question count 0";
            this.TextBoxQuestionCount.SelectedText = "";
            this.TextBoxQuestionCount.ShadowDecoration.Parent = this.TextBoxQuestionCount;
            this.TextBoxQuestionCount.Size = new System.Drawing.Size(204, 45);
            this.TextBoxQuestionCount.TabIndex = 11;
            // 
            // ButtonBack
            // 
            this.ButtonBack.Image = global::EyeQuiz.Properties.Resources.back_to_light_100px;
            this.ButtonBack.Location = new System.Drawing.Point(19, 19);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(52, 50);
            this.ButtonBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ButtonBack.TabIndex = 6;
            this.ButtonBack.TabStop = false;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            this.ButtonBack.MouseEnter += new System.EventHandler(this.ButtonBack_MouseEnter);
            this.ButtonBack.MouseLeave += new System.EventHandler(this.ButtonBack_MouseLeave);
            // 
            // UCQuizeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.TextBoxQuestionCount);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.PanelFilter);
            this.Controls.Add(this.PanelQuiz);
            this.Controls.Add(this.TextBoxSearch);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PanelQuizeList);
            this.Name = "UCQuizeList";
            this.Size = new System.Drawing.Size(934, 650);
            this.Load += new System.EventHandler(this.UCQuizeList_Load);
            this.PanelQuizeList.ResumeLayout(false);
            this.PanelQuizeList.PerformLayout();
            this.ContextMenuPanel.ResumeLayout(false);
            this.PanelQuiz.ResumeLayout(false);
            this.PanelFilter.ResumeLayout(false);
            this.PanelFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelQuizeList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelQuiz;
        private System.Windows.Forms.Label LabelQuizName;
        private System.Windows.Forms.PictureBox ButtonBack;
        private Guna.UI2.WinForms.Guna2Button ButtonAdd;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxSearch;
        private System.Windows.Forms.Panel PanelFilter;
        private System.Windows.Forms.Label LabelMine;
        private System.Windows.Forms.Label LabelAllQuiz;
        private Guna.UI2.WinForms.Guna2CustomRadioButton RadioButtonOnlyMe;
        private Guna.UI2.WinForms.Guna2CustomRadioButton RadioButtonAll;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button ButtonStart;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxQuestionCount;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip ContextMenuPanel;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
    }
}
