namespace PaulinaKujawaLab2Zadanie
{
    partial class FormAnimal1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAnimal1));
            this.pictureBoxA1 = new System.Windows.Forms.PictureBox();
            this.labelH = new System.Windows.Forms.Label();
            this.labelNameA = new System.Windows.Forms.Label();
            this.labelL = new System.Windows.Forms.Label();
            this.labelState = new System.Windows.Forms.Label();
            this.buttonFeed = new System.Windows.Forms.Button();
            this.textBoxNameCreature = new System.Windows.Forms.TextBox();
            this.labelGiveName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxA1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxA1
            // 
            this.pictureBoxA1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxA1.Image")));
            this.pictureBoxA1.Location = new System.Drawing.Point(11, 0);
            this.pictureBoxA1.Name = "pictureBoxA1";
            this.pictureBoxA1.Size = new System.Drawing.Size(598, 469);
            this.pictureBoxA1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxA1.TabIndex = 0;
            this.pictureBoxA1.TabStop = false;
            // 
            // labelH
            // 
            this.labelH.AutoSize = true;
            this.labelH.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelH.Location = new System.Drawing.Point(530, 293);
            this.labelH.Name = "labelH";
            this.labelH.Size = new System.Drawing.Size(40, 20);
            this.labelH.TabIndex = 1;
            this.labelH.Text = "100";
            // 
            // labelNameA
            // 
            this.labelNameA.AutoSize = true;
            this.labelNameA.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameA.Location = new System.Drawing.Point(291, 60);
            this.labelNameA.Name = "labelNameA";
            this.labelNameA.Size = new System.Drawing.Size(23, 24);
            this.labelNameA.TabIndex = 2;
            this.labelNameA.Text = "#";
            // 
            // labelL
            // 
            this.labelL.AutoSize = true;
            this.labelL.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelL.Location = new System.Drawing.Point(530, 380);
            this.labelL.Name = "labelL";
            this.labelL.Size = new System.Drawing.Size(16, 20);
            this.labelL.TabIndex = 3;
            this.labelL.Text = "1";
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelState.Location = new System.Drawing.Point(269, 101);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(45, 20);
            this.labelState.TabIndex = 4;
            this.labelState.Text = "Wild";
            // 
            // buttonFeed
            // 
            this.buttonFeed.Location = new System.Drawing.Point(387, 101);
            this.buttonFeed.Name = "buttonFeed";
            this.buttonFeed.Size = new System.Drawing.Size(75, 23);
            this.buttonFeed.TabIndex = 5;
            this.buttonFeed.Text = "Feed";
            this.buttonFeed.UseVisualStyleBackColor = true;
            this.buttonFeed.Click += new System.EventHandler(this.buttonFeed_Click);
            // 
            // textBoxNameCreature
            // 
            this.textBoxNameCreature.Location = new System.Drawing.Point(42, 104);
            this.textBoxNameCreature.Name = "textBoxNameCreature";
            this.textBoxNameCreature.Size = new System.Drawing.Size(100, 20);
            this.textBoxNameCreature.TabIndex = 6;
            this.textBoxNameCreature.TextChanged += new System.EventHandler(this.textBoxNameCreature_TextChanged);
            // 
            // labelGiveName
            // 
            this.labelGiveName.AutoSize = true;
            this.labelGiveName.Location = new System.Drawing.Point(42, 86);
            this.labelGiveName.Name = "labelGiveName";
            this.labelGiveName.Size = new System.Drawing.Size(100, 13);
            this.labelGiveName.TabIndex = 7;
            this.labelGiveName.Text = "Name your creature";
            // 
            // FormAnimal1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 481);
            this.Controls.Add(this.labelGiveName);
            this.Controls.Add(this.textBoxNameCreature);
            this.Controls.Add(this.buttonFeed);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.labelL);
            this.Controls.Add(this.labelNameA);
            this.Controls.Add(this.labelH);
            this.Controls.Add(this.pictureBoxA1);
            this.Name = "FormAnimal1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormAnimal1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxA1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxA1;
        private System.Windows.Forms.Label labelH;
        private System.Windows.Forms.Label labelNameA;
        private System.Windows.Forms.Label labelL;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Button buttonFeed;
        private System.Windows.Forms.TextBox textBoxNameCreature;
        private System.Windows.Forms.Label labelGiveName;
    }
}