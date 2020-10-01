namespace PaulinaKujawaLab2Zadanie
{
    partial class FormAnimal2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAnimal2));
            this.pictureBoxA2 = new System.Windows.Forms.PictureBox();
            this.labelNameA = new System.Windows.Forms.Label();
            this.labelH = new System.Windows.Forms.Label();
            this.labelL = new System.Windows.Forms.Label();
            this.labelState = new System.Windows.Forms.Label();
            this.buttonFeed = new System.Windows.Forms.Button();
            this.labelGiveName = new System.Windows.Forms.Label();
            this.textBoxNameCreature = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxA2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxA2
            // 
            this.pictureBoxA2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxA2.Image")));
            this.pictureBoxA2.Location = new System.Drawing.Point(12, 2);
            this.pictureBoxA2.Name = "pictureBoxA2";
            this.pictureBoxA2.Size = new System.Drawing.Size(602, 483);
            this.pictureBoxA2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxA2.TabIndex = 1;
            this.pictureBoxA2.TabStop = false;
            // 
            // labelNameA
            // 
            this.labelNameA.AutoSize = true;
            this.labelNameA.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameA.Location = new System.Drawing.Point(297, 57);
            this.labelNameA.Name = "labelNameA";
            this.labelNameA.Size = new System.Drawing.Size(23, 24);
            this.labelNameA.TabIndex = 3;
            this.labelNameA.Text = "#";
            // 
            // labelH
            // 
            this.labelH.AutoSize = true;
            this.labelH.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelH.Location = new System.Drawing.Point(532, 291);
            this.labelH.Name = "labelH";
            this.labelH.Size = new System.Drawing.Size(40, 20);
            this.labelH.TabIndex = 4;
            this.labelH.Text = "100";
            // 
            // labelL
            // 
            this.labelL.AutoSize = true;
            this.labelL.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelL.Location = new System.Drawing.Point(532, 382);
            this.labelL.Name = "labelL";
            this.labelL.Size = new System.Drawing.Size(16, 20);
            this.labelL.TabIndex = 5;
            this.labelL.Text = "1";
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelState.Location = new System.Drawing.Point(275, 106);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(45, 20);
            this.labelState.TabIndex = 9;
            this.labelState.Text = "Wild";
            // 
            // buttonFeed
            // 
            this.buttonFeed.Location = new System.Drawing.Point(387, 105);
            this.buttonFeed.Name = "buttonFeed";
            this.buttonFeed.Size = new System.Drawing.Size(75, 23);
            this.buttonFeed.TabIndex = 10;
            this.buttonFeed.Text = "Feed";
            this.buttonFeed.UseVisualStyleBackColor = true;
            this.buttonFeed.Click += new System.EventHandler(this.buttonFeed_Click);
            // 
            // labelGiveName
            // 
            this.labelGiveName.AutoSize = true;
            this.labelGiveName.Location = new System.Drawing.Point(48, 86);
            this.labelGiveName.Name = "labelGiveName";
            this.labelGiveName.Size = new System.Drawing.Size(100, 13);
            this.labelGiveName.TabIndex = 11;
            this.labelGiveName.Text = "Name your creature";
            // 
            // textBoxNameCreature
            // 
            this.textBoxNameCreature.Location = new System.Drawing.Point(48, 106);
            this.textBoxNameCreature.Name = "textBoxNameCreature";
            this.textBoxNameCreature.Size = new System.Drawing.Size(100, 20);
            this.textBoxNameCreature.TabIndex = 12;
            // 
            // FormAnimal2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 486);
            this.Controls.Add(this.textBoxNameCreature);
            this.Controls.Add(this.labelGiveName);
            this.Controls.Add(this.buttonFeed);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.labelL);
            this.Controls.Add(this.labelH);
            this.Controls.Add(this.labelNameA);
            this.Controls.Add(this.pictureBoxA2);
            this.Name = "FormAnimal2";
            this.Text = "FormAnimal2";
            this.Load += new System.EventHandler(this.FormAnimal2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxA2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxA2;
        private System.Windows.Forms.Label labelNameA;
        private System.Windows.Forms.Label labelH;
        private System.Windows.Forms.Label labelL;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Button buttonFeed;
        private System.Windows.Forms.Label labelGiveName;
        private System.Windows.Forms.TextBox textBoxNameCreature;
    }
}