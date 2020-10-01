using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaulinaKujawaLab2Zadanie
{
    public partial class FormTutorial3 : Form
    {
        int click = 0;
        public FormTutorial3()
        {
            InitializeComponent();
        }

        private void pictureBoxNext_Click(object sender, EventArgs e)
        {
            click ++;
            if (click == 1)
            {
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;

            }
            else if (click == 2)
            {
                FormTutorial4 formTutorial4 = new FormTutorial4();
                formTutorial4.Show();
                this.Close();
            }

        }
    }
}
