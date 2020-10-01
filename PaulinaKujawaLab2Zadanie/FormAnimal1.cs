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
    public partial class FormAnimal1 : Form
    {
        Creature creature;
        FormMain formMain;
        public FormAnimal1(Creature c, FormMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;
            this.creature = c;
        }
        /// <summary>
        /// Using the Feed() function for the element of the class
        /// feedLevel is growing, food amount is decreasing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Changing name of the creature using textBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxNameCreature_TextChanged(object sender, EventArgs e)
        {
            creature.name = textBoxNameCreature.Text;
            labelNameA.Text = creature.name;
        }

        private void FormAnimal1_Load(object sender, EventArgs e)
        {
            labelNameA.Text = creature.name;
            labelH.Text = creature.health.ToString();
            labelL.Text = creature.level.ToString();
        }
    }
}
