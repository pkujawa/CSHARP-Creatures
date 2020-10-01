using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaulinaKujawaLab2Zadanie
{
    public class Variables
    {
        public int money = 0;
        public int food = 0;
        public int EarnMoney(int moneyearned)
        {
            money = money + moneyearned;
            return money;
        }
        /// <summary>
        /// When buying food, money is substracted and food is added to Inventory
        /// </summary>
        /// <param name="moneyspent"></param>
        /// <returns></returns>
        public int SpendMoney(int moneyspent)
        {
            if (money >= moneyspent)
            {
                money = money - moneyspent;
                food++;
            }
            else
            {
                MessageBox.Show("You don't have enough money to buy this. You should go to work to earn more money.");
            }
            return money;
        }
    }

    
}
