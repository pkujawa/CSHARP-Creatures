namespace PaulinaKujawaLab2Zadanie
{
    partial class FormAnimal6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAnimal6));
            this.pictureBoxA6 = new System.Windows.Forms.PictureBox();
            this.labelNameA = new System.Windows.Forms.Label();
            this.labelH = new System.Windows.Forms.Label();
            this.labelL = new System.Windows.Forms.Label();
            this.labelState = new System.Windows.Forms.Label();
            this.buttonFeed = new System.Windows.Forms.Button();
            this.textBoxNameCreature = new System.Windows.Forms.TextBox();
            this.labelGiveName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxA6)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxA6
            // 
            this.pictureBoxA6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxA6.Image")));
            this.pictureBoxA6.Location = new System.Drawing.Point(-2, -2);
            this.pictureBoxA6.Name = "pictureBoxA6";
            this.pictureBoxA6.Size = new System.Drawing.Size(640, 486);
            this.pictureBoxA6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxA6.TabIndex = 0;
            this.pictureBoxA6.TabStop = false;
            // 
            // labelNameA
            // 
            this.labelNameA.AutoSize = true;
            this.labelNameA.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameA.Location = new System.Drawing.Point(304, 43);
            this.labelNameA.Name = "labelNameA";
            this.labelNameA.Size = new System.Drawing.Size(23, 24);
            this.labelNameA.TabIndex = 7;
            this.labelNameA.Text = "#";
            // 
            // labelH
            // 
            this.labelH.AutoSize = true;
            this.labelH.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelH.Location = new System.Drawing.Point(564, 292);
            this.labelH.Name = "labelH";
            this.labelH.Size = new System.Drawing.Size(40, 20);
            this.labelH.TabIndex = 8;
            this.labelH.Text = "100";
            // 
            // labelL
            // 
            this.labelL.AutoSize = true;
            this.labelL.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelL.Location = new System.Drawing.Point(564, 383);
            this.labelL.Name = "labelL";
            this.labelL.Size = new System.Drawing.Size(16, 20);
            this.labelL.TabIndex = 9;
            this.labelL.Text = "1";
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelState.Location = new System.Drawing.Point(282, 94);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(45, 20);
            this.labelState.TabIndex = 10;
            this.labelState.Text = "Wild";
            // 
            // buttonFeed
            // 
            this.buttonFeed.Location = new System.Drawing.Point(407, 93);
            this.buttonFeed.Name = "buttonFeed";
            this.buttonFeed.Size = new System.Drawing.Size(75, 23);
            this.buttonFeed.TabIndex = 11;
            this.buttonFeed.Text = "Feed";
            this.buttonFeed.UseVisualStyleBackColor = true;
            this.buttonFeed.Click += new System.EventHandler(this.buttonFeed_Click);
            // 
            // textBoxNameCreature
            // 
            this.textBoxNameCreature.Location = new System.Drawing.Point(50, 91);
            this.textBoxNameCreature.Name = "textBoxNameCreature";
            this.textBoxNameCreature.Size = new System.Drawing.Size(100, 20);
            this.textBoxNameCreature.TabIndex = 14;
            this.textBoxNameCreature.TextChanged += new System.EventHandler(this.textBoxNameCreature_TextChanged_1);
            // 
            // labelGiveName
            // 
            this.labelGiveName.AutoSize = true;
            this.labelGiveName.Location = new System.Drawing.Point(50, 71);
            this.labelGiveName.Name = "labelGiveName";
            this.labelGiveName.Size = new System.Drawing.Size(100, 13);
            this.labelGiveName.TabIndex = 13;
            this.labelGiveName.Text = "Name your creature";
            // 
            // FormAnimal6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 485);
            this.Controls.Add(this.textBoxNameCreature);
            this.Controls.Add(this.labelGiveName);
            this.Controls.Add(this.buttonFeed);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.labelL);
            this.Controls.Add(this.labelH);
            this.Controls.Add(this.labelNameA);
            this.Controls.Add(this.pictureBoxA6);
            this.Name = "FormAnimal6";
            this.Text = "FormAnimal6";
            this.Load += new System.EventHandler(this.FormAnimal6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxA6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxA6;
        private System.Windows.Forms.Label labelNameA;
        private System.Windows.Forms.Label labelH;
        private System.Windows.Forms.Label labelL;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Button buttonFeed;
        private System.Windows.Forms.TextBox textBoxNameCreature;
        private System.Windows.Forms.Label labelGiveName;
    }
}