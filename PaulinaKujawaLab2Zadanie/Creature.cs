using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaulinaKujawaLab2Zadanie
{
    public class Creature : ICreature
    {
        // variable saying if we stil own the creature or if it escaped
        public bool owned = true; 
        // species of creature
        public int species;
        // if fight was won or lost
        public bool fightlost = false;
        // types are: "fire", "water" and "forest"
        public string type = "";
        // name of creature which will be given by its owner
        public string name = "";
        // level of creature - creture is found with random level 1 - 10 and it levels up after every won fight
        public int level;
        // health of creature - it drops to 0 after every fight and can be healed fully in Hospital
        public int health = 100;
        // feedLevel grows while player is feeding the creature.
        protected int feedLevel = 0;
        // trustLevel depends on the feedlevel, low truslevel leads to big chance of losing the creature
        public string trustLevel = "Wild";
        // used in random fuction for escaping probability
        int escapeProbability = 0;
        Random random = new Random();
        // dominance used in fight algorithm; 
        double dominance = 0;
        /// <summary>
        /// Feeding teh creature; feedLevel grows evey time teh creature is being fed
        /// trustLevel changes depending on the feedLevel
        /// </summary>
        public void Feed()
        {
            feedLevel++;
            if (feedLevel == 10)
            {
                trustLevel = "Aloof";
            }
            else if (feedLevel == 30)
            {
                trustLevel = "Affectionate";
            }
        }
        /// <summary>
        /// Random function 1:1 leading to finding species 0 or species 1 of the creature
        /// </summary>
        /// <returns></returns>
        public int Search()
        {
            Random animal = new Random();
            species = animal.Next(2);
            return species;
        }
        /// <summary>
        /// Random function leading to escaping of the creature - or not
        /// The chance depends on the trustLevel
        /// </summary>
        public void GetAway()
        {
            if (this.trustLevel == "Wild")
            {
                escapeProbability = 8;
            }
            if (this.trustLevel == "Aloof")
            {
                escapeProbability = 3;
            }
            if (this.trustLevel == "Affectionate")
            {
                escapeProbability = 0;
            }
            int risk = random.Next(10);
            if (risk < escapeProbability)
            {
                MessageBox.Show(string.Format("Your creature {0} has escaped! You have to take better care of your creatures.", name));
                owned = false;
            }

        }
        /// <summary>
        /// Rastoring health of the creature
        /// </summary>
        public void RestoreHealth()
        {
            health = 100;
        }
        /// <summary>
        /// Function for fight - taking into the account the dominance       
        /// </summary>
        /// <param name="enemy"></param>
        public void Fight(Creature enemy)
        {
            if (this.health == 0)
            {
                MessageBox.Show("This creature does not have enough health to fight!");
            }
            else
            {
                this.Dominance(enemy);
                enemy.Dominance(this);

                if (this.level + this.dominance*this.level>= enemy.level + enemy.dominance * enemy.level)
                {
                    this.health = 0;
                    enemy.fightlost = true;
                }
                else
                {
                    MessageBox.Show("You lost a fight.");
                    this.health = 0;
                    enemy.fightlost = false;
                }
            }

        }
        /// <summary>
        /// Dominance - fire is stronger than forest; water than fire and forest than water
        /// The dominance is influencing the result of the fight
        /// </summary>
        /// <param name="enemy"></param>
        public void Dominance(Creature enemy)
        {
            if (this.type == "water" & enemy.type == "fire")
            {
                this.dominance = 0.25;
            }
            else if (this.type == "forest" & enemy.type == "water")
            {
                this.dominance = 0.25;
            }
            else if (this.type == "fire" & enemy.type == "forest")
            {
                this.dominance = 0.25;
            }
            else if (this.type == enemy.type)
            {
                this.dominance = 0;
            }
        }
        /// <summary>
        /// Random function giving the level of the found creature
        /// </summary>
        /// <returns></returns>
        public int RandomLevel()
        {
            Random lvl = new Random();
            int randomLevel = lvl.Next(1,11);
            level = randomLevel;
            return level;
        }

        
    }
}
