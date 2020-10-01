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
    public partial class FormAnimal6 : Form
    {
        FormMain formMain;
        Creature creature;
        public FormAnimal6(Creature c, FormMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;
            this.creature = c;
        }

        private void buttonFeed_Click(object sender, EventArgs e)
        {
            if (formMain.variables.food >= 0)
            {
                creature.Feed();
                labelState.Text = creature.trustLevel;
                formMain.variables.food--;
            }
            else
            {
                MessageBox.Show("You don't have any food!");
            }
        }

        private void textBoxNameCreature_TextChanged_1(object sender, EventArgs e)
        {
            creature.name = textBoxNameCreature.Text;
            labelNameA.Text = creature.name;
        }

        private void FormAnimal6_Load(object sender, EventArgs e)
        {
            labelNameA.Text = creature.name;
            labelH.Text = creature.health.ToString();
            labelL.Text = creature.level.ToString();
        }
    }
}
