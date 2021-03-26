
namespace EyeQuiz
{
    partial class Form2
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
            this.PanelUserControls = new System.Windows.Forms.Panel();
            this.PanelFormLeft = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ButtonLogout = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.PictureBoxMinimize = new System.Windows.Forms.PictureBox();
            this.PictureBoxDrag = new System.Windows.Forms.PictureBox();
            this.PanelFormTop = new System.Windows.Forms.Panel();
            this.PanelFormLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxDrag)).BeginInit();
            this.PanelFormTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelUserControls
            // 
            this.PanelUserControls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelUserControls.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PanelUserControls.Location = new System.Drawing.Point(200, 56);
            this.PanelUserControls.Name = "PanelUserControls";
            this.PanelUserControls.Size = new System.Drawing.Size(934, 650);
            this.PanelUserControls.TabIndex = 9;
            // 
            // PanelFormLeft
            // 
            this.PanelFormLeft.Controls.Add(this.label1);
            this.PanelFormLeft.Controls.Add(this.pictureBox1);
            this.PanelFormLeft.Controls.Add(this.ButtonLogout);
            this.PanelFormLeft.Controls.Add(this.ButtonDashboard);
            this.PanelFormLeft.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(128)))), ((int)(((byte)(212)))));
            this.PanelFormLeft.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(128)))), ((int)(((byte)(212)))));
            this.PanelFormLeft.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(128)))), ((int)(((byte)(212)))));
            this.PanelFormLeft.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(128)))), ((int)(((byte)(212)))));
            this.PanelFormLeft.Location = new System.Drawing.Point(-2, 0);
            this.PanelFormLeft.Name = "PanelFormLeft";
            this.PanelFormLeft.ShadowDecoration.Parent = this.PanelFormLeft;
            this.PanelFormLeft.Size = new System.Drawing.Size(200, 711);
            this.PanelFormLeft.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(61, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 35);
            this.label1.TabIndex = 8;
            this.label1.Text = "EyeQuiz";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::EyeQuiz.Properties.Resources.checklist_96px;
            this.pictureBox1.Location = new System.Drawing.Point(0, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // ButtonLogout
            // 
            this.ButtonLogout.CheckedState.Parent = this.ButtonLogout;
            this.ButtonLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonLogout.CustomImages.Parent = this.ButtonLogout;
            this.ButtonLogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(114)))), ((int)(((byte)(207)))));
            this.ButtonLogout.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonLogout.ForeColor = System.Drawing.Color.White;
            this.ButtonLogout.HoverState.Parent = this.ButtonLogout;
            this.ButtonLogout.Location = new System.Drawing.Point(0, 192);
            this.ButtonLogout.Name = "ButtonLogout";
            this.ButtonLogout.ShadowDecoration.Parent = this.ButtonLogout;
            this.ButtonLogout.Size = new System.Drawing.Size(200, 45);
            this.ButtonLogout.TabIndex = 6;
            this.ButtonLogout.Text = "Logout";
            this.ButtonLogout.Click += new System.EventHandler(this.ButtonLogout_Click);
            // 
            // ButtonDashboard
            // 
            this.ButtonDashboard.CheckedState.Parent = this.ButtonDashboard;
            this.ButtonDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDashboard.CustomImages.Parent = this.ButtonDashboard;
            this.ButtonDashboard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(114)))), ((int)(((byte)(207)))));
            this.ButtonDashboard.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonDashboard.ForeColor = System.Drawing.Color.White;
            this.ButtonDashboard.HoverState.Parent = this.ButtonDashboard;
            this.ButtonDashboard.Location = new System.Drawing.Point(0, 147);
            this.ButtonDashboard.Name = "ButtonDashboard";
            this.ButtonDashboard.ShadowDecoration.Parent = this.ButtonDashboard;
            this.ButtonDashboard.Size = new System.Drawing.Size(200, 45);
            this.ButtonDashboard.TabIndex = 5;
            this.ButtonDashboard.Text = "Dashboard";
            this.ButtonDashboard.Click += new System.EventHandler(this.ButtonDashboard_Click);
            // 
            // PictureBoxMinimize
            // 
            this.PictureBoxMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBoxMinimize.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxMinimize.Cursor = System.Windows.Forms.Cursors.Default;
            this.PictureBoxMinimize.Image = global::EyeQuiz.Properties.Resources.macos_minimize_24px;
            this.PictureBoxMinimize.Location = new System.Drawing.Point(894, 9);
            this.PictureBoxMinimize.Name = "PictureBoxMinimize";
            this.PictureBoxMinimize.Size = new System.Drawing.Size(40, 38);
            this.PictureBoxMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxMinimize.TabIndex = 8;
            this.PictureBoxMinimize.TabStop = false;
            this.PictureBoxMinimize.Click += new System.EventHandler(this.PictureBoxMinimize_Click);
            this.PictureBoxMinimize.MouseEnter += new System.EventHandler(this.PictureBoxMinimize_MouseEnter);
            this.PictureBoxMinimize.MouseLeave += new System.EventHandler(this.PictureBoxMinimize_MouseLeave);
            // 
            // PictureBoxDrag
            // 
            this.PictureBoxDrag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBoxDrag.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxDrag.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.PictureBoxDrag.Image = global::EyeQuiz.Properties.Resources.drag_26px;
            this.PictureBoxDrag.Location = new System.Drawing.Point(853, 12);
            this.PictureBoxDrag.Name = "PictureBoxDrag";
            this.PictureBoxDrag.Size = new System.Drawing.Size(36, 33);
            this.PictureBoxDrag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxDrag.TabIndex = 6;
            this.PictureBoxDrag.TabStop = false;
            this.PictureBoxDrag.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBoxDrag_MouseDown);
            this.PictureBoxDrag.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBoxDrag_MouseMove);
            this.PictureBoxDrag.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBoxDrag_MouseUp);
            // 
            // PanelFormTop
            // 
            this.PanelFormTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(40)))));
            this.PanelFormTop.Controls.Add(this.PictureBoxDrag);
            this.PanelFormTop.Controls.Add(this.PictureBoxMinimize);
            this.PanelFormTop.Location = new System.Drawing.Point(198, 0);
            this.PanelFormTop.Name = "PanelFormTop";
            this.PanelFormTop.Size = new System.Drawing.Size(943, 55);
            this.PanelFormTop.TabIndex = 10;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1139, 710);
            this.Controls.Add(this.PanelFormLeft);
            this.Controls.Add(this.PanelUserControls);
            this.Controls.Add(this.PanelFormTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EyeQuiz";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.PanelFormLeft.ResumeLayout(false);
            this.PanelFormLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxDrag)).EndInit();
            this.PanelFormTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxMinimize;
        private System.Windows.Forms.PictureBox PictureBoxDrag;
        private System.Windows.Forms.Panel PanelUserControls;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel PanelFormLeft;
        private Guna.UI2.WinForms.Guna2Button ButtonLogout;
        private Guna.UI2.WinForms.Guna2Button ButtonDashboard;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelFormTop;
    }
}