namespace PaulinaKujawaLab2Zadanie
{
    partial class FormMain
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.pictureBoxMap = new System.Windows.Forms.PictureBox();
            this.buttonInventory = new System.Windows.Forms.Button();
            this.buttonHospital = new System.Windows.Forms.Button();
            this.buttonShop = new System.Windows.Forms.Button();
            this.buttonVulcan = new System.Windows.Forms.Button();
            this.buttonForest1 = new System.Windows.Forms.Button();
            this.buttonForest2 = new System.Windows.Forms.Button();
            this.buttonLake = new System.Windows.Forms.Button();
            this.timerTimeInGame = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxForWork = new System.Windows.Forms.PictureBox();
            this.buttonWork = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForWork)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMap
            // 
            this.pictureBoxMap.Enabled = false;
            this.pictureBoxMap.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMap.Image")));
            this.pictureBoxMap.Location = new System.Drawing.Point(12, -1);
            this.pictureBoxMap.Name = "pictureBoxMap";
            this.pictureBoxMap.Size = new System.Drawing.Size(1679, 837);
            this.pictureBoxMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMap.TabIndex = 0;
            this.pictureBoxMap.TabStop = false;
            // 
            // buttonInventory
            // 
            this.buttonInventory.BackColor = System.Drawing.Color.Transparent;
            this.buttonInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInventory.Location = new System.Drawing.Point(1224, 38);
            this.buttonInventory.Name = "buttonInventory";
            this.buttonInventory.Size = new System.Drawing.Size(101, 82);
            this.buttonInventory.TabIndex = 1;
            this.buttonInventory.Text = "Inventory";
            this.buttonInventory.UseVisualStyleBackColor = false;
            this.buttonInventory.Click += new System.EventHandler(this.buttonInventory_Click);
            // 
            // buttonHospital
            // 
            this.buttonHospital.Location = new System.Drawing.Point(1346, 38);
            this.buttonHospital.Name = "buttonHospital";
            this.buttonHospital.Size = new System.Drawing.Size(111, 87);
            this.buttonHospital.TabIndex = 2;
            this.buttonHospital.Text = "Hospital";
            this.buttonHospital.UseVisualStyleBackColor = true;
            this.buttonHospital.Click += new System.EventHandler(this.buttonHospital_Click);
            // 
            // buttonShop
            // 
            this.buttonShop.Location = new System.Drawing.Point(1485, 34);
            this.buttonShop.Name = "buttonShop";
            this.buttonShop.Size = new System.Drawing.Size(98, 91);
            this.buttonShop.TabIndex = 3;
            this.buttonShop.Text = "Shop";
            this.buttonShop.UseVisualStyleBackColor = true;
            this.buttonShop.Click += new System.EventHandler(this.buttonShop_Click);
            // 
            // buttonVulcan
            // 
            this.buttonVulcan.Location = new System.Drawing.Point(77, 144);
            this.buttonVulcan.Name = "buttonVulcan";
            this.buttonVulcan.Size = new System.Drawing.Size(306, 222);
            this.buttonVulcan.TabIndex = 4;
            this.buttonVulcan.Text = "Vulcan";
            this.buttonVulcan.UseVisualStyleBackColor = true;
            this.buttonVulcan.Click += new System.EventHandler(this.buttonVulcan_Click);
            // 
            // buttonForest1
            // 
            this.buttonForest1.Location = new System.Drawing.Point(26, 417);
            this.buttonForest1.Name = "buttonForest1";
            this.buttonForest1.Size = new System.Drawing.Size(453, 408);
            this.buttonForest1.TabIndex = 5;
            this.buttonForest1.Text = "Forest1";
            this.buttonForest1.UseVisualStyleBackColor = true;
            this.buttonForest1.Click += new System.EventHandler(this.buttonForest1_Click);
            // 
            // buttonForest2
            // 
            this.buttonForest2.Location = new System.Drawing.Point(1432, 381);
            this.buttonForest2.Name = "buttonForest2";
            this.buttonForest2.Size = new System.Drawing.Size(245, 424);
            this.buttonForest2.TabIndex = 6;
            this.buttonForest2.Text = "Forest2";
            this.buttonForest2.UseVisualStyleBackColor = true;
            this.buttonForest2.Click += new System.EventHandler(this.buttonForest2_Click);
            // 
            // buttonLake
            // 
            this.buttonLake.Location = new System.Drawing.Point(677, 570);
            this.buttonLake.Name = "buttonLake";
            this.buttonLake.Size = new System.Drawing.Size(574, 255);
            this.buttonLake.TabIndex = 7;
            this.buttonLake.Text = "Lake";
            this.buttonLake.UseVisualStyleBackColor = true;
            this.buttonLake.Click += new System.EventHandler(this.buttonLake_Click);
            // 
            // timerTimeInGame
            // 
            this.timerTimeInGame.Enabled = true;
            this.timerTimeInGame.Interval = 60000;
            this.timerTimeInGame.Tick += new System.EventHandler(this.timerTimeInGame_Tick);
            // 
            // pictureBoxForWork
            // 
            this.pictureBoxForWork.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxForWork.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxForWork.Enabled = false;
            this.pictureBoxForWork.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxForWork.Image")));
            this.pictureBoxForWork.Location = new System.Drawing.Point(720, 257);
            this.pictureBoxForWork.Name = "pictureBoxForWork";
            this.pictureBoxForWork.Size = new System.Drawing.Size(252, 195);
            this.pictureBoxForWork.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxForWork.TabIndex = 8;
            this.pictureBoxForWork.TabStop = false;
            // 
            // buttonWork
            // 
            this.buttonWork.Location = new System.Drawing.Point(807, 291);
            this.buttonWork.Name = "buttonWork";
            this.buttonWork.Size = new System.Drawing.Size(102, 97);
            this.buttonWork.TabIndex = 9;
            this.buttonWork.Text = "Care";
            this.buttonWork.UseVisualStyleBackColor = true;
            this.buttonWork.Click += new System.EventHandler(this.buttonWork_Click_1);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1703, 848);
            this.Controls.Add(this.pictureBoxForWork);
            this.Controls.Add(this.buttonWork);
            this.Controls.Add(this.pictureBoxMap);
            this.Controls.Add(this.buttonInventory);
            this.Controls.Add(this.buttonHospital);
            this.Controls.Add(this.buttonShop);
            this.Controls.Add(this.buttonForest2);
            this.Controls.Add(this.buttonVulcan);
            this.Controls.Add(this.buttonForest1);
            this.Controls.Add(this.buttonLake);
            this.Name = "FormMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForWork)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBoxMap;
        private System.Windows.Forms.Button buttonInventory;
        private System.Windows.Forms.Button buttonHospital;
        private System.Windows.Forms.Button buttonShop;
        private System.Windows.Forms.Button buttonVulcan;
        private System.Windows.Forms.Button buttonForest1;
        private System.Windows.Forms.Button buttonForest2;
        private System.Windows.Forms.Button buttonLake;
        private System.Windows.Forms.Timer timerTimeInGame;
        private System.Windows.Forms.PictureBox pictureBoxForWork;
        private System.Windows.Forms.Button buttonWork;
    }
}

