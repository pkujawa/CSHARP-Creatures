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
    public partial class FormTutorialF : Form
    {
        public FormTutorialF()
        {
            InitializeComponent();
        }

        private void pictureBoxNext_Click(object sender, EventArgs e)
        {
            FormTutorial3 formTutorial2 = new FormTutorial3();
            formTutorial2.Show();
            this.Close();
        }
    }
}
