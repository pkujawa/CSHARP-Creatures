using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaulinaKujawaLab2Zadanie
{
    interface ICreature
    {
        void Feed();
        void Dominance(Creature creature);
        void Fight(Creature creature);
        void RestoreHealth();
        void GetAway();
        int RandomLevel();
        int Search();

    }
}
