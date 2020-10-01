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
    public partial class FormTutorialA : Form
    {
        public FormTutorialA()
        {
            InitializeComponent();
        }

        private void pictureBoxNext_Click(object sender, EventArgs e)
        {           
            FormTutorialV formV = new FormTutorialV();
            formV.Show();
            this.Close();           
        }
    }
}
