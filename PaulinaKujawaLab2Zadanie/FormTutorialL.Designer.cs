namespace PaulinaKujawaLab2Zadanie
{
    partial class FormTutorialL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTutorialL));
            this.pictureBoxLake = new System.Windows.Forms.PictureBox();
            this.labelL = new System.Windows.Forms.Label();
            this.pictureBoxNext = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNext)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLake
            // 
            this.pictureBoxLake.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLake.Image")));
            this.pictureBoxLake.Location = new System.Drawing.Point(0, -2);
            this.pictureBoxLake.Name = "pictureBoxLake";
            this.pictureBoxLake.Size = new System.Drawing.Size(1052, 525);
            this.pictureBoxLake.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLake.TabIndex = 1;
            this.pictureBoxLake.TabStop = false;
            // 
            // labelL
            // 
            this.labelL.AutoSize = true;
            this.labelL.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelL.Location = new System.Drawing.Point(376, 297);
            this.labelL.Name = "labelL";
            this.labelL.Size = new System.Drawing.Size(520, 24);
            this.labelL.TabIndex = 2;
            this.labelL.Text = "Searching the lake, you have a chance of finding water creatures";
            // 
            // pictureBoxNext
            // 
            this.pictureBoxNext.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxNext.Image")));
            this.pictureBoxNext.Location = new System.Drawing.Point(939, 430);
            this.pictureBoxNext.Name = "pictureBoxNext";
            this.pictureBoxNext.Size = new System.Drawing.Size(122, 93);
            this.pictureBoxNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxNext.TabIndex = 5;
            this.pictureBoxNext.TabStop = false;
            this.pictureBoxNext.Click += new System.EventHandler(this.pictureBoxNext_Click);
            // 
            // FormTutorialL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 522);
            this.Controls.Add(this.pictureBoxNext);
            this.Controls.Add(this.labelL);
            this.Controls.Add(this.pictureBoxLake);
            this.Name = "FormTutorialL";
            this.Text = "FormTutorialL";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNext)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLake;
        private System.Windows.Forms.Label labelL;
        private System.Windows.Forms.PictureBox pictureBoxNext;
    }
}