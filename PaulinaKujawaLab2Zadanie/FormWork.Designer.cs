namespace PaulinaKujawaLab2Zadanie
{
    partial class FormWork
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWork));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.labelMoneyEarnedV = new System.Windows.Forms.Label();
            this.labelTimeSpentV = new System.Windows.Forms.Label();
            this.labelTimeSpent = new System.Windows.Forms.Label();
            this.labelMoneyEarned = new System.Windows.Forms.Label();
            this.timerTimeOfWork = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(623, 476);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(246, 59);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(108, 44);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start working";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStop.Location = new System.Drawing.Point(246, 109);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonStop.Size = new System.Drawing.Size(108, 44);
            this.buttonStop.TabIndex = 2;
            this.buttonStop.Text = "Stop working";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // labelMoneyEarnedV
            // 
            this.labelMoneyEarnedV.AutoSize = true;
            this.labelMoneyEarnedV.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMoneyEarnedV.Location = new System.Drawing.Point(331, 223);
            this.labelMoneyEarnedV.Name = "labelMoneyEarnedV";
            this.labelMoneyEarnedV.Size = new System.Drawing.Size(19, 20);
            this.labelMoneyEarnedV.TabIndex = 3;
            this.labelMoneyEarnedV.Text = "#";
            // 
            // labelTimeSpentV
            // 
            this.labelTimeSpentV.AutoSize = true;
            this.labelTimeSpentV.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeSpentV.Location = new System.Drawing.Point(331, 314);
            this.labelTimeSpentV.Name = "labelTimeSpentV";
            this.labelTimeSpentV.Size = new System.Drawing.Size(19, 20);
            this.labelTimeSpentV.TabIndex = 4;
            this.labelTimeSpentV.Text = "#";
            // 
            // labelTimeSpent
            // 
            this.labelTimeSpent.AutoSize = true;
            this.labelTimeSpent.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeSpent.Location = new System.Drawing.Point(33, 314);
            this.labelTimeSpent.Name = "labelTimeSpent";
            this.labelTimeSpent.Size = new System.Drawing.Size(84, 20);
            this.labelTimeSpent.TabIndex = 5;
            this.labelTimeSpent.Text = "Time Spent";
            // 
            // labelMoneyEarned
            // 
            this.labelMoneyEarned.AutoSize = true;
            this.labelMoneyEarned.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMoneyEarned.Location = new System.Drawing.Point(33, 223);
            this.labelMoneyEarned.Name = "labelMoneyEarned";
            this.labelMoneyEarned.Size = new System.Drawing.Size(105, 20);
            this.labelMoneyEarned.TabIndex = 6;
            this.labelMoneyEarned.Text = "Money Earned";
            // 
            // timerTimeOfWork
            // 
            this.timerTimeOfWork.Enabled = true;
            this.timerTimeOfWork.Interval = 1000;
            this.timerTimeOfWork.Tick += new System.EventHandler(this.timerTimeOfWork_Tick_1);
            // 
            // FormWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 450);
            this.Controls.Add(this.labelMoneyEarned);
            this.Controls.Add(this.labelTimeSpent);
            this.Controls.Add(this.labelTimeSpentV);
            this.Controls.Add(this.labelMoneyEarnedV);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormWork";
            this.Text = "FormCare";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label labelMoneyEarnedV;
        private System.Windows.Forms.Label labelTimeSpentV;
        private System.Windows.Forms.Label labelTimeSpent;
        private System.Windows.Forms.Label labelMoneyEarned;
        private System.Windows.Forms.Timer timerTimeOfWork;
    }
}