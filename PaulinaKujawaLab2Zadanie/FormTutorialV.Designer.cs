namespace PaulinaKujawaLab2Zadanie
{
    partial class FormTutorialV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTutorialV));
            this.pictureBoxVulc = new System.Windows.Forms.PictureBox();
            this.labelV = new System.Windows.Forms.Label();
            this.pictureBoxNext = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVulc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNext)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxVulc
            // 
            this.pictureBoxVulc.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxVulc.Image")));
            this.pictureBoxVulc.Location = new System.Drawing.Point(-4, -8);
            this.pictureBoxVulc.Name = "pictureBoxVulc";
            this.pictureBoxVulc.Size = new System.Drawing.Size(1052, 525);
            this.pictureBoxVulc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxVulc.TabIndex = 0;
            this.pictureBoxVulc.TabStop = false;
            // 
            // labelV
            // 
            this.labelV.AutoSize = true;
            this.labelV.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelV.Location = new System.Drawing.Point(221, 104);
            this.labelV.Name = "labelV";
            this.labelV.Size = new System.Drawing.Size(456, 24);
            this.labelV.TabIndex = 1;
            this.labelV.Text = "While searching the vulcano, you can find fire creatures";
            // 
            // pictureBoxNext
            // 
            this.pictureBoxNext.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxNext.Image")));
            this.pictureBoxNext.Location = new System.Drawing.Point(935, 424);
            this.pictureBoxNext.Name = "pictureBoxNext";
            this.pictureBoxNext.Size = new System.Drawing.Size(122, 93);
            this.pictureBoxNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxNext.TabIndex = 5;
            this.pictureBoxNext.TabStop = false;
            this.pictureBoxNext.Click += new System.EventHandler(this.pictureBoxNext_Click);
            // 
            // FormTutorialV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 516);
            this.Controls.Add(this.pictureBoxNext);
            this.Controls.Add(this.labelV);
            this.Controls.Add(this.pictureBoxVulc);
            this.Name = "FormTutorialV";
            this.Text = "FormTutorialV";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVulc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNext)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxVulc;
        private System.Windows.Forms.Label labelV;
        private System.Windows.Forms.PictureBox pictureBoxNext;
    }
}