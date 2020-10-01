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
    public partial class FormTutorial4 : Form
    {
        public FormTutorial4()
        {
            InitializeComponent();
        }

        private void pictureBoxNext_Click(object sender, EventArgs e)
        {
            MessageBox.Show("That's all you have to know. The rest you will discover yourself. Good luck!");
            this.Close();
        }
    }
}
