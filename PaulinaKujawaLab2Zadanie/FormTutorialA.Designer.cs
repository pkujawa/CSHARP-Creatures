namespace PaulinaKujawaLab2Zadanie
{
    partial class FormTutorialA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTutorialA));
            this.pictureBoxMap = new System.Windows.Forms.PictureBox();
            this.pictureBoxForWork = new System.Windows.Forms.PictureBox();
            this.pictureBoxNext = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForWork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNext)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMap
            // 
            this.pictureBoxMap.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMap.Image")));
            this.pictureBoxMap.Location = new System.Drawing.Point(0, -1);
            this.pictureBoxMap.Name = "pictureBoxMap";
            this.pictureBoxMap.Size = new System.Drawing.Size(1059, 527);
            this.pictureBoxMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMap.TabIndex = 3;
            this.pictureBoxMap.TabStop = false;
            // 
            // pictureBoxForWork
            // 
            this.pictureBoxForWork.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxForWork.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxForWork.Enabled = false;
            this.pictureBoxForWork.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxForWork.Image")));
            this.pictureBoxForWork.Location = new System.Drawing.Point(444, 161);
            this.pictureBoxForWork.Name = "pictureBoxForWork";
            this.pictureBoxForWork.Size = new System.Drawing.Size(165, 116);
            this.pictureBoxForWork.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxForWork.TabIndex = 11;
            this.pictureBoxForWork.TabStop = false;
            // 
            // pictureBoxNext
            // 
            this.pictureBoxNext.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxNext.Image")));
            this.pictureBoxNext.Location = new System.Drawing.Point(946, 433);
            this.pictureBoxNext.Name = "pictureBoxNext";
            this.pictureBoxNext.Size = new System.Drawing.Size(122, 93);
            this.pictureBoxNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxNext.TabIndex = 18;
            this.pictureBoxNext.TabStop = false;
            this.pictureBoxNext.Click += new System.EventHandler(this.pictureBoxNext_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(299, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(355, 26);
            this.label3.TabIndex = 21;
            this.label3.Text = "You are beginning an incredible adventure";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(356, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(503, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "You are looking for magical creatures in 3 different locations.";
            // 
            // FormTutorialA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 522);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBoxNext);
            this.Controls.Add(this.pictureBoxForWork);
            this.Controls.Add(this.pictureBoxMap);
            this.Name = "FormTutorialA";
            this.Text = "FormTutorialA";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForWork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNext)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMap;
        private System.Windows.Forms.PictureBox pictureBoxForWork;
        private System.Windows.Forms.PictureBox pictureBoxNext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}