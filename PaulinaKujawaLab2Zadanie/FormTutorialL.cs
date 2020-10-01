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
    public partial class FormTutorialL : Form
    {
        public FormTutorialL()
        {
            InitializeComponent();
        }

        private void pictureBoxNext_Click(object sender, EventArgs e)
        {
            FormTutorialF formF = new FormTutorialF();
            formF.Show();
            this.Close();
        }
    }
}
