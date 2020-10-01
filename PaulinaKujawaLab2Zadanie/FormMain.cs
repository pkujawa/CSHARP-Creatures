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
    public partial class FormMain : Form
    {
        public Variables variables = new Variables();
        public List<Creature> listOfCreatures = new List<Creature>();
        string type = "";
        /// <summary>
        /// Opening the tutorial - if players wants it
        /// </summary>
  
        public FormMain()
        {
            InitializeComponent();
            if (MessageBox.Show("", "Quick tutorial?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                FormTutorialA formTutorial1 = new FormTutorialA();
                formTutorial1.Show();
                formTutorial1.TopMost = true;
            }

        }
        /// <summary>
        /// Opening Inventory
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonInventory_Click(object sender, EventArgs e)
        {
            FormInventory inventory = new FormInventory(this);
            inventory.Show();
        }
        /// <summary>
        /// Opening Shop
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShop_Click(object sender, EventArgs e)
        {
            FormShop formShop = new FormShop(this);
            formShop.Show();
        }
        /// <summary>
        /// Opening Hospital
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHospital_Click(object sender, EventArgs e)
        {
            FormHospital formHospital = new FormHospital(this);
            formHospital.Show();

        }
        /// <summary>
        /// Searching Vulcano and using teh function Search() to check if players got the luck to find anything at all; then it sets type to "fire" since it was found in the Vulcano
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonVulcan_Click(object sender, EventArgs e)
        {
            Location location = new Location();           
            if (location.Search() == true)
            {
                type = "fire";
                FormFound formFound = new FormFound(this);
                formFound.type = type;
                formFound.Show();
            }
            
        }
        /// <summary>
        /// Searching Forest and setting the type to "forest"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonForest1_Click(object sender, EventArgs e)
        {
            Location location = new Location();
            if (location.Search() == true)
            {
                type = "forest";
                FormFound formFound = new FormFound(this);
                formFound.type = type;
                formFound.Show();
            }

        }
        /// <summary>
        /// Searching the forest and setting the type to "forest"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonForest2_Click(object sender, EventArgs e)
        {
            Location location = new Location();
            if (location.Search() == true)
            {
                type = "forest";
                FormFound formFound = new FormFound(this);
                formFound.type = type;
                formFound.Show();
            }

        }
        /// <summary>
        /// Searching the lake and setting the type to "lake"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLake_Click(object sender, EventArgs e)
        {
            Location location = new Location();
            if (location.Search() == true)
            {
                type = "water";
                FormFound formFound = new FormFound(this);
                formFound.type = type;
                formFound.Show();
            }

        }
        /// <summary>
        /// Opening Work
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonWork_Click_1(object sender, EventArgs e)
        {
            FormWork formWork = new FormWork(this);
            formWork.Show();
        }
        /// <summary>
        /// Timer for function checking every minute if the creature is escaping or not
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerTimeInGame_Tick(object sender, EventArgs e)
        {
            timerTimeInGame.Stop();
            foreach (Creature c in listOfCreatures)
            {
                c.GetAway();
            }
            listOfCreatures.RemoveAll(c => c.owned == false);
            timerTimeInGame.Start();
        }
    }
}
