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
    public partial class FormFight : Form
    {
        private FormFound formFound;
        bool alreadyowned = false;
        public FormFight(FormFound formFound)
        {
            InitializeComponent();
            this.formFound = formFound;

        }
        /// <summary>
        /// Using Function Fight() for creature c owned by player and enemy creature 
        /// if fight is won, our creature levels up
        /// If you already have this species, you can fight it but you won't get new creature
        /// </summary>
        /// <param name="type"></param>
        /// <param name="species"></param>
        private void ForFight(string type, int species)
        {
            foreach (Creature c in formFound.formMain.listOfCreatures)
            {
                if (c.type == type & c.species == species)
                {
                    c.Fight(formFound.creature);
                    if (formFound.creature.fightlost == true)
                    {
                        c.level++;
                    }

                }
            }
            foreach (Creature c in formFound.formMain.listOfCreatures)
            {
                if (c.type == formFound.creature.type)
                {
                    if (c.species == formFound.creature.species)
                    {
                        alreadyowned = true;
                    }
                    this.Close();
                }
            }
        }
        /// <summary>
        /// If we won the fight, we get to own the new creature which is added to our list of creatures
        /// </summary>
        private void AddToList()
        {
            if (alreadyowned == false)
            {
                if (formFound.creature.fightlost == true)
                {
                    MessageBox.Show("You won the fight! You can see your new creature in the Inventory! Don't forget to give it a name!");
                    formFound.formMain.listOfCreatures.Add(formFound.creature);
                }
            }
            else if (alreadyowned == true & formFound.creature.fightlost == true)
            {
                MessageBox.Show("You won the fight!");
            }


        }
        /// <summary>
        /// Buttons for all of the possible creatures in the game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAnimal1_Click(object sender, EventArgs e)
        {
            ForFight("fire", 0);           
            AddToList();
            this.Close();
            formFound.Close();
        }

        private void buttonAnimal2_Click(object sender, EventArgs e)
        {
            ForFight("fire", 1);
            AddToList();
            this.Close();
            formFound.Close();
        }

        private void buttonAnimal3_Click(object sender, EventArgs e)
        {
            ForFight("forest", 1);
            AddToList();
            this.Close();
            formFound.Close();
        }

        private void buttonAnimal4_Click(object sender, EventArgs e)
        {
            ForFight("forest", 0);
            AddToList();
            this.Close();
            formFound.Close();
        }

        private void buttonAnimal5_Click(object sender, EventArgs e)
        {
            ForFight("water", 1);
            AddToList();
            this.Close();
            formFound.Close();
        }

        private void buttonAnimal6_Click(object sender, EventArgs e)
        {
            ForFight("water", 0);
            AddToList();
            this.Close();
            formFound.Close();
        }
        /// <summary>
        /// Showing the pictureBoxes of the creatures hidden under empty pictureBoxes
        /// They are revealed when we own them
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormFight_Load(object sender, EventArgs e)
        {
            foreach (Creature c in formFound.formMain.listOfCreatures)
            {
                if (c.type == "fire" & c.species == 0)
                {
                    pictureBox1.Visible = false;

                }
            }
            foreach (Creature c in formFound.formMain.listOfCreatures)
            {
                if (c.type == "fire" & c.species == 1)
                {
                    pictureBox2.Visible = false;

                }
            }
            foreach (Creature c in formFound.formMain.listOfCreatures)
            {
                if (c.type == "forest" & c.species == 0)
                {
                    pictureBox4.Visible = false;

                }
            }
            foreach (Creature c in formFound.formMain.listOfCreatures)
            {
                if (c.type == "forest" & c.species == 1)
                {
                    pictureBox3.Visible = false;

                }
            }
            foreach (Creature c in formFound.formMain.listOfCreatures)
            {
                if (c.type == "water" & c.species == 0)
                {
                    pictureBox6.Visible = false;

                }
            }
            foreach (Creature c in formFound.formMain.listOfCreatures)
            {
                if (c.type == "water" & c.species == 1)
                {
                    pictureBox5.Visible = false;

                }
            }

        }
    }
}
