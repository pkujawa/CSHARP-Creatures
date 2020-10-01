using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaulinaKujawaLab2Zadanie
{
    class Location : ILocations
    {
        bool found = false; 
        Random find = new Random();
        /// <summary>
        /// Function checking if player managed to find anything in the location.
        /// The chance for finding anything is 0.2
        /// </summary>
        /// <returns></returns>
        public bool Search()
        {
            int finding = find.Next(5);
            if (finding == 4)
            {
                found = true;
            }
            else
            {
                MessageBox.Show("You couldn't find anything interesting.");
            }
            return found;
        }
    }
}
