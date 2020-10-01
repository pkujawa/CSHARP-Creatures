namespace PaulinaKujawaLab2Zadanie
{
    partial class FormInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInventory));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelMoneyInv = new System.Windows.Forms.Label();
            this.labelFoodI = new System.Windows.Forms.Label();
            this.buttonAnimal1 = new System.Windows.Forms.Button();
            this.buttonAnimal2 = new System.Windows.Forms.Button();
            this.buttonAnimal3 = new System.Windows.Forms.Button();
            this.buttonAnimal4 = new System.Windows.Forms.Button();
            this.buttonAnimal5 = new System.Windows.Forms.Button();
            this.buttonAnimal6 = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(571, 564);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelMoneyInv
            // 
            this.labelMoneyInv.AutoSize = true;
            this.labelMoneyInv.Location = new System.Drawing.Point(132, 53);
            this.labelMoneyInv.Name = "labelMoneyInv";
            this.labelMoneyInv.Size = new System.Drawing.Size(14, 13);
            this.labelMoneyInv.TabIndex = 1;
            this.labelMoneyInv.Text = "#";
            // 
            // labelFoodI
            // 
            this.labelFoodI.AutoSize = true;
            this.labelFoodI.Location = new System.Drawing.Point(511, 62);
            this.labelFoodI.Name = "labelFoodI";
            this.labelFoodI.Size = new System.Drawing.Size(14, 13);
            this.labelFoodI.TabIndex = 2;
            this.labelFoodI.Text = "#";
            // 
            // buttonAnimal1
            // 
            this.buttonAnimal1.Location = new System.Drawing.Point(188, 277);
            this.buttonAnimal1.Name = "buttonAnimal1";
            this.buttonAnimal1.Size = new System.Drawing.Size(85, 56);
            this.buttonAnimal1.TabIndex = 3;
            this.buttonAnimal1.Text = "Animal1";
            this.buttonAnimal1.UseVisualStyleBackColor = true;
            this.buttonAnimal1.Click += new System.EventHandler(this.buttonAnimal1_Click);
            // 
            // buttonAnimal2
            // 
            this.buttonAnimal2.Location = new System.Drawing.Point(312, 277);
            this.buttonAnimal2.Name = "buttonAnimal2";
            this.buttonAnimal2.Size = new System.Drawing.Size(75, 56);
            this.buttonAnimal2.TabIndex = 4;
            this.buttonAnimal2.Text = "Animal2";
            this.buttonAnimal2.UseVisualStyleBackColor = true;
            this.buttonAnimal2.Click += new System.EventHandler(this.buttonAnimal2_Click);
            // 
            // buttonAnimal3
            // 
            this.buttonAnimal3.Location = new System.Drawing.Point(188, 370);
            this.buttonAnimal3.Name = "buttonAnimal3";
            this.buttonAnimal3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonAnimal3.Size = new System.Drawing.Size(85, 71);
            this.buttonAnimal3.TabIndex = 5;
            this.buttonAnimal3.Text = "Animal3";
            this.buttonAnimal3.UseVisualStyleBackColor = true;
            this.buttonAnimal3.Click += new System.EventHandler(this.buttonAnimal3_Click);
            // 
            // buttonAnimal4
            // 
            this.buttonAnimal4.Location = new System.Drawing.Point(312, 362);
            this.buttonAnimal4.Name = "buttonAnimal4";
            this.buttonAnimal4.Size = new System.Drawing.Size(75, 70);
            this.buttonAnimal4.TabIndex = 6;
            this.buttonAnimal4.Text = "Animal4";
            this.buttonAnimal4.UseVisualStyleBackColor = true;
            this.buttonAnimal4.Click += new System.EventHandler(this.buttonAnimal4_Click);
            // 
            // buttonAnimal5
            // 
            this.buttonAnimal5.Location = new System.Drawing.Point(198, 465);
            this.buttonAnimal5.Name = "buttonAnimal5";
            this.buttonAnimal5.Size = new System.Drawing.Size(75, 60);
            this.buttonAnimal5.TabIndex = 7;
            this.buttonAnimal5.Text = "Animal5";
            this.buttonAnimal5.UseVisualStyleBackColor = true;
            this.buttonAnimal5.Click += new System.EventHandler(this.buttonAnimal5_Click);
            // 
            // buttonAnimal6
            // 
            this.buttonAnimal6.Location = new System.Drawing.Point(312, 465);
            this.buttonAnimal6.Name = "buttonAnimal6";
            this.buttonAnimal6.Size = new System.Drawing.Size(75, 60);
            this.buttonAnimal6.TabIndex = 8;
            this.buttonAnimal6.Text = "Animal6";
            this.buttonAnimal6.UseVisualStyleBackColor = true;
            this.buttonAnimal6.Click += new System.EventHandler(this.buttonAnimal6_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(12, 84);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(117, 23);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Save the Money";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoad.Location = new System.Drawing.Point(12, 113);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(117, 23);
            this.buttonLoad.TabIndex = 10;
            this.buttonLoad.Text = "Load the Money";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // FormInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 588);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelFoodI);
            this.Controls.Add(this.labelMoneyInv);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonAnimal1);
            this.Controls.Add(this.buttonAnimal2);
            this.Controls.Add(this.buttonAnimal3);
            this.Controls.Add(this.buttonAnimal4);
            this.Controls.Add(this.buttonAnimal5);
            this.Controls.Add(this.buttonAnimal6);
            this.Name = "FormInventory";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FormInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelMoneyInv;
        private System.Windows.Forms.Label labelFoodI;
        private System.Windows.Forms.Button buttonAnimal1;
        private System.Windows.Forms.Button buttonAnimal2;
        private System.Windows.Forms.Button buttonAnimal3;
        private System.Windows.Forms.Button buttonAnimal4;
        private System.Windows.Forms.Button buttonAnimal5;
        private System.Windows.Forms.Button buttonAnimal6;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
    }
}