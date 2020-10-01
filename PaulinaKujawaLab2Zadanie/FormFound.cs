﻿using System;
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
    public partial class FormFound : Form
    {
        public FormMain formMain;
        public int species;
        bool alreadyowned = false;
        public string type;
        public Creature creature;
        public FormFound(FormMain formMain)
        {
            InitializeComponent();
            Shown += FormFound_Shown;
            this.formMain = formMain;
        }
        /// <summary>
        /// Showing the appropriate pictureBox of the creature - of the proper type and species randomly generated by functions
        /// Creating new element of the class
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormFound_Load(object sender, EventArgs e)
        {
            if (type == "fire")
            {
                labelFoundFire.Visible = true;
                creature = new Creature();

                species = creature.Search();
                switch (species)
                {
                    case 0:
                        pictureBoxFound1.Visible = true;
                        break;
                    case 1:
                        pictureBoxFound2.Visible = true;
                        break;
                }
            }
            else if (type == "forest")
            {
                labelFoundForest.Visible = true;
                creature = new Creature();
                species = creature.Search();
                switch (species)
                {
                    case 0:
                        pictureBoxFound4.Visible = true;
                        break;
                    case 1:
                        pictureBoxFound3.Visible = true;
                        break;
                }
            }
            else
            {
                labelFoundWater.Visible = true;
                creature = new Creature();
                species = creature.Search();
                switch (species)
                {
                    case 0:
                        pictureBoxFound6.Visible = true;
                        break;
                    case 1:
                        pictureBoxFound5.Visible = true;
                        break;
                }
            }
            creature.RandomLevel();
            creature.type = type;
            labelLevelFound.Text = String.Format("Level {0}",creature.level);
        }
        /// <summary>
        /// If creature is Level 1, it is added to our Inventory and we don't have to fight it
        /// If we already own creature of certain type and species - game tells us that and doesn't add new element to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormFound_Shown(object sender, EventArgs e)
        {      
            foreach (Creature c in formMain.listOfCreatures)
            {
                if (c.type == creature.type)
                {
                    if (c.species == creature.species)
                    {
                        MessageBox.Show("You already have this species! You can fight it but it won't join your team.");
                        alreadyowned = true;
                        break;
                    }
                }
            }
            if (alreadyowned == false & creature.level == 1)
            {
                MessageBox.Show("This creature is a new born. You are taking it home without a fight.");
                formMain.listOfCreatures.Add(creature);
                this.Close();
            }

        }
        /// <summary>
        /// We can also ingore the creature
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonIgnore_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You decide to walk past the creature");
            this.Close();
        }

        private void buttonFight_Click(object sender, EventArgs e)
        {
            FormFight formFight = new FormFight(this);
            formFight.Show();
        }
    }
}

