namespace PaulinaKujawaLab2Zadanie
{
    partial class FormAnimal4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAnimal4));
            this.pictureBoxA4 = new System.Windows.Forms.PictureBox();
            this.labelNameA = new System.Windows.Forms.Label();
            this.labelH = new System.Windows.Forms.Label();
            this.labelL = new System.Windows.Forms.Label();
            this.labelState = new System.Windows.Forms.Label();
            this.buttonFeed = new System.Windows.Forms.Button();
            this.textBoxNameCreature = new System.Windows.Forms.TextBox();
            this.labelGiveName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxA4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxA4
            // 
            this.pictureBoxA4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxA4.Image")));
            this.pictureBoxA4.Location = new System.Drawing.Point(2, 5);
            this.pictureBoxA4.Name = "pictureBoxA4";
            this.pictureBoxA4.Size = new System.Drawing.Size(649, 472);
            this.pictureBoxA4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxA4.TabIndex = 0;
            this.pictureBoxA4.TabStop = false;
            // 
            // labelNameA
            // 
            this.labelNameA.AutoSize = true;
            this.labelNameA.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameA.Location = new System.Drawing.Point(309, 46);
            this.labelNameA.Name = "labelNameA";
            this.labelNameA.Size = new System.Drawing.Size(23, 24);
            this.labelNameA.TabIndex = 5;
            this.labelNameA.Text = "#";
            // 
            // labelH
            // 
            this.labelH.AutoSize = true;
            this.labelH.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelH.Location = new System.Drawing.Point(541, 293);
            this.labelH.Name = "labelH";
            this.labelH.Size = new System.Drawing.Size(40, 20);
            this.labelH.TabIndex = 6;
            this.labelH.Text = "100";
            // 
            // labelL
            // 
            this.labelL.AutoSize = true;
            this.labelL.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelL.Location = new System.Drawing.Point(541, 381);
            this.labelL.Name = "labelL";
            this.labelL.Size = new System.Drawing.Size(16, 20);
            this.labelL.TabIndex = 7;
            this.labelL.Text = "1";
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelState.Location = new System.Drawing.Point(287, 86);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(45, 20);
            this.labelState.TabIndex = 8;
            this.labelState.Text = "Wild";
            // 
            // buttonFeed
            // 
            this.buttonFeed.Location = new System.Drawing.Point(408, 85);
            this.buttonFeed.Name = "buttonFeed";
            this.buttonFeed.Size = new System.Drawing.Size(75, 23);
            this.buttonFeed.TabIndex = 9;
            this.buttonFeed.Text = "Feed";
            this.buttonFeed.UseVisualStyleBackColor = true;
            this.buttonFeed.Click += new System.EventHandler(this.buttonFeed_Click);
            // 
            // textBoxNameCreature
            // 
            this.textBoxNameCreature.Location = new System.Drawing.Point(53, 87);
            this.textBoxNameCreature.Name = "textBoxNameCreature";
            this.textBoxNameCreature.Size = new System.Drawing.Size(100, 20);
            this.textBoxNameCreature.TabIndex = 14;
            this.textBoxNameCreature.TextChanged += new System.EventHandler(this.textBoxNameCreature_TextChanged_1);
            // 
            // labelGiveName
            // 
            this.labelGiveName.AutoSize = true;
            this.labelGiveName.Location = new System.Drawing.Point(53, 67);
            this.labelGiveName.Name = "labelGiveName";
            this.labelGiveName.Size = new System.Drawing.Size(100, 13);
            this.labelGiveName.TabIndex = 13;
            this.labelGiveName.Text = "Name your creature";
            // 
            // FormAnimal4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 480);
            this.Controls.Add(this.textBoxNameCreature);
            this.Controls.Add(this.labelGiveName);
            this.Controls.Add(this.buttonFeed);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.labelL);
            this.Controls.Add(this.labelH);
            this.Controls.Add(this.labelNameA);
            this.Controls.Add(this.pictureBoxA4);
            this.Name = "FormAnimal4";
            this.Text = "FormAnimal4";
            this.Load += new System.EventHandler(this.FormAnimal4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxA4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxA4;
        private System.Windows.Forms.Label labelNameA;
        private System.Windows.Forms.Label labelH;
        private System.Windows.Forms.Label labelL;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Button buttonFeed;
        private System.Windows.Forms.TextBox textBoxNameCreature;
        private System.Windows.Forms.Label labelGiveName;
    }
}