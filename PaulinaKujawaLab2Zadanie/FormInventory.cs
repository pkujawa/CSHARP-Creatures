using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaulinaKujawaLab2Zadanie
{
    public partial class FormInventory : Form
    {
        public int money;

        private FormMain formMain;
        public FormInventory(FormMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;
        }
        /// <summary>
        /// Buttons leading to forms for proper creatures - of the specific type and soecies
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAnimal1_Click(object sender, EventArgs e)
        {
            foreach (Creature c in formMain.listOfCreatures)
            {
                if (c.type == "fire" & c.species == 0)
                {
                    FormAnimal1 formanimal1 = new FormAnimal1(c, formMain);
                    formanimal1.Show();
                }
            }
        }

        private void buttonAnimal2_Click(object sender, EventArgs e)
        {
            foreach (Creature c in formMain.listOfCreatures)
            {
                if (c.type == "fire" & c.species == 1)
                {
                    FormAnimal2 formanimal2 = new FormAnimal2(c, formMain);
                    formanimal2.Show();
                }
            }
        }

        private void buttonAnimal3_Click(object sender, EventArgs e)
        {
            foreach (Creature c in formMain.listOfCreatures)
            {
                if (c.type == "forest" & c.species == 1)
                {
                    FormAnimal3 formanimal3 = new FormAnimal3(c, formMain);
                    formanimal3.Show();
                }
            }
        }

        private void buttonAnimal4_Click(object sender, EventArgs e)
        {
            foreach (Creature c in formMain.listOfCreatures)
            {
                if (c.type == "forest" & c.species == 0)
                {
                    FormAnimal4 formanimal4 = new FormAnimal4(c, formMain);
                    formanimal4.Show();
                }
            }
        }

        private void buttonAnimal5_Click(object sender, EventArgs e)
        {
            foreach (Creature c in formMain.listOfCreatures)
            {
                if (c.type == "water" & c.species == 1)
                {
                    FormAnimal5 formanimal5 = new FormAnimal5(c, formMain);
                    formanimal5.Show();
                }
            }
        }

        private void buttonAnimal6_Click(object sender, EventArgs e)
        {
            foreach (Creature c in formMain.listOfCreatures)
            {
                if (c.type == "water" & c.species == 0)
                {
                    FormAnimal6 formanimal6 = new FormAnimal6(c, formMain);
                    formanimal6.Show();
                }
            }
        }
        /// <summary>
        /// Taking amounts of food and money from FormMain
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormInventory_Load(object sender, EventArgs e)
        {
            labelMoneyInv.Text = formMain.variables.money.ToString();
            labelFoodI.Text = formMain.variables.food.ToString();
        }
        /// <summary>
        /// Saving the amount of money
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("money.txt"))
            {
                writer.Write(formMain.variables.money.ToString());
            }
        }
        /// <summary>
        /// Loading the amount of money
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader("money.txt"))
            {
                if ("money.txt".Length > 0)
                {
                    formMain.variables.money = Int32.Parse(reader.ReadLine());
                    labelMoneyInv.Text = formMain.variables.money.ToString();
                }
            }
        } 
    }
}
