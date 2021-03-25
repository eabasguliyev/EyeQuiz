
namespace EyeQuiz.UCQuiz
{
    partial class UCDragDrop
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
            ((System.ComponentModel.ISupportInitialize)(this.ButtonBack)).BeginInit();
            this.SuspendLayout();
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
            // UCDragDrop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::EyeQuiz.Properties.Resources.xml_240px;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.ButtonBack);
            this.DoubleBuffered = true;
            this.Name = "UCDragDrop";
            this.Size = new System.Drawing.Size(934, 650);
            this.Load += new System.EventHandler(this.UCDragDrop_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.UCDragDrop_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.UCDragDrop_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.ButtonBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ButtonBack;
    }
}
