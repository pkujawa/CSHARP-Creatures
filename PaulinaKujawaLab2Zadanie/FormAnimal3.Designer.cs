namespace PaulinaKujawaLab2Zadanie
{
    partial class FormAnimal3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAnimal3));
            this.pictureBoxA3 = new System.Windows.Forms.PictureBox();
            this.labelNameA = new System.Windows.Forms.Label();
            this.labelH = new System.Windows.Forms.Label();
            this.labelL = new System.Windows.Forms.Label();
            this.buttonFeed = new System.Windows.Forms.Button();
            this.labelState = new System.Windows.Forms.Label();
            this.textBoxNameCreature = new System.Windows.Forms.TextBox();
            this.labelGiveName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxA3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxA3
            // 
            this.pictureBoxA3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxA3.Image")));
            this.pictureBoxA3.Location = new System.Drawing.Point(12, 2);
            this.pictureBoxA3.Name = "pictureBoxA3";
            this.pictureBoxA3.Size = new System.Drawing.Size(640, 477);
            this.pictureBoxA3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxA3.TabIndex = 1;
            this.pictureBoxA3.TabStop = false;
            // 
            // labelNameA
            // 
            this.labelNameA.AutoSize = true;
            this.labelNameA.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameA.Location = new System.Drawing.Point(313, 47);
            this.labelNameA.Name = "labelNameA";
            this.labelNameA.Size = new System.Drawing.Size(23, 24);
            this.labelNameA.TabIndex = 4;
            this.labelNameA.Text = "#";
            // 
            // labelH
            // 
            this.labelH.AutoSize = true;
            this.labelH.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelH.Location = new System.Drawing.Point(547, 292);
            this.labelH.Name = "labelH";
            this.labelH.Size = new System.Drawing.Size(40, 20);
            this.labelH.TabIndex = 5;
            this.labelH.Text = "100";
            // 
            // labelL
            // 
            this.labelL.AutoSize = true;
            this.labelL.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelL.Location = new System.Drawing.Point(547, 394);
            this.labelL.Name = "labelL";
            this.labelL.Size = new System.Drawing.Size(16, 20);
            this.labelL.TabIndex = 6;
            this.labelL.Text = "1";
            // 
            // buttonFeed
            // 
            this.buttonFeed.Location = new System.Drawing.Point(434, 91);
            this.buttonFeed.Name = "buttonFeed";
            this.buttonFeed.Size = new System.Drawing.Size(75, 23);
            this.buttonFeed.TabIndex = 10;
            this.buttonFeed.Text = "Feed";
            this.buttonFeed.UseVisualStyleBackColor = true;
            this.buttonFeed.Click += new System.EventHandler(this.buttonFeed_Click);
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelState.Location = new System.Drawing.Point(291, 92);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(45, 20);
            this.labelState.TabIndex = 11;
            this.labelState.Text = "Wild";
            // 
            // textBoxNameCreature
            // 
            this.textBoxNameCreature.Location = new System.Drawing.Point(57, 94);
            this.textBoxNameCreature.Name = "textBoxNameCreature";
            this.textBoxNameCreature.Size = new System.Drawing.Size(100, 20);
            this.textBoxNameCreature.TabIndex = 14;
            this.textBoxNameCreature.TextChanged += new System.EventHandler(this.textBoxNameCreature_TextChanged_1);
            // 
            // labelGiveName
            // 
            this.labelGiveName.AutoSize = true;
            this.labelGiveName.Location = new System.Drawing.Point(57, 74);
            this.labelGiveName.Name = "labelGiveName";
            this.labelGiveName.Size = new System.Drawing.Size(100, 13);
            this.labelGiveName.TabIndex = 13;
            this.labelGiveName.Text = "Name your creature";
            // 
            // FormAnimal3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 482);
            this.Controls.Add(this.textBoxNameCreature);
            this.Controls.Add(this.labelGiveName);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.buttonFeed);
            this.Controls.Add(this.labelL);
            this.Controls.Add(this.labelH);
            this.Controls.Add(this.labelNameA);
            this.Controls.Add(this.pictureBoxA3);
            this.Name = "FormAnimal3";
            this.Text = "FormAnimal3";
            this.Load += new System.EventHandler(this.FormAnimal3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxA3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxA3;
        private System.Windows.Forms.Label labelNameA;
        private System.Windows.Forms.Label labelH;
        private System.Windows.Forms.Label labelL;
        private System.Windows.Forms.Button buttonFeed;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.TextBox textBoxNameCreature;
        private System.Windows.Forms.Label labelGiveName;
    }
}