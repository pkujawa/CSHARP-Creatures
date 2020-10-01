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
    public partial class FormHospital : Form
    {
        private FormMain formMain;
        public FormHospital(FormMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;
        }
        /// <summary>
        /// Healing all our creatures to max (100)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRestore_Click(object sender, EventArgs e)
        {
            foreach (Creature c in formMain.listOfCreatures)
            {
                c.RestoreHealth();
            }
            MessageBox.Show("All of your creatures have been healed.");
            this.Close();
        }
    }
}
