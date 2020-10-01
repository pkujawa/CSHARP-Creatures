namespace PaulinaKujawaLab2Zadanie
{
    partial class FormTutorialF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTutorialF));
            this.pictureBoxF = new System.Windows.Forms.PictureBox();
            this.labelF = new System.Windows.Forms.Label();
            this.pictureBoxNext = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNext)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxF
            // 
            this.pictureBoxF.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxF.Image")));
            this.pictureBoxF.Location = new System.Drawing.Point(-5, 0);
            this.pictureBoxF.Name = "pictureBoxF";
            this.pictureBoxF.Size = new System.Drawing.Size(1059, 525);
            this.pictureBoxF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxF.TabIndex = 2;
            this.pictureBoxF.TabStop = false;
            // 
            // labelF
            // 
            this.labelF.AutoSize = true;
            this.labelF.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelF.Location = new System.Drawing.Point(250, 207);
            this.labelF.Name = "labelF";
            this.labelF.Size = new System.Drawing.Size(605, 24);
            this.labelF.TabIndex = 3;
            this.labelF.Text = "While searching forests, you might get a chance of finding forest creatures";
            // 
            // pictureBoxNext
            // 
            this.pictureBoxNext.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxNext.Image")));
            this.pictureBoxNext.Location = new System.Drawing.Point(932, 432);
            this.pictureBoxNext.Name = "pictureBoxNext";
            this.pictureBoxNext.Size = new System.Drawing.Size(122, 93);
            this.pictureBoxNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxNext.TabIndex = 4;
            this.pictureBoxNext.TabStop = false;
            this.pictureBoxNext.Click += new System.EventHandler(this.pictureBoxNext_Click);
            // 
            // FormTutorialF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 525);
            this.Controls.Add(this.pictureBoxNext);
            this.Controls.Add(this.labelF);
            this.Controls.Add(this.pictureBoxF);
            this.Name = "FormTutorialF";
            this.Text = "FormTutorialF";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNext)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxF;
        private System.Windows.Forms.Label labelF;
        private System.Windows.Forms.PictureBox pictureBoxNext;
    }
}