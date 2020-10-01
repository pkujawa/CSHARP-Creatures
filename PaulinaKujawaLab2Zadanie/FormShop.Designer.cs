namespace PaulinaKujawaLab2Zadanie
{
    partial class FormShop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormShop));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonBuyFood = new System.Windows.Forms.Button();
            this.labelMoneyShop = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(692, 483);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonBuyFood
            // 
            this.buttonBuyFood.Location = new System.Drawing.Point(493, 156);
            this.buttonBuyFood.Name = "buttonBuyFood";
            this.buttonBuyFood.Size = new System.Drawing.Size(75, 23);
            this.buttonBuyFood.TabIndex = 1;
            this.buttonBuyFood.Text = "Buy Food";
            this.buttonBuyFood.UseVisualStyleBackColor = true;
            this.buttonBuyFood.Click += new System.EventHandler(this.buttonBuyFood_Click);
            // 
            // labelMoneyShop
            // 
            this.labelMoneyShop.AutoSize = true;
            this.labelMoneyShop.Location = new System.Drawing.Point(505, 49);
            this.labelMoneyShop.Name = "labelMoneyShop";
            this.labelMoneyShop.Size = new System.Drawing.Size(14, 13);
            this.labelMoneyShop.TabIndex = 2;
            this.labelMoneyShop.Text = "#";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(398, 207);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 28);
            this.label14.TabIndex = 3;
            this.label14.Text = "14";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(403, 294);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(212, 162);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // FormShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 486);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.labelMoneyShop);
            this.Controls.Add(this.buttonBuyFood);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormShop";
            this.Text = "FormShop";
            this.Load += new System.EventHandler(this.FormShop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonBuyFood;
        private System.Windows.Forms.Label labelMoneyShop;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}